
namespace sluttest
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.realName_txb = new System.Windows.Forms.TextBox();
            this.username_txb = new System.Windows.Forms.TextBox();
            this.addMember_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "username";
            // 
            // realName_txb
            // 
            this.realName_txb.Location = new System.Drawing.Point(99, 21);
            this.realName_txb.Name = "realName_txb";
            this.realName_txb.Size = new System.Drawing.Size(166, 20);
            this.realName_txb.TabIndex = 2;
            // 
            // username_txb
            // 
            this.username_txb.Location = new System.Drawing.Point(99, 50);
            this.username_txb.Name = "username_txb";
            this.username_txb.Size = new System.Drawing.Size(166, 20);
            this.username_txb.TabIndex = 3;
            // 
            // addMember_btn
            // 
            this.addMember_btn.Location = new System.Drawing.Point(182, 76);
            this.addMember_btn.Name = "addMember_btn";
            this.addMember_btn.Size = new System.Drawing.Size(83, 26);
            this.addMember_btn.TabIndex = 4;
            this.addMember_btn.Text = "Add user";
            this.addMember_btn.UseVisualStyleBackColor = true;
            this.addMember_btn.Click += new System.EventHandler(this.addMember_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(99, 76);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(83, 26);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.addMember_btn);
            this.Controls.Add(this.username_txb);
            this.Controls.Add(this.realName_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox realName_txb;
        private System.Windows.Forms.TextBox username_txb;
        private System.Windows.Forms.Button addMember_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}