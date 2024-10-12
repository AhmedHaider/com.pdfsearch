using com.pdfsearch.Core;
using com.pdfsearch.Models;
using System.Runtime.InteropServices;

namespace com.pdfsearch.Views;

public partial class frmManageUser : Form
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

    public User _user = new();

    public frmManageUser()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();
    private void btnCancel_Click(object sender, EventArgs e) => Close();

    private void frmManageUser_Load(object sender, EventArgs e)
    {
        txtId.Text = _user.Id.ToString();
        txtUserName.Text = _user.Username;
        txtPassword.Text = _user.Password;
        chkIsAuthorized.Checked = _user.IsAuthorized;
        txtCreatedAt.Text = _user.CreatedAt.ToString();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        using var context = new AppDbContext();

        var user = context.Users.Find(_user.Id);

        if (user == null)
        {
            MessageBox.Show("Can't update the specified user!");
            Close();
            return;
        }

        user.Password = txtPassword.Text;
        user.IsAuthorized = chkIsAuthorized.Checked;

        context.SaveChanges();

        MessageBox.Show("data has been updated successfully.");
        DialogResult = DialogResult.OK;
    }
}