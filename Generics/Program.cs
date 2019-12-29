using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        //generic method to operate on any data type
        public static void MyGenericMethod<T>(T x, T y) 
        { 
            Console.WriteLine($"Parameters type is {typeof(T)}" ); 
        }
        static void Main(string[] args)
        {
            //Can only contain int type 
            List<int> intList = new List<int>(); 
            //no boxing 
            intList.Add(10); 
            //no unboxing 
            int i = intList[0]; 
            //Can only contain Employee objects 
            List<Employee> empList = new List<Employee>(); 
            //no boxing 
            empList.Add(new Employee("Amr", "Ashush", 23500)); 
            //no unboxing 
            Employee e = empList[0];
            Console.WriteLine(e.Display());

            Console.WriteLine();

            //A generic Queue collection 
            Queue<int> intQueue = new Queue<int>();
            //Add an int to the end of the queue 
            //(no boxing) 
            intQueue.Enqueue(5);
            //Returns the int at the beginning of the queue 
            //without removing it. 
            //(no unboxing) 
            int j = intQueue.Peek();
            Console.WriteLine(j);
            //Removes and returns the int at the beginning of the queue 
            //(no unboxing) 
            int k = intQueue.Dequeue();
            Console.WriteLine(k);

            Console.WriteLine();

            Stack<int> intStack = new Stack<int>(); 
            //Insert an int at the top of the stack 
            //(no boxing) 
            intStack.Push(6); 
            //Returns the int at the top of the stack 
            //without removing it. 
            //(no unboxing) 
            int x = intStack.Peek();
            Console.WriteLine(x);
            //Removes and returns the int at the top of the stack 
            //(no unboxing) 
            int y = intStack.Pop();
            Console.WriteLine(y);

            Console.WriteLine();

            Dictionary<string, int> dictionary = new Dictionary<string, int>(); 
            //Add the specified key and value to the dictionary
            dictionary.Add("Position", 8);
            dictionary.Add("Age", 23);
            //Removes the value with the specified key from the dictionary 
            dictionary.Remove("Position"); 
            //get the number of the Key/Value pairs contained in the dictionary 
            int count = dictionary.Count;
            Console.WriteLine(count);

            Console.WriteLine();

            //universal generic method implementation
            int a=2, b=6; 
            MyGenericMethod<int>(a, b);

            Console.WriteLine();

            string st="me", str="you";
            //you can omit the type parameter if the generic method requires arguments, because the compiler can infer the type parameter based on the member parameters ie no need for MyGenericMethod<string>(st, str);
            MyGenericMethod(st, str);

        }
    }
}
