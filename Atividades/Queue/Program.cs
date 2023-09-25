using System;

namespace QueueClass
{

    public class Queue
    {

        static readonly int MAX = 10;
        int back = -1;
        int front = -1;
        int[] queue = new int[MAX];

        public bool IsEmpety(){
            return (back < 0);
        }

        public bool Enqueue()
    }
}