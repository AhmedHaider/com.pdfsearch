using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace com.pdfsearch.Core;

internal class SearchService
{
    public static void SearchFileName(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        // Get all PDF files in the directory and subdirectories
        var files = Directory.GetFiles(txtFolderPath.Text, "*.pdf", SearchOption.AllDirectories);

        // Filter the files where the name contains the search term
        var foundFiles = files.Where(file => Path.GetFileName(file)
            .Contains(txtSearchTerm.Text, StringComparison.OrdinalIgnoreCase));

        // Use Invoke to clear the ListBox on the UI thread
        lstResult.Invoke(new Action(lstResult.Items.Clear));

        // Add only the file name (without the path) to the ListBox
        foreach (var foundFile in foundFiles)
        {
            string fileName = Path.GetFileName(foundFile);

            // Use Invoke to add items to the ListBox on the UI thread
            lstResult.Invoke(new Action(() => { lstResult.Items.Add(fileName); }));
        }
    }

    public static void SearchFileContent(ListBox lstResult, TextBox txtFolderPath, TextBox txtSearchTerm)
    {
        string executingDirectory = txtFolderPath.Text;
        string textToFind = txtSearchTerm.Text;

        DirectoryInfo directoryInfo = new(executingDirectory);
        FileInfo[] fileInfos = directoryInfo.GetFiles("*.pdf");

        foreach (FileInfo fileInfo in fileInfos)
        {
            bool foundText = false;

            using (FileStream fileStream = File.OpenRead(fileInfo.FullName))
            using (PdfReader pdfReader = new PdfReader(fileStream))
            using (PdfDocument pdfDocument = new PdfDocument(pdfReader))
            {
                for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    PdfPage pdfPage = pdfDocument.GetPage(page);
                    string pageText = PdfTextExtractor.GetTextFromPage(pdfPage, new SimpleTextExtractionStrategy());

                    if (pageText.Contains(textToFind, StringComparison.OrdinalIgnoreCase))
                    {
                        foundText = true;
                        break;
                    }
                }
            }

            // Safely update the ListBox on the UI thread
            if (foundText)
            {
                var found = $"{fileInfo.Name}";

                // Add only the file name (without the path) to the ListBox
                lstResult.Invoke(new Action(() => { lstResult.Items.Add(found); }));
            }
        }
    }
}
