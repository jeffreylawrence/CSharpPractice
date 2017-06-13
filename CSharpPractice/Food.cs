using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Food
    {
        private string name;
        private string foodGroup;
        private int gramsPerPortion;

        public Food()
        {

        }

        public Food(string name, string foodGroup, int gramsPerPortion)
        {
            this.name = name;
            this.foodGroup = foodGroup;
            this.gramsPerPortion = gramsPerPortion;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int GramsPerPortion
        {
            get
            {
                return gramsPerPortion;
            }

            set
            {
                gramsPerPortion = value;
            }
        }

        private string FoodGroup
        {
            get
            {
                return foodGroup;
            }

            set
            {
                foodGroup = value;
            }
        }
    }
}
