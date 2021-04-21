using System;

namespace FirstRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to  Sarah Pizza's Store");
            Console.WriteLine("The Pizza available are  Small(500), Medium(1000), Large(1500) ");
            Console.WriteLine("Please Enter 1 for Small, 2 for Medium, 3 for Large");

            Order();
            Continue();
        }

        private static void Order()
        {
            string choiceOfPizza = Console.ReadLine();
            int small = 500;
            int medium = 1000;
            int large = 1500;

            switch (choiceOfPizza)
            {
                case "1":
                    Console.Write($"Thank you for Shopping with us\nYour order is the small Pizza \nYour Bill is {small} ");
                    break;
                case "2":
                    Console.WriteLine($"Thank you for Shopping with us \nYour order is the Medium Pizza \nYour Bill is {medium} ");
                    break;
                case "3":
                    Console.WriteLine($"Thank you for Shopping with us \nYour order is the Large Pizza \nYour Bill is {large} ");
                    break;
                default:
                    Console.WriteLine("Invalid Selection\nPlease Enter 1, 2 or 3 for your order ");
                    Order();
                    break;
            }
        //     Console.WriteLine("Do you want to order again? \nPlease Enter 'Yes' or 'No'"); ;
        //     string contShop = Console.ReadLine();

        //     if (contShop == "no")
        //     {
        //         Console.WriteLine("Thank you!");
        //         Console.WriteLine($"Your Total is ");

        //     }
        //     else if (contShop == "yes")
        //     {
        //         Console.WriteLine("welcome to  Sarah Pizza's Store");
        //         Console.WriteLine("The Pizza available are  Small(500), Medium(1000), Large(1500) ");
        //         Console.WriteLine("Please Enter 1 for Small, 2 for Medium, 3 for Large");
        //         Order();
        //         Continue();
        //     }
        //     else
        //     {
        //         Console.WriteLine("invalid Option");
        //         Continue();

        //     }



        }
        private static void Continue()
        {
            Console.WriteLine("Do you want to order again? \nPlease Enter 'Yes' or 'No'"); ;
            string contShop = Console.ReadLine();

            if (contShop == "no")
            {
                Console.WriteLine("Thank you!");
                Console.WriteLine($"Your total bill is");
                Environment.Exit(0);

            }
            else if (contShop == "yes")
            {
                Console.WriteLine("welcome to  Sarah Pizza's Store");
                Console.WriteLine("The Pizza available are  Small(500), Medium(1000), Large(1500) ");
                Console.WriteLine("Please Enter 1 for Small, 2 for Medium, 3 for Large");
                Order();
                
            }
            else
            {
                Console.WriteLine("invalid Option");
                Continue();

            }
        }

    }
}
