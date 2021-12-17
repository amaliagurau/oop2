using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class Facultate
    {
        public string UniName;
        public Student[] Students;

        public Facultate(string Name)
        {
            this.UniName = Name;
        }

        public string Index(string ID_student)
        { 
            for(int i=0; i<Students.Length; i++)
            {
                if(string.Equals(ID_student, Students[i].ID_student))
                {
                    string s = Students[i].firstName + " " + Students[i].lastName;
                    return s;
                }
            }
            return "Studentul nu a fost gasit";

        }
    }
}
