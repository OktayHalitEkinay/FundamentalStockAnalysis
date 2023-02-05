using Entities;
using FormBusiness.Helpers;

namespace Business.Concrete
{
    public class StockManager
    {
        public List<Stock> GetStocks()
        {
            List<Stock> stocks = new List<Stock>();
            List<BusinessFile> businessFiles = FileDialogHelper.GetExcelFilesViaFileDialog();
            foreach (var businessFile in businessFiles)
            {
                stocks.Add(new Stock { Name = businessFile.Name, Path = businessFile.Path });
            }
            return stocks;
        }
    }
}
