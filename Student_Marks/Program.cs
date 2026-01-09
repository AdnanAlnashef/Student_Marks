using System;
using Student_Marks.DataStructure;
using Student_Marks.Models;
class Program
{
    static void Main(string[] args)
    {
        int enteredNumber;
        char qua;
        StudentLinkedList MySchoole = new StudentLinkedList();
        Console.WriteLine("Welcome to out schoole..");
        do
        {
            do
            {
                Console.WriteLine("Enter 1 To Add student in the first...\nEnter 2 to add student in the second..." +
                        "\nEnter 3 to print all student...\nEnter 4 to sorting student by name..." +
                        "\nEnter 5 to sorting student by estimate...\nEnter 6 to search students by first test mark..." +
                        "\nEnter 7 to search studetns by second test mark...");
                enteredNumber = int.Parse(Console.ReadLine());
            } while (enteredNumber != 1 && enteredNumber != 2 && enteredNumber != 3 && enteredNumber != 4 && enteredNumber != 5
                && enteredNumber != 6 && enteredNumber != 7);
            switch (enteredNumber)
            {
                case 1:
                    Console.WriteLine("Enter Student Name : ");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Enter student country : ");
                    string country1 = Console.ReadLine();
                    Console.WriteLine("Enter First Test Mark : ");
                    double firstMark1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second test Mark : ");
                    double secondMark1 = double.Parse(Console.ReadLine());
                    Student std1 = new Student(name1, country1, firstMark1, secondMark1);
                    MySchoole.AddFirst(std1);
                    break;
                case 2:
                    Console.WriteLine("Enter Student Name : ");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Enter student country : ");
                    string country2 = Console.ReadLine();
                    Console.WriteLine("Enter First Test Mark : ");
                    double firstMark2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second test Mark : ");
                    double secondMark2 = double.Parse(Console.ReadLine());
                    Student std2 = new Student(name2, country2, firstMark2, secondMark2);
                    MySchoole.AddFirst(std2);
                    break;
            }
        } while (qua == 'y' || qua == 'Y');
    }
}
