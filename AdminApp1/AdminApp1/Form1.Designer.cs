namespace AdminApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtQID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtC = new System.Windows.Forms.RichTextBox();
            this.rtD = new System.Windows.Forms.RichTextBox();
            this.rtB = new System.Windows.Forms.RichTextBox();
            this.rtA = new System.Windows.Forms.RichTextBox();
            this.btnCheckID = new System.Windows.Forms.Button();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSearchQE = new System.Windows.Forms.TextBox();
            this.cbStatusQE = new System.Windows.Forms.ComboBox();
            this.btnSearchQE = new System.Windows.Forms.Button();
            this.btnCheckExamCode = new System.Windows.Forms.Button();
            this.cbSubjectQE = new System.Windows.Forms.ComboBox();
            this.txtDateQE = new System.Windows.Forms.TextBox();
            this.txtCheckExamCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpdateQE = new System.Windows.Forms.Button();
            this.btnRandomQE = new System.Windows.Forms.Button();
            this.btnCreateQE = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 697);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1368, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Question Manage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtQID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1292, 287);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 179);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(435, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtQID
            // 
            this.txtQID.Location = new System.Drawing.Point(212, 38);
            this.txtQID.Multiline = true;
            this.txtQID.Name = "txtQID";
            this.txtQID.Size = new System.Drawing.Size(164, 32);
            this.txtQID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(1091, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(588, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.rtC);
            this.groupBox1.Controls.Add(this.rtD);
            this.groupBox1.Controls.Add(this.rtB);
            this.groupBox1.Controls.Add(this.rtA);
            this.groupBox1.Controls.Add(this.btnCheckID);
            this.groupBox1.Controls.Add(this.cbSubject);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdD);
            this.groupBox1.Controls.Add(this.rdC);
            this.groupBox1.Controls.Add(this.rdB);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Controls.Add(this.rtContent);
            this.groupBox1.Location = new System.Drawing.Point(30, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1292, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Detail";
            // 
            // rtC
            // 
            this.rtC.Location = new System.Drawing.Point(558, 136);
            this.rtC.Name = "rtC";
            this.rtC.Size = new System.Drawing.Size(561, 29);
            this.rtC.TabIndex = 8;
            this.rtC.Text = "";
            // 
            // rtD
            // 
            this.rtD.Location = new System.Drawing.Point(564, 195);
            this.rtD.Name = "rtD";
            this.rtD.Size = new System.Drawing.Size(555, 31);
            this.rtD.TabIndex = 7;
            this.rtD.Text = "";
            // 
            // rtB
            // 
            this.rtB.Location = new System.Drawing.Point(558, 75);
            this.rtB.Name = "rtB";
            this.rtB.Size = new System.Drawing.Size(555, 31);
            this.rtB.TabIndex = 7;
            this.rtB.Text = "";
            // 
            // rtA
            // 
            this.rtA.Location = new System.Drawing.Point(558, 29);
            this.rtA.Name = "rtA";
            this.rtA.Size = new System.Drawing.Size(555, 31);
            this.rtA.TabIndex = 7;
            this.rtA.Text = "";
            // 
            // btnCheckID
            // 
            this.btnCheckID.Location = new System.Drawing.Point(274, 29);
            this.btnCheckID.Name = "btnCheckID";
            this.btnCheckID.Size = new System.Drawing.Size(75, 23);
            this.btnCheckID.TabIndex = 6;
            this.btnCheckID.Text = "Check ID";
            this.btnCheckID.UseVisualStyleBackColor = true;
            this.btnCheckID.Click += new System.EventHandler(this.btnCheckID_Click);
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Items.AddRange(new object[] {
            "Topnotch 1",
            "Topnotch 2",
            "Topnotch 3",
            "Summit 1"});
            this.cbSubject.Location = new System.Drawing.Point(115, 75);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 24);
            this.cbSubject.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(489, 205);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(39, 21);
            this.rdD.TabIndex = 1;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(489, 144);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(38, 21);
            this.rdC.TabIndex = 1;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(489, 92);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(38, 21);
            this.rdB.TabIndex = 1;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdA.Location = new System.Drawing.Point(479, 39);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(38, 21);
            this.rdA.TabIndex = 1;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(25, 136);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(437, 115);
            this.rtContent.TabIndex = 0;
            this.rtContent.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage2.Controls.Add(this.txtSearchQE);
            this.tabPage2.Controls.Add(this.cbStatusQE);
            this.tabPage2.Controls.Add(this.btnSearchQE);
            this.tabPage2.Controls.Add(this.btnCheckExamCode);
            this.tabPage2.Controls.Add(this.cbSubjectQE);
            this.tabPage2.Controls.Add(this.txtDateQE);
            this.tabPage2.Controls.Add(this.txtCheckExamCode);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnUpdateQE);
            this.tabPage2.Controls.Add(this.btnRandomQE);
            this.tabPage2.Controls.Add(this.btnCreateQE);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1368, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Question Exam";
            // 
            // txtSearchQE
            // 
            this.txtSearchQE.Location = new System.Drawing.Point(277, 319);
            this.txtSearchQE.Name = "txtSearchQE";
            this.txtSearchQE.Size = new System.Drawing.Size(100, 22);
            this.txtSearchQE.TabIndex = 7;
            // 
            // cbStatusQE
            // 
            this.cbStatusQE.FormattingEnabled = true;
            this.cbStatusQE.Items.AddRange(new object[] {
            "Waiting",
            "Doing",
            "Done"});
            this.cbStatusQE.Location = new System.Drawing.Point(277, 204);
            this.cbStatusQE.Name = "cbStatusQE";
            this.cbStatusQE.Size = new System.Drawing.Size(121, 24);
            this.cbStatusQE.TabIndex = 6;
            // 
            // btnSearchQE
            // 
            this.btnSearchQE.Location = new System.Drawing.Point(405, 319);
            this.btnSearchQE.Name = "btnSearchQE";
            this.btnSearchQE.Size = new System.Drawing.Size(75, 23);
            this.btnSearchQE.TabIndex = 5;
            this.btnSearchQE.Text = "Search";
            this.btnSearchQE.UseVisualStyleBackColor = true;
            this.btnSearchQE.Click += new System.EventHandler(this.btnSearchQE_Click);
            // 
            // btnCheckExamCode
            // 
            this.btnCheckExamCode.Location = new System.Drawing.Point(570, 28);
            this.btnCheckExamCode.Name = "btnCheckExamCode";
            this.btnCheckExamCode.Size = new System.Drawing.Size(75, 23);
            this.btnCheckExamCode.TabIndex = 5;
            this.btnCheckExamCode.Text = "Check";
            this.btnCheckExamCode.UseVisualStyleBackColor = true;
            this.btnCheckExamCode.Click += new System.EventHandler(this.btnCheckIDE_Click);
            // 
            // cbSubjectQE
            // 
            this.cbSubjectQE.FormattingEnabled = true;
            this.cbSubjectQE.Items.AddRange(new object[] {
            "Topnotch 1",
            "Topnotch 2",
            "Topnotch 3",
            "Summit 1"});
            this.cbSubjectQE.Location = new System.Drawing.Point(277, 80);
            this.cbSubjectQE.Name = "cbSubjectQE";
            this.cbSubjectQE.Size = new System.Drawing.Size(265, 24);
            this.cbSubjectQE.TabIndex = 4;
            // 
            // txtDateQE
            // 
            this.txtDateQE.Location = new System.Drawing.Point(277, 137);
            this.txtDateQE.Name = "txtDateQE";
            this.txtDateQE.Size = new System.Drawing.Size(265, 22);
            this.txtDateQE.TabIndex = 3;
            // 
            // txtCheckExamCode
            // 
            this.txtCheckExamCode.Location = new System.Drawing.Point(277, 29);
            this.txtCheckExamCode.Name = "txtCheckExamCode";
            this.txtCheckExamCode.Size = new System.Drawing.Size(265, 22);
            this.txtCheckExamCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Exam Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, -279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(119, 364);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 279);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnUpdateQE
            // 
            this.btnUpdateQE.Location = new System.Drawing.Point(666, 318);
            this.btnUpdateQE.Name = "btnUpdateQE";
            this.btnUpdateQE.Size = new System.Drawing.Size(111, 23);
            this.btnUpdateQE.TabIndex = 0;
            this.btnUpdateQE.Text = "UPDATE";
            this.btnUpdateQE.UseVisualStyleBackColor = true;
            this.btnUpdateQE.Click += new System.EventHandler(this.btnUpdateQE_Click);
            // 
            // btnRandomQE
            // 
            this.btnRandomQE.Location = new System.Drawing.Point(614, 80);
            this.btnRandomQE.Name = "btnRandomQE";
            this.btnRandomQE.Size = new System.Drawing.Size(115, 42);
            this.btnRandomQE.TabIndex = 0;
            this.btnRandomQE.Text = "Random";
            this.btnRandomQE.UseVisualStyleBackColor = true;
            this.btnRandomQE.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCreateQE
            // 
            this.btnCreateQE.Location = new System.Drawing.Point(277, 269);
            this.btnCreateQE.Name = "btnCreateQE";
            this.btnCreateQE.Size = new System.Drawing.Size(75, 23);
            this.btnCreateQE.TabIndex = 0;
            this.btnCreateQE.Text = "CREATE";
            this.btnCreateQE.UseVisualStyleBackColor = true;
            this.btnCreateQE.Click += new System.EventHandler(this.btnCreateQE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 741);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtQID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckID;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtD;
        private System.Windows.Forms.RichTextBox rtB;
        private System.Windows.Forms.RichTextBox rtA;
        private System.Windows.Forms.RichTextBox rtC;
        private System.Windows.Forms.TextBox txtDateQE;
        private System.Windows.Forms.TextBox txtCheckExamCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpdateQE;
        private System.Windows.Forms.Button btnRandomQE;
        private System.Windows.Forms.Button btnCreateQE;
        private System.Windows.Forms.ComboBox cbSubjectQE;
        private System.Windows.Forms.Button btnSearchQE;
        private System.Windows.Forms.Button btnCheckExamCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStatusQE;
        private System.Windows.Forms.TextBox txtSearchQE;
    }
}

