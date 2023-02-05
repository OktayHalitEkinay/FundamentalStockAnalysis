using Entities;

namespace FormBusiness.Helpers
{
    public static class FileDialogHelper
    {
        public static List<BusinessFile> GetExcelFilesViaFileDialog()
        {
            List<BusinessFile> businessFiles = new List<BusinessFile>();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası|*.xls";
            file.RestoreDirectory = true;
            file.Title = "Excel Dosyası Seçiniz..";
            file.Multiselect = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                var fileNamesAndPaths = file.FileNames.Zip(file.SafeFileNames, (p, n) => new { Path = p, Name = n });
                foreach (var pn in fileNamesAndPaths)
                {
                    businessFiles.Add(new BusinessFile { Name = Path.GetFileNameWithoutExtension(pn.Name), NameWithExtension = pn.Name, Path = pn.Path });
                }
            }
            return businessFiles;
        }
    }
}
