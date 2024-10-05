using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread chickenThread = new Thread(PrintChicken);
        Thread eggThread = new Thread(PrintEgg);
        Console.WriteLine("Спор начался! Участники спора: ");
        chickenThread.Start();
        eggThread.Start();

        // Дожидаемся завершения обоих потоков
        chickenThread.Join();
        eggThread.Join();

        // Проверяем, какой поток завершился последним
        if (chickenThread.IsAlive)
        {
            Console.WriteLine("Побеждает: Курица");
        }
        else
        {
            Console.WriteLine("Побеждает: Яйцо");
        }
    }

    static void PrintChicken()
    {
        Console.WriteLine("Курица");
    }

    static void PrintEgg()
    {
        Console.WriteLine("Яйцо");
    }
}