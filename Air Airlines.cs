using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroporiki
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp();
        }
        static void StartUp() //Manager Function
        {
            Greetings();
            GetUserInfo();
            GetChoice();
        }
        static void Greetings()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Air Airlines!");
            Console.ResetColor();
        }
        static void GetUserInfo ()
        {
            string messageInvalidFirstName;
            string messageInvalidLastName;
            string firstName = GetFirstName();
            string lastName = GetLastName();
            if (isValidInput(firstName, out messageInvalidFirstName))
            {
                Console.WriteLine($"First Name: {firstName}");
            }
            else
            {
                Console.WriteLine(messageInvalidFirstName);
                GetUserInfo();
            }
            if(isValidInput(lastName, out messageInvalidLastName))
            {
                Console.WriteLine($"Last Name: {lastName}");
            }
            else
            {
                Console.WriteLine(messageInvalidLastName);
                GetUserInfo();
            }
        }
        static string GetFirstName()
        {
            Console.WriteLine("Enter your first name");
            string firstNameInput = Console.ReadLine();
            string firstName = char.ToUpper(firstNameInput[0])+ firstNameInput.Substring(1).ToLower();
            return firstName;
        }
        static string GetLastName()
        {
            Console.WriteLine("Enter your last name");
            string lastNameInput = Console.ReadLine();
            string lastName = char.ToUpper(lastNameInput[0]) + lastNameInput.Substring(1).ToLower();
            return lastName;
        }
        //Checks if the user's input is letter-only and printing according message if it's not
        static bool isValidInput(string userInput, out string message) 
        {
            message = "";
            if (!hasOnlyLetters(userInput))
            {
                message = "Please to not use digits when entering your credentials.";
                return false;
            }
            return true;
        }
        //Checks if a given string has only letters in it
        static bool hasOnlyLetters(string input) => input.All(x => Char.IsLetter(x));

        //The user picks a number from the menu, returned as a string type digit
        static string Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pick a choice from the menu");
            Console.ResetColor();
            Console.WriteLine("Enter 1 to review all the available countries you can travel to");
            Console.WriteLine("Enter 2 to pick country");
            Console.WriteLine("Enter 3 to see the available dates for the go-to flight");
            Console.WriteLine("Enter 4 to enter the preferred date");
            Console.WriteLine("Enter 5 to review your order");
            Console.WriteLine("Enter 6 to exit");
            string choice = Console.ReadLine();
            return choice;
        }
        //Checks if the choice is a parsable number or not, returns the user's choice if it is
        static int CheckMenuInput(out string message)
        {
            message = "";
            string choice = Menu();
            int choiceNumber;
            bool isValidMenuChoice = Int32.TryParse(choice, out choiceNumber);
            if (!isValidMenuChoice)
            {
                message = "Please enter a number from 1 to 6";
            }
            return choiceNumber;
        }
        static void GetChoice()
        {
            string country = "";
            string date = "";
            string message;
            int choice = CheckMenuInput(out message);
            switch (choice)
            {
                case 1: 
                    CountryMenu(); GetChoice(); break;
                case 2: 
                    GetCountry(); GetChoice(); break;
                case 3: 
                    AvailableDates(); GetChoice(); break;
                case 4: 
                    GetDate(); GetChoice(); break;
                case 5:
                    country = GetCountry();
                    date = GetDate();
                    Console.WriteLine($"You chose to fly to {country} on {date}");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Thank you for choosing to fly with Air Airlines! Have a safe flight."); break;
                case 6: 
                    Console.ForegroundColor = ConsoleColor.DarkRed; 
                    Console.WriteLine("Thank you for choosing to fly with Air Airlines! Hope to see you again soon!"); return;
                default:
                    Console.WriteLine("Oops! Looks like you entered a wrong number. Please choose a number from 1 to 6"); GetChoice(); break;
            }
        }
        /// <summary>
        /// Prints to the console the available countries to travel to
        /// </summary>
        static void CountryMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ____________________________________________ ");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|----------Available Destinations------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|         **------Greece--------**           |");
            Console.WriteLine("|         **-------Italy--------**           |");
            Console.WriteLine("|         **------Moldavia------**           |");
            Console.WriteLine("|         **------America-------**           |");
            Console.WriteLine("|         **-----Amsterdam------**           |");
            Console.WriteLine("|         **-------China--------**           |");
            Console.WriteLine("|         **-----Singapore------**           |");
            Console.WriteLine("|         **------Bahamas-------**           |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|__*__Fly____Safe____with____AirAirlines__*__|");
            Console.WriteLine("                                              ");
            Console.ResetColor();
        }
        static string GetCountry()
        {
            Console.WriteLine("Please type the country you want to fly to.");
            string countryInput = Console.ReadLine();
            string country = char.ToUpper(countryInput[0]) + countryInput.Substring(1).ToLower(); 
            Console.WriteLine("You chose to fly to {0}", country);
            if (country == "Greece"|| country == "Italy" || country == "Moldavia" || country == "America" || country == "Amsterdam"
                || country == "China" || country == "Singapore" || country == "Bahamas")
            {
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("Please choose from the list of the available countries");
                CountryMenu(); GetCountry();
            }
            return country;
        }
        static string GetDate()
        {
            Console.WriteLine("Please enter the date of your flight (dd/mm/yyyy)");
            string date = Console.ReadLine();
            switch (date)
            {
                case "01/01/2021":
                case "02/02/2021":
                case "13/2/2021":
                case "14/2/2021":
                case "10/5/2021": Console.WriteLine($"You chose to fly on {date}"); break;

                default:
                    Console.WriteLine("Wrong Input.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Choose a date from the available ones!");
                    Console.ResetColor();
                    AvailableDates();
                    Console.WriteLine("Please insert your preferred date in the correct form dd/mm/yyyy");
                    GetDate(); break;
            }
            return date;
        }
        static void AvailableDates()
        {
            Console.WriteLine("The available dates for your destination are: ");
            Console.WriteLine("01/01/2021");
            Console.WriteLine("02/02/2021");
            Console.WriteLine("13/2/2021");
            Console.WriteLine("14/2/2021");
            Console.WriteLine("10/5/2021");
        }
    }
}
