using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.Ms
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCode = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupClaims",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClaims", x => new { x.GroupId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provider = table.Column<int>(type: "int", nullable: false),
                    ExternalUserId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Code = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSend = table.Column<bool>(type: "bit", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => new { x.UserId, x.ClaimId });
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.UserId, x.GroupId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitizenId = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhones = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UpdateContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsReadyForSell = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedUserId = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "LastUpdatedDate", "LastUpdatedUserId", "Name", "Status", "isDeleted" },
                values: new object[,]
                {
                    { 1, "tr-TR", new DateTime(2022, 9, 8, 15, 21, 17, 704, DateTimeKind.Local).AddTicks(4525), 0, new DateTime(2022, 9, 8, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(2499), 0, "Türkçe", false, false },
                    { 2, "en-US", new DateTime(2022, 9, 8, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(3529), 0, new DateTime(2022, 9, 8, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(3534), 0, "English", false, false }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "LangId", "LastUpdatedDate", "LastUpdatedUserId", "Status", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 89, "Save", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4983), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4984), 0, false, "Kaydet", false },
                    { 90, "Save", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4986), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4986), 0, false, "Save", false },
                    { 91, "GroupName", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4988), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4989), 0, false, "Grup Adı", false },
                    { 92, "GroupName", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4990), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4991), 0, false, "Group Name", false },
                    { 93, "FullName", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4992), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4993), 0, false, "Tam Adı", false },
                    { 94, "FullName", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4995), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4996), 0, false, "Full Name", false },
                    { 95, "Address", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4997), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4998), 0, false, "Adres", false },
                    { 96, "Address", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4999), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5000), 0, false, "Address", false },
                    { 97, "Notes", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5001), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5002), 0, false, "Notlar", false },
                    { 98, "Notes", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5004), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5004), 0, false, "Notes", false },
                    { 99, "ConfirmPassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5006), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5007), 0, false, "Parolayı Doğrula", false },
                    { 100, "ConfirmPassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5008), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5009), 0, false, "Confirm Password", false },
                    { 101, "Code", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5010), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5011), 0, false, "Kod", false },
                    { 88, "ChangePassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4981), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4982), 0, false, "Change Password", false },
                    { 87, "ChangePassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4979), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4980), 0, false, "Parola Değiştir", false },
                    { 86, "NewPassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4977), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4978), 0, false, "New Password:", false },
                    { 85, "NewPassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4974), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4975), 0, false, "Yeni Parola:", false },
                    { 71, "PasswordSpecialCharacter", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4942), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4943), 0, false, "En Az 1 Simge İçermelidir!", false },
                    { 72, "PasswordSpecialCharacter", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4944), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4945), 0, false, "Must Contain At Least 1 Symbol!", false },
                    { 73, "SendPassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4947), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4948), 0, false, "Yeni Parolanız E-Posta Adresinize Gönderildi.", false },
                    { 74, "SendPassword", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4949), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4950), 0, false, "Your new password has been sent to your e-mail address.", false },
                    { 75, "InvalidCode", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4952), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4953), 0, false, "Geçersiz Bir Kod Girdiniz!", false },
                    { 76, "InvalidCode", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4954), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4955), 0, false, "You Entered An Invalid Code!", false },
                    { 102, "Code", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5013), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5014), 0, false, "Code", false },
                    { 77, "SmsServiceNotFound", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4956), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4957), 0, false, "SMS Servisine Ulaşılamıyor.", false },
                    { 79, "TrueButCellPhone", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4961), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4962), 0, false, "Bilgiler doğru. Cep telefonu gerekiyor.", false },
                    { 80, "TrueButCellPhone", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4963), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4964), 0, false, "The information is correct. Cell phone is required.", false },
                    { 81, "TokenProviderException", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4965), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4966), 0, false, "Token Provider boş olamaz!", false },
                    { 82, "TokenProviderException", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4968), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4969), 0, false, "Token Provider cannot be empty!", false },
                    { 83, "Unknown", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4970), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4971), 0, false, "Bilinmiyor!", false },
                    { 84, "Unknown", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4972), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4973), 0, false, "Unknown!", false },
                    { 78, "SmsServiceNotFound", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4959), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4959), 0, false, "Unable to Reach SMS Service.", false },
                    { 103, "Alias", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5015), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5016), 0, false, "Görünen Ad", false },
                    { 104, "Alias", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5017), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5018), 0, false, "Alias", false },
                    { 105, "Description", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5019), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5020), 0, false, "Açıklama", false },
                    { 136, "LogList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5134), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5135), 0, false, "LogList", false },
                    { 135, "LogList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5132), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5132), 0, false, "İşlem Kütüğü", false },
                    { 134, "TranslateList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5129), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5130), 0, false, "Translate List", false },
                    { 133, "TranslateList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5127), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5128), 0, false, "Dil Çeviri Listesi", false },
                    { 132, "LanguageList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5125), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5126), 0, false, "Language List", false }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "LangId", "LastUpdatedDate", "LastUpdatedUserId", "Status", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 131, "LanguageList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5123), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5124), 0, false, "Dil Listesi", false },
                    { 130, "OperationClaimList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5120), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5121), 0, false, "OperationClaim List", false },
                    { 129, "OperationClaimList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5075), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5076), 0, false, "Yetki Listesi", false },
                    { 128, "UserList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5072), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5073), 0, false, "User List", false },
                    { 127, "UserList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5070), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5071), 0, false, "Kullanıcı Listesi", false },
                    { 126, "Add", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5068), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5069), 0, false, "Add", false },
                    { 125, "Add", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5065), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5067), 0, false, "Ekle", false },
                    { 124, "GrupPermissions", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5063), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5064), 0, false, "Grup Permissions", false },
                    { 123, "GrupPermissions", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5061), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5062), 0, false, "Grup Yetkileri", false },
                    { 122, "GroupList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5059), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5060), 0, false, "Group List", false },
                    { 121, "GroupList", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5057), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5057), 0, false, "Grup Listesi", false },
                    { 120, "Permissions", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5054), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5055), 0, false, "İzinler", false },
                    { 106, "Description", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5022), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5023), 0, false, "Description", false },
                    { 107, "Value", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5024), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5025), 0, false, "Değer", false },
                    { 108, "Value", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5027), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5028), 0, false, "Value", false },
                    { 109, "LangCode", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5029), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5030), 0, false, "Dil Kodu", false },
                    { 110, "LangCode", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5032), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5033), 0, false, "Lang Code", false },
                    { 111, "Name", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5034), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5035), 0, false, "Adı", false },
                    { 70, "PasswordDigit", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4940), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4941), 0, false, "It Must Contain At Least 1 Digit!", false },
                    { 112, "Name", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5036), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5037), 0, false, "Name", false },
                    { 114, "MobilePhones", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5041), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5042), 0, false, "Mobile Phone", false },
                    { 115, "NoRecordsFound", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5043), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5044), 0, false, "Kayıt Bulunamadı", false },
                    { 116, "NoRecordsFound", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5045), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5046), 0, false, "No Records Found", false },
                    { 117, "Required", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5048), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5049), 0, false, "Bu alan zorunludur!", false },
                    { 118, "Required", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5050), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5051), 0, false, "This field is required!", false },
                    { 119, "Permissions", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5052), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5053), 0, false, "Permissions", false },
                    { 113, "MobilePhones", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5039), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5039), 0, false, "Cep Telefonu", false },
                    { 69, "PasswordDigit", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4938), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4939), 0, false, "En Az 1 Rakam İçermelidir!", false },
                    { 68, "PasswordLowercaseLetter", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4935), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4936), 0, false, "Must Contain At Least 1 Lowercase Letter!", false },
                    { 67, "PasswordLowercaseLetter", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4933), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4934), 0, false, "En Az 1 Küçük Harf İçermelidir!", false },
                    { 31, "Added", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4779), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4780), 0, false, "Başarıyla Eklendi.", false },
                    { 30, "AppMenu", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4777), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4778), 0, false, "Application", false },
                    { 29, "AppMenu", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4774), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4775), 0, false, "Uygulama", false },
                    { 28, "Management", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4772), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4773), 0, false, "Management", false },
                    { 27, "Management", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4770), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4771), 0, false, "Yönetim", false },
                    { 26, "TranslateWords", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4768), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4768), 0, false, "Translate Words", false },
                    { 25, "TranslateWords", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4765), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4766), 0, false, "Dil Çevirileri", false },
                    { 24, "Languages", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4763), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4763), 0, false, "Languages", false },
                    { 23, "Languages", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4760), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4761), 0, false, "Diller", false },
                    { 22, "OperationClaim", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4758), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4759), 0, false, "Operation Claim", false },
                    { 21, "OperationClaim", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4756), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4757), 0, false, "Operasyon Yetkileri", false },
                    { 20, "Groups", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4754), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4755), 0, false, "Groups", false }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "LangId", "LastUpdatedDate", "LastUpdatedUserId", "Status", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 19, "Users", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4752), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4752), 0, false, "Users", false },
                    { 18, "Create", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4749), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4750), 0, false, "Create", false },
                    { 17, "UsersClaims", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4746), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4747), 0, false, "User's Claims", false },
                    { 16, "UsersGroups", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4744), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4745), 0, false, "User's Groups", false },
                    { 15, "Delete", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4742), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4743), 0, false, "Delete", false },
                    { 1, "Login", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(3826), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(3836), 0, false, "Giriş", false },
                    { 2, "Email", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4704), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4708), 0, false, "E posta", false },
                    { 3, "Password", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4711), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4712), 0, false, "Parola", false },
                    { 4, "Update", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4714), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4714), 0, false, "Güncelle", false },
                    { 5, "Delete", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4716), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4717), 0, false, "Sil", false },
                    { 6, "UsersGroups", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4721), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4721), 0, false, "Kullanıcının Grupları", false },
                    { 32, "Added", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4782), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4782), 0, false, "Successfully Added.", false },
                    { 7, "UsersClaims", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4723), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4724), 0, false, "Kullanıcının Yetkileri", false },
                    { 9, "Users", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4727), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4728), 0, false, "Kullanıcılar", false },
                    { 10, "Groups", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4731), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4732), 0, false, "Gruplar", false },
                    { 11, "Login", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4733), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4734), 0, false, "Login", false },
                    { 12, "Email", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4735), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4736), 0, false, "Email", false },
                    { 13, "Password", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4737), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4738), 0, false, "Password", false },
                    { 14, "Update", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4740), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4740), 0, false, "Update", false },
                    { 8, "Create", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4725), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4726), 0, false, "Yeni", false },
                    { 137, "DeleteConfirm", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5136), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5137), 0, false, "Emin misiniz?", false },
                    { 33, "Updated", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4784), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4785), 0, false, "Başarıyla Güncellendi.", false },
                    { 35, "Deleted", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4789), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4790), 0, false, "Başarıyla Silindi.", false },
                    { 66, "PasswordUppercaseLetter", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4931), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4932), 0, false, "Must Contain At Least 1 Capital Letter!", false },
                    { 65, "PasswordUppercaseLetter", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4927), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4928), 0, false, "En Az 1 Büyük Harf İçermelidir!", false },
                    { 64, "PasswordLength", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4925), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4926), 0, false, "Must be at least 8 characters long! ", false },
                    { 63, "PasswordLength", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4922), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4923), 0, false, "Minimum 8 Karakter Uzunluğunda Olmalıdır!", false },
                    { 62, "PasswordEmpty", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4920), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4921), 0, false, "Password can not be empty!", false },
                    { 61, "PasswordEmpty", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4918), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4919), 0, false, "Parola boş olamaz!", false },
                    { 60, "CID", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4916), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4916), 0, false, "Citizenship Number", false },
                    { 59, "CID", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4913), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4914), 0, false, "Vatandaşlık No", false },
                    { 58, "WrongCID", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4911), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4912), 0, false, "Citizenship Number Not Found In Our System. Please Create New Registration!", false },
                    { 57, "WrongCID", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4909), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4910), 0, false, "Vatandaşlık No Sistemimizde Bulunamadı. Lütfen Yeni Kayıt Oluşturun!", false },
                    { 56, "NameAlreadyExist", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4906), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4907), 0, false, "The Object You Are Trying To Create Already Exists.", false },
                    { 55, "NameAlreadyExist", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4904), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4905), 0, false, "Oluşturmaya Çalıştığınız Nesne Zaten Var.", false },
                    { 54, "SendMobileCode", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4902), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4902), 0, false, "Please Enter The Code Sent To You By SMS!", false },
                    { 53, "SendMobileCode", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4899), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4900), 0, false, "Lütfen Size SMS Olarak Gönderilen Kodu Girin!", false },
                    { 52, "SuccessfulLogin", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4897), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4898), 0, false, "Login to the system is successful.", false },
                    { 51, "SuccessfulLogin", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4895), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4896), 0, false, "Sisteme giriş başarılı.", false },
                    { 50, "PasswordError", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4892), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4893), 0, false, "Credentials Failed to Authenticate, Username and / or password incorrect.", false },
                    { 36, "Deleted", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4791), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4792), 0, false, "Successfully Deleted.", false },
                    { 37, "OperationClaimExists", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4862), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4863), 0, false, "Bu operasyon izni zaten mevcut.", false }
                });

            migrationBuilder.InsertData(
                table: "Translates",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserId", "LangId", "LastUpdatedDate", "LastUpdatedUserId", "Status", "Value", "isDeleted" },
                values: new object[,]
                {
                    { 38, "OperationClaimExists", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4865), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4866), 0, false, "This operation permit already exists.", false },
                    { 39, "StringLengthMustBeGreaterThanThree", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4867), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4868), 0, false, "Lütfen En Az 3 Karakterden Oluşan Bir İfade Girin.", false },
                    { 40, "StringLengthMustBeGreaterThanThree", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4870), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4871), 0, false, "Please Enter A Phrase Of At Least 3 Characters.", false },
                    { 41, "CouldNotBeVerifyCid", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4872), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4873), 0, false, "Kimlik No Doğrulanamadı.", false },
                    { 34, "Updated", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4787), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4788), 0, false, "Successfully Updated.", false },
                    { 42, "CouldNotBeVerifyCid", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4874), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4875), 0, false, "Could not be verify Citizen Id", false },
                    { 44, "VerifyCid", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4879), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4880), 0, false, "Verify Citizen Id", false },
                    { 45, "AuthorizationsDenied", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4881), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4882), 0, false, "Yetkiniz olmayan bir alana girmeye çalıştığınız tespit edildi.", false },
                    { 46, "AuthorizationsDenied", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4883), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4884), 0, false, "It has been detected that you are trying to enter an area that you do not have authorization.", false },
                    { 47, "UserNotFound", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4886), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4886), 0, false, "Kimlik Bilgileri Doğrulanamadı. Lütfen Yeni Kayıt Ekranını kullanın.", false },
                    { 48, "UserNotFound", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4888), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4889), 0, false, "Credentials Could Not Verify. Please use the New Registration Screen.", false },
                    { 49, "PasswordError", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4890), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4891), 0, false, "Kimlik Bilgileri Doğrulanamadı, Kullanıcı adı ve/veya parola hatalı.", false },
                    { 43, "VerifyCid", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4877), 0, 1, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(4877), 0, false, "Kimlik No Doğrulandı.", false },
                    { 138, "DeleteConfirm", new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5138), 0, 2, new DateTime(2022, 9, 8, 15, 21, 17, 717, DateTimeKind.Local).AddTicks(5139), 0, false, "Are you sure?", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MobileLogins_ExternalUserId_Provider",
                table: "MobileLogins",
                columns: new[] { "ExternalUserId", "Provider" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CitizenId",
                table: "Users",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MobilePhones",
                table: "Users",
                column: "MobilePhones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "GroupClaims");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "MobileLogins");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Translates");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WareHouses");
        }
    }
}