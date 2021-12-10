using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTower
{
    public interface IAirplane
    {
        void RequestTakeOff(IControlTower controlTower);
        void CompleteTakeOff();
        void RequestLanding (IControlTower controlTower);
        void CompleteLanding ();

        string Name { get; set; }
        bool Landing { get; set; }

    }
}
