using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Yeti: Beast
    {
        public override string Pet()
        {
            return "Yeti's like being pet behind the horns.";
        }
        public override string Sound()
        {
            return "A screeching roar to send chills down your spine.";
        }
        public Yeti(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {

        }
    }
}
