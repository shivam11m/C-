using System;

namespace practiceapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string c = Console.ReadLine();

            Calc obj = new Calc(a,b);
            if(c== "+")
            {
                int r = obj.add();
                Console.WriteLine(r);
            }
            else if(c == "-")
            {
                int r = obj.subtract();
                Console.WriteLine(r);
            }
            else if(c == "/")
            {
                int r = obj.divide();
                Console.WriteLine(r);
            }
            else
            {
                int r = obj.mul();
                Console.WriteLine(r);
            }


        }
    }
    class Calc
    {
        public int num1, num2;
        public Calc(int a, int b)
        {
            this.num1 = a;
            this.num2 = b;

        }

        public int add()
        {
            return num1+num2;
        }
        public int subtract()
        {
            return num1-num2;
        }
        public int divide()
        {
            if (num2!= 0)
            {
                return num1/num2;
            }
            return 0;
        }
        public int mul()
        {
            return num1*num2;
        }
    }
}
