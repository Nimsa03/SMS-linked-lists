using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_linked_lists
{
    class Node
    {
        public Student Data { get; set; }
        public Node Next { get; set; }
       
        public Node(Student data)
        {
            Data = data;
            Next = null;
        }
    }
}
