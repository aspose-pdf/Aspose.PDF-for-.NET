using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Aspose.Pdf.Live.Demos.UI.Models;
using Aspose.Pdf;
using Newtonsoft.Json.Linq;

namespace Aspose.Pdf.Live.Demos.UI.Controllers
{
	///<Summary>
	/// AsposePdfMetadataController class to parse pdf document
	///</Summary>
	public class AsposePdfMetadataController : AsposePdfBase
	{
		///<Summary>
		/// Properties method. Should include 'FileName' and 'id' as params
		///</Summary>
		[HttpPost]
		
		public HttpResponseMessage Properties(string folderName, string fileName)
		{
			
			try
			{
				

				var doc = new Document(Path.Combine(Config.Configuration.WorkingDirectory, folderName, fileName));
				return Request.CreateResponse(HttpStatusCode.OK, new PropertiesResponse(doc));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
			}
		}

		///<Summary>
		/// Properties method. Should include 'FileName', 'id', 'properties' as params
		///</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public Response Download()
		{
			Opts.AppName = "Metadata";
			Opts.MethodName = "Download";
			try
			{
				var request = Request.Content.ReadAsAsync<JObject>().Result;
				Opts.FileName = Convert.ToString(request["FileName"]);
				Opts.ResultFileName = Opts.FileName;
				Opts.FolderName = Convert.ToString(request["id"]);

				var doc = new Document(Opts.WorkingFileName);
				var pars = request["properties"]["BuiltIn"].ToObject<List<DocProperty>>();
				SetBuiltInProperties(doc, pars);
				pars = request["properties"]["Custom"].ToObject<List<DocProperty>>();
				SetCustomProperties(doc, pars);

				return  Process((inFilePath, outPath, zipOutFolder) => { doc.Save(outPath); });
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return  new Response
				{
					Status = "500 " + ex.Message,
					StatusCode = 500
				};
			}
		}

		///<Summary>
		/// Properties method. Should include 'FileName', 'id' as params
		///</Summary>
		[HttpPost]
		[AcceptVerbs("GET", "POST")]
		public Response Clear()
		{
			Opts.AppName = "MetadataApp";
			Opts.MethodName = "Clear";
			try
			{
				var request = Request.Content.ReadAsAsync<JObject>().Result;
				Opts.FileName = Convert.ToString(request["FileName"]);
				Opts.ResultFileName = Opts.FileName;
				Opts.FolderName = Convert.ToString(request["id"]);

				var doc = new Document(Opts.WorkingFileName);
				doc.Info.Clear();
				doc.Info.ClearCustomData();

				return  Process((inFilePath, outPath, zipOutFolder) => { doc.Save(outPath); });
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new Response
				{
					Status = "500 " + ex.Message,
					StatusCode = 500
				};
			}
		}

		/// <summary>
		/// SetBuiltInProperties
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="pars"></param>
		private void SetBuiltInProperties(Document doc, List<DocProperty> pars)
		{
			var builtin = doc.Info;
			foreach (var par in pars)
			{
				if (par.Name != null &&
				    !par.Name.Equals("Creator", StringComparison.InvariantCultureIgnoreCase) &&
				    !par.Name.Equals("Producer", StringComparison.InvariantCultureIgnoreCase))
				{
					var parName = par.Name.ToLower();
					switch (parName)
					{
						case "author":
							builtin.Author = Convert.ToString(par.Value);
							break;
						case "keywords":
							builtin.Keywords = Convert.ToString(par.Value);
							break;
						case "subject":
							builtin.Subject = Convert.ToString(par.Value);
							break;
						case "title":
							builtin.Title = Convert.ToString(par.Value);
							break;
						case "trapped":
							var resParse = Boolean.TryParse(Convert.ToString(par.Value), out bool valTr);
							if (resParse)
								builtin.Trapped = valTr.ToString();
							break;
						case "CreationDate":
							DateTime.TryParse(par.Value.ToString(), out DateTime val2);
							builtin.CreationDate = val2;
							break;
						case "ModDate":
							DateTime.TryParse(par.Value.ToString(), out DateTime val1);
							builtin.ModDate = val1;
							break;
					}
				}
			}
		}


		/// <summary>
		/// SetCustomProperties
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="pars"></param>
		private void SetCustomProperties(Document doc, List<DocProperty> pars)
		{
			var custom = doc.Info;
			custom.ClearCustomData();
			foreach (var par in pars)
				switch (par.Type)
				{
					case PropertyType.String:
						custom.Add(par.Name, Convert.ToString(par.Value));
						break;
				}
		}

		/// <summary>
		/// PropertiesResponse
		/// </summary>
		private class PropertiesResponse
		{
			public List<DocProperty> BuiltIn { get; set; }
			public List<DocProperty> Custom { get; set; }

			public PropertiesResponse(Document doc)
			{
				BuiltIn = new List<DocProperty>();
				Custom = new List<DocProperty>();

				BuiltIn.Add(new DocProperty() { Name = "Author", Value = doc.Info.Author, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "Creator", Value = doc.Info.Creator, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "Keywords", Value = doc.Info.Keywords, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "Producer", Value = doc.Info.Producer, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "Subject", Value = doc.Info.Subject, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "Title", Value = doc.Info.Title, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "Trapped", Value = doc.Info.Trapped, Type = PropertyType.String });
				BuiltIn.Add(new DocProperty() { Name = "CreationDate", Value = doc.Info.CreationDate.ToString("yyyy-MM-ddTmm:hh:ssZ"), Type = PropertyType.DateTime });
				//BuiltIn.Add(new DocProperty() { Name = "CreationTimeZone", Value = doc.Info.CreationTimeZone.ToString() });
				BuiltIn.Add(new DocProperty() { Name = "ModDate", Value = doc.Info.ModDate.ToString("yyyy-MM-ddTmm:hh:ssZ"), Type = PropertyType.DateTime });
				//BuiltIn.Add(new DocProperty() { Name = "ModTimeZone", Value = doc.Info.ModTimeZone.ToString() });
				foreach (var prop in doc.Info)
				{
					if (!Aspose.Pdf.DocumentInfo.IsPredefinedKey(prop.Key))
						Custom.Add(new DocProperty() { Name = prop.Key, Value = prop.Value, Type = PropertyType.String });
				}
			}
		}

		/// <summary>
		/// The same fields as in DocumentProperty
		/// </summary>
		private class DocProperty
		{
			public string Name { get; set; }
			public object Value { get; set; }
			public PropertyType Type { get; set; }
		}
		public enum PropertyType
		{
			/// <summary>The property is a boolean value.</summary>
			Boolean,
			/// <summary>The property is a date time value.</summary>
			DateTime,
			/// <summary>The property is a floating number.</summary>
			Double,
			/// <summary>The property is an integer number.</summary>
			Number,
			/// <summary>The property is a string value.</summary>
			String,
			/// <summary>The property is an array of strings.</summary>
			StringArray,
			/// <summary>The property is an array of objects.</summary>
			ObjectArray,
			/// <summary>The property is an array of bytes.</summary>
			ByteArray,
			/// <summary>The property is some other type.</summary>
			Other,
		}

	}
}
