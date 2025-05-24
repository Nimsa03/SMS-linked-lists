using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SMS_linked_lists
{
    class SinglyLinkedList
    {
        private Node head;
        private Node tail;

        internal Node Head { get => head; set => head = value; }
        internal Node Tail { get => tail; set => tail = value; }

        public SinglyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public bool Insert(Student student)
        {
            Node current = head;
            while(current!= null)
            {
                if(current.Data.IndexNum == student.IndexNum)
                {
                    Console.WriteLine("Already exists");
                    return false;
                }
                current = current.Next;
            }
            Node newNode = new Node(student);

            if (head==null || student.IndexNum < head.Data.IndexNum)
            {
                newNode.Next = head;
                head = newNode;
                return true;
            }
            current = head;
            while(current.Next != null && current.Next.Data.IndexNum < student.IndexNum)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            return true;
        }

        public Student Search(int indexNum)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.IndexNum == indexNum)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }

        public bool remove(int indexnum)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Data.IndexNum == indexnum)
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.IndexNum == indexnum)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No students");

            }
            Console.WriteLine("STUDENT LIST");

            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

        }
    }
}
