using System;

namespace QuanLyLichDangKiKhamBenh
{
    public class Patients
    {
        private int cCCD;
        private string name;
        private string gender;
        private DateTime dayOfBirth;
        private int contact;
        private int age;
        private string bloodGroup;
        private string history;
        private string address;

        public Patients()
        {
        }

        public Patients(int cCCD, string name, string gender, DateTime dayOfBirth, int contact, int age, string bloodGroup, string history, string address)
        {
            this.CCCD = cCCD;
            this.Name = name;
            this.Gender = gender;
            this.DayOfBirth = dayOfBirth;
            this.Contact = contact;
            this.Age = age;
            this.BloodGroup = bloodGroup;
            this.History = history;
            this.Address = address;
        }

        public int CCCD
        {
            get { return cCCD; }
            set { cCCD = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DayOfBirth
        {
            get { return dayOfBirth; }
            set { dayOfBirth = value; }
        }

        public int Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string BloodGroup
        {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }

        public string History
        {
            get { return history; }
            set { history = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
