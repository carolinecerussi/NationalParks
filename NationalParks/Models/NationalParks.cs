using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Collections.Generic;  


namespace NationalParks.Models
{
    public class NationalPark
    {		
				[Key]
        public int ParkId { get; set; }
				[Required]
				public string Name { get; set; }
        [Required]
				public string Location { get; set; }
        [Required]
				public bool CampingAllowed { get; set; }
        [Required]
				public int ParkFee { get; set; }
    }
}