using System;
using System.Text;
using System.Threading;
class Programm {
    public string file;
    public string world;
    void Run()
    {
    Console.OutputEncoding = Encoding.UTF8;
    Console.Write("Введіть шлях до директорії: ");
    file = Console.ReadLine();
    Console.Write("Введіть слово для пошуку: ");
    world = Console.ReadLine();
    Console.Write("[Пошук запущено...] ");
    Thread.Sleep(1000);
    }
    void Search()
    {


        if (File.Exists(file)) 
        {
            string content = File.ReadAllText(file);

            if (content.Contains(world,StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Слово {world} Знайдено у файлі: {file}");
            else
                Console.WriteLine("Слово не знайдено");
        }
    }
    static void Main()
{
        Programm p = new Programm();

        var t1 = new Thread(p.Run);
        t1.Start();
        t1.Join();
        var t2 = new Thread(p.Search);
        t2.Start();

    }
               }