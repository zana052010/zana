using System.Runtime.CompilerServices;

namespace zana
{
    
    class Program
    {
        static void Call(int a, int b)
        {
            Console.WriteLine("Напишите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите символ который хотите вставить: + - * /");
            char res = Convert.ToChar(Console.ReadLine());
            switch (res)
            {
                case '+':
                    int result = a + b;
                    Console.WriteLine($"{a} {res} {b} = {result} ");
                    break;
                case '-':
                    int result1 = a - b;
                    Console.WriteLine($"{a} {res} {b} = {result1} ");
                    break;
                case '*':
                    int result2 = a * b;
                    Console.WriteLine($"{a} {res} {b} = {result2} ");
                    break;
                case '/':
                    int result3 = a / b;
                    Console.WriteLine($"{a} {res} {b} = {result3} ");
                    break;
            }
        }

        static void Main()
        {
            int a = 0; 
            int b = 0;
            Call(a, b);
        }
    }
}