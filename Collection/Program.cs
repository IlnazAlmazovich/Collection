using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.List<T> список
            Console.WriteLine("Использование List<T>:");
            List<int> numbers = new List<int>();//создаём пустой список целочисленных чисел
            numbers.Add(1);//Добавляем число 1 в список
            numbers.Add(2);//Добавляем число 2 в список
            numbers.Add(3);//Добавляем число 3 в список

            foreach (int number in numbers)//перебираем каждое число
            {
                Console.WriteLine(number);// выводим числа на консоль
            }
            Console.WriteLine();


            //2.Dictionary<TKey, TValue>: словарь
            Console.WriteLine("Использование Dictionary<TKey, TValue>:");
            Dictionary<string, int> ages = new Dictionary<string, int>();//Создаем пустой словарь с именами и возрастами
            ages.Add("Alice", 25); //Добавляем в словарь имя и возрост
            ages.Add("Bob", 30);//Добавляем в словарь имя и возрост
            ages.Add("Charlie", 35);//Добавляем в словарь имя и возрост

            foreach (KeyValuePair<string, int> kvp in ages)//перебираем каждую пару
                                                           //KeyValuePair объединяет два значения в одно значение kvp
            {
                Console.WriteLine("Name: " + kvp.Key + ", Age: " + kvp.Value);//выводим данные на консоль
            }
            Console.WriteLine();

            // 3.Queue<T>: очередь
            Console.WriteLine("Использование Queue<T>:");
            Queue<int> queue = new Queue<int>();// Создаем пустую очередь
            queue.Enqueue(1); // Добавляем число 1 в очередь
            queue.Enqueue(2); // Добавляем число 2 в очередь
            queue.Enqueue(3); // Добавляем число 3 в очередь

            while (queue.Count > 0)// Пока очередь не пуста будет выполнятьяс следующий код
            {
                int number = queue.Dequeue();// Извлекаем данные из очереди
                Console.WriteLine(number);// выводим данные на конслоль
            }
            Console.WriteLine();

            //4.Stack<T>: стек
            Console.WriteLine("Использование Stack<T>:");
            Stack<int> stack = new Stack<int>();//создаём пустой стек
            stack.Push(1);//добавляем в стек число 1
            stack.Push(2);//добавляем в стек число 2
            stack.Push(3);//добавляем в стек число 3

            while (stack.Count > 0)//пока стек не пустой
            {
                int number = stack.Pop();//извлекаем число
                Console.WriteLine(number);//выводим на консоль
            }
            Console.WriteLine();

            //5.HashSet<T>: множество
            Console.WriteLine("Использование HashSet<T>:");
            HashSet<int> set = new HashSet<int>();//создаём пустое множество
            set.Add(1);//добавляем число 1 в множество
            set.Add(2);//добавляем число 2 в множество
            set.Add(3);//добавляем число 3 в множество

            foreach (int number in set)//перебираем каждый элемент множества
            {
                Console.WriteLine(number);//выводим на консоль данные
            }
            Console.ReadKey();
        }
    }
}
