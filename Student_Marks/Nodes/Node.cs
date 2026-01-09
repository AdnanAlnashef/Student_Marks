using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.Models;

namespace Student_Marks.Nodes
{
    //العقدة التي تمثل كل طالب
    public class Node
    {
        public Student Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(Student std)
        {
            Data = std;
        }
    }
}
