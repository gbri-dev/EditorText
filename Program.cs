using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("O Que Deseja Fazer?");
            System.Console.WriteLine("1 - Abrir um arquivo");
            System.Console.WriteLine("2 - Criar um novo arquivo");
            System.Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Abrir()
        {

        }

        static void Editar()
        {

        }
    }
}
