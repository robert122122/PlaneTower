using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTower
{
    public class Airplane : IAirplane
    {
        public string Name { get; set; }

        public bool Landing { get; set; }

        public Airplane(string name)
        {
            Name = name;
            Landing = false;
        }

        public void CompleteLanding()
        {
            Landing = false;
            Console.WriteLine("Airplane: " + this.Name + " has completed the landing!");
        }

        public void CompleteTakeOff()
        {
            Landing = false;
            Console.WriteLine("Airplane: " + this.Name + " has completed taking off!");
        }

        public void RequestLanding(IControlTower controlTower)
        {
            if (controlTower.CanLand(this) == true)
            {
                Console.WriteLine("Airplane: " + this.Name + " is landing!");
                this.Landing = true;
            }
            else
                Console.WriteLine("Track is ocuppied");
        }

        public void RequestTakeOff(IControlTower controlTower)
        {
            if (controlTower.CanTakeOff(this) == true)
            {
                Console.WriteLine("Airplane: " + this.Name + " is taking off!");
                this.Landing = true;
            }
        }
    }
}
