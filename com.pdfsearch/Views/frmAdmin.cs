using com.pdfsearch.Core;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace com.pdfsearch.Views;

public partial class frmAdmin : Form
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

    public frmAdmin()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e) => Close();

    private async void frmAdmin_Load(object sender, EventArgs e)
    {
        await GetData();
    }

    private async Task GetData()
    {
        var context = new AppDbContext();
        dgvMain.DataSource = await context.Users.ToListAsync();
    }

    private async void dgvMain_DoubleClick(object sender, EventArgs e)
    {
        using var context = new AppDbContext();
        var _id = (int)dgvMain.CurrentRow.Cells[0].Value;

        if (_id < 1) return;

        var user = context.Users.Find(_id);

        if (user == null) return;

        var frm = new frmManageUser { _user = user };

        if (frm.ShowDialog() == DialogResult.OK)
            await GetData();
    }
}