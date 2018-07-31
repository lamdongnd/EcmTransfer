using log4net;
using System;
using System.Windows.Forms;
using Tpbank.Core.Model;
using TpBank.Core.Componet;

namespace Tpbank.ScanApp
{
    public partial class LoginForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public event EventHandler LoginSuccessFull;
        protected virtual void OnLoginSuccessFull(EventArgs e)
        {
            EventHandler handler = LoginSuccessFull;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public bool IsLoginSuccessFull { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            IsLoginSuccessFull = false;
            InitInfo();
        }

        private void InitInfo()
        {
            
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info("Start login with User: " + txtUserName.Text);
                #region Kiểm tra thông tin đăng nhập
                LoginModel LoginInfo = new LoginModel();
                LoginInfo.Domain = cmbDomain.SelectedItem.ToString();
                LoginInfo.UserName = txtUserName.Text;
                LoginInfo.Password = txtPassword.Text;
                LoginInfo.ProductType = cmbProductType.SelectedItem.ToString();
                LoginInfo.RememberInfo = chkRemember.Checked;
                LoginInfo.Authentication = false;

                #region nếu validate thành công => Lưu thông tin vào config để init khi đăng nhập lần sau
                ApplicationEngine.Option.LoginInfo = LoginInfo;
                ApplicationEngine.Option.LoginInfo.SaveInfo();
                ApplicationEngine.Configuration.SetUserDataFolder(LoginInfo);
                DialogResult = DialogResult.OK;
                #endregion
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbDomain.SelectedIndex = 0;
            foreach (var item in cmbDomain.Items)
            {
                if (item.ToString().Equals(ApplicationEngine.Option.LoginInfo.Domain))
                {
                    cmbDomain.SelectedItem = item;
                    break;
                }
            }
            
            txtUserName.Text = ApplicationEngine.Option.LoginInfo.UserName;
            txtPassword.Text = ApplicationEngine.Option.LoginInfo.Password;
            cmbProductType.SelectedIndex = 0;
            foreach (var item in cmbProductType.Items)
            {
                if (item.ToString().Equals(ApplicationEngine.Option.LoginInfo.ProductType))
                {
                    cmbProductType.SelectedItem = item;
                    break;
                }
            }
            chkRemember.Checked = ApplicationEngine.Option.LoginInfo.RememberInfo;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
