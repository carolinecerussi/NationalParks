namespace NationalParks.Models
{
    public class NationalPark
    {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool CampingAllowed { get; set; }
        public int ParkFee { get; set; }
    }
}