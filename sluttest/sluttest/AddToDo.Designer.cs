
namespace sluttest
{
    partial class AddToDo
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
            this.taskText_txtbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addTask_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskText_txtbox
            // 
            this.taskText_txtbox.Location = new System.Drawing.Point(12, 12);
            this.taskText_txtbox.Multiline = true;
            this.taskText_txtbox.Name = "taskText_txtbox";
            this.taskText_txtbox.Size = new System.Drawing.Size(288, 172);
            this.taskText_txtbox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 1, 16, 53, 3, 0);
            // 
            // addTask_btn
            // 
            this.addTask_btn.Location = new System.Drawing.Point(434, 211);
            this.addTask_btn.Name = "addTask_btn";
            this.addTask_btn.Size = new System.Drawing.Size(83, 26);
            this.addTask_btn.TabIndex = 5;
            this.addTask_btn.Text = "Add task";
            this.addTask_btn.UseVisualStyleBackColor = true;
            this.addTask_btn.Click += new System.EventHandler(this.addTask_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(345, 211);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(83, 26);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // AddToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 249);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.addTask_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.taskText_txtbox);
            this.Name = "AddToDo";
            this.Text = "AddToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskText_txtbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addTask_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}