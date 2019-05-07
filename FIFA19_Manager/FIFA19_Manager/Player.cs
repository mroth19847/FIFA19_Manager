using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA19_Manager
{
    /// <summary>
    /// The Player class stores the individual ID and the name of a player. Additionally, urls to pictures
    /// and information like nationality and club is included. There is also a score for each position, in order
    /// to know how well the player plays on the different positions.
    /// </summary>
    public class Player
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string PhotoURL { get; set; }

        public string Nationality { get; set; }

        public int Overall { get; set; }

        public string ClubURL { get; set; }

        public string Club { get; set; }

        public int GKval { get; set; }

        public int STval { get; set; }

        public int LSval { get; set; }

        public int RSval { get; set; }

        public int ZMval { get; set; }

        public int ZDMval { get; set; }

        public int LVval { get; set; }

        public int RVval { get; set; }

        public int IVval { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", Name, Overall);
        }
    }
}
