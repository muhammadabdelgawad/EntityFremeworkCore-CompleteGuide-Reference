using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class seedStocksData02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Balance", "Industry", "Name", "Sector", "Symbol" },
                values: new object[,]
                {
                    { 11, 4713.9099999999999, "n/a", "Invesco Municipal Opportunity Trust", "n/a", "VMO" },
                    { 12, 89388.610000000001, "Catalog/Specialty Distribution", "EVINE Live Inc.", "Consumer Services", "EVLV" },
                    { 13, 64653.480000000003, "Biotechnology: Commercial Physical & Biological Resarch", "Exact Sciences Corporation", "Health Care", "EXAS" },
                    { 14, 25532.299999999999, "Clothing/Shoe/Accessory Stores", "Foot Locker, Inc.", "Consumer Services", "FL" },
                    { 15, 46424.129999999997, "Radio And Television Broadcasting And Communications Equipment", "Vuzix Corporation", "Technology", "VUZI" },
                    { 16, 19062.599999999999, "Marine Transportation", "Pyxis Tankers Inc.", "Transportation", "PXS" },
                    { 17, 72709.259999999995, "Business Services", "Total System Services, Inc.", "Miscellaneous", "TSS" },
                    { 18, 38747.510000000002, "Water Supply", "AquaVenture Holdings Limited", "Public Utilities", "WAAS" },
                    { 19, 79821.970000000001, "Specialty Chemicals", "Hawkins, Inc.", "Consumer Durables", "HWKN" },
                    { 20, 22480.360000000001, "n/a", "PennantPark Floating Rate Capital Ltd.", "n/a", "PFLT" },
                    { 21, 64379.199999999997, "Medical/Dental Instruments", "Alliqua BioMedical, Inc.", "Health Care", "ALQA" },
                    { 22, 29351.200000000001, "Apparel", "V.F. Corporation", "Consumer Non-Durables", "VFC" },
                    { 23, 78091.149999999994, "n/a", "Drive Shack Inc.", "n/a", "DS^D" },
                    { 24, 95637.649999999994, "Computer Software: Programming, Data Processing", "GDS Holdings Limited", "Technology", "GDS" },
                    { 25, 75840.470000000001, "Major Pharmaceuticals", "Seres Therapeutics, Inc.", "Health Care", "MCRB" },
                    { 26, 57641.580000000002, "Major Banks", "South State Corporation", "Finance", "SSB" },
                    { 27, 12908.59, "Real Estate Investment Trusts", "FelCor Lodging Trust Incorporated", "Consumer Services", "FCH" },
                    { 28, 52723.690000000002, "Metal Fabrications", "Proto Labs, Inc.", "Capital Goods", "PRLB" },
                    { 29, 35791.330000000002, "Textiles", "Crown Crafts, Inc.", "Basic Industries", "CRWS" },
                    { 30, 23749.580000000002, "Hotels/Resorts", "Peak Resorts, Inc.", "Consumer Services", "SKIS" },
                    { 31, 51499.769999999997, "Hotels/Resorts", "China Lodging Group, Limited", "Consumer Services", "HTHT" },
                    { 32, 81785.889999999999, "Other Specialty Stores", "Big 5 Sporting Goods Corporation", "Consumer Services", "BGFV" },
                    { 33, 11477.49, "Real Estate Investment Trusts", "Pennsylvania Real Estate Investment Trust", "Consumer Services", "PEI" },
                    { 34, 89203.630000000005, "Clothing/Shoe/Accessory Stores", "Boot Barn Holdings, Inc.", "Consumer Services", "BOOT" },
                    { 35, 38603.370000000003, "Oil & Gas Production", "Vaalco Energy Inc", "Energy", "EGY" },
                    { 36, 5802.3999999999996, "Major Pharmaceuticals", "Albireo Pharma, Inc.", "Health Care", "ALBO" },
                    { 37, 10248.780000000001, "n/a", "Tsakos Energy Navigation Ltd", "n/a", "TNP^C" },
                    { 38, 64759.139999999999, "Electronic Components", "Western Digital Corporation", "Technology", "WDC" },
                    { 39, 6498.5799999999999, "Electric Utilities: Central", "Vistra Energy Corp.", "Public Utilities", "VST" },
                    { 40, 98211.899999999994, "n/a", "Washington Prime Group Inc.", "n/a", "WPG^H" },
                    { 41, 14916.440000000001, "Medical/Dental Instruments", "Antares Pharma, Inc.", "Health Care", "ATRS" },
                    { 42, 20345.330000000002, "EDP Services", "MINDBODY, Inc.", "Technology", "MB" },
                    { 43, 48828.239999999998, "Semiconductors", "Intel Corporation", "Technology", "INTC" },
                    { 44, 22197.130000000001, "n/a", "BlackRock Investment Quality Municipal Trust Inc. (The)", "n/a", "BKN" },
                    { 45, 90814.039999999994, "Oil & Gas Production", "Harmony Merger Corp.", "Public Utilities", "HRMNW" },
                    { 46, 5035.7799999999997, "Major Pharmaceuticals", "Cellectar Biosciences, Inc.", "Health Care", "CLRB" },
                    { 47, 67233.789999999994, "EDP Services", "Park City Group, Inc.", "Technology", "PCYG" },
                    { 48, 59289.510000000002, "Oil Refining/Marketing", "Macquarie Infrastructure Company", "Energy", "MIC" },
                    { 49, 71891.350000000006, "Semiconductors", "MaxLinear, Inc", "Technology", "MXL" },
                    { 50, 22161.279999999999, "Oil & Gas Production", "Hugoton Royalty Trust", "Energy", "HGT" },
                    { 51, 83215.210000000006, "Major Banks", "Pathfinder Bancorp, Inc.", "Finance", "PBHC" },
                    { 52, 64260.57, "Home Furnishings", "Leggett & Platt, Incorporated", "Consumer Durables", "LEG" },
                    { 53, 63801.889999999999, "Apparel", "Kate Spade & Company", "Consumer Non-Durables", "KATE" },
                    { 54, 3350.5100000000002, "n/a", "Protective Life Corporation", "n/a", "PL^E" },
                    { 55, 7597.96, "Department/Specialty Retail Stores", "Cencosud S.A.", "Consumer Services", "CNCO" },
                    { 56, 6098.8699999999999, "Savings Institutions", "Magyar Bancorp, Inc.", "Finance", "MGYR" },
                    { 57, 77505.589999999997, "Major Pharmaceuticals", "DelMar Pharmaceuticals, Inc.", "Health Care", "DMPI" },
                    { 58, 3428.3499999999999, "n/a", "First Trust Small Cap Core AlphaDEX Fund", "n/a", "FYX" },
                    { 59, 73733.929999999993, "n/a", "China TechFaith Wireless Communication Technology Limited", "n/a", "CNTF" },
                    { 60, 51952.18, "Oil & Gas Production", "Canadian Natural Resources Limited", "Energy", "CNQ" },
                    { 61, 41505.230000000003, "Medical/Dental Instruments", "Glaukos Corporation", "Health Care", "GKOS" },
                    { 62, 78836.589999999997, "n/a", "Dreyfus Municipal Bond Infrastructure Fund, Inc.", "n/a", "DMB" },
                    { 63, 31240.139999999999, "Aerospace", "Grupo Aeroportuario del Sureste, S.A. de C.V.", "Transportation", "ASR" },
                    { 64, 59982.029999999999, "Consumer Electronics/Appliances", "iRobot Corporation", "Consumer Durables", "IRBT" },
                    { 65, 62750.650000000001, "Medical Specialities", "UnitedHealth Group Incorporated", "Health Care", "UNH" },
                    { 66, 64337.139999999999, "Computer Software: Programming, Data Processing", "Sabre Corporation", "Technology", "SABR" },
                    { 67, 91239.970000000001, "Beverages (Production/Distribution)", "Willamette Valley Vineyards, Inc.", "Consumer Non-Durables", "WVVI" },
                    { 68, 55349.68, "Other Specialty Stores", "ZAGG Inc", "Consumer Services", "ZAGG" },
                    { 69, 93187.479999999996, "Marine Transportation", "Navios Maritime Partners LP", "Transportation", "NMM" },
                    { 70, 11844.24, "Aerospace", "Grupo Aeroportuario del Centro Norte S.A.B. de C.V.", "Transportation", "OMAB" },
                    { 71, 87019.610000000001, "n/a", "Public Storage", "n/a", "PSA^Z" },
                    { 72, 66098.820000000007, "n/a", "Blackrock Core Bond Trust", "n/a", "BHK" },
                    { 73, 57311.290000000001, "Biotechnology: Electromedical & Electrotherapeutic Apparatus", "The Spectranetics Corporation", "Health Care", "SPNC" },
                    { 74, 92281.460000000006, "Hotels/Resorts", "MGM Resorts International", "Consumer Services", "MGM" },
                    { 75, 84788.130000000005, "n/a", "Vanguard Short-Term Government ETF", "n/a", "VGSH" },
                    { 76, 30063.700000000001, "Major Banks", "Texas Capital Bancshares, Inc.", "Finance", "TCBIP" },
                    { 77, 16803.580000000002, "Specialty Foods", "J & J Snack Foods Corp.", "Consumer Non-Durables", "JJSF" },
                    { 78, 51587.360000000001, "Advertising", "WPP plc", "Technology", "WPPGY" },
                    { 79, 45519.290000000001, "Industrial Machinery/Components", "Key Technology, Inc.", "Technology", "KTEC" },
                    { 80, 15341.25, "n/a", "Sophiris Bio, Inc.", "n/a", "SPHS" },
                    { 81, 35990.809999999998, "n/a", "PartnerRe Ltd.", "n/a", "PRE^G" },
                    { 82, 88537.059999999998, "Oilfield Services/Equipment", "CSI Compressco LP", "Energy", "CCLP" },
                    { 83, 31509.09, "Advertising", "Criteo S.A.", "Technology", "CRTO" },
                    { 84, 37413.410000000003, "Biotechnology: Biological Products (No Diagnostic Substances)", "Aviragen Therapeutics, Inc.", "Health Care", "AVIR" },
                    { 85, 28476.529999999999, "n/a", "State Street Corporation", "n/a", "STT^E" },
                    { 86, 54783.059999999998, "Major Banks", "Old Point Financial Corporation", "Finance", "OPOF" },
                    { 87, 74553.880000000005, "n/a", "iShares MSCI ACWI ex US Index Fund", "n/a", "ACWX" },
                    { 88, 82628.449999999997, "Biotechnology: Commercial Physical & Biological Resarch", "Exelixis, Inc.", "Health Care", "EXEL" },
                    { 89, 58492.610000000001, "Steel/Iron Ore", "Ternium S.A.", "Basic Industries", "TX" },
                    { 90, 87167.309999999998, "Industrial Machinery/Components", "CBAK Energy Technology, Inc.", "Miscellaneous", "CBAK" },
                    { 91, 74861.440000000002, "Major Pharmaceuticals", "Soligenix, Inc.", "Health Care", "SNGX" },
                    { 92, 34085.300000000003, "Major Pharmaceuticals", "Novo Nordisk A/S", "Health Care", "NVO" },
                    { 93, 90172.300000000003, "Precious Metals", "Uranium Resources, Inc.", "Basic Industries", "URRE" },
                    { 94, 43757.610000000001, "n/a", "Second Sight Medical Products, Inc.", "n/a", "EYES" },
                    { 95, 82323.929999999993, "Major Pharmaceuticals", "PhaseRx, Inc.", "Health Care", "PZRX" },
                    { 96, 71047.130000000005, "Radio And Television Broadcasting And Communications Equipment", "Pointer Telocation Ltd.", "Technology", "PNTR" },
                    { 97, 35785.669999999998, "Major Pharmaceuticals", "AMAG Pharmaceuticals, Inc.", "Health Care", "AMAG" },
                    { 98, 31341.639999999999, "Marine Transportation", "Scorpio Tankers Inc.", "Transportation", "SBNA" },
                    { 99, 2178.9299999999998, "n/a", "PowerShares DWA Consumer Staples Momentum Portfolio", "n/a", "PSL" },
                    { 100, 92176.679999999993, "Accident &Health Insurance", "Assurant, Inc.", "Finance", "AIZ" },
                    { 101, 54742.529999999999, "Industrial Specialties", "Inogen, Inc", "Health Care", "INGN" },
                    { 102, 29819.959999999999, "Electrical Products", "Itron, Inc.", "Capital Goods", "ITRI" },
                    { 103, 27661.119999999999, "Computer Communications Equipment", "A10 Networks, Inc.", "Technology", "ATEN" },
                    { 104, 78015.050000000003, "Oil Refining/Marketing", "Hunter Maritime Acquisition Corp.", "Transportation", "HUNT" },
                    { 105, 54286.529999999999, "Major Banks", "Colony Bankcorp, Inc.", "Finance", "CBAN" },
                    { 106, 53985.800000000003, "Oil Refining/Marketing", "C.H. Robinson Worldwide, Inc.", "Transportation", "CHRW" },
                    { 107, 74587.330000000002, "Finance: Consumer Services", "Enova International, Inc.", "Finance", "ENVA" },
                    { 108, 11486.77, "Radio And Television Broadcasting And Communications Equipment", "QUALCOMM Incorporated", "Technology", "QCOM" },
                    { 109, 62602.779999999999, "Medical/Dental Instruments", "Globus Medical, Inc.", "Health Care", "GMED" },
                    { 110, 2535.1100000000001, "n/a", "First Trust Nasdaq Pharmaceuticals ETF", "n/a", "FTXH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 110);
        }
    }
}
