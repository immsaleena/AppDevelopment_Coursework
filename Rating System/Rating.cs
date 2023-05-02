using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_System
{
    public class Rating
    {
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public int FoodQuality { get; set; }
        public int StaffFriendliness { get; set; }
        public int Cleanliness { get; set; }
        public int OrderAccuracy { get; set; }
        public int RestaurantAmbiance { get; set; }
        public int ValueForMoney { get; set; }
        public int Suggestion { get; set; }
    }
}
