using ClosedXML.Excel;
using CSharp_ExcelExport.Entities;

namespace CSharp_ExcelExport
{
    static class GenerateFile
    {
        public static void GenerateFileXlsx(string tableName, string fileName, IEnumerable<ShopCart> purcahses)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\" + fileName;

            if (File.Exists(filePath))
                File.Delete(filePath);

            using (var workbook = new XLWorkbook())
            {
                var spreadsheet = workbook.Worksheets.Add(tableName);

                int line = 1;
                GenerateHeader(spreadsheet);
                line++;

                foreach (var item in purcahses)
                {
                    spreadsheet.Cell("A" + line).Value = item.Id;
                    spreadsheet.Cell("B" + line).Value = item.CartNumber;
                    spreadsheet.Cell("C" + line).Value = item.TotalValue;
                    spreadsheet.Cell("D" + line).Value = item.LastUpdate;

                    line++;
                }

                workbook.SaveAs(filePath);
            }
        }

        static void GenerateHeader(IXLWorksheet worksheet)
        {
            worksheet.Cell("A1").Value = "Identifier";
            worksheet.Cell("B1").Value = "Number of cart";
            worksheet.Cell("C1").Value = "Total value";
            worksheet.Cell("D1").Value = "Last update";
        }
    }
}
