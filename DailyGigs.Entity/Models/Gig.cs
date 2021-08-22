using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGigs.Entity.Models
{
    public class Gig
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Plug Plug { get; set; }

        public decimal Rate { get; set; }

        public DateTime Duration { get; set; }

        public Category Category { get; set; }

        public List<Gig> Gigs { get; set; }
    }
}
