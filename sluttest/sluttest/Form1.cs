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

            GetServerData("select Username, RLName from users", null);

            members_listbox.DataSource = users;
            //tasks_n_time_bindingSource.DataSource = (Member)members_listbox.SelectedIndexChanged
        }

        private void GetServerData(string sqlsats, Member member)
        {
            MySqlConnection connection = OpenDataReader();

            MySqlCommand cmd = new MySqlCommand(sqlsats, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (member==null)
            {
                while (dataReader.Read())
                {
                    users.Add(new Member(dataReader.GetString("Username"), dataReader.GetString("RLName")));
                }
            }
            else
            {
                member.tasks.Clear();
                while (dataReader.Read())
                {
                    member.tasks.Add(new TaskLista(dataReader.GetString("task"),dataReader.GetDateTime("dueDate")));
                }
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
                AddUserToServer(newuser);
                users.Add(newuser);
            }
        }

        private static void AddUserToServer(Member newuser)
        {
            MySqlConnection connection = OpenDataReader();

            string sqlsats = "Insert into users (Username, RLName) values (\'" + newuser.Username + "\',\'" + newuser.RealName + "\')";
            MySqlCommand cmd = new MySqlCommand(sqlsats, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            connection.Close();
        }

        private void add_todo_Click(object sender, EventArgs e)
        {
            AddToDo addToDo = new AddToDo();

            DialogResult dr = addToDo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Member member = (Member)members_listbox.SelectedValue;
                addToDo.tlist.DueDate = addToDo.tlist.DueDate.Date;
                MySqlConnection connection = OpenDataReader();

                string sqlsats = "Insert into tasks (username, task, dueDate) values (\'" + member.Username + "\',\'" + addToDo.tlist.Task + "\',\'"+addToDo.tlist.DueDate+" \')";
                MySqlCommand cmd = new MySqlCommand(sqlsats, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                connection.Close();
                member.tasks.Add(addToDo.tlist);
            }
        }

        private void changeMember(object sender, EventArgs e)
        {
            Member temp = (Member)members_listbox.SelectedValue;
            taskListaBindingSource.DataSource = temp.tasks; 
            GetServerData("select task, dueDate from tasks where username = \'" + temp.Username + "\'", temp);

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