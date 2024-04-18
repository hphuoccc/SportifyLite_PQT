using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class SignUp : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "CkIjEA3D7s7dxH1BWr0WF4VcU0ab7M068ojHUlDG",
            BasePath = "https://loginandregister-f73c6-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        private int currentUserId;
        public SignUp()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            UserIDLogic();
            
        }
        private async void UserIDLogic()
        {
            FirebaseResponse usersResponse = await client.GetAsync("users");
            var usersData = usersResponse.ResultAs<Dictionary<string, UserData>>();

            if (usersData != null && usersData.Count > 0)
            {
                currentUserId = usersData.Values.Max(u => u.userid) + 1;
            }
            else
            {
                currentUserId = 1;
            }
        }
        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            int birthYear;
            if (!int.TryParse(birth.Text, out birthYear))
            {
                             MessageBox.Show("Thông tin không hợp lệ !");
                return;
            }

            // Sử dụng biến birthYear trong đối tượng UserData
            

            UserData userData = new UserData()
            {
                username = txtUser.Text,
                password = txtPass.Text,
                userid = currentUserId,
                realname = realname.Text,
                gender = cmbGender.SelectedItem.ToString(),                
            };
            userData.birthday = birthYear;

            // Xác thực thông tin đăng ký
            if (!IsValidSignUp(userData.username, userData.password))
            {
                MessageBox.Show("Thông tin đăng ký không hợp lệ!");
                return;
            }
            
            FirebaseResponse response = await client.SetAsync("Users/" + userData.username, userData);

            currentUserId++;

            MessageBox.Show("Đăng ký thành công! Mời về trang đăng nhập");

            this.Close();

        }
        private bool IsValidSignUp(string username, string password)
        {
            
            if (cmbGender.SelectedIndex == -1 || password != txtComPass.Text || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(realname.Text) || string.IsNullOrEmpty(birth.Text.ToString()) || string.IsNullOrEmpty( txtComPass.Text) )
            {
               
                return false; 
            }
            else return true;
                      
        }
        

        private void btnCTSI_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

   
}
