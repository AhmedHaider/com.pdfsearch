namespace com.pdfsearch.Views;

public partial class frmAdminValidation : Form
{
    public frmAdminValidation()
    {
        InitializeComponent();
    }

    private void btnAdminLogin_Click(object sender, EventArgs e)
    {
        if (txtPassword.Text.Equals("123"))
        {
            var frm = new frmAdmin();
            Hide();
            frm.ShowDialog();
            Close();
        }
        else
        {
            MessageBox.Show("Invalid Credentials.");
        }
    }
}
