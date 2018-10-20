
namespace ClassTask1
{ 
    /// <summary>
    ///  Class, that realize stack and its methods
    /// </summary>
    class Stack
    {
        public int maxSize;
        public int[] masStack;                     // array,that the basis of stack
        public int size;                           // size of stack
        /// <summary>
        ///  constructor, that realizes stack  
        /// </summary>
        /// <param name="maxSize">
        /// takes the maximum size ofstack
        /// </param>
        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            masStack = new int[maxSize];
            size = -1;
        }
        /// <summary>
        /// Method that adds elemnts in stack
        /// </summary>
        /// <param name="value">
        /// Value that is added to the stack
        /// </param>
        public void push(int value)
        {
           size = size + 1; 
            masStack[size] = value;
        }
        /// <summary>
        /// Method that removes an element
        /// </summary>
        /// <returns>
        /// Return stack without last element
        /// </returns>
        public int pop()
        {  
            return  (masStack[size--]);
        }
        /// <summary>
        /// Method,that checks does stack has elements
        /// </summary>
        /// <returns> 
        /// If stack empty return true
        /// </returns>
        public bool emptyStack()
        {
            return (size==-1);
        }
    }
}
