using System;
using RecordManagemant.Entities;

namespace RecordManagemant.Data.Seeds;

public class NationalitiesSeed
{
    public static Nationality[] SeedData()
    {
        {
            return new[]
                {
                    new Nationality
                    {
                        Id = Guid.Parse("c82341c5-84a3-4509-bee2-169a9e865747"),
                        Name = "Česká Republika",
                    },
                    new Nationality
                    {
                        Id = Guid.Parse("0d22d4ef-8529-4708-a255-5ebfafaa7a93"),
                        Name = "Slovensko",
                    }
                };
        }
    }
}