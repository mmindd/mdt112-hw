using System;
namespace passwordchecking
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 6-digit password: ");
            int password = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter agency name (FBI, CIA, or NSA): ");
            string agency = Console.ReadLine().ToUpper();

            bool isValid  = false;

            int firstdigit = password / 100000;
            int seconddigit = (password / 10000) % 10;
            int thirddigit = (password / 1000) % 10;
            int fourthdigit = (password / 100) % 10;
            int fifthdigit = (password / 10) % 10;
            int lastdigit = password % 10;

            if (agency == "CIA")
            {
                if (lastdigit % 3 == 0 && fifthdigit != 1 && fifthdigit != 3 && fifthdigit != 5
                    && thirddigit >= 6 && thirddigit != 8)
                    {
                        isValid = true;
                    }
            } 

            else if (agency == "FBI")
            {
                if (firstdigit >= 4 && firstdigit <= 7 && fourthdigit % 2 == 0
                    && fourthdigit != 6 && seconddigit % 2 == 1)
                    {
                        isValid = true;
                    }
            }

            else if (agency == "NSA")
            {
                bool hasseven = false;

                for (int i = 0; i < 6; i++)
                {
                    int digit = password % 10;
                    if (digit == 7)
                    {
                        hasseven = true;
                        break;
                    }

                    password /= 10;
                }

                if (30 % lastdigit == 0 && thirddigit % 3 == 0 && 
                    thirddigit % 2 == 1 && hasseven)
                    {
                        isValid = true;
                    }
            }

            Console.WriteLine("password " + (isValid ? "true" : "false"));

            Console.ReadLine();

        }
    }

}
