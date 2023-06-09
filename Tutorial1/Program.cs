﻿//===============Hash Tables============

using Tutorial1.HashTable;

HashTable hashTable=new HashTable();
hashTable.Set("ammad","032832232");
hashTable.Set("test", "7327834");
hashTable.Set("mike", "34242342");
hashTable.Set("john", "6576575656");

Console.WriteLine(hashTable.Get("ammad"));
Console.WriteLine(hashTable.Get("test"));
Console.WriteLine(hashTable.Get("mike"));
Console.WriteLine(hashTable.Get("john"));

////==============Tree Traversal===========
//using Tutorial1.BinarySearchTree;

//BinarySearchTree bst = new BinarySearchTree();
//bst.Insert(7, "squirtle");
//bst.Insert(23, "ekans");
//bst.Insert(151, "mew");
//bst.Insert(4, "charmander");
//bst.Insert(1, "bulbasaur");

//Console.WriteLine("\n**********Binary search Tree***********");
//bst.PrintRandomNodes(bst.Root);


//Console.WriteLine("\n**********In Order Traversal(L,Node,R)***********");
//bst.PrintInOrderTraversal();

//Console.WriteLine("\n**********Pre Order Traversal(Node,L,R)***********");
//bst.PrintPreOrderTraversal();

//Console.WriteLine("\n**********Post Order Traversal(L,R,Node)***********");
//bst.PrintPostOrderTraversal();




////=========Recusion=========
//using Tutorial1.Recursion;

//Recursion rec=new Recursion();
//Console.WriteLine(rec.RecurstiveFactorial(5));


////===============Bubble Sort==================

//using Tutorial1.SortingAlgos;

//BubbleSort bs=new BubbleSort();
//int[] unsortArray=new int[] {50,0,1,25,53,2,5,6,3};
//bs.SortArray(unsortArray);

//int[] unsortedArray = { 5, 2, 8, 4, 9, 1 };
//int[] sortedArray = bs.PerforBubbleSort(unsortedArray);

//// Print the sorted array
//Console.Write("\nSorted array: ");
//for (int i = 0; i < sortedArray.Length; i++)
//{
//    Console.Write(sortedArray[i] + " ");
//}

////==============Binary Trees====================== 

//using Tutorial1.BinarySearchTree;

//BinarySearchTree bst=new BinarySearchTree();
//bst.Insert(7,"Squirtle" );
//bst.Insert(23, "Ekans");
//bst.Insert(151, "Mew");
//bst.Insert(4 ,"Charmander");
//bst.Insert(1, "Bulbasaur");

//Console.WriteLine(bst.Find(151));



////==============Binary Search================
//int[] binaryArray = new int[] { -22,-15,2, 7,20, 30, 54 };
//Console.WriteLine(BinarySearch(binaryArray,2));

//int BinarySearch(int[]inArray, int value)
//{
//    int start = 0;
//    int end = binaryArray.Length;
//    //start end+while less than is going criss crossing
//    while (start<end)
//    {
//        //put in parenthesis because add them incorrect
//        int midpoint = (start+end) / 2;

//        //Search the middle the of the book
//        if (binaryArray[midpoint]==value)
//        {
//            return midpoint;
//        }
//        else if (binaryArray[midpoint] < value)
//        {
//            start = midpoint+1;
//        }
//        else
//        {
//            end = midpoint;
//        }
//    }
//    return -1;//if don't find anything
//}

//int findno = 56;

//int half = binaryarray.length/2;
//int end = binaryarray.length - 1;

//if (binaryarray[half] == findno)
//{
//    console.writeline($"number {findno} found at index {half}");
//}
//else if (findno > binaryarray[half])
//{
//	for (int i = half; i <= end ; i++)
//	{
//        if (binaryarray[i] == findno)
//        {
//            console.writeline($"number {findno} found at index {i}");
//        }

//    }
//}
//else
//{
//    for (int i = 0; i <= half; i++)
//    {
//        if (binaryarray[i] == findno)
//        {
//            console.writeline($"number {findno} found at index {i}");
//        }

//    }

//}






////===============Queue stuff===============
//using Tutorial1.Queue;

//Queue queue = new Queue(4);

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);

//queue.Dequeue();
//queue.Dequeue();

//queue.Peek();


////===========Stack stuff===============
//using Tutorial1.Stack;

//Stack stack = new Stack(10);

//for (int i = 0; i < 3; i++)
//{
//    stack.Push("Squirtle");
//    stack.Push("Pickachu");
//    stack.Push("Charmander");
//}

//stack.Pop();
//stack.Peek();

//while (!stack.isEmpty())
//{
//    var value = stack.Pop();
//    Console.WriteLine(value);   
//}

////=============Linked List stuff============
//using Tutorial1.LinkedList;

//LinkedList linkedList=new LinkedList();

//linkedList.InsertFirst(1);
//linkedList.InsertFirst(2);
//linkedList.InsertFirst(3);
//linkedList.InsertFirst(4);


//linkedList.DeleteFirst();
//linkedList.DeleteFirst();

//linkedList.InsertLast(546);
//linkedList.InsertLast(6);

//linkedList.DisplayList();


//Node nodeA = new Node();
//nodeA.Data = 9043;

//Node nodeB = new Node();
//nodeB.Data = 543;

//Node nodeC = new Node();
//nodeC.Data = 6434;

//Node nodeD = new Node();
//nodeD.Data = 500;

//nodeA.Next = nodeB;
//nodeB.Next = nodeC;
//nodeC.Next = nodeD;



////================LINEAR SEARCH============
///using System.Collections;
//using System.Xml.Linq;
//using Tutorial1.ADT;

//int[] inArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

////Key means what values we are searching for
//bool LinearSearch(int[] array, int key)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] == key)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine(LinearSearch(inArray, 0));
