// See https://aka.ms/new-console-template for more information
using DataAccess.Excel;


var result1=ExcelOperations.ReadRowByRowNumber("C:\\CodeWorkings\\Finans\\FundamentalStockAnalysis\\Resources\\test.xlsx","Sheet1","1");
var result2=ExcelOperations.ReadColumnByColumnName("C:\\CodeWorkings\\Finans\\FundamentalStockAnalysis\\Resources\\test.xlsx","Sheet1","A");
Console.WriteLine("Hello, World!");
