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
    public partial class AddToDo : Form
    {
        public TaskLista tlist;
        string task;
        DateTime taskDue;
        public AddToDo()
        {
            InitializeComponent();
        }

        private void addTask_btn_Click(object sender, EventArgs e)
        {
            task = taskText_txtbox.Text;
            taskDue = dateTimePicker1.Value;
            tlist = new TaskLista(task, taskDue);
            this.DialogResult = DialogResult.OK;
        }
    }
}
