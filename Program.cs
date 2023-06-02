// See https://aka.ms/new-console-template for more information
using VisioForge.Libs.ZXing;

DateTime today = DateTime.Today;
string input = "";

do
{
    Console.WriteLine("Which date? (or 'exit')");
    input = Console.ReadLine();   //Asking user input date

    DateTime dt;

    if (DateTime.TryParse(input, out dt))  // convert user input from string  => DateTime type
    {
        TimeSpan result = today - dt;

        if (result == TimeSpan.Zero)
        {
            Console.WriteLine("The date is today");
        }
        else if(result > TimeSpan.Zero) { 
            Console.WriteLine($"Your days are {result.Days} days ago!");
        }
        else
        {// switch from negative days to positive => Math.Abs()
            Console.WriteLine($"That date will be in  {Math.Abs(result.Days)} days!");  
        }
    }
    else if(input == "")
    {
        Console.WriteLine("Please, input valid date");
    }
    } while (input != "exit");



