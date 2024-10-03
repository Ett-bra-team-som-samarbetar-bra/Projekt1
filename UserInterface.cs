
namespace Projekt1;

public class UserInterface
{
    private TheGenerator generator; // Get references to generator object
    public string userName{ get; private set; } = "";


    public UserInterface(TheGenerator generator)
    {
        this.generator = generator;
    }

    public void SetUserName()
    {
        Console.WriteLine("What's your name?");
        this.userName = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(this.userName))
        {
            this.userName = "User";
        }
    }

    public void FeedbackFromUser()
    {
        // Making sure the user is satisfied with the randomly generated event.
        Console.WriteLine($"On a scale from 1-10, how would you describe you feeling right now {this.userName}?");
        if (int.TryParse(Console.ReadLine(), out int feelNumber))
        {
            if (feelNumber < 5)
            {
                Console.WriteLine("Here, it sounds like you need a pick-me-up.");
                generator.GenerateMotivationalspeech(userName);
            }
            else if (feelNumber == 10)
            {
                generator.GenerateRainbow();
            }
            else if (feelNumber > 5)
            {
                Console.WriteLine("Oh really? We will see about that");
                generator.GenerateInsult(userName);
            }
            else
            {
                Console.WriteLine("Perfectly lagom, as all things should be...");
            }
        }
        else
        {
            Console.WriteLine("Thats not an integer, is it?");
        }
    }
}
