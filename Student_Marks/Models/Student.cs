using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.Enums;
using Student_Marks.Helpers;

namespace Student_Marks.Models
{
    //يمثل الطالب بصفاته
    public class Student
    {
        public int Number { get; set; }
        public string FullName { get; set; }
        public Governorates Country { get; set; }
        public double FirstTestMark { get; set; }
        public double SecondTestMark { get; set; }
        public Estimates Estimate => StudentHelper.SumEstimate(FirstTestMark, SecondTestMark);
        public Student() { }
        public Student(int number, string name, Governorates country, double firstTestMark, double secondTestMark)
        {
            Number = number;
            FullName = name;
            Country = country;
            FirstTestMark = firstTestMark;
            SecondTestMark = secondTestMark;
        }

        public override string ToString()
        {
            return $"number : {Number}, fullname : {FullName}, country : {Country}, firstmark : {FirstTestMark}, secondmark : {SecondTestMark}, estimates : {Estimate}";
        }
    }
}
