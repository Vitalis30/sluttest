
namespace sluttest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.members_listbox = new System.Windows.Forms.ListBox();
            this.add_member = new System.Windows.Forms.Button();
            this.add_todo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tasks_n_time_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.todo_dataGridView = new System.Windows.Forms.DataGridView();
            this.taskListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tasks_n_time_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // members_listbox
            // 
            this.members_listbox.FormattingEnabled = true;
            this.members_listbox.Location = new System.Drawing.Point(12, 12);
            this.members_listbox.Name = "members_listbox";
            this.members_listbox.Size = new System.Drawing.Size(120, 199);
            this.members_listbox.TabIndex = 0;
            this.members_listbox.SelectedIndexChanged += new System.EventHandler(this.changeMember);
            // 
            // add_member
            // 
            this.add_member.Location = new System.Drawing.Point(12, 217);
            this.add_member.Name = "add_member";
            this.add_member.Size = new System.Drawing.Size(75, 23);
            this.add_member.TabIndex = 3;
            this.add_member.Text = "Add member";
            this.add_member.UseVisualStyleBackColor = true;
            this.add_member.Click += new System.EventHandler(this.add_member_Click);
            // 
            // add_todo
            // 
            this.add_todo.Location = new System.Drawing.Point(93, 217);
            this.add_todo.Name = "add_todo";
            this.add_todo.Size = new System.Drawing.Size(75, 23);
            this.add_todo.TabIndex = 4;
            this.add_todo.Text = "add todo";
            this.add_todo.UseVisualStyleBackColor = true;
            this.add_todo.Click += new System.EventHandler(this.add_todo_Click);
            // 
            // todo_dataGridView
            // 
            this.todo_dataGridView.AutoGenerateColumns = false;
            this.todo_dataGridView.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.todo_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todo_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.todo_dataGridView.DataSource = this.taskListaBindingSource;
            this.todo_dataGridView.Location = new System.Drawing.Point(138, 12);
            this.todo_dataGridView.Name = "todo_dataGridView";
            this.todo_dataGridView.Size = new System.Drawing.Size(402, 199);
            this.todo_dataGridView.TabIndex = 2;
            // 
            // taskListaBindingSource
            // 
            this.taskListaBindingSource.DataSource = typeof(sluttest.TaskLista);
            // 
            // taskDataGridViewTextBoxColumn
            // 
            this.taskDataGridViewTextBoxColumn.DataPropertyName = "Task";
            this.taskDataGridViewTextBoxColumn.HeaderText = "Task";
            this.taskDataGridViewTextBoxColumn.Name = "taskDataGridViewTextBoxColumn";
            this.taskDataGridViewTextBoxColumn.Width = 245;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.Width = 114;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.add_todo);
            this.Controls.Add(this.add_member);
            this.Controls.Add(this.todo_dataGridView);
            this.Controls.Add(this.members_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tasks_n_time_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todo_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskListaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox members_listbox;
        private System.Windows.Forms.Button add_member;
        private System.Windows.Forms.Button add_todo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource tasks_n_time_bindingSource;
        private System.Windows.Forms.DataGridView todo_dataGridView;
        private System.Windows.Forms.BindingSource taskListaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
    }
}

