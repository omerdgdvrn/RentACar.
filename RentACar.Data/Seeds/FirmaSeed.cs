using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.Core.Models;

namespace RentACar.Data.Seeds
{
    public class FirmaSeed : IEntityTypeConfiguration<Firma>
    {
        public void Configure(EntityTypeBuilder<Firma> builder)
        {
            builder.HasData(
                new Firma
                {
                    FirmaID = 1,
                    Unvan = "Bornova",
                    Telefon = "234234",
                    Mail = "Bornova@Bornova.com",
                    Adres = "Bornova",
                    VergiNo = "Bornova32"
                },
                new Firma
                {
                    FirmaID = 2,
                    Unvan = "Sukruler",
                    Telefon = "0326569",
                    Mail = "Sukruler@gmail.com",
                    Adres = "Sukruler",
                    VergiNo = "Sukruler22"
                },
                 new Firma
                 {
                     FirmaID = 3,
                     Unvan = "Hoba",
                     Telefon = "3534",
                     Mail = "Hoba@gmail.com",
                     Adres = "Hoba",
                     VergiNo = "Hoba3423"
                 }
            );
        }
    }
}
