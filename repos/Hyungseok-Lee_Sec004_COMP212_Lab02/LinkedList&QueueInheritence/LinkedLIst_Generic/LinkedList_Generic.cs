using System;

namespace LinkedLIst_Generic
{
    class ListNode<T>
    {
        // automatic read-only property Data
        public T Data { get; private set; }

        // automatic property Next
        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    // class List declaration
    public class List<T> where T:IComparable<T> 
        // To use the extension 'Compare to', inherits the interface ICompparable<T>
    {
        private ListNode<T> firstNode;
        private ListNode<T> lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert T at front of List. If List is empty, 
        // firstNode and lastNode will refer to same T.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                firstNode = new ListNode<T>(insertItem, firstNode);
            }
        }

        // Insert T at end of List. If List is empty, 
        // firstNode and lastNode will refer to same T.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode<T>(insertItem);
            }
        }

        // remove first node from List
        public T RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }

        // remove last node from List
        public T RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode<T> current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: \n");

                ListNode<T> current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.WriteLine($"{current.Data} ");
                    current = current.Next;
                }
                Console.WriteLine("\n");
            }
        }

        public T Minimum()/* A method that finds the minimum value in the list.
            The method starts targeting the next node from the first node(the current node at the start) 
            and assign a current node to the next node if the next node has a smaller data value
            than the current node else the targeting
            is changed to the next node's next node and reapts detecting 
            if the targetted node has a smaller value than current value.
            To use the 'Compare to' extension, the class List<T> inherits the Icomparable<T> interface.*/
        {
            var current = firstNode;
            var next = current.Next;
            T result = current.Data;
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            else
            {
                while (next != null)
                {
                    if (result.CompareTo(next.Data) > 0)
                    {
                        current = next;
                        result = current.Data;
                    }
                    else
                    {
                        next = next.Next;
                    }
                }
                return result;
            }
        }

        public T GetLastNode()/*A method that returns the last node in the list
            through targeting the next node repeatedly until the next node is null as the alst node's next node is not present*/
        {
            ListNode<T> current = firstNode;
            if (IsEmpty())
            {
                throw new EmptyListException(name);     
            }
            else
            {
                while(current.Next != null)
                {
                    current = current.Next;
                }
            }
            return current.Data;
        }
    }

    // class EmptyListException declaration
    public class EmptyListException : Exception
    {
        // parameterless constructor
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name)
           : base($"The {name} is empty") { }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner)
           : base(exception, inner) { }
    }
}
