Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.Pdf
Imports DevExpress.Drawing

Namespace CreateGraphics

    Friend Class Program

        Const DrawingDpi As Single = 72.0F

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                processor.LoadDocument("..\..\RotatedDocument.pdf")
                Using textBrush As DXSolidBrush = New DXSolidBrush(Color.FromArgb(100, Color.Blue))
                    AddGraphics(processor, "text", textBrush)
                End Using

                processor.SaveDocument("..\..\RotatedDocumentWithGraphics.pdf")
            End Using
        End Sub

        Private Shared Sub AddGraphics(ByVal processor As PdfDocumentProcessor, ByVal text As String, ByVal textBrush As DXSolidBrush)
            Dim pages As IList(Of PdfPage) = processor.Document.Pages
            For i As Integer = 0 To pages.Count - 1
                Dim page As PdfPage = pages(i)
                Using graphics As PdfGraphics = processor.CreateGraphics()
                    Dim actualPageSize As SizeF = PrepareGraphics(page, graphics, DrawingDpi, DrawingDpi)
                    Dim font As DXFont = New DXFont("Segoe UI", 20, DXFontStyle.Regular)
                    Dim textSize As SizeF = graphics.MeasureString(text, font, PdfStringFormat.GenericDefault, DrawingDpi, DrawingDpi)
                    Dim topLeft As PointF = New PointF(0, 0)
                    Dim bottomRight As PointF = New PointF(actualPageSize.Width - textSize.Width, actualPageSize.Height - textSize.Height)
                    graphics.DrawString(text, font, textBrush, topLeft)
                    graphics.DrawString(text, font, textBrush, bottomRight)
                    graphics.AddToPageForeground(page, DrawingDpi, DrawingDpi)
                End Using
            Next
        End Sub

        Private Shared Function PrepareGraphics(ByVal page As PdfPage, ByVal graphics As PdfGraphics, ByVal dpiX As Single, ByVal dpiY As Single) As SizeF
            Dim cropBox As PdfRectangle = page.CropBox
            Dim cropBoxWidth As Single = ConvertFromPdfUnits(CSng(cropBox.Width), dpiX)
            Dim cropBoxHeight As Single = ConvertFromPdfUnits(CSng(cropBox.Height), dpiY)
            Select Case page.Rotate
                Case 90
                    graphics.RotateTransform(-90)
                    graphics.TranslateTransform(-cropBoxHeight, 0)
                    Return New SizeF(cropBoxHeight, cropBoxWidth)
                Case 180
                    graphics.RotateTransform(-180)
                    graphics.TranslateTransform(-cropBoxWidth, -cropBoxHeight)
                    Return New SizeF(cropBoxWidth, cropBoxHeight)
                Case 270
                    graphics.RotateTransform(-270)
                    graphics.TranslateTransform(0, -cropBoxWidth)
                    Return New SizeF(cropBoxHeight, cropBoxWidth)
            End Select
            Return New SizeF(cropBoxWidth, cropBoxHeight)
        End Function
        Private Shared Function ConvertFromPdfUnits(ByVal pdfValue As Single, ByVal targetDpi As Single) As Single
            Return pdfValue / 72.0F * targetDpi
        End Function
    End Class
End Namespace
