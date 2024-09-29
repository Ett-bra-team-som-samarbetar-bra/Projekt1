using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class TheGenerator
    {
        private Random random = new();

        public void GenerateInsult()
        {
            int i = random.Next(0, insults.Count); //takes a random string from the list of insults.
            string randomWord = insults[i];
            Console.WriteLine("Here's yer daily insult: " + randomWord);
        }

        public void GenerateMotivationalspeech()
        {
            // fill out
        }
        public void GenerateSpanishLovePoem()
        {
            // fill out
        }

        private List<string> insults =
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
    }
}
