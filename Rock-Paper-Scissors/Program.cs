using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        // 1 - rock
        // 2 - paper
        // 3 - scissors
        static void Main(string[] args)
        {
            Console.Title = "Rock-Paper-Scissors";            
            Console.WriteLine("Choose mode [E]asy [M]edium or [I]mpossible");
            while (true)
            {
                var pressKey = Console.ReadKey(true).Key;
                if (pressKey == ConsoleKey.E)
                {
                    Easy();
                    break;
                }                    
                else if (pressKey == ConsoleKey.M)
                {
                    Midium();
                    break;
                }                
                else if (pressKey == ConsoleKey.I)
                {
                    Impossible();
                    break;
                }
                else
                {
                    Console.WriteLine("This key is not avaliable! \nPlease, choose mode between [E]asy [M]edium or [I]mpossible!");
                }                       
            }                       
        }
        public static void Easy()
        {
            Console.WriteLine("Choose [r]ock [p]aper or [s]cissors");           
            int input = 0;
            while (input == 0)
            {
                var pressKey = Console.ReadKey(true).Key;
                if (pressKey == ConsoleKey.R)
                    input = 1;
                else if (pressKey == ConsoleKey.P)
                    input = 2;
                else if (pressKey == ConsoleKey.S)
                    input = 3;
                else
                    Console.WriteLine("This key is not avaliable! \nPlease, choose between [r]ock [p]aper or [s]cissors!");
            }
            if (input == 1)
                Console.WriteLine("The computer chose Scissors");            
            else if (input == 2)
                Console.WriteLine("The computer chose Rock");
            else
                Console.WriteLine("The computer chose Paper");
            Console.WriteLine("You win");
        }

        public static void Midium()
        {
            Console.WriteLine("Choose [r]ock [p]aper or [s]cissors");
            
            int input = 0;
            while (input == 0)
            {
                var pressKey = Console.ReadKey(true).Key;
                if (pressKey == ConsoleKey.R)
                    input = 1;
                else if (pressKey == ConsoleKey.P)
                    input = 2;
                else if (pressKey == ConsoleKey.S)
                    input = 3;
                else
                    Console.WriteLine("This key is not avaliable! \nPlease, choose between [r]ock [p]aper or [s]cissors!");
            }

            Random rn = new Random();
            int aiChose = rn.Next(1, 4);
            if (aiChose == 1)
                Console.WriteLine("The computer chose Rock");
            else if (aiChose == 2)
                Console.WriteLine("The computer chose Paper");
            else
                Console.WriteLine("The compuer chose Scissors");
            
            if (input == aiChose)
                Console.WriteLine("Draw");
            else if (input == 1 && aiChose == 2)         
                Console.WriteLine("You lose");
            else if (input == 2 && aiChose == 1)
                Console.WriteLine("You win");
            else if (input == 1 && aiChose == 3)           
                Console.WriteLine("You win");
            else if (input == 3 && aiChose == 1)
                Console.WriteLine("You lose");
            else if (input == 2 && aiChose == 3)           
                Console.WriteLine("You lose");
            else       
                Console.WriteLine("You win");
        }

        public static void Impossible()
        {
            Console.WriteLine("Choose [r]ock [p]aper or [s]cissors");
            int input = 0;
            while (input == 0)
            {
                var pressKey = Console.ReadKey(true).Key;
                if (pressKey == ConsoleKey.R)
                    input = 1;
                else if (pressKey == ConsoleKey.P)
                    input = 2;
                else if (pressKey == ConsoleKey.S)
                    input = 3;
                else
                    Console.WriteLine("This key is not avaliable! \nPlease, choose between [r]ock [p]aper or [s]cissors!");
            }
            if (input == 1)
                Console.WriteLine("The computer chose Paper");
            else if (input == 2)
                Console.WriteLine("The computer chose Scissors");
            else
                Console.WriteLine("The computer chose Rock");
            Console.WriteLine("You lose");
        }
    }
}

