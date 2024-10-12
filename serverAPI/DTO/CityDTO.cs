using System.ComponentModel.DataAnnotations.Schema;

namespace serverAPI.DTO
{
    public class CityDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool? Capital { get; set; }

        public long Population { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public required string CountryName { get; set; }
    }
}
