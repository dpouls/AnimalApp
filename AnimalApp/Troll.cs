using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Troll : Beast
    {
        /// <summary>
        ///returns info about petting the beast
        /// </summary>
        /// <returns></returns>
        public override string Pet()
        {
            return "The troll will eat your face if you try.";
        }

        /// <summary>
        /// overrides the default message with something specific for this beast. 
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "An extremely loud ape-like growl.";
        }
        /// <summary>
        /// we use the arguments on the base class for this constructor.
        /// </summary>
        /// <param name="paramFood"></param>
        /// <param name="paramSkin"></param>
        public Troll(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {

        }
    }
}
