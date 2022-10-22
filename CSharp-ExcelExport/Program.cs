using CSharp_ExcelExport;

var purchases = SeedData.SeedCart();

GenerateFile.GenerateFileXlsx("Purchases", "purchases.xlsx", purchases);