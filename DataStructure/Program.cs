using System;
using DataStructure;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** WELCOME IN THE DATA STRUCTURE *****");
        LinkedList list = new LinkedList();
        bool check = true;
        Console.WriteLine(" Display Linked List Data 1\n");
        while (check)
        { 
        Console.WriteLine(" **** ENTER THE ABOVE OPTION TO EXECUTE THE METHODS *****");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("**** DISPLAYING ELEMENT OF THE LINKED LIST ****");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}