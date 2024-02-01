using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aspose.Pdf.Translate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public void Upload()
        {

        }

        [HttpGet]
        [Route("get-status")]
        public void GetStatus(string documentId)
        {

        }

        [HttpGet]
        [Route("download")]
        public void Download(string documentId)
        {

        }
    }
}
