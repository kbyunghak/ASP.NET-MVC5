using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStuff.Models.Canada
{
    public class City
    {
        [Key, Column(Order = 0)]
        public int CityId { get; set; }

        public string CityName { get; set; }

        public string Papulation { get; set; }
        //not sure to add provinceName
        public string ProvinceCode { get; set; }

        public Province Province { get; set; }
    }
}
