using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Dragon : Beast
    {
        
        /// <summary>
        ///returns info about petting the beast
        /// 
        /// </summary>
         /// <returns></returns>
        public override string Pet()
        {
            return "White dragons will let you pet them if they are dead.";
        }
        /// <summary>
        /// overrides the default message with something specific for this beast. 
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Sound()
        {
            return "A screeching roar to send chills down your spine.";
        }
        /// <summary>
        /// we use the arguments on the base class for this constructor.
        /// </summary>
        /// <param name="paramFood"></param>
        /// <param name="paramSkin"></param>
        public Dragon(string paramFood, string paramSkin) : base( paramFood, paramSkin)
         {

         }
    }
}
