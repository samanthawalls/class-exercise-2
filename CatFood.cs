using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Class_Exercise_2
{
     public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool IsKittenFood { get; set; }

        public CatFood()
        {
         IsKittenFood = false; 
        }

    }
}
