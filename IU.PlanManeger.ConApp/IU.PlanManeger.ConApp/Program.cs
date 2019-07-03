using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IU.PlanManeger.ConApp.Models;
using System.Xml;
using System.IO;

namespace IU.PlanManeger.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathfilexml = @"D:\EventFileStore.xml";

            // Создаем xml файл, если его нет
            if (File.Exists(pathfilexml) == false)
            {
                XmlTextWriter textWritter = new XmlTextWriter(pathfilexml, Encoding.UTF8);
                // Создаем заголовок
                textWritter.WriteStartDocument();
                // Создаем "голову"
                textWritter.WriteStartElement("head");
                textWritter.WriteEndElement();
                textWritter.Close();
            }

            // Для занесения данных
            XmlDocument document = new XmlDocument();
            // Загружаем файл
            document.Load(pathfilexml);

            XmlNode element = document.CreateElement("element");
            // указываем родителя
            document.DocumentElement.AppendChild(element);
            
            // получим корневой элемент
            XmlElement root = document.DocumentElement;

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
                            Console.WriteLine("Введите дату начала события в формате (дд.мм.гггг)");
                            DateTime startdate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Введите дату окончания события в формате (дд.мм.гггг)");
                            DateTime enddate = DateTime.Parse(Console.ReadLine());
                            // сохраняем в хранилище
                            var evt = new Event();
                            evt.Title = line;
                            evt.StartDate = startdate;
                            evt.EndDate = enddate;
                            store.Add(evt);
                            // пишем, что все хорошо
                            Console.WriteLine("Все хорошо");

                            XmlNode subElement1 = document.CreateElement("title"); // даём имя
                            subElement1.InnerText = evt.Title; // и значение
                            element.AppendChild(subElement1); // и указываем кому принадлежит

                            XmlNode subElement2 = document.CreateElement("startdate"); // даём имя
                            subElement2.InnerText = evt.StartDate.Value.ToShortDateString(); // и значение
                            element.AppendChild(subElement2); // и указываем кому принадлежит

                            XmlNode subElement3 = document.CreateElement("enddate"); // даём имя
                            subElement3.InnerText = evt.EndDate.Value.ToShortDateString(); // и значение
                            element.AppendChild(subElement3); // и указываем кому принадлежит

                            document.Save(pathfilexml);

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
                                Console.WriteLine($"{evt.Title} Дата проведения: с {evt.StartDate.Value.ToShortDateString()} по {evt.EndDate.Value.ToShortDateString()}");
                            }

                            Console.WriteLine("События из файла");
                            // обход всех узлов в корневом элементе
                            foreach (XmlNode xnode in root)
                            {
                                // обходим все дочерние узлы элемента
                                foreach (XmlNode childnode in xnode.ChildNodes)
                                {
                                    if (childnode.Name == "title")
                                    {
                                        Console.Write(childnode.InnerText);
                                    }
                                    if (childnode.Name == "startdate")
                                    {
                                        Console.Write(" Дата проведения: с " + childnode.InnerText);
                                    }
                                    if (childnode.Name == "enddate")
                                    {
                                        Console.WriteLine(" по " + childnode.InnerText);
                                    }
                                }
                            }
                            Console.WriteLine();
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
