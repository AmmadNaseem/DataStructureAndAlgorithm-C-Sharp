using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Queue
{
    public class Queue
    {
        //FANTOM VALUES WILL STILL EXIST BUT WE MOVE FRONT LOGICALLY.
        public int MaxSize { get; set; } // Sets the number of elements because this is an array
        public int[] QueueArray { get; set; }//Actual array we will store elements in
        public int Front { get; set; }//Index to keep track of front.it used with Dequeue.front is logically remove. it keep track of our array.
        public int Rear { get; set; }//Index to keep track of adds.last item tracking.Used with Enqueue
        public int NItems { get; set; }//This will keep track of length

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray=new int[size];
            Front = 0;// USED FOR DEQUEUING
            Rear = -1; //last item tracking. USED FOR ENQUEUING.
        }

        //=========somebosy is going into chik fila line
        public void Enqueue(int item)
        {
            Rear++; //increment our pointer for keep the track of line we are in.
            QueueArray[Rear] =item; //insert into where the rear was incremented.
            NItems++; //Increment that track number of items.
        }

        public int Dequeue()
        {
            int temp=QueueArray[Front];
            Front++;
            if (Front==MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek()
        {
            return QueueArray[Front];   
        }
    }
}
