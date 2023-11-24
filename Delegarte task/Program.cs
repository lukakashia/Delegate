using System;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers add = Add;
            AddNumbers substruct = Substract;
            AddIntNumbers multiplication = Addition;
            MyDelegate myDelegate = (message) =>
            {
                Console.WriteLine("Nameless function called with message: " + message);
            };

            Action<int, int> del = (a, b) =>
            {
                int sum = a + b;
                Console.WriteLine("sum: " +  sum);
            };

            double result = add(a:2.4, b: 4.5);
            double result2 = substruct(4.4, 2.2);
            int result3 = multiplication(10, 20);
            del(10, 20);

            Func<int, int, int> Task5 = FirstPart;

            Func<Func<int, int, int>, int, int, int> sa = SecondPart;
          
         
            Console.WriteLine("result of the addition is: " + result);
            Console.WriteLine("Result of the substraction is: " + result2);
            Console.WriteLine("Result of the multiplication of integers: " + result3);
        }
        public delegate double AddNumbers(double a, double b);
        public delegate int AddIntNumbers(int a, int b);
        public delegate void MyDelegate(string messae);
       
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Substract(double a, double b)
        {
            return a - b;
        }

        static int Addition(int a, int b)
        {
            return a * b;
        }
       static int FirstPart(int firstNum, int secondNum) => firstNum + secondNum;

        static int SecondPart(Func<int, int, int> meth, int firstNum, int secondNum) => meth(firstNum, secondNum) * (firstNum + secondNum);

    }
}