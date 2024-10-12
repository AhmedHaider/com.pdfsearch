using com.pdfsearch.Core;
using com.pdfsearch.Views;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace com.pdfsearch;

public partial class frmMain : Form
{
    #region Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    private void lblTitlebar_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
    #endregion

    string executingDirectory = string.Empty;

    public frmMain()
    {
        InitializeComponent();
        btnClose.Click += (s, e) => Close();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using FolderBrowserDialog fbd = new();
        if (fbd.ShowDialog() == DialogResult.OK)
            txtPdfDirPath.Text = fbd.SelectedPath;
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        // Use the reusable validation method
        if (!ValidateInput(txtPdfDirPath, "Select a directory..."))
            return;

        if (!ValidateInput(txtSearchTerm, "Type a search term..."))
            return;

        executingDirectory = txtPdfDirPath.Text;

        // Clear the previous results
        lblResultCount.Text = "No. of Files Found:";
        lstResults.Items.Clear();
        pbSpinner.Visible = true;

        // Execute the search asynchronously
        await Task.Run(() =>
        {
            if (rdoFileName.Checked)
                SearchService.SearchFileName(lstResults, txtPdfDirPath, txtSearchTerm);
            else
                SearchService.SearchFileContent(lstResults, txtPdfDirPath, txtSearchTerm);
        });

        pbSpinner.Visible = false;
        lblResultCount.Text = $"No. of Files Found: {lstResults.Items.Count}";

        // Show a message if no files are found
        if (lstResults.Items.Count < 1)
            MessageBox.Show("No files found containing your search criterion.");
    }


    private void miOpen_Click(object sender, EventArgs e)
    {
        OpenFile();
    }

    private void miSave_Click(object sender, EventArgs e)
    {
        Save();
    }

    private void lstResults_DoubleClick(object sender, EventArgs e)
    {
        OpenFile();
    }

    private void lstResults_MouseDown(object sender, MouseEventArgs e)
    {
        var cuurentList = (ListBox)sender;
        var index = cuurentList.IndexFromPoint(e.Location);

        if (e.Button == MouseButtons.Right)
            if (index != -1)
                cuurentList.SelectedIndex = index;
    }

    private void lstResults_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            OpenFile();
    }

    private void pbAdmin_Click(object sender, EventArgs e)
    {
        var frm = new frmAdminValidation();
        frm.ShowDialog();
    }

    #region Helpers
    private bool ValidateInput(TextBox textBox, string message)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox.Focus();
            return false;
        }
        return true;
    }

    private void OpenFile()
    {
        if (lstResults.SelectedItem != null)
        {
            // Combine the current directory with the selected file name to get the full path
            string? fileName = lstResults.SelectedItem as string;


            if (fileName != null)
            {
                string filePath = Path.Combine(executingDirectory, fileName);
                // Check if the file exists before trying to open it
                if (File.Exists(filePath))
                {
                    // Use Process.Start to open the file using the default PDF viewer
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    // Show an error message if the file is not found
                    MessageBox.Show("File not found: " + filePath);
                }
            }
        }
    }

    private void Save()
    {
        if (lstResults.SelectedIndex != -1)
        {
            string sourceFilePath = Path.Combine(executingDirectory, lstResults.SelectedItem!.ToString()!);
            SaveFileDialog saveFileDialog = new()
            {
                FileName = Path.GetFileName(sourceFilePath), // Set initial filename based on source
                Filter = "PDF Files (*.pdf)|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = saveFileDialog.FileName;
                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show("File saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }
    }
    #endregion

    private void frmMain_Load(object sender, EventArgs e)
    {
        btnSearch.Text = char.ConvertFromUtf32(128269).ToString();
    }
}