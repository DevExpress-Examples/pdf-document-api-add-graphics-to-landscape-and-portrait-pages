<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595418/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T383767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# PDF Document API - Create Graphics in a Document with Landscape and Portrait Page Orientations

This example shows how to add text to the top left and bottom right of a page in a document with landscape and portrait pages.

>[!IMPORTANT]
> You need a license for the [DevExpress Office File API Subscription](https://www.devexpress.com/products/net/office-file-api/) or [DevExpress Universal Subscription](https://www.devexpress.com/subscriptions/universal.xml) to use this library in production code.

## Implementation Details

The [PdfGraphics](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfGraphics) class allows you to draw graphics content in PDF. To create graphics, call the [PdfDocumentProcessor.CreateGraphics](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.CreateGraphics) method.

To draw text on a page, call the [PdfGraphics.DrawString](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfGraphics.DrawString.overloads) method with specified text, font, brush and location.

To add graphics to a page foreground, call the [AddToPageForeground](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfGraphics.AddToPageForeground.overloads) method.

## Files to Review

* [Program.cs](./CS/CreateGraphics/Program.cs) (VB: [Program.vb](./VB/CreateGraphics/Program.vb))

## Documentation

* [PDF Graphics API](https://docs.devexpress.com/OfficeFileAPI/119009/pdf-document-api/pdf-graphics)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-graphics-to-landscape-and-portrait-pages&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-add-graphics-to-landscape-and-portrait-pages&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
