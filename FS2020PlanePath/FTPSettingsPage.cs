using System;
using System.Windows.Forms;

namespace FS2020PlanePath
{
    public partial class FTPSettingsPage : Form
    {
        private FTPSettings _FTPSettings = new FTPSettings();

        public FTPSettingsPage()
        {
            InitializeComponent();
        }

        private void FTPSettingsPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tbHost.Text = _FTPSettings.Host;
            tbPort.Text = _FTPSettings.Port.ToString();
            tbPath.Text = _FTPSettings.Path;
            tbUsername.Text = _FTPSettings.UserName;
            tbPassword.Text = _FTPSettings.Password;
            cbUseSFTP.Checked = _FTPSettings.UseSFTP;
        }

        private void SaveData()
        {
            _FTPSettings.Host = tbHost.Text;
            _FTPSettings.Port = Convert.ToUInt16(tbPort.Text);
            _FTPSettings.Path = tbPath.Text;
            _FTPSettings.UserName = tbUsername.Text;
            _FTPSettings.Password = tbPassword.Text;
            _FTPSettings.UseSFTP = cbUseSFTP.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void cbUseSFTP_Click(object sender, EventArgs e)
        {
            // Sets the default port based on protocol selection
            if ((tbPort.Text == "" || tbPort.Text == "21") && cbUseSFTP.Checked)
            {
                tbPort.Text = "22";
            }
            else if ((tbPort.Text == "" || tbPort.Text == "22") && !cbUseSFTP.Checked)
            {
                tbPort.Text = "21";
            }
        }
    }
}
