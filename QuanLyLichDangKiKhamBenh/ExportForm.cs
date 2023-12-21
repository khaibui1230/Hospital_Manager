using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDangKiKhamBenh
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }

        public bool ExportExcelResult { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
           ExportExcelResult = ExportExcel();

            this.Close();


        }

        private bool ExportExcel()
        {
            return true;
        }

        public bool ExportWordResult { get; private set; }
        private void Word_Click(object sender, EventArgs e)
        {
            ExportWordResult = ExportPdf();
            this.Close();
        }

        private bool ExportPdf()
        {
            return true;
        }
        public bool ExportPdfResult { get; private set; }
        private void PDf_Click(object sender, EventArgs e)
        {
            ExportPdfResult = ExportWord();
            this.Close();
        }

        private bool ExportWord()
        {
            return true;
        }
    }
}
