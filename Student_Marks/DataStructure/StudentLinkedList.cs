using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.Helpers.Sorts;
using Student_Marks.Models;
using Student_Marks.Nodes;

namespace Student_Marks.DataStructure
{
    public class StudentLinkedList
    {
        private Node First;
        private Node Last;

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

        public void SearchByFirstTestMark(double mark)
        {

        }
    }
}
