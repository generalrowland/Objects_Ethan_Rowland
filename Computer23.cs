using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Ethan_Rowland
{
    class Computer23 : IBootUp
    {
       public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public Computer23(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a {Type} Computer, it is on: {IsOn}!";
        }
    }
}
