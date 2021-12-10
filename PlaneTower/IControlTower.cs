using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTower
{
    public interface IControlTower
    {
        List<IAirplane> Airplanes{ get; set; }
        void Register(IAirplane airplane);
        bool CanTakeOff(IAirplane airplane);
        bool CanLand(IAirplane airplane);
        bool HasLanded(IAirplane airplane);
        bool HasTakeOff(IAirplane airplane);
    }
}
