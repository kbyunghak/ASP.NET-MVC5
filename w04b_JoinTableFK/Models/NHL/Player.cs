using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStuff.Models.NHL
{
    public class Player
    {
        // What happens if same jersey number is used in another team?
        [Key, Column(Order = 0)]
        public string JerseyNumber { get; set; }

        [Key, Column(Order = 1)]
        public string FirstName { get; set; }

        [Key, Column(Order = 2)]
        public string LastName { get; set; }

        public string Position { get; set; }
        public bool IsRight { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }

        public string TeamName { get; set; }
        public Team Team { get; set; }
    }
}
