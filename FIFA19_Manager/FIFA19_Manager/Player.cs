using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA19_Manager
{
    public class Player
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string PhotoURL { get; set; }

        public string Nationality { get; set; }

        public int Overall { get; set; }

        public string ClubURL { get; set; }

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
