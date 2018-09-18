using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerFieldServer.api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminWebsites",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 6, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminWebsites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 12, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BankAcount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupSoccerFields",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 6, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    OpenTime = table.Column<DateTime>(nullable: false),
                    CloseTime = table.Column<DateTime>(nullable: false),
                    PercentVAT = table.Column<double>(nullable: false),
                    PercentPunish = table.Column<double>(nullable: false),
                    PercentRushHour = table.Column<double>(nullable: false),
                    Condition = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSoccerFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 12, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Condition = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    GroupSoccerFieldId = table.Column<string>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_GroupSoccerFields_GroupSoccerFieldId",
                        column: x => x.GroupSoccerFieldId,
                        principalTable: "GroupSoccerFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoccerFields",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 12, nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Kind = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Condition = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    GroupSoccerFieldId = table.Column<string>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoccerFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoccerFields_GroupSoccerFields_GroupSoccerFieldId",
                        column: x => x.GroupSoccerFieldId,
                        principalTable: "GroupSoccerFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 12, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Regency = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    BankAcount = table.Column<string>(nullable: true),
                    GroupSoccerFieldId = table.Column<string>(maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_GroupSoccerFields_GroupSoccerFieldId",
                        column: x => x.GroupSoccerFieldId,
                        principalTable: "GroupSoccerFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookFields",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 12, nullable: false),
                    SoccerFieldId = table.Column<string>(maxLength: 12, nullable: false),
                    CustomerId = table.Column<string>(maxLength: 12, nullable: false),
                    StaffId = table.Column<string>(maxLength: 12, nullable: false),
                    BillerId = table.Column<string>(maxLength: 12, nullable: false),
                    DayOfActionBookField = table.Column<DateTime>(nullable: false),
                    DayOfBookField = table.Column<DateTime>(nullable: false),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    DayOfBill = table.Column<DateTime>(nullable: false),
                    BookFieldFee = table.Column<decimal>(nullable: false),
                    ProductFee = table.Column<decimal>(nullable: false),
                    ChangeFee = table.Column<decimal>(nullable: false),
                    VatFee = table.Column<decimal>(nullable: false),
                    TotalFee = table.Column<decimal>(nullable: false),
                    Condition = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookFields_Staffs_BillerId",
                        column: x => x.BillerId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookFields_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookFields_SoccerFields_SoccerFieldId",
                        column: x => x.SoccerFieldId,
                        principalTable: "SoccerFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookFields_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkScheduleStaffs",
                columns: table => new
                {
                    StaffId = table.Column<string>(maxLength: 12, nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    Shift = table.Column<int>(nullable: false),
                    Condition = table.Column<bool>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkScheduleStaffs", x => new { x.StaffId, x.Day, x.Shift });
                    table.UniqueConstraint("AK_WorkScheduleStaffs_Day_Shift_StaffId", x => new { x.Day, x.Shift, x.StaffId });
                    table.ForeignKey(
                        name: "FK_WorkScheduleStaffs_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerHistorys",
                columns: table => new
                {
                    CustomerId = table.Column<string>(maxLength: 12, nullable: false),
                    BookFieldId = table.Column<string>(maxLength: 12, nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerHistorys", x => new { x.CustomerId, x.BookFieldId });
                    table.UniqueConstraint("AK_CustomerHistorys_BookFieldId_CustomerId", x => new { x.BookFieldId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_CustomerHistorys_BookFields_BookFieldId",
                        column: x => x.BookFieldId,
                        principalTable: "BookFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerHistorys_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailsOfBookFields",
                columns: table => new
                {
                    BookFieldId = table.Column<string>(maxLength: 12, nullable: false),
                    ProductId = table.Column<string>(maxLength: 12, nullable: false),
                    BillerId = table.Column<string>(maxLength: 12, nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsOfBookFields", x => new { x.BookFieldId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_DetailsOfBookFields_Staffs_BillerId",
                        column: x => x.BillerId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailsOfBookFields_BookFields_BookFieldId",
                        column: x => x.BookFieldId,
                        principalTable: "BookFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailsOfBookFields_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookFields_BillerId",
                table: "BookFields",
                column: "BillerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookFields_CustomerId",
                table: "BookFields",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookFields_SoccerFieldId",
                table: "BookFields",
                column: "SoccerFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_BookFields_StaffId",
                table: "BookFields",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsOfBookFields_BillerId",
                table: "DetailsOfBookFields",
                column: "BillerId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsOfBookFields_ProductId",
                table: "DetailsOfBookFields",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupSoccerFieldId",
                table: "Products",
                column: "GroupSoccerFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_SoccerFields_GroupSoccerFieldId",
                table: "SoccerFields",
                column: "GroupSoccerFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_GroupSoccerFieldId",
                table: "Staffs",
                column: "GroupSoccerFieldId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminWebsites");

            migrationBuilder.DropTable(
                name: "CustomerHistorys");

            migrationBuilder.DropTable(
                name: "DetailsOfBookFields");

            migrationBuilder.DropTable(
                name: "WorkScheduleStaffs");

            migrationBuilder.DropTable(
                name: "BookFields");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SoccerFields");

            migrationBuilder.DropTable(
                name: "GroupSoccerFields");
        }
    }
}
