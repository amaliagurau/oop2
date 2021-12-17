using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class Student 
    {
        public string firstName;
        public string lastName;
        public DateTime dateOfBirth;
        public string ID_student;

        public Student(string FirstName, string LastName, DateTime dateOfBirth, string ID_student)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.dateOfBirth = dateOfBirth;
            this.ID_student = ID_student;



        }

    } 
}
