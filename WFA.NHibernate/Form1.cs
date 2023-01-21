using Models;
using ServiceSample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.NHibernate
{
    public partial class Form1 : Form
    {

        private readonly UserService _userService = new UserService(); 

        public Form1()
        {
            InitializeComponent();

            ListUserFunc();

        }


        public void ListUserFunc()
        {
            List<User> usersList = _userService.GetUsers().ToList();
            dtList.DataSource = usersList;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            User _user = new User
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = int.Parse(txtAge.Text),
                RegisterDate = DateTime.Now
            };
            _userService.USerAdd(_user);
            ListUserFunc();

        }
    }
}
