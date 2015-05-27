using System;
using System.Collections.Generic;


class StudentSpeciality
{
    public string Speciality { get; set; }
    public string FacultyNumber { get; set; }

    public StudentSpeciality(string speciality, string facultyNumber)
    {
        this.Speciality = speciality;
        this.FacultyNumber = facultyNumber;
    }
}

