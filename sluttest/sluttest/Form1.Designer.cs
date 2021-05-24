
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
            this.members_listbox = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.todo_dataGridView = new System.Windows.Forms.DataGridView();
            this.add_member = new System.Windows.Forms.Button();
            this.add_todo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.todo_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // members_listbox
            // 
            this.members_listbox.FormattingEnabled = true;
            this.members_listbox.Location = new System.Drawing.Point(12, 12);
            this.members_listbox.Name = "members_listbox";
            this.members_listbox.Size = new System.Drawing.Size(120, 199);
            this.members_listbox.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(562, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // todo_dataGridView
            // 
            this.todo_dataGridView.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.todo_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todo_dataGridView.Location = new System.Drawing.Point(148, 12);
            this.todo_dataGridView.Name = "todo_dataGridView";
            this.todo_dataGridView.Size = new System.Drawing.Size(402, 199);
            this.todo_dataGridView.TabIndex = 2;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_todo);
            this.Controls.Add(this.add_member);
            this.Controls.Add(this.todo_dataGridView);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.members_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.todo_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox members_listbox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView todo_dataGridView;
        private System.Windows.Forms.Button add_member;
        private System.Windows.Forms.Button add_todo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

