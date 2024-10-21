namespace Aspose.PDF.FormFiller.Models
{
    public class FormCardViewModel
    {
        public string CardId { get; set; }

        public string TitleResx => $"pdfFormFiller{CardId}Title";

        public string DescriptionResx => $"pdfFormFiller{CardId}CardDescription";

        public string FormUrl => CardId.ToLower();
    }
}
