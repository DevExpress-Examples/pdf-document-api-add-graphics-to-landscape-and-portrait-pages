<!-- default file list -->
*Files to look at*:

* [Program.cs](./CS/CreateGraphics/Program.cs) (VB: [Program.vb](./VB/CreateGraphics/Program.vb))
<!-- default file list end -->
# How to create graphics in a document with landscape and portrait page orientations


This example shows how to add text to the top left and bottom right of a page in a document with landscape and portrait pages.


<h3>Description</h3>

PDF graphics represented by an instance of the <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressPdfPdfGraphicstopic">PdfGraphics</a> class. To create graphics, call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_CreateGraphicstopic">PdfDocumentProcessor.CreateGraphics</a> method. To access <strong>PdfGraphics</strong>, you need to reference the<strong> DevExpress.Pdf.Drawing</strong> assembly.<br><br>To draw text on a page, call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_DrawStringtopic">PdfGraphics.DrawString</a> method with specified text, font, brush and location.<br>To add graphics to a page foreground, call the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressPdfPdfGraphics_AddToPageForegroundtopic">PdfGraphics.AddToPageForeground</a> method.

<br/>


