using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.Helpers.Search;
using Student_Marks.Helpers.Sorts;
using Student_Marks.Models;
using Student_Marks.Nodes;

namespace Student_Marks.DataStructure
{
    public class StudentLinkedList
    {
        private Node First;
        private Node Last;

        //للاضافة بالنهاية اللائحة الخطية المزدوجة
        public void AddLast(Student std)
        {
            Node node = new Node(std);
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }

            Last.Next = node;
            node.Prev = Last;
            Last = node;
        }

        //لطباعة كل اللائحة الخطية المزدوجة
        public void Print()
        {
            Node Current = First;
            while(Current != null)
            {
                Console.WriteLine(Current.Data.ToString());
                Current = Current.Next;
            }
            Console.WriteLine();
        }

        //للاضافة باول اللائحة
        public void AddFirst(Student std)
        {
            Node node = new Node(std);
            if (First == null)
            {
                First = node;
                Last = node;
                return;
            }
            node.Next = First;
            First.Prev = node;
            First = node;
        }

        //للفرز عن طريق اسماء الطلاب
        public void SortingByName()
        {
            Node Current = First;
            List<Student> students = new List<Student>();
            while(Current != null)
            {
                students.Add(Current.Data);
                Current = Current.Next;
            }
            students = Sorting.SelectionSort(students, true);
            foreach (Student std in students)
            {
                Console.WriteLine(std.ToString());
            }
        }

        //للفرز عن طريق محصلة الطلاب
        public void SortingByEstimate()
        {
            Node Current = First;
            List<Student> students = new List<Student>();
            while( Current != null)
            {
                students.Add(Current.Data);
                Current = Current.Next;
            }
            students = Sorting.SelectionSort(students, false);
            foreach (Student std in students)
            {
                Console.WriteLine(std.ToString());
            }
        }

        //للبحث عن الطلاب عن طريق ادخال علامة الاختبار الاولى لهم
        public void SearchByFirstTestMark(double mark)
        {
            Node Current = First;
            List<Student> students = new List<Student>();
            while(Current != null)
            {
                students.Add(Current.Data);
                Current = Current.Next;
            }
            SearchByMark.SearchByFirstMark(mark, students);
            Console.WriteLine();
        }

        //للبحث عن الطلاب عن طريق ادخال علامة اختبارهم الثانية
        public void SearchBySecondTestMark(double mark)
        {
            Node Current = First;
            List<Student> students = new List<Student>();
            while (Current != null)
            {
                students.Add(Current.Data);
                Current = Current.Next;
            }
            SearchByMark.SearchBySecondMark(mark, students);
            Console.WriteLine();
        }
    }
}
