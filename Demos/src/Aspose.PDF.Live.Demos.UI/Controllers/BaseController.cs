using Aspose.Pdf.Live.Demos.UI.Config;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf.Live.Demos.UI.Models.Common;
using Aspose.Pdf.Live.Demos.UI.Services;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected InputFiles UploadFiles(HttpRequestBase Request, string _folderName)
        {
            try
            {
                //string _folderName = Guid.NewGuid().ToString();
                var pathProcessor = new PathProcessor(_folderName);
                InputFiles _inputFiles = new InputFiles();
                //foreach (string fileName in Request.Files)
                for (int i = 0; i < Request.Files.Count; i++)

                {
                    HttpPostedFileBase postedFile = Request.Files[i];

                    if (postedFile != null)
                    {
                        // Check if File is available.
                        if (postedFile != null && postedFile.ContentLength > 0)
                        {
                            string fn = System.IO.Path.GetFileName(postedFile.FileName);
                            string _savepath = pathProcessor.SourceFolder + "\\" + fn;
                            postedFile.SaveAs(_savepath);
                            _inputFiles.Add(new InputFile(fn, _folderName, _savepath));

                        }
                    }
                }
                return _inputFiles;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        protected AsposePdfBase.DocumentInfo[] UploadDocuments(HttpRequestBase Request, string sourceFolder)
        {
            try
            {
                var pathProcessor = new PathProcessor(sourceFolder);
                List<AsposePdfBase.DocumentInfo> documents = new List<AsposePdfBase.DocumentInfo>();
                //foreach (string fileName in Request.Files)
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase postedFile = Request.Files[i];

                    if (postedFile != null)
                    {
                        // Check if File is available.
                        if (postedFile != null && postedFile.ContentLength > 0)
                        {
                            string _savepath = pathProcessor.SourceFolder + "\\" + System.IO.Path.GetFileName(postedFile.FileName);
                            postedFile.SaveAs(_savepath);

                            string _extension = System.IO.Path.GetExtension(postedFile.FileName);
                            _extension = _extension.Replace(".", "");

                            if (_extension == "cgm")
                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new CgmLoadOptions())
                                });
                            }
                            else if (_extension == "epub")

                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new EpubLoadOptions())
                                });

                            }
                            else if (_extension == "pcl")

                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new PclLoadOptions())
                                });

                            }
                            else if (_extension == "tex")

                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new LatexLoadOptions())
                                });

                            }
                            else if ((_extension == "ps") || (_extension == "eps"))

                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new PsLoadOptions())
                                });

                            }
                            else if ((_extension == "mhtml") || (_extension == "mht"))

                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new MhtLoadOptions())
                                });

                            }
                            else if (_extension == "md")
                            {
                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath, new MdLoadOptions())
                                });

                            }
                            else
                            {

                                documents.Add(new AsposePdfBase.DocumentInfo()
                                {
                                    FileName = _savepath,
                                    PdfDocument = new Aspose.Pdf.Document(_savepath)
                                });

                            }
                        }

                    }
                }

                return documents.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new AsposePdfBase.DocumentInfo[0];
            }
        }


        /// <summary>
        /// Response when uploaded files exceed the limits
        /// </summary>
        protected Response BadDocumentResponse = new Response()
        {
            Status = "Some of your documents are corrupted",
            StatusCode = 500
        };


        public abstract string Product { get; }

        protected override void OnActionExecuted(ActionExecutedContext ctx)
        {
            base.OnActionExecuted(ctx);
            ViewBag.Title = ViewBag.Title ?? Resources["ApplicationTitle"];
            ViewBag.MetaDescription = ViewBag.MetaDescription ?? "Save time and software maintenance costs by running single instance of software, but serving multiple tenants/websites. Customization available for Joomla, Wordpress, Discourse, Confluence and other popular applications.";
        }

        private AsposePdfContext _atcContext;


        /// <summary>
        /// Main context object to access all the dcContent specific context info
        /// </summary>
        public AsposePdfContext AsposePdfContext
        {
            get
            {
                if (_atcContext == null)
                {
                    _atcContext = new AsposePdfContext(HttpContext.ApplicationInstance.Context);
                }

                return _atcContext;
            }
        }

        private Dictionary<string, string> _resources;

        /// <summary>
        /// key/value pair containing all the error messages defined in resources.xml file
        /// </summary>
        public Dictionary<string, string> Resources
        {
            get
            {
                if (_resources == null)
                {
                    _resources = AsposePdfContext.Resources;
                }

                return _resources;
            }
        }



    }
}
