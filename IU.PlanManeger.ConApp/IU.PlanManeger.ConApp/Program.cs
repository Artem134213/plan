using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IU.PlanManeger.ConApp.Models;

namespace IU.PlanManeger.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStore<Event> store = new EventStore();

            while (true)
            {
                Console.WriteLine("0. Отчистить");
                Console.WriteLine("1. Добавть событие");
                Console.WriteLine("2. Показать все событие");

                // Получть выбор пользователя
                var select = Console.ReadLine();
                switch (select)
                {
                    case "0":
                        {
                            Console.Clear();
                            break;
                        }
                    case "1":
                        {
                            // если выбрано Добавить
                            // просим ввести title и дату
                            Console.WriteLine("Введите тему");
                            var line = Console.ReadLine();
                            // сохраняем в хранилище
                            var evt = new Event();
                            evt.Title = line;
                            store.Add(evt);
                            // пишем, что все хорошо
                            Console.WriteLine("Все хорошо");
                            break;
                        }
                    case "2":
                        {
                            // если выбрано Показать
                            Console.WriteLine("События");
                            // Перебираем все значения из хранилища
                            foreach (var evt in store.Entities)
                            {
                                // выводим их на экран
                                Console.WriteLine($"{evt.Uid} {evt.Title}");
                            }
                            break;
                        }
                    default:
                        break;
                }
                // если выбрано Показать
                // Перебираем все значения из хранилища
                // выводим их на экран
            }
            Console.ReadKey();
        }
    }
}
