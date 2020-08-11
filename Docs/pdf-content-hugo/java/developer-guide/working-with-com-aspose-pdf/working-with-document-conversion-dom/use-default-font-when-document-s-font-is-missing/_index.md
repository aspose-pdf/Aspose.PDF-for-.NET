---
title: Use Default Font when Document's Font is Missing
type: docs
weight: 50
url: /java/use-default-font-when-document-s-font-is-missing/
---

When transforming PDF files to DOC or HTML format, the fonts used inside PDF file are used in resultant files, so that formatting of document is preserved. However users can face Font not found issue when converting PDF files to DOC or HTML format on non-Windows environment. As a workaround, user has to install respective font on his system but sometimes user is not certain about the font to be used. Therefore we implemented an API to use default font if specific font used inside document is missing (not installed over system). So instead of throwing an exception, default font i.e. Arial will be used when performing a conversion and a message appear in Console that default font is used because XYZ font was found missing. However, notice that we do not guarantee that the substituted font will correctly shows all the characters. Therefore you should find yourself the font that will be compatible with the missing original font. Also, we implemented the ability to get notification when the font is substituted.

{{< gist "aspose-pdf" "474c352a71ac9477aa0d604fd32e1c6a" "Examples-src-main-java-com-aspose-pdf-examples-AsposePdf-Conversion-DefaultFontWhenSpecificFontMissing-.java" >}}
