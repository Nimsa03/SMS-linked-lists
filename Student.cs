using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_linked_lists
{
    class Student
    {
        private int indexNum;
        private string name;
        private double gpa;
        private int admissionYear;
        private string nic;

        public int IndexNum { get => indexNum; set => indexNum = value; }
        public string Name { get => name; set => name = value; }
        public double Gpa { get => gpa; set => gpa = value; }
        public int AdmissionYear { get => admissionYear; set => admissionYear = value; }
        public string Nic { get => nic; set => nic = value; }

        public Student(int indexNum, string name, double gpa, int admissionYear, string nic)
        {
            this.indexNum = indexNum;
            this.name = name;
            this.gpa = gpa;
            this.admissionYear = admissionYear;
            this.nic = nic;
        }

        public override string? ToString()
        {
            Console.WriteLine($"Index \t| Name \t| GPA \t| Admission year | Nic \t|");
            return $"{IndexNum} \t|{Name} \t|{Gpa} \t|{AdmissionYear}  \t\t|{Nic} \t|";
        }
    }


}
