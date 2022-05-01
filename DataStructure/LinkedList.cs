using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList<T> where T:IComparable
    {
        public Node<T> head=null;
        public void AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine(newNode.data + " " + "inserted into Linked List ");
            }
        }
        public void SortOrderList()
        {
            Node<T> current = head, index=null;
            T temp;
            if (head == null)
            {
                return;
            }
               
            while (current != null)
            {
                index = current.next;
                while (index != null)
                {
                    if (current.data.CompareTo(index.data) > 0)
                    {
                        temp = current.data;
                        current.data=index.data;
                        index.data=temp;
                    }
                    index=index.next;
                }
                current = current.next;
            }
            DisplaySortedList();
        }
        public void DisplaySortedList()
        { 
        Node<T> temp=head;
            if (head == null)
            { 
            Console.WriteLine("There is no element int he linked List");
            }
            while (temp != null)
            { 
            Console .Write(temp.data+ "  ");
                temp=temp.next;
            }
            Console.WriteLine(" ");
        }
    }
}
