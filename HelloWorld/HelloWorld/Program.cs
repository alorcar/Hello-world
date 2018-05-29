using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Write(Messages.Bienvenido);
            Console.Title = Messages.MyfirstHelloWorldApp;
            Console.WriteLine("Messages.MyfirstHelloWorldApp");
            Console.Read();
        }
    }
}
