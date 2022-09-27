using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();

            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfTable = new PdfPTable(3);

            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir TC");

            pdfTable.AddCell("Ahmet");
            pdfTable.AddCell("Yaz");
            pdfTable.AddCell("1113331111");

            pdfTable.AddCell("Kemal");
            pdfTable.AddCell("Yılmaz");
            pdfTable.AddCell("1111111111");

            document.Add(pdfTable);

            document.Close();

            return File("/PdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
