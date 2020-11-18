using System;

namespace stubbing_project
{
    public class Program
    {
        public bool switch_case(string x)
        {
            switch (int.Parse(x))
            {
                case 1:
                    Console.WriteLine("Option 1 isnt complet yet");
                    return true;
                case 2:
                    Console.WriteLine("Option 2 isnt complete yet");
                    return true;
                case 3:
                    Console.WriteLine("Option 3 isnt complete yet");
                    return true;
                case 4:
                    Console.WriteLine("Option 4 isnt complete yet");
                    return true;
                case 5:
                    Console.WriteLine("Option 5 isnt complete yet");
                    return true;
                case 6:
                    Console.WriteLine("Option 6 isnt complete yet");
                    return true;
                case 7:
                    Console.WriteLine("Option 7 isnt complete yet");
                    return true;
                case 8:
                    Console.WriteLine("Option 8 isnt complete yet");
                    return true;
                case 9:
                    Console.WriteLine("Option 9 isnt complete yet");
                    return true;
                case 10:
                    Console.WriteLine("Option 10 isnt complete yet");
                    return true;
                case 11:
                    return true;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid answer!! Press any button to try again");
                    Console.ReadKey();
                    return false;
            }
        }
        void menu(Program program)
        {

            Console.Clear();
            Console.WriteLine("Please choose one of the following case options: ");
            Console.WriteLine();
            Console.WriteLine("Option 1");
            Console.WriteLine();
            Console.WriteLine("Option 2");
            Console.WriteLine();
            Console.WriteLine("Option 3");
            Console.WriteLine();
            Console.WriteLine("Option 4");
            Console.WriteLine();
            Console.WriteLine("Option 5");
            Console.WriteLine();
            Console.WriteLine("Option 6");
            Console.WriteLine();
            Console.WriteLine("Option 7");
            Console.WriteLine();
            Console.WriteLine("Option 8");
            Console.WriteLine();
            Console.WriteLine("Option 9");
            Console.WriteLine();
            Console.WriteLine("Option 10");
            Console.WriteLine();
            Console.WriteLine("Option 11 for EXIT");


            string x = Console.ReadLine();
            bool result = true;
            result = program.switch_case(x);

            if (!result)
            {
                program.menu(program);
            }


        }


        static void Main(string[] args)
        {
            Program program = new Program();

            program.menu(program);

        }
    }

}