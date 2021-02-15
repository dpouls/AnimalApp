using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    public abstract class Beast
    {
        //base class
        //variables to hold the passed in food/skin type
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
        /// <summary>
        /// constructor that takes in food/skin arguments and assigns them to their respective variables.
        /// </summary>
        /// <param name="paramFood"></param>
        /// <param name="paramSkin"></param>
        public Beast(string paramFood, string paramSkin)
        {
            FoodType = paramFood;
            SkinType = paramSkin;
        }
        /// <summary>
        /// returns a generic message regarding if a beast needs to eat
        /// </summary>
        /// <returns></returns>
        public string Eat()
        {
            return "Needs food to survive.";
        }
        /// <summary>
        /// returns a generic message regarding how a beast moves.
        /// </summary>
        /// <returns></returns>
        public string Move()
        {
            return "Moves quickly.";
        }
        /// <summary>
        /// method that will be completed on a child class (derived class)
        /// </summary>
        /// <returns></returns>
        public abstract string Pet();
        /// <summary>
        /// returns a default method but will be overrided in derrived class.
        /// </summary>
        /// <returns></returns>
        public virtual string Sound()
        {
            return "Makes a typical scary animal noise.";
        }
    }
}
