using System;

namespace EnumsAndParsingValues
{
    class Program
    {
        static void Main(string[] args)
        {

            string response;
            
            bool success = false;
            
            int n = 0;

            do
            {
                n++;
                
                try
                {
                    Console.Write("Please enter the current day of the week (spelled out fully):  ");
                    
                    response = Console.ReadLine();

                    Week week = new Week();

                    response = response.ToLower();
                    
                    response = week.createDay(response);
                    
                    var day = Enum.Parse<Week.Day>(response);

                    Console.WriteLine($"We recognized your entry as : {day} ");

                    success = true;

                }

                catch (ArgumentException)
                {
                    if (n < 3)
                    {
                        Console.WriteLine("Sorry, we didn't recognize your entry. Please use standard spelling.");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, that didn't work out, either. We suggest running the program again and entering something like \"Tuesday\".");
                    }
                }
            } while (!success && n < 3);
              Console.Write("Please enter the current day of the week (spelled out fully):  ");
        }
    }
}
