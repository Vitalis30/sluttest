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

        BindingList<Member> users = new BindingList<Member>();
        public Form1()
        {
            InitializeComponent();
            users.Add(new Member("vit01", "Vitalis Victorzon"));
            users.Add(new Member("vit02", "Vitalis Victorzon"));
            users.Add(new Member("vit03", "Vitalis Victorzon"));

            members_listbox.DataSource = users;
            //tasks_n_time_bindingSource.DataSource = (Member)members_listbox.SelectedIndexChanged
        }

        private void add_member_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();

            DialogResult dresult = addUser.ShowDialog();

            if (dresult == DialogResult.OK)
            {
                Member newuser = addUser.newUser;
                users.Add(newuser);
            }
        }

        private void add_todo_Click(object sender, EventArgs e)
        {
            AddToDo addToDo = new AddToDo();

            DialogResult dr = addToDo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Member u = (Member)members_listbox.SelectedValue;
                u.tasks.Add(addToDo.tlist);
            }
        }

        private void changeMember(object sender, EventArgs e)
        {
            Member temp = (Member)members_listbox.SelectedValue;
            taskListaBindingSource.DataSource = temp.tasks;
            //todo_dataGridView.Refresh();//.Invalidate();
        }
    }
}