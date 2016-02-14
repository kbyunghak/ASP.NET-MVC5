using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStuff.Models.NHL
{
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int CaptainJerseyNumber { get; set; }
        public string Manager { get; set; }
        public decimal SalaryCap { get; set; }

        public List<Player> Players { get; set; }
    }
}
