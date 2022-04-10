using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTransition
{
    public class ThirdGeneration:SecondGeneration
    {
        public ThirdGeneration()
        {

        }
        public ThirdGeneration(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void SendEmails()
        {
            Console.WriteLine("your Email has been sent");
        }

        public void PlayGames()
        {
            Console.WriteLine("You just unlocked a new level in this game");
        }

        public void SendWhatsAppMessage()
        {
            Console.WriteLine("You are eligible to send WhatsAppMessages");
        }
    }
}
