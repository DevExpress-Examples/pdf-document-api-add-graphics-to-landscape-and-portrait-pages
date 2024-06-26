<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595418/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T383767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/CreateGraphics/Program.cs) (VB: [Program.vb](./VB/CreateGraphics/Program.vb))
<!-- default file list end -->
# PDF Document API - Create Graphics in a Document with Landscape and Portrait Page Orientations


This example shows how to add text to the top left and bottom right of a page in a document with landscape and portrait pages.


<h3>Description</h3>

PDF graphics represented by an instance of the&nbsp;<a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfGraphicstopic">PdfGraphics</a> class. To create graphics, call the&nbsp;<a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateGraphicstopic">PdfDocumentProcessor.CreateGraphics</a> method. To access <strong>PdfGraphics</strong>, you need to reference the<strong> DevExpress.Pdf.Drawing</strong> assembly.<br><br>To draw text on a page, call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_DrawStringtopic">PdfGraphics.DrawString</a> method with specified text, font, brush and location.<br>To add graphics to a page foreground, call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_AddToPageForegroundtopic">PdfGraphics.AddToPageForeground</a> method.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-graphics-to-landscape-and-portrait-pages&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-graphics-to-landscape-and-portrait-pages&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
