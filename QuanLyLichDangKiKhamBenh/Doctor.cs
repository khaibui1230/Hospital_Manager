using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDangKiKhamBenh
{
    public class Doctor
    {
        private int docID;
        private string docName;
        private string gender;
        private string docPass;
        private int docExp;
        private string docSpec;

        public Doctor()
        {
        }

        public Doctor(int docID, string docName, string gender, string docPass, int docExp, string docSpec)
        {
            DocID = docID;
            DocName = docName;
            Gender = gender;
            DocPass = docPass;
            DocExp = docExp;
            DocSpec = docSpec;
        }

        public int DocID
        {
            get { return docID; }
            set { docID = value; }
        }

        public string DocName
        {
            get { return docName; }
            set { docName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

       

        public string DocSpec
        {
            get { return docSpec; }
            set { docSpec = value; }
        }

        public string DocPass
        {
            get { return docPass; }
            set { docPass = value; }
        }

        public int DocExp
        {
            get { return docExp; }
            set { docExp = value; }
        }
    }
}
