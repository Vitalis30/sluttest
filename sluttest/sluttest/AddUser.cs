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
    public partial class AddUser : Form
    {
        public Member newUser = new Member();
        public AddUser()
        {
            InitializeComponent();
        }

        private void addMember_btn_Click(object sender, EventArgs e)
        {
            newUser.RealName = realName_txb.Text;
            newUser.Username = username_txb.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
