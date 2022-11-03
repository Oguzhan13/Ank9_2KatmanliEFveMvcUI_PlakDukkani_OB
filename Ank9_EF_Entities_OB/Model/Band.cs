using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_OB.Model
{
    public class Band
    {
        public int BandId { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public IList<Musician> BandMembers { get; set; }

        public Band()
        {
            BandMembers = new List<Musician>();
        }
    }
}
