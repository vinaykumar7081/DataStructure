using System;
using DataStructure;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** WELCOME IN THE DATA STRUCTURE *****");
        DataStructure.LinkedList<int> list = new DataStructure.LinkedList<int>();
        bool check = true;
        Console.WriteLine(" Adding A Node 1\n Dislpay Sorted List 2\n ");
        while (check)
        { 
        Console.WriteLine(" **** ENTER THE ABOVE OPTION TO EXECUTE THE METHODS *****");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("**** DISPLAYING ELEMENT OF THE LINKED LIST ****");
                    list.AddNode(56);
                    list.AddNode(30);
                    list.AddNode(40);
                    list.AddNode(70);
                   // list.DisplaySortedList();
                    break;
                case 2:
                    Console.WriteLine("**** DISPLAYING SORTED ELEMENT OF THE LINKED LIST ****");
                    list.SortOrderList();
                    break;
                
                case 0:
                    check = false;
                    break;
            }
        }
    }
}