using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.Models;

namespace Student_Marks.Helpers.Search
{
    public static class SearchByMark
    {
        //هذه الميثود تبحث عن العلامة الاختبار الاول للطالب على الطريقة العودية ولان هنا احتمال اكثر من طالب لهم علامة الاختبار نفسها جعلت كل ما يجد نفس العلامة الملوبة يطبعه
        public static void SearchByFirstMark(double mark, List<Student> students, int index = 0)
        {
            if (index < students.Count)
            {
                if (students[index].FirstTestMark == mark)
                    Console.WriteLine(students[index].ToString());
                SearchByFirstMark(mark, students, index + 1);
            }
        }

        //نفس الشيء هذه الميثود لكن لعلامة الاختبار الثاني
        public static void SearchBySecondMark(double mark, List<Student> students, int index = 0)
        {
            if (index < students.Count)
            {
                if (students[index].SecondTestMark == mark)
                    Console.WriteLine(students[index].ToString());
                SearchBySecondMark(mark, students, index + 1);
            }
        }
    }
}
