---
title: Extract Text From All the Pages of a PDF Document in Ruby
type: docs
weight: 30
url: /java/extract-text-from-all-the-pages-of-a-pdf-document-in-ruby/
---

## **Aspose.PDF - Extract Text From All the Pages**
To extract TextrFrom All the Pages Pdf document using **Aspose.PDF Java for Ruby**, simply invoke **ExtractTextFromAllPages** module.

**Ruby Code**

{{< highlight ruby >}}

 # The path to the documents directory.

data_dir = File.dirname(File.dirname(File.dirname(File.dirname(__FILE__)))) + '/data/'



\# Open the target document

pdf = Rjb::import('com.aspose.pdf.Document').new(data_dir + 'input1.pdf')

\# create TextAbsorber object to extract text

text_absorber = Rjb::import('com.aspose.pdf.TextAbsorber').new

\# accept the absorber for all the pages

pdf.getPages().accept(text_absorber)

\# In order to extract text from specific page of document, we need to specify the particular page using its index against accept(..) method.

\# accept the absorber for particular PDF page

\# pdfDocument.getPages().get_Item(1).accept(textAbsorber);

#get the extracted text

extracted_text = text_absorber.getText()

\# create a writer and open the file

writer = Rjb::import('java.io.FileWriter').new(Rjb::import('java.io.File').new(data_dir + "extracted_text.out.txt"))

writer.write(extracted_text)

\# write a line of text to the file

\# tw.WriteLine(extractedText);

\# close the stream

writer.close()

puts "Text extracted successfully. Check output file."


{{< /highlight >}}
## **Download Running Code**
Download **Extract Text From All the Pages (Aspose.PDF)** from any of the below mentioned social coding sites:

- [GitHub](https://github.com/aspose-pdf/Aspose.PDF-for-Java/tree/master/Plugins/Aspose_Pdf_Java_for_Ruby/lib/asposepdfjava/Text/extracttextfromallpages.rb)
