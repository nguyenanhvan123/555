namespace CilientApp1
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExamCodeTest = new System.Windows.Forms.TextBox();
            this.txtUserNameTest = new System.Windows.Forms.TextBox();
            this.txtPassWordTest = new System.Windows.Forms.TextBox();
            this.btnLoginTest = new System.Windows.Forms.Button();
            this.btnExitTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Exam Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "PassWord";
            // 
            // txtExamCodeTest
            // 
            this.txtExamCodeTest.Location = new System.Drawing.Point(149, 64);
            this.txtExamCodeTest.Name = "txtExamCodeTest";
            this.txtExamCodeTest.Size = new System.Drawing.Size(100, 22);
            this.txtExamCodeTest.TabIndex = 1;
            // 
            // txtUserNameTest
            // 
            this.txtUserNameTest.Location = new System.Drawing.Point(149, 155);
            this.txtUserNameTest.Name = "txtUserNameTest";
            this.txtUserNameTest.Size = new System.Drawing.Size(100, 22);
            this.txtUserNameTest.TabIndex = 1;
            // 
            // txtPassWordTest
            // 
            this.txtPassWordTest.Location = new System.Drawing.Point(137, 239);
            this.txtPassWordTest.Name = "txtPassWordTest";
            this.txtPassWordTest.Size = new System.Drawing.Size(100, 22);
            this.txtPassWordTest.TabIndex = 1;
            // 
            // btnLoginTest
            // 
            this.btnLoginTest.Location = new System.Drawing.Point(233, 333);
            this.btnLoginTest.Name = "btnLoginTest";
            this.btnLoginTest.Size = new System.Drawing.Size(75, 23);
            this.btnLoginTest.TabIndex = 2;
            this.btnLoginTest.Text = "Login";
            this.btnLoginTest.UseVisualStyleBackColor = true;
            this.btnLoginTest.Click += new System.EventHandler(this.btnLoginTest_Click);
            // 
            // btnExitTest
            // 
            this.btnExitTest.Location = new System.Drawing.Point(575, 333);
            this.btnExitTest.Name = "btnExitTest";
            this.btnExitTest.Size = new System.Drawing.Size(75, 23);
            this.btnExitTest.TabIndex = 2;
            this.btnExitTest.Text = "Exit";
            this.btnExitTest.UseVisualStyleBackColor = true;
            this.btnExitTest.Click += new System.EventHandler(this.btnExitTest_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitTest);
            this.Controls.Add(this.btnLoginTest);
            this.Controls.Add(this.txtPassWordTest);
            this.Controls.Add(this.txtUserNameTest);
            this.Controls.Add(this.txtExamCodeTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExamCodeTest;
        private System.Windows.Forms.TextBox txtUserNameTest;
        private System.Windows.Forms.TextBox txtPassWordTest;
        private System.Windows.Forms.Button btnLoginTest;
        private System.Windows.Forms.Button btnExitTest;
    }
}