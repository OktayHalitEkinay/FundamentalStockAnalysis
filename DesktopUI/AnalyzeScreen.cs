using Business.Concrete;
using Entities;

namespace DesktopUI
{
    public partial class AnalyzeScreen : Form
    {
        List<Stock> stocks = new List<Stock>();
        List<Stock> selectedStocks = new List<Stock>();
        StockManager stockManager=new StockManager();
        public AnalyzeScreen()
        {
            InitializeComponent();
        }

        private void GetStocksButton_Click(object sender, EventArgs e)
        {
           stocks=stockManager.GetStocks();

        }

       
    }
}
