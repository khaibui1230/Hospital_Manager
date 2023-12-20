//using iTextSharp.text.pdf;
//using iTextSharp.text;

//namespace QuanLyLichDangKiKhamBenh
//{
//    public class PdfExporter
//    {
//        public void ExportToPdf(string filePath, List<Patients> patients)
//        {
//            using (var writer = new PdfWriter(filePath))
//            {
//                using (var pdf = new PdfDocument(writer))
//                {
//                    var document = new Document(pdf);

//                    foreach (var patient in patients)
//                    {
//                        document.Add(new Paragraph($"Tên: {patient.Name}, Tuổi: {patient.Age}, Địa chỉ: {patient.Address}"));
//                    }
//                }
//            }
//        }
//    }
//}
