using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Foreign Key
        public int LeagueId { get; set; }

        public virtual League League { get; set; }
    }
}
