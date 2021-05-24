using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sluttest
{
    public partial class Form1 : Form
    {

        List<Member> users = new List<Member>();
        public Form1()
        {
            InitializeComponent();
            users.Add(new Member("vit01", "Vitalis Victorzon"));
            users.Add(new Member("vit02", "Vitalis Victorzon"));
            users.Add(new Member("vit03", "Vitalis Victorzon"));

            members_listbox.DataSource = users;
        }

        private void add_member_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();

            DialogResult dresult = addUser.ShowDialog();

            if (dresult == DialogResult.OK)
            {
                Member newuser = AddUser.newUser;
                users.Add();
            }
        }
    }
}