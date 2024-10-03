
namespace Projekt1;

public class App
{
    // Objects
    private TheGenerator generator;
    private MusicBox musicBox;
    private UserInterface userInterface;


    public App()
    {
        musicBox = new MusicBox();
        generator = new TheGenerator();
        userInterface = new UserInterface(generator);
    }

    public void Run()
    {   
        userInterface.SetUserName();
        RandomProgramPath(userInterface.userName);
        userInterface.FeedbackFromUser();

        Console.ReadKey(); 
    }

    private void RandomProgramPath(string userName)
    {   
        // Picks a random number from 0-8 to place in the switch statement
        int randomPick = generator.GenerateRandomNumber(0, 8);

        switch (randomPick)
        {
            case 0:
                generator.GenerateInsult(userName);
                break;
            case 1:
                generator.GenerateMotivationalspeech(userName);
                break;
            case 2:
                generator.GenerateHamster();
                break;
            case 3:
                generator.GenerateRainbow();
                break;
            case 4:
                musicBox.SweetChildOfMine();
                break;
            case 5:
                musicBox.Blues();
                break;
            case 6:
                musicBox.Pirates();
                break;
            default:
                break;
        }
    }
}
