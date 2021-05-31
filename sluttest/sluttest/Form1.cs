using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sluttest
{
    public partial class Form1 : Form
    {

        BindingList<Member> users = new BindingList<Member>();
        public Form1()
        {
            InitializeComponent();
            GetUsers();

            members_listbox.DataSource = users;
            //tasks_n_time_bindingSource.DataSource = (Member)members_listbox.SelectedIndexChanged
        }

        private void GetUsers()
        {
            MySqlConnection connection = OpenDataReader();

            string sqlsats = "select Username, RLName from users";
            MySqlCommand cmd = new MySqlCommand(sqlsats, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                users.Add(new Member(dataReader.GetString("Username"), dataReader.GetString("RLName")));
            }

            connection.Close();
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
        }
        private static MySqlConnection OpenDataReader()
        {
            string connectionString = "SERVER=localhost;DATABASE=todo;UID=root;PASSWORD=skola123";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}