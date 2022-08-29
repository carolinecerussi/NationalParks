using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{
    public class NationalParksContext : DbContext
    {
        public NationalParksContext(DbContextOptions<NationalParksContext> options)
            : base(options)
        {
        }

    
		public DbSet<NationalPark> NationalParks { get; set; }
		
		protected override void OnModelCreating(ModelBuilder builder)
		{
  	builder.Entity<NationalPark>().HasData(
          new NationalPark { ParkId = 1, Name = "Yellowstone National Park", Location = "Wyoming USA", CampingAllowed = true, ParkFee = 25 },
          new NationalPark { ParkId = 2, Name = "Grand Canyon National Park", Location = "Arizona USA", CampingAllowed = false, ParkFee = 20 },
          new NationalPark { ParkId = 3, Name = "Badlands National Park", Location=  "South Dakota USA", CampingAllowed = false, ParkFee = 35 },
          new NationalPark { ParkId = 4, Name = "Yosemite National Park", Location = "California USA", CampingAllowed =true, ParkFee = 25 },
          new NationalPark { ParkId = 5, Name = "Denali National Park", Location = "Alaska USA", CampingAllowed = true, ParkFee = 35 },
					new NationalPark { ParkId = 6, Name = "Acadia National Park", Location = "Maine USA", CampingAllowed = true, ParkFee = 25 },
          new NationalPark { ParkId = 7, Name = "Arches National Park", Location = "Utah USA", CampingAllowed = false, ParkFee = 20 },
          new NationalPark { ParkId = 8, Name = "Glacier National Park", Location=  "Montana USA", CampingAllowed = true, ParkFee = 35 },
          new NationalPark { ParkId = 9, Name = "Grand Teton National Park", Location = "Colorado USA", CampingAllowed = true, ParkFee = 25 },
          new NationalPark { ParkId = 10, Name = "Zion National Park", Location = "Utah USA", CampingAllowed = true, ParkFee = 35 });
		}
}
}