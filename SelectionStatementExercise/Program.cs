namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNum = r.Next(1, 100);
            int userInput = 0;
            
            Console.WriteLine("Guess my favorite number between 1 and 100?");
            
            while (userInput != favNum)
            {
                userInput = int.Parse(Console.ReadLine());
            
                if (userInput < favNum)
                {
                    Console.WriteLine("Too low! Guess again.");
                }
                else if (userInput > favNum)
                {
                    Console.WriteLine("Too high! Guess again");
                }
                else
                {
                    Console.WriteLine("Congratulations bud you guessed it!!!!");
                }
            
            }
            
            Console.WriteLine("Enter your favorite school subject: ");
            
            string subject = Console.ReadLine().Trim().ToLower();
            
            switch (subject)
            { 
                case "math":
                    Console.WriteLine("Math is the language of the universe! ");
                    break;
                case "science":
                    Console.WriteLine("History helps us understand how the world works! ");
                    break;
                case "history":
                    Console.WriteLine("History teaches us valuable lessons from the past.");
                    break;
                case "english":
                    Console.WriteLine("English is the gateway to great stories and communication.");
                    break;
                case "art":
                    Console.WriteLine("Art unlocks creativity and expression.");
                    break;
                case "music":
                    Console.WriteLine("Music brings rhythm and harmony to life. ");
                    break;
                case "physical education":
                case "pe":
                    Console.WriteLine("Physical education teaches the mind & body endurance.");
                    break;
                case "biology":
                    Console.WriteLine("Biology teaches the scientific fundamentals of life");
                    break;
                case "spanish":
                    Console.WriteLine("Spanish is called the language of love, learn a little love.");
                    break;
                default:
                    Console.WriteLine("Interesting choice, what do you like about.");
                    break;
                        
            }
        }
    }
}
