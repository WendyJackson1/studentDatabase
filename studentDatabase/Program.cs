
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string[] studentName = { "Asia", "Austin", "Wendy" };
            string[] homeTown = { "Lincoln Park", "Akron", "Oxford" };
            string[] favoriteFood = { "steak", "tacos", "Italian" };
            int studentId;

            while (true)
            {
                Console.WriteLine("Would you like to see a list of all students in the class? Please enter y/n");
                string studentList = Console.ReadLine().ToLower();
                if (studentList == "y")
                {
                    Console.WriteLine($"The students we have in our class are:");
                    foreach (var name in studentName)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if (studentList == "n")
                {
                    Console.WriteLine("Not a problem");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I dont understand.");
                }

                Console.WriteLine();
                Console.WriteLine("What student would you like to learn more about? Enter a number 1-3.");
                int studentChoice = int.Parse(Console.ReadLine());

                if (studentChoice <= 0 || studentChoice > studentName.Length + 1)
                {
                    Console.WriteLine("Sorry, that is not a valid.  Please choose a number 1-3.");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    studentId = studentChoice - 1;
                    break;
                }

            }
            while (true)
            {
                Console.WriteLine($"You have chosen {studentName[studentId]}. What would you like to know about {studentName[studentId]}? Please enter hometown or favorite food. ");
                string navigationChoice = Console.ReadLine().ToLower().Trim();

                if (navigationChoice.Contains("town"))
                {
                    Console.WriteLine($"{studentName[studentId]} is from {homeTown[studentId]}.");
                    Console.WriteLine();
                    break;
                }
                else if (navigationChoice.Contains("food"))
                {
                    Console.WriteLine($"{studentName[studentId]}'s favorite food is {favoriteFood[studentId]}.");

                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I dont understand. Please choose hometown or favorite food.");

                    continue;
                }
            }

            Console.WriteLine("Would you like to run the program again? Please enter y/n");
            string userContinue = Console.ReadLine().ToLower();

            if (userContinue == "y")
            {
                Console.WriteLine("Awesome!");
                continue;
            }
            else if (userContinue == "n")
            {
                Console.WriteLine("See you next time, Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("I'm sorry, I dont understand. Please choose y/n");
            }
        }
    }
}