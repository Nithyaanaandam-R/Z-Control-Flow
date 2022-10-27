using System.Runtime.CompilerServices;

internal class Program
{
    private static int Main(string[] args)
    {
        List<int> collections = new List<int>();

    MainMenu:

        Console.WriteLine("Enter a number between 1 - 1000");
        int inp = int.Parse(Console.ReadLine());

        inp = (inp > 1000) ?inp/=1000 : inp*= 1 ; //Tertiary Conditional Operator

        if(inp % 31 == 0) //if - else if ladder
        {
            Console.WriteLine("Jackpot!!!!");
        }
        else if(inp % 5 == 0)
        {
            if (inp > 500)
                Console.WriteLine($"You have won {inp / 2 + 5}");

            else if (inp > 750)
                Console.WriteLine($"You have lost {inp / 1.5}!");
            else
                Console.WriteLine($"You have retained your amount");
        }
        else if(inp % 2 == 0)
        {
            Console.WriteLine("You get a free coupon!");
        }
        else
        {
            Console.WriteLine("Better Luck next time ;)");
        }

        Console.WriteLine("Would you like to try again ?");

        switch (Console.ReadLine()) //switch case
        {
            case "y":
            case "Y":
                goto MainMenu;
                break;
            default:break;
        }

        Console.WriteLine("!!! You are being looped ;p Do not leak the jackpot numbers ;) "); //Loops

        for(int i = 1; i < 1000; i++)
        {
            collections.Add(i);
            
            if (i % 31 == 0)
                Console.WriteLine($"You could have won if you entered this number - {i}");          
            
            if (i == 346)
            {
                Console.WriteLine("Do you want to exit the loop? Enter abcde. NOW!!!");
                if (Console.ReadLine() == "abcde")
                    break;                                                                          //breaks you out the loop
            }

        }

        do
        {
            Console.WriteLine("This will execute atleast once, so don't mind it");                  // executes atleast once and then checks conditon (exit controlled loop)
        } while (--inp > inp);

        foreach (int val in collections)
        {
            if (val % inp == 0)
            {
                Console.WriteLine($"Bug Found! xD{val}");
            }
        }

        Console.WriteLine("Finally out! Returning 0. Over and out");
        return 0;

    }
}