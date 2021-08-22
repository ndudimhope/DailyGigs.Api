using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGigs.Entity.Models
{
    public class Category
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string CategoryImageUrl { get; set; }

        //Navigation Property
        public List<Gig> Gigs { get; set; }

        public Category(string Name)
        {

        }

    }
}
