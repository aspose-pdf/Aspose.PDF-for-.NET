using System;
using System.IO;
using Aspose.Pdf.Facades;

namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.SecuritySignatures
{
    public class SetPrivilegesOnFile
    {
        public static void Run()
        {
            // ExStart:SetPrivilegesOnFile
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfFacades_SecuritySignatures();

            // Create DocumentPrivileges object
            DocumentPrivilege privilege = DocumentPrivilege.ForbidAll;
            privilege.ChangeAllowLevel = 1;
            privilege.AllowPrint = true;
            privilege.AllowCopy = true;

            // Create PdfFileSecurity object 
            PdfFileSecurity fileSecurity = new PdfFileSecurity();
            fileSecurity.BindPdf(dataDir + "input.pdf");

            // Set document privileges
            fileSecurity.SetPrivilege(privilege);
            fileSecurity.Save(dataDir + "SetPrivilegesOnFile_out.pdf");
            // ExEnd:SetPrivilegesOnFile   
           
        }
    }
}