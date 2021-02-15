using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Yeti: Beast
    {
        /// <summary>
        ///returns info about petting the beast
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Pet()
        {
            return "Yeti's like being pet behind the horns.";
        }
        /// <summary>
        ///overrides the default message with something specific for this beast. 
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "A screeching roar to send chills down your spine.";
        }
        /// <summary>
        /// we use the arguments on the base class for this constructor.
        /// 
        /// </summary>
        /// <param name="paramFood"></param>
        /// <param name="paramSkin"></param>
        public Yeti(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {

        }
    }
}
