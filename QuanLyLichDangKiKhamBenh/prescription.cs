namespace QuanLyLichDangKiKhamBenh
{
    public class prescription
    {
        //public static object Medications { get; internal set; }
        public int PrescriptionID { get; set; }
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public List<Medication> Medications { get; set; }

        public prescription()
        {
            Medications = new List<Medication>();
        }
    }
}