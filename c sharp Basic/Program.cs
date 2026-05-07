class Program
{

    static void Main()
    {
        int TotalCofeeCost = 0;
    Start:

        Console.WriteLine("1 - Small , 2 - Medium , 3 - Large");

        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {

            case 1:
                TotalCofeeCost += 1;
                break;

            case 2:
                TotalCofeeCost += 2;
                break;

            case 3:
                TotalCofeeCost += 3;
                break;

            default:
                Console.WriteLine("Your choice {0} is invalid", userChoice);
                break;
        }
    Decide:
        Console.WriteLine("Do you want to buy another Coffee :-  Yes , No");
        
            string userDecision = Console.ReadLine();

        switch (userDecision.ToUpper())
        {


            case "YES": goto Start;
            case "NO": break;
            default:
                Console.Write("Your choice {0} is invalid, please try again");
                goto Decide;


        }
            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalCofeeCost);
        }
    }

