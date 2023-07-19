using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsposePdfEditor
{
    public partial class AsposePdfEditor : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Please get a free temproary license of Aspose.Pdf for .NET or Aspose.Total for .NET from http://www.aspose.com/corporate/purchase/temporary-license.aspx, 
            //put it in License folder of the project, uncomment below lines of code and add its path in SetLicense() method

            //Aspose.Pdf.License lic = new Aspose.Pdf.License();
            //lic.SetLicense(Server.MapPath("License/Aspose.Total.lic"));
            
        }
    }
}