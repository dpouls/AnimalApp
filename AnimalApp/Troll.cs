using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Troll : Beast
    {
        public override string Pet()
        {
            return "The troll will eat your face if you try.";
        }
        public override string Sound()
        {
            return "A screeching roar to send chills down your spine.";
        }
        public Troll(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {

        }
    }
}
