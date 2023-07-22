using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Http.Routing;
using System.Net.Http;

/// <summary>
/// Summary description for Configuration
/// </summary>
namespace Aspose.Pdf.Live.Demos.UI.Config
{
	public static class Configuration
	{		
		private static string _appName = ConfigurationManager.AppSettings["AppName"].ToString();
		private static string _resourceFileSessionName = ConfigurationManager.AppSettings["ResourceFileSessionName"];
		

		public static string ResourceFileSessionName
		{
			get { return _resourceFileSessionName; }
		}
		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string WorkingDirectory
		{
			get {
				string sourceFilespath = AppContext.BaseDirectory + "/Assets/SourceFiles/";
				if ( ! System.IO.Directory.Exists(sourceFilespath))
				{
					System.IO.Directory.CreateDirectory(sourceFilespath);
				}

				return sourceFilespath;
			}
		}

		/// <summary>
		/// Get Working Directory
		/// </summary>
		public static string OutputDirectory
		{
			get
			{
				string OutputFilespath = AppContext.BaseDirectory + "/Assets/OutputFiles/";
				if (!System.IO.Directory.Exists(OutputFilespath))
				{
					System.IO.Directory.CreateDirectory(OutputFilespath);
				}

				return OutputFilespath;
			}
		}
		
		public static string AppName
        {
            get { return _appName; }
        }
        public static string AsposeAppLiveDemosPath
        {
            get {
				HttpRequestMessage httpRequestMessage = HttpContext.Current.Items["MS_HttpRequestMessage"] as HttpRequestMessage;
                return new UrlHelper(httpRequestMessage).Content("../"); 
			}
        }
		public static string FileDownloadLink
		{
			get 
			{
                HttpRequestMessage httpRequestMessage = HttpContext.Current.Items["MS_HttpRequestMessage"] as HttpRequestMessage;
                return new UrlHelper(httpRequestMessage).Content("../common/download");
            }
		}
		
		public static string FileViewLink
		{
			get 
			{
                HttpRequestMessage httpRequestMessage = HttpContext.Current.Items["MS_HttpRequestMessage"] as HttpRequestMessage;
                return new UrlHelper(httpRequestMessage).Content("./viewer");
            }
		}
	}
}
