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
        Console.WriteLine("Welcome to our schoole..");
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
                    double firstMark1;
                    double secondMark1;
                    do
                    {
                        Console.WriteLine("Enter First Test Mark : ");
                        firstMark1 = double.Parse(Console.ReadLine());
                    } while (firstMark1 < 0 && firstMark1 > 100);
                    do
                    {
                        Console.WriteLine("Enter second test Mark : ");
                        secondMark1 = double.Parse(Console.ReadLine());
                    } while (secondMark1 < 0 && secondMark1 > 100);
                    Student std1 = new Student(name1, country1, firstMark1, secondMark1);
                    MySchoole.AddFirst(std1);
                    break;
                case 2:
                    Console.WriteLine("Enter Student Name : ");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Enter student country : ");
                    string country2 = Console.ReadLine();
                    double firstMark2;
                    double secondMark2;
                    do
                    {
                        Console.WriteLine("Enter First Test Mark : ");
                        firstMark2 = double.Parse(Console.ReadLine());
                    } while (firstMark2 < 0 && firstMark2 > 100);
                    do
                    {
                        Console.WriteLine("Enter second test Mark : ");
                        secondMark2 = double.Parse(Console.ReadLine());
                    }while (secondMark2 < 0 && secondMark2 > 100);
                    Student std2 = new Student(name2, country2, firstMark2, secondMark2);
                    MySchoole.AddLast(std2);
                    break;
                case 3:
                    MySchoole.Print();
                    break;
                case 4:
                    MySchoole.SortingByName();
                    break;
                case 5:
                    MySchoole.SortingByEstimate();
                    break;
                case 6:
                    double first;
                    do
                    {
                        Console.WriteLine("Enter first test mark : ");
                        first = double.Parse(Console.ReadLine());
                    }while (first < 0 && first > 100);
                    MySchoole.SearchByFirstTestMark(first);
                    break;
                case 7:
                    double second;
                    do
                    {
                        Console.WriteLine("Enter second test mark : ");
                        second = double.Parse(Console.ReadLine());
                    }while ( second < 0 && second > 100);
                    MySchoole.SearchByFirstTestMark(second);
                    break;
            }
            do
            {
                Console.WriteLine("Enter y to continu or Enter n to exit");
                qua = Convert.ToChar(Console.ReadLine());
            } while (qua != 'y' && qua != 'Y' && qua != 'n' && qua != 'N');
        } while (qua == 'y' || qua == 'Y');
        Console.WriteLine("Welcome techer in my schoole");
    }
}
