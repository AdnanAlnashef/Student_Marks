using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.DataStructure;
using Student_Marks.Models;

namespace Student_Marks.Helpers.Sorts
{
    public static class Sorting
    {
        //هذه الميثود للفرز الانتخابي تاخذ ليست وقيمة بول هذه القيمو بول فقط لتحديد الفرز هل هو عن طريق الاسم ام التقدير
        public static List<Student> SelectionSort(List<Student> students, bool type)
        {
            if (type == true)
            {
                for (int i = 0; i < students.Count - 1; i++)
                    for (int j = i + 1; j < students.Count; j++)
                    {
                        int result = string.Compare(students[i].FullName, students[j].FullName, StringComparison.Ordinal);
                        if (result < 0)
                        {
                            Student std = students[i];
                            students[i] = students[j];
                            students[j] = std;
                        }
                    }
            }
            else
            {
                for (int i = 0; i < students.Count - 1; i++)
                    for (int j = i + 1; j < students.Count; j++)
                        if (students[i].Estimate > students[j].Estimate)
                        {
                            Student std = students[i];
                            students[i] = students[j];
                            students[j] = std;
                        }
            }
                return students;
        }
    }
}
