using System;

namespace PolskaZapis
{
    class Program
    {
        static void Main(string[] args)
        {
            string primer = Console.ReadLine();
            string[] zapisi = primer.Split(" ");
            string[] result = new string[zapisi.Length];
            SimpleStack<string> stack = new SimpleStack<string>();
            for(int i = 0; i < zapisi.Length;i++)
            {
                string x = zapisi[i];
                if (x == "(")
                {
                    stack.Push(x);
                }
                else if (x == ")")
                {

                }
                else if (x == "-")
                {
                    result[i] = stack.Peek();
                    stack.Pop();
                    stack.Push(x);

                }
                else if (x == "+")
                {
                    stack.Push(x);
                }
                else if (x == "/")
                {
                    stack.Push(x);
                }
                else if (x == "*")
                {
                    stack.Push(x);
                }
                else
                {
                    result[i] = x;
                }
            }
        }
    }
}
