using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    public abstract class Beast
    {
        private string _foodType;
        private string _skinType;

        public string SkinType
        {
            get { return _skinType; }
            set { _skinType = value; }
        }
        
        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }
        public Beast(string paramFood, string paramSkin)
        {
            FoodType = paramFood;
            SkinType = paramSkin;
        }
        public string Eat()
        {
            return "Needs food to survive.";
        }
        public string Move()
        {
            return "Moves quickly.";
        }

        public abstract string Pet();

        public virtual string Sound()
        {
            return "Makes a typical scary animal noise.";
        }
    }
}
