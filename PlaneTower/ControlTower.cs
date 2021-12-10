using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTower
{
    public class ControlTower:IControlTower
    {
        public List<IAirplane> Airplanes { get; set; }

        public ControlTower()
        {
            Airplanes = new List<IAirplane>();
        }

        public bool CanLand(IAirplane airplane)
        {
            Console.WriteLine("Airplane: " + airplane.Name + " requested landing!");
            foreach(IAirplane airplaneX in Airplanes)
            {
                if(airplaneX.Landing == true)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CanTakeOff(IAirplane airplane)
        {
            Console.WriteLine("Airplane: " + airplane.Name + " requested taking off!");
            foreach (IAirplane airplaneX in Airplanes)
            {
                if (airplaneX.Landing == true)
                {
                    return false;
                }
            }
            return true;
        }

        public bool HasLanded(IAirplane airplane)
        {
            airplane.Landing = false;
            return true;
        }

        public bool HasTakeOff(IAirplane airplane)
        {
            airplane.Landing = false;
            return true;
        }

        public void Register(IAirplane airplane)
        {
            foreach(IAirplane airplaneX in Airplanes)
            {
                if (airplaneX.Name == airplane.Name)
                {
                    throw new Exception("Airplane already exists");
                }
            }
            Airplanes.Add(airplane);
        }
    }
}
