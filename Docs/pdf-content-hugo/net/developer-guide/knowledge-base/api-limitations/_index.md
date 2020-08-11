---
title: API Limitations
type: docs
weight: 70
url: /net/api-limitations/
---

## **Xsl Fo to Pdf**
Following are the known issues of XSL-FO support.

- SVG is not supported
## **PDF creator information**
- Please note that you cannot set values against the **Application** and **Producer** fields, because Aspose Ltd. and Aspose.PDF for .NET x.x.x will be displayed against these fields
## **Others**
Following are some other known issues.

- Pdf/X is not supported.
- Dynamic XFA form is not supported: As its pages created/rendered at the time of PDF loading, in Adobe Acrobat/Reader. So we can't extract and save any such virtual page or several pages. Instead we (and Adobe Acrobat) can extract only one true page which contains only error message.
- Special symbols $p and $P will not work if they do not end with a blank character.
- HTML to PDF conversion :- HTML is a very vast language and with every new release of Aspose.PDF for .NET, we try our level best to deliver a better & robust version of HTML to PDF conversion (*by support all kinds of HTML*) but as there are numerous HTML files with different nature/structure and complexity, so sometimes our component encounters some issues in terms of formatting when rendering HTML contents to PDF format and it usually happens when using documents with complex structure.
- Fonts embedding is not supported in MS Word for Macintosh and also please note that in MS Word for Windows, it only limited to TrueType fonts. Therefore when viewing word(DOC) files generated as a result of PDF to DOC conversion through Aspose.PDF for.NET, embedded fonts are substituted when viewing the files in MS Word on MAC OS. For further details, please take a look over [macsupportcentral](http://www.macsupportcentral.com/2012/05/embed-fonts-microsoft-office-word-files/).
