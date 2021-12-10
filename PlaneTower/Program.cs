using System;

namespace PlaneTower
{
    class Program
    {
        static void Main(string[] args)
        {
            IAirplane a1 = new Airplane("Boeing1");
            IAirplane a2 = new Airplane("Boeing2");
            IAirplane a3 = new Airplane("Boeing3");
            IAirplane a4 = new Airplane("Boeing4");

            IControlTower controlTower = new ControlTower();

            controlTower.Register(a1);
            controlTower.Register(a2);
            controlTower.Register(a3);
            controlTower.Register(a4);

            a1.RequestLanding(controlTower);
            a2.RequestLanding(controlTower);
            a3.RequestLanding(controlTower);

            a1.CompleteLanding();
            a2.RequestLanding(controlTower);
            a3.RequestLanding(controlTower);
            a2.CompleteLanding();
            


        }
    }
}
