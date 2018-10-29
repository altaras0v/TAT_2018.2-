namespace CarToList
{
    /// <summary>
    /// Class with Nodes that needs for creation of DoublyLinkedList
    /// </summary>
    public class Node
    {
        private Node _Next;
        private Node _Prev;
        public Car car { get; set; }

        /// <summary>
        /// Initialize new node with empty fields
        /// </summary>
        public Node()
        {

        }

        /// <summary>
        /// Initialize new node with field Car
        /// </summary>
        /// <param name="newCar">Object to add parameters for car(object) field</param>
        public Node(Car newCar)
        {
           car = newCar;
        }

        /// <summary>
        /// Initialize next node
        /// </summary>
        public Node Next
        {
            get { return this._Next; }
            set { this._Next = value; }
        }

        /// <summary>
        /// Initialize previous node
        /// </summary>
        public Node Prev
        {
            get { return this._Prev; }
            set { this._Prev = value; }
        }
    }
}