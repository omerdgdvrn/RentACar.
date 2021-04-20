using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Data.Migrations
{
    public partial class car : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alici",
                keyColumn: "AliciID",
                keyValue: 1,
                columns: new[] { "Ad", "Adres", "CepTel", "Mail", "Soyad", "TCKimlikNo" },
                values: new object[] { "Sukru", "Bornova İzmir", "2423", "Sukru@gmail.com", "Sukru Sukru", "54654" });

            migrationBuilder.UpdateData(
                table: "Alici",
                keyColumn: "AliciID",
                keyValue: 2,
                columns: new[] { "Ad", "Adres", "CepTel", "Mail", "Soyad", "TCKimlikNo" },
                values: new object[] { "Omer", "Bornova İzmir", "05", "Omer@gmail.com", "Omer", "23423" });

            migrationBuilder.UpdateData(
                table: "Alici",
                keyColumn: "AliciID",
                keyValue: 3,
                columns: new[] { "Ad", "CepTel", "Mail", "Soyad", "TCKimlikNo" },
                values: new object[] { "Hilal", "33", "Hilal@gmail.com", "Hilal", "534534" });

            migrationBuilder.UpdateData(
                table: "Firma",
                keyColumn: "FirmaID",
                keyValue: 1,
                columns: new[] { "Adres", "Mail", "Telefon", "Unvan", "VergiNo" },
                values: new object[] { "Bornova", "Bornova@Bornova.com", "234234", "Bornova", "Bornova32" });

            migrationBuilder.UpdateData(
                table: "Firma",
                keyColumn: "FirmaID",
                keyValue: 2,
                columns: new[] { "Adres", "Mail", "Unvan", "VergiNo" },
                values: new object[] { "Sukruler", "Sukruler@gmail.com", "Sukruler", "Sukruler22" });

            migrationBuilder.UpdateData(
                table: "Firma",
                keyColumn: "FirmaID",
                keyValue: 3,
                columns: new[] { "Adres", "Mail", "Telefon", "Unvan", "VergiNo" },
                values: new object[] { "Hoba", "Hoba@gmail.com", "3534", "Hoba", "Hoba3423" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Alici",
                keyColumn: "AliciID",
                keyValue: 1,
                columns: new[] { "Ad", "Adres", "CepTel", "Mail", "Soyad", "TCKimlikNo" },
                values: new object[] { "Melek", "Göztepe İzmir", "05385161703", "melekalperatmaca@gmail.com", "Alper Atmaca", "22222222220" });

            migrationBuilder.UpdateData(
                table: "Alici",
                keyColumn: "AliciID",
                keyValue: 2,
                columns: new[] { "Ad", "Adres", "CepTel", "Mail", "Soyad", "TCKimlikNo" },
                values: new object[] { "Necdet", "Yeşilyurt İzmir", "05462253671", "necdet.uygur@gmail.com", "Uygur", "11111111110" });

            migrationBuilder.UpdateData(
                table: "Alici",
                keyColumn: "AliciID",
                keyValue: 3,
                columns: new[] { "Ad", "CepTel", "Mail", "Soyad", "TCKimlikNo" },
                values: new object[] { "Ömer", "05465675080", "omerdgdvrn21@gmail.com", "Dağdeviren", "44444444440" });

            migrationBuilder.UpdateData(
                table: "Firma",
                keyColumn: "FirmaID",
                keyValue: 1,
                columns: new[] { "Adres", "Mail", "Telefon", "Unvan", "VergiNo" },
                values: new object[] { "Göztepe", "atmacalper@atmacalper.com", "0535210", "AtmacAlpers", "A123" });

            migrationBuilder.UpdateData(
                table: "Firma",
                keyColumn: "FirmaID",
                keyValue: 2,
                columns: new[] { "Adres", "Mail", "Unvan", "VergiNo" },
                values: new object[] { "Yeşilyurt", "uygurs@me.com", "Uygurs", "Y125" });

            migrationBuilder.UpdateData(
                table: "Firma",
                keyColumn: "FirmaID",
                keyValue: 3,
                columns: new[] { "Adres", "Mail", "Telefon", "Unvan", "VergiNo" },
                values: new object[] { "Bornova", "dagdeviren@dagdeviren.com", "0789542", "Dagdevirens", "D567" });
        }
    }
}
