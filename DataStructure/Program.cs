﻿using System;
using DataStructure;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** WELCOME IN THE DATA STRUCTURE *****");
        LinkedList list = new LinkedList();
        bool check = true;
        Console.WriteLine(" Display Linked List Data 1\n Dislpay Appeded Element list 2\n Adding Data at the perticular Position 3\n Delete Data At Perticular Position 4\n Deleting Last Index Elements 5\n Searching Elements In the Linked List 6\n Insert 40 between 30 and 70: 7\n Display Size of the Linked List 8\n");
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
                    list.Add(40);
                    list.Add(70);
                    list.Display();
                    break;
                case 2:
                    Console.WriteLine("**** DISPLAYING ELEMENT OF THE LINKED LIST ****");
                    list.Add(56);
                    list.Append(30);
                    list.Append(70);
                    break;
                case 3:
                    Console.WriteLine("**** ADDING  ELEMENT ON PERTICULAR POSITION IN THE LINKED LIST ****");
                    list.Add(56);
                    list.Add(70);
                    int a = list.Search(56);
                    list.InsertAtPerticularPosition(a+1, 30);
                    list.Display();
                    break;
                case 4:
                    Console.WriteLine("**** DELETING ELEMENT AT PERTICULAR POSITION IN THE LINKED LIST ****");
                    Console.WriteLine("Enter the position of the Element");
                    int index=Convert.ToInt32(Console.ReadLine());
                    list.DeleteNodeAtPerticularPosition(index);
                    list.Display();
                    break;
                case 5:
                    Console.WriteLine("**** DELETING  AT POSITION ELEMENT IN THE LINKED LIST ****");
                    list.DeleteLastIndex();
                    list.Display();
                    break;
                case 6:
                    Console.WriteLine("**** SEARCHING ELEMENT IN THE LINKED LIST ****");
                    int node = list.Search(30);
                    Console.WriteLine("element present on the index:-> " + node);
                    list.Display();
                    break;
                case 7:
                    Console.WriteLine("**** ADDING  ELEMENT ON PERTICULAR POSITION IN THE LINKED LIST ****");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    int b= list.Search(30);
                    list.InsertAtPerticularPosition( b+ 1, 40);
                    list.Display();
                    break;
                case 8:
                    Console.WriteLine("**** DISPLAYING SIZE OF THE LINKED LIST ****");
                    int search=list.Search(40);
                    list.LinkedListSize();
                    list.Display();
                    list.DeleteNodeAtPerticularPosition(search);
                    list.LinkedListSize();
                    list.Display();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}