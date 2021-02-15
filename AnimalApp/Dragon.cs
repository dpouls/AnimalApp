using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Dragon : Beast
    {
        public override string Pet()
        {
            return "White dragons will let you pet them if they are dead.";
        }
        public override string Sound()
        {
            return "A screeching roar to send chills down your spine.";
        }
        public Dragon(string paramFood, string paramSkin) : base( paramFood, paramSkin)
         {

         }
    }
}
