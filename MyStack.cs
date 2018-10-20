using System;

namespace ClassTask1
{
    class MyStack
    {
        /// <summary>
        /// Entry point
        /// </summary>
        static void Main(string[] args)
        {
           
                Stack myStack = new Stack(10);                // create stack with max.size = 10
                for (int i = 0; i < 9; i++)                   //fill the stack
               {
                    myStack.push(i + 5);
                }
                   
                if (!(myStack.emptyStack()))             
                myStack.pop();                                // delete element

                Console.WriteLine("MyStack is ");             // output stack
                if (myStack.emptyStack())
                {
                    Console.WriteLine(("MyStack is empty"));

                }
                else
                {
                    while (!(myStack.emptyStack()))            //check, that stack is not empty
                    {

                        int stackElement = myStack.pop();
                        Console.WriteLine(stackElement);

                    }

                }
                Console.Read();  
        }
    }
}
