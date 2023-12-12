using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_exampl__Delte_list_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Удаление
            List<string> list = new List<string>()
            { 
             "Ильдина", 
             "Влад", 
             "Софа", 
             "Полина", 
             "Юра", 
             "Эдуард" 
            
            };

            //удаляем элемент под номером 1
            Console.WriteLine("Удаялем элемент по номеру позиции");
            list.RemoveAt(1);//удаляем элемент из заданной позиции
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //удаляем сам элемент
            Console.WriteLine("Удаляем элемент по его значению");
            list.Remove("Полина");//удаляем конкретный элемент
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Удаляем списко полностью
            Console.WriteLine("Полностью удаляем список:");
            list.Clear();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
