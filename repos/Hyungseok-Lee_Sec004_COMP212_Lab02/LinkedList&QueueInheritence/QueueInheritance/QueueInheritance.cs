using System;
using LinkedLIst_Generic;
namespace QueueInheritance
{
    public class QueueInheritance<T> :List<T> where T:IComparable<T>
    {
        // pass name "queue" to List constructor
        public QueueInheritance() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(T dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public T Dequeue()
        {
            return RemoveFromFront();
        }
    }
}
