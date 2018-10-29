using System;
namespace CarToList
{
    /// <summary>
    /// New class like a LinkedList
    /// </summary>
    class DoublyLinkedList
    {
        private Node First;         // First element of list
        private Node Current;       // Current element of list

        /// <summary>
        /// Initialize new list 
        /// </summary>
        public DoublyLinkedList()
        {
            Node node = new Node();
            First = Current = null;
        }
       
        /// <summary>
        /// Initialize new list with first element
        /// </summary>
        /// <param name="firstCar">Object that id added in vertex of list</param>
        public DoublyLinkedList(Car firstCar)
        {
            Node node = new Node();
            node = First;
        }

        /// <summary>
        /// Method that add object to first position in list
        /// </summary>
        /// <param name="newcar">Object that id added in vertex of list</param>
        public void Push(Car newcar)
        {
            Node newNode = new Node(newcar);

            if (First == null)
            {
                First = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode; 
                newNode.Next.Prev = First;
            }
        }

        /// <summary>
        /// Method that displays list on the screen
        /// </summary>
        public void Display() 
        {
            if (First.car == null)
            {
                Console.WriteLine("Doubly Linked List is empty");
                return;
            }
            Current = First;
            uint count = 1;
            while (Current != null)
            {
                Console.WriteLine("Car "  + count + " : " + Current.car.Model.ToString() + " " + Current.car.Brand.ToString() + " " 
                                          + Current.car.Color.ToString());
                count++;
                Current = Current.Next;
            }
        }

        /// <summary>
        ///  Method that searches objects with same parameters
        /// </summary>
        /// <param name="newcar">The fields of this object will be used to search for same objects.</param>
        /// <returns>Return objects that have same parameters</returns>
        public DoublyLinkedList Search(Car newcar)
        {
            Node Current = First;
            DoublyLinkedList SearchResult = new DoublyLinkedList();
            while (Current != null)
            {
                if ((Current.car.Brand == newcar.Brand) || (Current.car.Color == newcar.Color) || (Current.car.Model == newcar.Model))
                {
                    SearchResult.Push(new Car(Current.car));
                    Current = Current.Next;
                }
                else Current = Current.Next;
            }
            return SearchResult;
        }      
    }
}