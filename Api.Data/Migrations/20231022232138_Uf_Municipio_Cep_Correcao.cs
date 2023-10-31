using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Uf_Municipio_Cep_Correcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2aa7a60d-6328-4317-84f5-08009c0554e5"));

            migrationBuilder.RenameColumn(
                name: "Lagrodouro",
                table: "Cep",
                newName: "Logradouro");

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 23, 21, 38, 694, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("933b8c5c-f72e-424d-a6ff-296cbf67e0a1"), new DateTime(2023, 10, 22, 20, 21, 38, 694, DateTimeKind.Local).AddTicks(2771), "pereira.mateusramos@gmail.com", "Administrador", new DateTime(2023, 10, 22, 20, 21, 38, 694, DateTimeKind.Local).AddTicks(2784) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("933b8c5c-f72e-424d-a6ff-296cbf67e0a1"));

            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Cep",
                newName: "Lagrodouro");

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2023, 10, 22, 1, 54, 29, 443, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("2aa7a60d-6328-4317-84f5-08009c0554e5"), new DateTime(2023, 10, 21, 22, 54, 29, 443, DateTimeKind.Local).AddTicks(8431), "pereira.mateusramos@gmail.com", "Administrador", new DateTime(2023, 10, 21, 22, 54, 29, 443, DateTimeKind.Local).AddTicks(8446) });
        }
    }
}
