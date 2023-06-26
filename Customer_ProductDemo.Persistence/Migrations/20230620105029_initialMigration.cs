using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Customer_ProductDemo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArearLocality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "RefAddressTypes",
                columns: table => new
                {
                    AddressTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefAddressTypes", x => x.AddressTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "RefOrderStatusCodes",
                columns: table => new
                {
                    OrderStatusCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order_Status_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefOrderStatusCodeOrderStatusCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefOrderStatusCodes", x => x.OrderStatusCode);
                    table.ForeignKey(
                        name: "FK_RefOrderStatusCodes_RefOrderStatusCodes_RefOrderStatusCodeOrderStatusCode",
                        column: x => x.RefOrderStatusCodeOrderStatusCode,
                        principalTable: "RefOrderStatusCodes",
                        principalColumn: "OrderStatusCode");
                });

            migrationBuilder.CreateTable(
                name: "RefPaymentMethods",
                columns: table => new
                {
                    PaymentMethodeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentMethodDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefPaymentMethods", x => x.PaymentMethodeCode);
                });

            migrationBuilder.CreateTable(
                name: "RefproductTypes",
                columns: table => new
                {
                    ProductTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefproductTypes", x => x.ProductTypeCode);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethodCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefPaymentMethodPaymentMethodeCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_RefPaymentMethods_RefPaymentMethodPaymentMethodeCode",
                        column: x => x.RefPaymentMethodPaymentMethodeCode,
                        principalTable: "RefPaymentMethods",
                        principalColumn: "PaymentMethodeCode");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_RefproductTypes_ProductTypeCode",
                        column: x => x.ProductTypeCode,
                        principalTable: "RefproductTypes",
                        principalColumn: "ProductTypeCode");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddressHistories",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefAddressTypeAddressTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddressHistories", x => new { x.CustomerId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_CustomerAddressHistories_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddressHistories_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddressHistories_RefAddressTypes_RefAddressTypeAddressTypeCode",
                        column: x => x.RefAddressTypeAddressTypeCode,
                        principalTable: "RefAddressTypes",
                        principalColumn: "AddressTypeCode");
                });

            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrders", x => new { x.CustomerId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_CustomerOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_RefOrderStatusCodes_OrderStatusCode",
                        column: x => x.OrderStatusCode,
                        principalTable: "RefOrderStatusCodes",
                        principalColumn: "OrderStatusCode");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderQuantity = table.Column<int>(type: "int", nullable: false),
                    CustomerOrderCustomerId = table.Column<int>(type: "int", nullable: true),
                    CustomerOrderOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_CustomerOrders_CustomerOrderCustomerId_CustomerOrderOrderId",
                        columns: x => new { x.CustomerOrderCustomerId, x.CustomerOrderOrderId },
                        principalTable: "CustomerOrders",
                        principalColumns: new[] { "CustomerId", "OrderId" });
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddressHistories_AddressId",
                table: "CustomerAddressHistories",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddressHistories_RefAddressTypeAddressTypeCode",
                table: "CustomerAddressHistories",
                column: "RefAddressTypeAddressTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_OrderStatusCode",
                table: "CustomerOrders",
                column: "OrderStatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RefPaymentMethodPaymentMethodeCode",
                table: "Customers",
                column: "RefPaymentMethodPaymentMethodeCode");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CustomerOrderCustomerId_CustomerOrderOrderId",
                table: "OrderItems",
                columns: new[] { "CustomerOrderCustomerId", "CustomerOrderOrderId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeCode",
                table: "Products",
                column: "ProductTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_RefOrderStatusCodes_RefOrderStatusCodeOrderStatusCode",
                table: "RefOrderStatusCodes",
                column: "RefOrderStatusCodeOrderStatusCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddressHistories");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "RefAddressTypes");

            migrationBuilder.DropTable(
                name: "CustomerOrders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "RefOrderStatusCodes");

            migrationBuilder.DropTable(
                name: "RefproductTypes");

            migrationBuilder.DropTable(
                name: "RefPaymentMethods");
        }
    }
}
