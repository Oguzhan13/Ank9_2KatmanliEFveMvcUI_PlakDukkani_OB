using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_OB.Model
{
    public class Musician
    {
        public int MusicianId { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public int BandId { get; set; }
        public Band Band { get; set; }

        //Çoka çok ilişki olsaydı
        //public IList<Band> Bands { get; set; }

        //public Musician()
        //{
        //    Bands = new List<Band>();
        //}
    }
}
