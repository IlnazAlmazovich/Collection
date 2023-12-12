using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Добавление в список
            Console.WriteLine("Добавляем элемент в лист:");
            List<string> name = new List<string>() { "Ильназ Алмазович" };//дан список где есть одно значение

            //в список name добавление значение
            name.Add("Талгат Рамилевич");
            foreach (string item in name)//перебираем каждый элемент списка
                //вместо типа данных string также можно использовать универсальный тип данных var
            {
                Console.WriteLine(item);//выводим на консоль весь список
            }
            Console.WriteLine();

            //Добавление массива
            Console.WriteLine( "Добавляем массив:");
            name.AddRange(new[] { "Ильдина", "Влад", "Софа", "Полина", "Юра", "Эдуард" });//добавляем текстовый массив в списко который дан выше
            foreach (string item in name)//перебираем каждый элемент массив
            {
                Console.WriteLine(item);//выводим список
            }
            // также можно было бы добавить другой список
            // name.AddRange(new List<string>(){ "Ильдина", "Влад", "Софа", "Полина", "Юра", "Эдуард"  });
            Console.WriteLine();


            //Вставляем элемент в определённое место
            Console.WriteLine("Всталяаем элемент на первое место:");
            name.Insert(0, "Мирас");// сначало указываем номер позиции потом указываем сам текст куда надо вставить
            foreach(string item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //name.InsertRange(1, new string[] { "Тимур", "Даша" }); // вставляем массив с индекса 1
            Console.ReadKey();
        }
    }
}
