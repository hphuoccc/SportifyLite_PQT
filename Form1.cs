using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace showIn4
{
    public partial class In4 : Form
    {
        IFirebaseClient client;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "CkIjEA3D7s7dxH1BWr0WF4VcU0ab7M068ojHUlDG",
            BasePath = "https://loginandregister-f73c6-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        public In4()
        {
            InitializeComponent();
        }
        
        private async void In4_Load(object sender, EventArgs e)     
        {
            // Khởi tạo kết nối Firebase
            client = new FireSharp.FirebaseClient(config);

            // Lấy dữ liệu từ Firebase
            FirebaseResponse response = await client.GetAsync("users/1"); // Thay đổi đường dẫn "users/1" bằng đường dẫn thực tế của dữ liệu bạn muốn lấy

            // Kiểm tra phản hồi từ Firebase
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Parse dữ liệu từ phản hồi
                User user = response.ResultAs<User>(); // Giả sử User là một lớp đại diện cho dữ liệu người dùng

                // Hiển thị thông tin người dùng trên các thành phần giao diện người dùng
                name.Text = user.realname;
                id.Text = user.userid.ToString();
                birth.Text = user.birthday.ToString();
                gender.Text = user.gender;
            }
            else
            {
                // Xử lý trường hợp không thành công khi lấy dữ liệu từ Firebase
                MessageBox.Show("Failed to retrieve data from Firebase.");
            }
        }
    }
  
}
