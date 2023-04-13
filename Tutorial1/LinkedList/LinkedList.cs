﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }

        public bool isEmpty()
        {
            return First != null;
        }

        public void InsertFirst(int data)
        {
            // create the node
            Node newNode=new Node();
            //put data in the node
            newNode.Data = data;
            //put the old node in next
            newNode.Next=First;
            //make the first the new node
            First=newNode;
        }

        public Node DeleteFirst()
        {
            //Assign the temporary variable
            Node temp=First;
            //Assign the next node
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list.........");
            Node current = First;
            while (current!=null)
            {
                current.DisplayNode();
                current=current.Next;
            }

        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next!=null)
            {
                current = current.Next;
            }
            Node newNode=new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
