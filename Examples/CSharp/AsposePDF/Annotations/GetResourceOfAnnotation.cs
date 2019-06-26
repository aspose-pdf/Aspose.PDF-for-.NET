using Aspose.Pdf.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.Annotations
{
    public class GetResourceOfAnnotation
    {
        public static void Run()
        {
            // ExStart:GetResourceOfAnnotation
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdf_Annotations();

            // Open document
            Document doc = new Document(dataDir + "AddAnnotation.pdf");
            //Create annotation
            ScreenAnnotation sa = new ScreenAnnotation(doc.Pages[1], new Rectangle(100, 400, 300, 600), dataDir + "AddSwfFileAsAnnotation.swf");
            doc.Pages[1].Annotations.Add(sa);
            // Save Doucument
            doc.Save(dataDir + "GetResourceOfAnnotation_Out.pdf");
            // Open document
            Document doc1 = new Document(dataDir + "GetResourceOfAnnotation_Out.pdf");
            //Get action of the annotation
            RenditionAction action = (doc.Pages[1].Annotations[1] as ScreenAnnotation).Action as RenditionAction;
            //Get rendition of the rendition action
            Rendition rendition = ((doc.Pages[1].Annotations[1] as ScreenAnnotation).Action as RenditionAction).Rendition;
            //Media Clip 
            MediaClip clip = (rendition as MediaRendition).MediaClip;
            FileSpecification data = (clip as MediaClipData).Data;
            MemoryStream ms = new MemoryStream();
            byte[] buffer = new byte[1024];
            int read = 0;
            //Data of media are accessible in FileSpecification.Contents
            Stream source = data.Contents;
            while ((read = source.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            Console.WriteLine(rendition.Name);
            Console.WriteLine(action.RenditionOperation);
            // ExStart:GetResourceOfAnnotation
        }
    }

}
