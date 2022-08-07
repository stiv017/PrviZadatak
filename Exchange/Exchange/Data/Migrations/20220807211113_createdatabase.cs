using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exchange.Data.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AED = table.Column<double>(type: "double", nullable: false),
                    AFN = table.Column<double>(type: "double", nullable: false),
                    ALL = table.Column<double>(type: "double", nullable: false),
                    AMD = table.Column<double>(type: "double", nullable: false),
                    ANG = table.Column<double>(type: "double", nullable: false),
                    AOA = table.Column<double>(type: "double", nullable: false),
                    ARS = table.Column<double>(type: "double", nullable: false),
                    AUD = table.Column<double>(type: "double", nullable: false),
                    AWG = table.Column<double>(type: "double", nullable: false),
                    AZN = table.Column<double>(type: "double", nullable: false),
                    BAM = table.Column<double>(type: "double", nullable: false),
                    BBD = table.Column<int>(type: "int", nullable: false),
                    BDT = table.Column<double>(type: "double", nullable: false),
                    BGN = table.Column<double>(type: "double", nullable: false),
                    BHD = table.Column<double>(type: "double", nullable: false),
                    BIF = table.Column<double>(type: "double", nullable: false),
                    BMD = table.Column<int>(type: "int", nullable: false),
                    BND = table.Column<double>(type: "double", nullable: false),
                    BOB = table.Column<double>(type: "double", nullable: false),
                    BRL = table.Column<double>(type: "double", nullable: false),
                    BSD = table.Column<int>(type: "int", nullable: false),
                    BTC = table.Column<double>(type: "double", nullable: false),
                    BTN = table.Column<double>(type: "double", nullable: false),
                    BWP = table.Column<double>(type: "double", nullable: false),
                    BYN = table.Column<double>(type: "double", nullable: false),
                    BZD = table.Column<double>(type: "double", nullable: false),
                    CAD = table.Column<double>(type: "double", nullable: false),
                    CDF = table.Column<double>(type: "double", nullable: false),
                    CHF = table.Column<double>(type: "double", nullable: false),
                    CLF = table.Column<double>(type: "double", nullable: false),
                    CLP = table.Column<double>(type: "double", nullable: false),
                    CNH = table.Column<double>(type: "double", nullable: false),
                    CNY = table.Column<double>(type: "double", nullable: false),
                    COP = table.Column<double>(type: "double", nullable: false),
                    CRC = table.Column<double>(type: "double", nullable: false),
                    CUC = table.Column<int>(type: "int", nullable: false),
                    CUP = table.Column<double>(type: "double", nullable: false),
                    CVE = table.Column<double>(type: "double", nullable: false),
                    CZK = table.Column<double>(type: "double", nullable: false),
                    DJF = table.Column<double>(type: "double", nullable: false),
                    DKK = table.Column<double>(type: "double", nullable: false),
                    DOP = table.Column<double>(type: "double", nullable: false),
                    DZD = table.Column<double>(type: "double", nullable: false),
                    EGP = table.Column<double>(type: "double", nullable: false),
                    ERN = table.Column<int>(type: "int", nullable: false),
                    ETB = table.Column<double>(type: "double", nullable: false),
                    EUR = table.Column<double>(type: "double", nullable: false),
                    FJD = table.Column<double>(type: "double", nullable: false),
                    FKP = table.Column<double>(type: "double", nullable: false),
                    GBP = table.Column<double>(type: "double", nullable: false),
                    GEL = table.Column<double>(type: "double", nullable: false),
                    GGP = table.Column<double>(type: "double", nullable: false),
                    GHS = table.Column<double>(type: "double", nullable: false),
                    GIP = table.Column<double>(type: "double", nullable: false),
                    GMD = table.Column<double>(type: "double", nullable: false),
                    GNF = table.Column<double>(type: "double", nullable: false),
                    GTQ = table.Column<double>(type: "double", nullable: false),
                    GYD = table.Column<double>(type: "double", nullable: false),
                    HKD = table.Column<double>(type: "double", nullable: false),
                    HNL = table.Column<double>(type: "double", nullable: false),
                    HRK = table.Column<double>(type: "double", nullable: false),
                    HTG = table.Column<double>(type: "double", nullable: false),
                    HUF = table.Column<double>(type: "double", nullable: false),
                    IDR = table.Column<int>(type: "int", nullable: false),
                    ILS = table.Column<double>(type: "double", nullable: false),
                    IMP = table.Column<double>(type: "double", nullable: false),
                    INR = table.Column<double>(type: "double", nullable: false),
                    IQD = table.Column<double>(type: "double", nullable: false),
                    IRR = table.Column<double>(type: "double", nullable: false),
                    ISK = table.Column<double>(type: "double", nullable: false),
                    JEP = table.Column<double>(type: "double", nullable: false),
                    JMD = table.Column<double>(type: "double", nullable: false),
                    JOD = table.Column<double>(type: "double", nullable: false),
                    JPY = table.Column<double>(type: "double", nullable: false),
                    KES = table.Column<double>(type: "double", nullable: false),
                    KGS = table.Column<double>(type: "double", nullable: false),
                    KHR = table.Column<double>(type: "double", nullable: false),
                    KMF = table.Column<double>(type: "double", nullable: false),
                    KPW = table.Column<int>(type: "int", nullable: false),
                    KRW = table.Column<double>(type: "double", nullable: false),
                    KWD = table.Column<double>(type: "double", nullable: false),
                    KYD = table.Column<double>(type: "double", nullable: false),
                    KZT = table.Column<double>(type: "double", nullable: false),
                    LAK = table.Column<double>(type: "double", nullable: false),
                    LBP = table.Column<double>(type: "double", nullable: false),
                    LKR = table.Column<double>(type: "double", nullable: false),
                    LRD = table.Column<double>(type: "double", nullable: false),
                    LSL = table.Column<double>(type: "double", nullable: false),
                    LYD = table.Column<double>(type: "double", nullable: false),
                    MAD = table.Column<double>(type: "double", nullable: false),
                    MDL = table.Column<double>(type: "double", nullable: false),
                    MGA = table.Column<double>(type: "double", nullable: false),
                    MKD = table.Column<double>(type: "double", nullable: false),
                    MMK = table.Column<double>(type: "double", nullable: false),
                    MNT = table.Column<double>(type: "double", nullable: false),
                    MOP = table.Column<double>(type: "double", nullable: false),
                    MRU = table.Column<double>(type: "double", nullable: false),
                    MUR = table.Column<double>(type: "double", nullable: false),
                    MVR = table.Column<double>(type: "double", nullable: false),
                    MWK = table.Column<double>(type: "double", nullable: false),
                    MXN = table.Column<double>(type: "double", nullable: false),
                    MYR = table.Column<double>(type: "double", nullable: false),
                    MZN = table.Column<double>(type: "double", nullable: false),
                    NAD = table.Column<double>(type: "double", nullable: false),
                    NGN = table.Column<double>(type: "double", nullable: false),
                    NIO = table.Column<double>(type: "double", nullable: false),
                    NOK = table.Column<double>(type: "double", nullable: false),
                    NPR = table.Column<double>(type: "double", nullable: false),
                    NZD = table.Column<double>(type: "double", nullable: false),
                    OMR = table.Column<double>(type: "double", nullable: false),
                    PAB = table.Column<int>(type: "int", nullable: false),
                    PEN = table.Column<double>(type: "double", nullable: false),
                    PGK = table.Column<double>(type: "double", nullable: false),
                    PHP = table.Column<double>(type: "double", nullable: false),
                    PKR = table.Column<double>(type: "double", nullable: false),
                    PLN = table.Column<double>(type: "double", nullable: false),
                    PYG = table.Column<double>(type: "double", nullable: false),
                    QAR = table.Column<double>(type: "double", nullable: false),
                    RON = table.Column<double>(type: "double", nullable: false),
                    RSD = table.Column<double>(type: "double", nullable: false),
                    RUB = table.Column<double>(type: "double", nullable: false),
                    RWF = table.Column<double>(type: "double", nullable: false),
                    SAR = table.Column<double>(type: "double", nullable: false),
                    SBD = table.Column<double>(type: "double", nullable: false),
                    SCR = table.Column<double>(type: "double", nullable: false),
                    SDG = table.Column<double>(type: "double", nullable: false),
                    SEK = table.Column<double>(type: "double", nullable: false),
                    SGD = table.Column<double>(type: "double", nullable: false),
                    SHP = table.Column<double>(type: "double", nullable: false),
                    SLL = table.Column<double>(type: "double", nullable: false),
                    SOS = table.Column<double>(type: "double", nullable: false),
                    SRD = table.Column<double>(type: "double", nullable: false),
                    SSP = table.Column<double>(type: "double", nullable: false),
                    STD = table.Column<double>(type: "double", nullable: false),
                    STN = table.Column<double>(type: "double", nullable: false),
                    SVC = table.Column<double>(type: "double", nullable: false),
                    SYP = table.Column<double>(type: "double", nullable: false),
                    SZL = table.Column<double>(type: "double", nullable: false),
                    THB = table.Column<double>(type: "double", nullable: false),
                    TJS = table.Column<double>(type: "double", nullable: false),
                    TMT = table.Column<double>(type: "double", nullable: false),
                    TND = table.Column<double>(type: "double", nullable: false),
                    TOP = table.Column<double>(type: "double", nullable: false),
                    TRY = table.Column<double>(type: "double", nullable: false),
                    TTD = table.Column<double>(type: "double", nullable: false),
                    TWD = table.Column<double>(type: "double", nullable: false),
                    TZS = table.Column<double>(type: "double", nullable: false),
                    UAH = table.Column<double>(type: "double", nullable: false),
                    UGX = table.Column<double>(type: "double", nullable: false),
                    USD = table.Column<int>(type: "int", nullable: false),
                    UYU = table.Column<double>(type: "double", nullable: false),
                    UZS = table.Column<double>(type: "double", nullable: false),
                    VES = table.Column<double>(type: "double", nullable: false),
                    VND = table.Column<double>(type: "double", nullable: false),
                    VUV = table.Column<double>(type: "double", nullable: false),
                    WST = table.Column<double>(type: "double", nullable: false),
                    XAF = table.Column<double>(type: "double", nullable: false),
                    XAG = table.Column<double>(type: "double", nullable: false),
                    XAU = table.Column<double>(type: "double", nullable: false),
                    XCD = table.Column<double>(type: "double", nullable: false),
                    XDR = table.Column<double>(type: "double", nullable: false),
                    XOF = table.Column<double>(type: "double", nullable: false),
                    XPD = table.Column<double>(type: "double", nullable: false),
                    XPF = table.Column<double>(type: "double", nullable: false),
                    XPT = table.Column<double>(type: "double", nullable: false),
                    YER = table.Column<double>(type: "double", nullable: false),
                    ZAR = table.Column<double>(type: "double", nullable: false),
                    ZMW = table.Column<double>(type: "double", nullable: false),
                    ZWL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Menjacnica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    disclaimer = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    Base = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ratesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menjacnica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menjacnica_Rates_ratesId",
                        column: x => x.ratesId,
                        principalTable: "Rates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Menjacnica_ratesId",
                table: "Menjacnica",
                column: "ratesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menjacnica");

            migrationBuilder.DropTable(
                name: "Rates");
        }
    }
}
