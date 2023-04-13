using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; } //Array stack you need a maxsixe to init array
       
        public string[] StackArray { get; set; }//this hold our array
        
        public int Top { get; set; }// this keeps track of the top

        //constructor for initializing the array stack.
        public Stack( int size)
        {// this holds cosntructor value
            this.MaxSize=size;
            //create array with size; Array initialization
            this.StackArray=new string[MaxSize]; //initalized the max size of arrray.
            this.Top = -1; //it is like a pointer. we give the top -1 because array is zero index; if we don't it will skip first element.
        }

        public void Push(string item)
        {
            Top++; // Incrementing adding to the top.
            StackArray[Top] = item;
        }

        public string Pop()
        {
            int old_top=Top;    //Think placeholder
            Top--;    //Decrement for the new top
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        //=============helper methods=========
        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return (MaxSize - 1 == Top);
        }

    }
}
