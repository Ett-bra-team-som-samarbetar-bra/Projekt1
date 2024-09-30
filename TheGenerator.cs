using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class TheGenerator
    {
        public static Random random = new();

        public static void GenerateInsult()
        {
            int i = random.Next(0, insults.Count); //takes a random string from the list of insults.
            string randomWord = insults[i];
            Console.WriteLine("Here's yer daily insult: " + randomWord);
        }

        public static void GenerateMotivationalspeech()
        {
            int i = random.Next(0, motivationalspeeches.Count);
            string randomMotivationalSpeech = motivationalspeeches[i];
            Console.WriteLine("Here is the daily motivational speech: " + randomMotivationalSpeech);
        }

        public static void Hamster()
        {
            Console.WriteLine(" .     .\r\n            (>\\---/<)\r\n            ,'     `.\r\n           /  q   p  \\\r\n          (  >(_Y_)<  )\r\n           >-' `-' `-<-.\r\n          /  _.== ,=.,- \\\r\n         /,    )`  '(    )\r\n        ; `._.'      `--<\r\n       :     \\        |  )\r\n       \\      )       ;_/  hjw\r\n        `._ _/_  ___.'-\\\\\\\r\n           `--\\\\\\");
        }

        private static List<string> insults =
            [
            "I'd agree with you, but then we'd both be wrong.",
            "You're like a cloud. When you disappear, it's a beautiful day.",
            "If I had a dollar for every brain you don't have, I'd have a dollar.",
            "Somewhere out there, a village is missing its idiot.",
            "You're not stupid; you just have bad luck thinking.",
            "I'd explain it to you, but I left my crayons at home.",
            "You bring everyone so much joy… when you leave the room.",
            "You're as useless as the 'ueue' in 'queue'.",
            "Your secrets are always safe with me. I never even listen when you tell me them.",
            "You have the right to remain silent because whatever you say will probably be stupid."
            ];

        private static List<string> motivationalspeeches =
            [
            "It takes courage to grow up and become who you really are.",
            "Nothing is impossible. The word itself says 'I'm possible!'",
            "Keep your face always toward the sunshine, and shadows will fall behind you.",
            "Attitude is a little thing that makes a big difference.",
            "To bring about change, you must not be afraid to take the first step. We will fail when we fail to try.",
            "All our dreams can come true, if we have the courage to pursue them.",
            "Don't sit down and wait for the opportunities to come. Get up and make them.",
            "It is during our darkest moments that we must focus to see the light.",
            "Believe you can and you're halfway there.",
            "All dreams are within reach. All you have to do is keep moving towards them."
            ];
    }
}
