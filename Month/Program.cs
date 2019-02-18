using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");
            string userInput = Console.ReadLine();
            // Save the input to a variable.
            
            

            // Use the if statment to update the monthName variable based on the user's input.
            string monthName = string.Empty;
            if (userInput == "1")
            {
                monthName = "January";
            }

            if (userInput == "2")
            {
                monthName = "February";
            }

            if (userInput == "3")
            {
                monthName = "March";
            }

            if (userInput == "4")
            {
                monthName = "April";
            }

            if (userInput == "5")
            {
                monthName = "May";
            }

            if (userInput == "6")
            {
                monthName = "June";
            }

            if (userInput == "7")
            {
                monthName = "July";
            }

            if (userInput == "8")
            {
                monthName = "August";
            }

            if (userInput == "9")
            {
                monthName = "September";
            }

            if (userInput == "10")
            {
                monthName = "October";
            }

            if (userInput == "11")
            {
                monthName = "November";
            }

            if (userInput == "12")
            {
                monthName = "December";
            }

            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
