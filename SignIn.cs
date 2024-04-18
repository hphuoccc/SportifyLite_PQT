using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace login_register
{
    public partial class Login : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "CkIjEA3D7s7dxH1BWr0WF4VcU0ab7M068ojHUlDG",
            BasePath = "https://loginandregister-f73c6-default-rtdb.asia-southeast1.firebasedatabase.app/",
        };
        public Login()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            // Xác thực thông tin đăng nhập
            if (await IsValidLogin(username, password))
            {
                // Hiển thị thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");

                // Chuyển đến trang chủ
                // ...

            }
            else
            {
                // Hiển thị thông báo lỗi đăng nhập
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }

        private async Task<bool> IsValidLogin(string username, string password)
        {
            FirebaseResponse usernameResponse = await client.GetAsync("users/" + username);
            if (usernameResponse.Body != "null")
            {
                var data = usernameResponse.ResultAs<UserData>();
                if (data.password == password)
                {
                    return true;
                }
            }

            return false;
        }
        private void btnCTSU_Click(object sender, EventArgs e)
        {

            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

    }
    
}
