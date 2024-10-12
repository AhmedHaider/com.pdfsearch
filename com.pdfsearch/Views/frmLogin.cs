using com.pdfsearch.Core;
using com.pdfsearch.Models;
using System.DirectoryServices.AccountManagement;
using System.Runtime.InteropServices;

namespace com.pdfsearch;

public partial class frmLogin : Form
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

    public frmLogin()
    {
        InitializeComponent();
        btnClose.Click += (s, e) => Close();
        btnExit.Click += (s, e) => Close();
    }

    private void frmLogin_Load(object sender, EventArgs e)
    {
        using var context = new AppDbContext();
        context.Database.EnsureCreated();

        txtDomainName.Text = Environment.UserDomainName;
        txtDomainUserName.Text = Environment.UserName;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        //DialogResult = DialogResult.OK;
        string domain = Environment.UserDomainName;
        string username = Environment.UserName;

        // Check if the current user is part of the domain
        if (IsUserPartOfDomain(domain, username))
        {
            using var context = new AppDbContext();
            var user = context.Users.FirstOrDefault(u => u.Username.Trim() == txtDomainUserName.Text.Trim());

            if (user != null)
            {
                if (!user.IsAuthorized)
                {
                    MessageBox.Show($"Access is denied for user [{user.Username}].", "ACCESS DENIED!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }

            SaveUserToDatabase(username);
            DialogResult = DialogResult.OK;
        }
        else
            MessageBox.Show($"User [{username}] is not part of the domain [{domain}] or not authorized.");
    }

    private bool IsUserPartOfDomain(string domain, string username)
    {
        try
        {
            using PrincipalContext context = new(ContextType.Domain, domain);
            UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
            // If the user is found in the domain, return true
            return user != null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error checking domain membership: {ex.Message}");
            // If there's an issue (e.g., machine is not part of a domain), return false
            return false;
        }
    }

    // Save user details to SQLite database
    void SaveUserToDatabase(string domainUserName)
    {
        using var db = new AppDbContext();
        var userExists = db.Users.FirstOrDefault(u => u.Username == txtDomainUserName.Text);

        if (userExists == null)
        {
            var user = new User
            {
                Username = domainUserName,
                IsAuthorized = true
            };
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
