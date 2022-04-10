using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneTransition
{
    public class SecondGeneration:FirstGeneration
    {
        public SecondGeneration()
        {

        }
        public SecondGeneration(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void TakePicture()
        {
            Console.WriteLine("Camera has taken your picture");
        }

        public void TakeVideo()
        {
            Console.WriteLine("I can take a video of you");
        }

        public void SendMMS()
        {
            Console.WriteLine("I can send you an MMS if I want");
        }

    }
}
