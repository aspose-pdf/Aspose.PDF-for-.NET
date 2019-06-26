using Aspose.Words;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel.Description;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OneClick_PDF_Document_Generator
{
    public partial class OneClickPDFButton : System.Web.UI.Page
    {
        OrganizationServiceProxy Service;
        string TemplateEntityName = "aspose_oneclickpdfconfiguration";
        Guid EntityId = Guid.Empty;
        int EntityType;
        string EntityName;
        string DownloadTemplate;
        string AttachToNoteTemplate;
        string DownloadFileName;
        string AttachToNoteFileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                EntityId = Request.QueryString["id"] == null ? Guid.Empty : new Guid(Request.QueryString["id"]);
                string OrgName = Request.QueryString["orgname"] == null ? "" : Request.QueryString["orgname"];
                EntityType = Request.QueryString["type"] == null ? 0 : int.Parse(Request.QueryString["type"]);
                EntityName = Request.QueryString["typename"] == null ? "" : Request.QueryString["typename"];

                string data = Request.QueryString["data"] == null ? "" : Request.QueryString["data"];
                if (EntityId != Guid.Empty && EntityType != 0 && OrgName != "" && data != "")
                {
                    CreateService(ConfigurationManager.AppSettings["ServerName"], OrgName, ConfigurationManager.AppSettings["Login"],
                         ConfigurationManager.AppSettings["Password"], ConfigurationManager.AppSettings["Domain"]);
                    try
                    {
                        string LicenseFilePath = ConfigurationManager.AppSettings["LicenseFilePath"];
                        // Check for license and apply if exists
                        if (File.Exists(LicenseFilePath))
                        {
                            License license = new License();
                            license.SetLicense(LicenseFilePath);
                        }
                    }
                    catch { }
                    string[] ButtonsData = data.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string ButtonData in ButtonsData)
                    {
                        string[] Data = ButtonData.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        if (Data.Length == 3)
                        {
                            string TemplateName = Data[0];
                            string ButtonToDisplay = Data[1];

                            if (ButtonToDisplay.ToLower() == "download")
                            {
                                BTN_Download.Visible = true;
                                DownloadTemplate = TemplateName;
                                DownloadFileName = Data[2];
                            }
                            if (ButtonToDisplay.ToLower() == "note")
                            {
                                BTN_AttachToNote.Visible = true;
                                AttachToNoteTemplate = TemplateName;
                                AttachToNoteFileName = Data[2];
                            }
                        }
                        else
                        {
                            LBL_Message.Text = "Data is not correct.";
                            BTN_Download.Visible = false;
                            BTN_AttachToNote.Visible = false;
                            LBL_Message.Visible = true;
                        }
                    }
                }
                else
                {
                    LBL_Message.Text = "Parameters are not correct, Please save the record first.";
                    BTN_Download.Visible = false;
                    BTN_AttachToNote.Visible = false;
                    LBL_Message.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LBL_Message.Text = "Error has occured. Details: " + ex.Message;
                BTN_Download.Visible = false;
                BTN_AttachToNote.Visible = false;
                LBL_Message.Visible = true;
            }
        }
        private OrganizationServiceProxy CreateService(string serverName, string OrganizationName, string Login, string Password, string Domain)
        {
            try
            {
                serverName = serverName.Contains("http://") || serverName.Contains("https://") ? serverName.Replace("http://", "").Replace("https://", "") : serverName;
                Uri oUri = new Uri("http://" + serverName + "/" + OrganizationName + "/XRMServices/2011/Organization.svc");
                ClientCredentials clientCredentials = new ClientCredentials();
                clientCredentials.UserName.UserName = Domain + "\\" + Login;
                clientCredentials.UserName.Password = Password;
                Service = new OrganizationServiceProxy(oUri, null, clientCredentials, null);
                return Service;
            }
            catch (Exception ex)
            {
                Service = null;
                throw ex;
            }
        }
        protected void BTN_Download_Click(object sender, EventArgs e)
        {
            try
            {
                QueryExpression TemplateQuery = new QueryExpression(TemplateEntityName);
                TemplateQuery.Criteria.AddCondition(new ConditionExpression("aspose_entity", ConditionOperator.Equal, EntityType));
                TemplateQuery.Criteria.AddCondition(new ConditionExpression("aspose_name", ConditionOperator.Equal, DownloadTemplate));
                TemplateQuery.ColumnSet = new ColumnSet(new string[] { });
                EntityCollection Templates = Service.RetrieveMultiple(TemplateQuery);
                if (Templates.Entities.Count == 1)
                {
                    Guid TemplateId = Templates[0].Id;
                    QueryExpression NotesQuery = new QueryExpression("annotation");
                    NotesQuery.Criteria.AddCondition(new ConditionExpression("objectid", ConditionOperator.Equal, TemplateId));
                    NotesQuery.ColumnSet = new ColumnSet(new string[] { "subject", "documentbody" });
                    EntityCollection Notes = Service.RetrieveMultiple(NotesQuery);
                    if (Notes.Entities.Count > 0)
                    {
                        Entity Note = Notes[0];
                        if (Note.Contains("documentbody"))
                        {
                            byte[] DocumentBody = Convert.FromBase64String(Note["documentbody"].ToString());
                            MemoryStream fileStream = new MemoryStream(DocumentBody);
                            Document doc = new Document(fileStream);
                            string[] fields = doc.MailMerge.GetFieldNames();
                            Entity PrimaryEntity = Service.Retrieve(EntityName, EntityId, new ColumnSet(fields));
                            if (PrimaryEntity != null)
                            {
                                string[] values = new string[fields.Length];
                                for (int i = 0; i < fields.Length; i++)
                                {
                                    if (PrimaryEntity.Contains(fields[i]))
                                    {
                                        if (PrimaryEntity[fields[i]].GetType() == typeof(OptionSetValue))
                                            values[i] = PrimaryEntity.FormattedValues[fields[i]].ToString();
                                        else if (PrimaryEntity[fields[i]].GetType() == typeof(EntityReference))
                                            values[i] = ((EntityReference)PrimaryEntity[fields[i]]).Name;
                                        else
                                            values[i] = PrimaryEntity[fields[i]].ToString();
                                    }
                                    else
                                        values[i] = "";
                                }
                                doc.MailMerge.Execute(fields, values);
                                MemoryStream UpdateDoc = new MemoryStream();
                                doc.Save(UpdateDoc, SaveFormat.Pdf);
                                Response.Clear();
                                Response.ContentType = "application/pdf";
                                Response.AddHeader("Content-Disposition", "attachment; filename=" + DownloadFileName + ".pdf");
                                Response.BinaryWrite(UpdateDoc.ToArray());
                                // myMemoryStream.WriteTo(Response.OutputStream); //works too
                                Response.Flush();
                                Response.Close();
                                Response.End();
                            }
                        }
                    }
                }
                else
                {
                    LBL_Message.Text = "More than one template found with same name";
                    BTN_Download.Visible = false;
                    BTN_AttachToNote.Visible = false;
                    LBL_Message.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LBL_Message.Text = "Error has occured. Details: " + ex.Message;
                BTN_Download.Visible = false;
                BTN_AttachToNote.Visible = false;
                LBL_Message.Visible = true;
            }
        }

        protected void BTN_AttachToNote_Click(object sender, EventArgs e)
        {
            try
            {
                QueryExpression TemplateQuery = new QueryExpression(TemplateEntityName);
                TemplateQuery.Criteria.AddCondition(new ConditionExpression("aspose_entity", ConditionOperator.Equal, EntityType));
                TemplateQuery.Criteria.AddCondition(new ConditionExpression("aspose_name", ConditionOperator.Equal, AttachToNoteTemplate));
                TemplateQuery.ColumnSet = new ColumnSet(new string[] { });
                EntityCollection Templates = Service.RetrieveMultiple(TemplateQuery);
                if (Templates.Entities.Count == 1)
                {
                    Guid TemplateId = Templates[0].Id;
                    QueryExpression NotesQuery = new QueryExpression("annotation");
                    NotesQuery.Criteria.AddCondition(new ConditionExpression("objectid", ConditionOperator.Equal, TemplateId));
                    NotesQuery.ColumnSet = new ColumnSet(new string[] { "subject", "documentbody" });
                    EntityCollection Notes = Service.RetrieveMultiple(NotesQuery);
                    if (Notes.Entities.Count > 0)
                    {
                        Entity Note = Notes[0];
                        if (Note.Contains("documentbody"))
                        {
                            byte[] DocumentBody = Convert.FromBase64String(Note["documentbody"].ToString());
                            MemoryStream fileStream = new MemoryStream(DocumentBody);
                            Document doc = new Document(fileStream);
                            string[] fields = doc.MailMerge.GetFieldNames();
                            Entity PrimaryEntity = Service.Retrieve(EntityName, EntityId, new ColumnSet(fields));
                            if (PrimaryEntity != null)
                            {
                                string[] values = new string[fields.Length];
                                for (int i = 0; i < fields.Length; i++)
                                {
                                    if (PrimaryEntity.Contains(fields[i]))
                                    {
                                        if (PrimaryEntity[fields[i]].GetType() == typeof(OptionSetValue))
                                            values[i] = PrimaryEntity.FormattedValues[fields[i]].ToString();
                                        else if (PrimaryEntity[fields[i]].GetType() == typeof(EntityReference))
                                            values[i] = ((EntityReference)PrimaryEntity[fields[i]]).Name;
                                        else
                                            values[i] = PrimaryEntity[fields[i]].ToString();
                                    }
                                    else
                                        values[i] = "";
                                }
                                doc.MailMerge.Execute(fields, values);
                                MemoryStream UpdateDoc = new MemoryStream();
                                doc.Save(UpdateDoc, SaveFormat.Pdf);
                                byte[] byteData = UpdateDoc.ToArray();
                                // Encode the data using base64.
                                string encodedData = System.Convert.ToBase64String(byteData);
                                Entity NewNote = new Entity("annotation");
                                // Im going to add Note to entity
                                NewNote.Attributes.Add("objectid", new EntityReference(EntityName, EntityId));
                                NewNote.Attributes.Add("subject", AttachToNoteFileName + ".pdf");

                                // Set EncodedData to Document Body
                                NewNote.Attributes.Add("documentbody", encodedData);

                                // Set the type of attachment
                                NewNote.Attributes.Add("mimetype", @"application/pdf");
                                NewNote.Attributes.Add("notetext", AttachToNoteFileName);

                                // Set the File Name
                                NewNote.Attributes.Add("filename", AttachToNoteFileName + ".pdf");
                                Guid NewNoteId = Service.Create(NewNote);
                            }
                        }
                    }
                }
                else
                {
                    LBL_Message.Text = "More than one template found with same name";
                    BTN_Download.Visible = false;
                    BTN_AttachToNote.Visible = false;
                    LBL_Message.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LBL_Message.Text = "Error has occured. Details: " + ex.Message;
                BTN_Download.Visible = false;
                BTN_AttachToNote.Visible = false;
                LBL_Message.Visible = true;
            }
        }
    }
}