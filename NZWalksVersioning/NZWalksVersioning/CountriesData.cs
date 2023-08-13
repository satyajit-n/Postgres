using NZWalksVersioning.Models.Doman;

namespace NZWalksVersioning
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                new{Id = 1,Name="US"},
                new{Id = 2,Name="IND"},
                new{Id = 3,Name="CAN"},
                new{Id = 4,Name="UK"},
                new{Id = 5,Name="DUB"},
                new{Id = 6,Name="PAK"},
                new{Id = 7,Name="NEP"}
            };

            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
