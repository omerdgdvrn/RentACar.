using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core.Models;

namespace RentACar.Data.Seeds
{
    public class AliciSeed : IEntityTypeConfiguration<Alici>
    {
        public void Configure(EntityTypeBuilder<Alici> builder)
        {
            builder.HasData(
                new Alici
                {
                    AliciID = 1,
                    Ad = "Sukru",
                    Soyad = "Sukru Sukru",
                    TCKimlikNo = "54654",
                    CepTel = "2423",
                    Mail = "Sukru@gmail.com",
                    Adres = "Bornova İzmir"
                },
                  new Alici
                  {
                      AliciID = 2,
                      Ad = "Omer",
                      Soyad = "Omer",
                      TCKimlikNo = "23423",
                      CepTel = "05",
                      Mail = "Omer@gmail.com",
                      Adres = "Bornova İzmir"
                  },
                    new Alici
                    {
                        AliciID = 3,
                        Ad = "Hilal",
                        Soyad = "Hilal",
                        TCKimlikNo = "534534",
                        CepTel = "33",
                        Mail = "Hilal@gmail.com",
                        Adres = "Bornova İzmir"
                    }
            );
        }
    }
}
