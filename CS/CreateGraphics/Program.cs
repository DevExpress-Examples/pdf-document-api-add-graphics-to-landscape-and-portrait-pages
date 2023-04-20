using System.Drawing;
using System.Collections.Generic;
using DevExpress.Pdf;

namespace CreateGraphics {
    class Program {
        const float DrawingDpi = 72f;

        static void Main(string[] args) {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                processor.LoadDocument("..\\..\\RotatedDocument.pdf");
                using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(100, Color.Blue)))
                    AddGraphics(processor, "text", textBrush);
                processor.SaveDocument("..\\..\\RotatedDocumentWithGraphics.pdf");
            }
        }

        static void AddGraphics(PdfDocumentProcessor processor, string text, SolidBrush textBrush) {
            IList<PdfPage> pages = processor.Document.Pages;
            for (int i = 0; i < pages.Count; i++) {
                PdfPage page = pages[i];
                using (PdfGraphics graphics = processor.CreateGraphics()) {
                    SizeF actualPageSize = PrepareGraphics(page, graphics, DrawingDpi, DrawingDpi);
                    using (Font font = new Font("Segoe UI", 20, FontStyle.Regular)) {
                        SizeF textSize = graphics.MeasureString(text, font, PdfStringFormat.GenericDefault, DrawingDpi, DrawingDpi);
                        PointF topLeft = new PointF(0, 0);
                        PointF bottomRight = new PointF(actualPageSize.Width - textSize.Width, actualPageSize.Height - textSize.Height);
                        graphics.DrawString(text, font, textBrush, topLeft);
                        graphics.DrawString(text, font, textBrush, bottomRight);
                        graphics.AddToPageForeground(page, DrawingDpi, DrawingDpi);
                    }
                }
            }
        }

        static SizeF PrepareGraphics(PdfPage page, PdfGraphics graphics, float dpiX, float dpiY) {
            PdfRectangle cropBox = page.CropBox;
            float cropBoxWidth = ConvertFromPdfUnits((float)cropBox.Width, dpiX);
            float cropBoxHeight = ConvertFromPdfUnits((float)cropBox.Height, dpiY);
            switch(page.Rotate) {
                case 90:
                    graphics.RotateTransform(-90);
                    graphics.TranslateTransform(-cropBoxHeight, 0);
                    return new SizeF(cropBoxHeight, cropBoxWidth);
                case 180:
                    graphics.RotateTransform(-180);
                    graphics.TranslateTransform(-cropBoxWidth, -cropBoxHeight);
                    return new SizeF(cropBoxWidth, cropBoxHeight);
                case 270:
                    graphics.RotateTransform(-270);
                    graphics.TranslateTransform(0, -cropBoxWidth);
                    return new SizeF(cropBoxHeight, cropBoxWidth);
            }
            return new SizeF(cropBoxWidth, cropBoxHeight);
        }
        static float ConvertFromPdfUnits(float pdfValue, float targetDpi) {
            return pdfValue / 72f * targetDpi;
        }
    }
}
