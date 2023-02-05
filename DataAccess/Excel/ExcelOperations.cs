using SpreadsheetLight;

namespace DataAccess.Excel
{
    public static class ExcelOperations
    {
        public static List<string> ReadRowByRowNumber(string path, string sheetName, string rowNumber)
        {
            //Aldığı satır numarasının sonuna kadar okur
            List<string> result = new List<string>();
            using (SLDocument sl = new SLDocument())
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (SLDocument sheet = new SLDocument(fs, sheetName))
            {
                SLWorksheetStatistics stats = sheet.GetWorksheetStatistics();
                for (int j = 1; j <= stats.EndColumnIndex; j++)
                {
                    result.Add(sheet.GetCellValueAsString(Convert.ToInt32(rowNumber), j));
                }
            }
            return result;
        }
        public static List<string> ReadColumnByColumnName(string path, string sheetName, string columnName)
        {
            //Aldığı sütun isminin sonuna kadar okur
            int columnNumber = ExcelOperationsHelper.ConvertColumnNameToNumber(columnName);

            List<string> result = new List<string>();
            using (SLDocument sl = new SLDocument())
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (SLDocument sheet = new SLDocument(fs, sheetName))
            {
                SLWorksheetStatistics stats = sheet.GetWorksheetStatistics();

                for (int j = 1; j <= stats.EndRowIndex; j++)
                {
                    result.Add(sheet.GetCellValueAsString(j, columnNumber));
                }
            }
            return result;
        }
        public static string ReadCellValue(string path, string sheetName, string columnName, string rowNumber)
        {
            //Aldığı hücrenin değerini okur
            int columnNumber = ExcelOperationsHelper.ConvertColumnNameToNumber(columnName);

            string result;
            using (SLDocument sl = new SLDocument())
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (SLDocument sheet = new SLDocument(fs, sheetName))
            {
                SLWorksheetStatistics stats = sheet.GetWorksheetStatistics();
                {
                    result = sheet.GetCellValueAsString(Convert.ToInt32(rowNumber), columnNumber);
                }
            }
            return result;
        }
    }
}
