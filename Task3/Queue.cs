using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Task3 
{
    public class Queue<T> : IEnumerable<T>
    {
        T[] array;
        int changeCounter = 0;       
        int enqueuePointer = 0;
        int dequeuePointer = 0;
        int size;

        public bool IsEmpty
        {
            get
            {
                return enqueuePointer == dequeuePointer;
            }
        }

        public Queue(int size = 16)
        {
            Contract.Requires<ArgumentOutOfRangeException>(size > 0);
            array = new T[size];
            this.size = size;
        }

        public void Enqueue(T element)
        {
            changeCounter++;
            array[enqueuePointer++] = element;
            enqueuePointer %= size;
            if (enqueuePointer == dequeuePointer)
                IncreaseQueue();
        }

        public T Dequeue()
        {
            
            if (dequeuePointer == enqueuePointer)
                throw new InvalidOperationException("Queue is empty.");
            changeCounter++;
            return array[dequeuePointer++];
        }

        public T Peek()
        {
            if (dequeuePointer == enqueuePointer)
                throw new InvalidOperationException("Queue is empty.");
            return array[dequeuePointer];
        }
       
        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class QueueEnumerator<U> : IEnumerator<U>
        {
            Queue<U> queue;
            int pointer;
            int changeCounter;
            bool moved = false;
            public QueueEnumerator(Queue<U> queue)
            {
                this.queue = queue;
                pointer = queue.dequeuePointer - 1;
                changeCounter = queue.changeCounter;
            }

            public U Current
            {
                get
                {
                    if (!moved)
                        throw new InvalidOperationException("Invalid enumerator pointer.");
                    return queue.array[pointer];                    
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
           
            public bool MoveNext()
            {
                if (changeCounter != queue.changeCounter)
                    throw new InvalidOperationException("Collection was changed.");
                moved = true;
                pointer = (pointer + 1) % queue.size;
                return pointer != queue.enqueuePointer;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose() { }
        }

        private void IncreaseQueue()
        {
            T[] newArray = new T[size * 2];
            int i = 0;        
            do
            {
                newArray[i++] = array[enqueuePointer];
                enqueuePointer = (enqueuePointer + 1) % size;
            } while (enqueuePointer != dequeuePointer);
            array = newArray;
            dequeuePointer = 0;
            enqueuePointer = size;
            size *= 2;
        }
    }
}
