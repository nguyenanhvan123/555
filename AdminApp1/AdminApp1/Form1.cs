using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp1
{
    public partial class Form1 : Form
    {
        List<Question> list = null;
        public Staff user = null;
        private bool addFlag = false;
        private bool addCkeck = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            user = lg.CurrentUser;
            if(user!=null)
            this.Text = "Welcome to:" + user.UserName;
        }
        private void btnCheckID_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            AdminModel model = new AdminModel();
            if (model.CheckExist(id) == false)
            {
                MessageBox.Show("ID Question Existed");
            }
            else
            {
                MessageBox.Show("Chua co ma nay nhap di!");
                addCkeck = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!addFlag)
            {
                ResetControl();
            
                btnAdd.Text = "Save";
            }
            else
            {
                if (addCkeck)
                {
                    string id = txtID.Text;
                    string subject = cbSubject.SelectedItem.ToString();
                    string A = rtA.Text;
                    string B = rtB.Text;
                    string C = rtC.Text;
                    string D = rtD.Text;
                    string content = rtContent.Text;
                    string correct = "";
                    if (subject.Equals("Topnotch 1"))
                        subject = "TN1";
                    if (subject.Equals("Topnotch 2"))
                        subject = "TN2";
                    if (subject.Equals("Topnotch 3"))
                        subject = "TN3";
                    if (subject.Equals("Summit 1"))
                        subject = "SUM1";
                    if (rdA.Checked)
                        correct = "_a";
                    if (rdB.Checked)
                        correct = "_b";
                    if (rdC.Checked)
                        correct = "_c";
                    if (rdD.Checked)
                        correct = "_d";
                    AdminModel model = new AdminModel();
                    if (model.AddQuestion(id, content, A, B, C, D, subject, correct))
                        MessageBox.Show("Add Success");
                    else
                        MessageBox.Show("Failed");
                    btnAdd.Text = "Add";
                    ResetControl();
                }
            }
            addFlag = !addFlag;
        }
        private void ResetControl()
        {
            txtID.Text = "";
            txtID.ReadOnly = false;
            rtA.Text = "";
            rtB.Text = "";
            rtC.Text = "";
            rtD.Text = "";
            cbSubject.Text = "";
            rtContent.Text = "";
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            AdminModel model = new AdminModel();
            dataGridView1.DataSource = model.GetQuestion();
            Manage_Exam me = new Manage_Exam();
            dataGridView2.DataSource = me.GetExam();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtID.ReadOnly = true;
            rtContent.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtA.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            rtB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtC.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            rtD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbSubject.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string asw = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (asw.Equals("_a"))
            {
                rdA.Checked = true;
            }
            if (asw.Equals("_b"))
            {
                rdB.Checked = true;
            }
            if (asw.Equals("_c"))
            {
                rdC.Checked = true;
            }
            if (asw.Equals("_d"))
            {
                rdD.Checked = true;
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            AdminModel model = new AdminModel();
            if (model.Delete(id) == true)
            {
                dataGridView1.DataSource = model.GetConnection();
                MessageBox.Show("Delete success");
                ResetGUI();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
            txtID.ReadOnly = false;
        }
        private void ResetGUI()
        {
            txtID.Text = "";
            rtA.Text = "";
            rtB.Text = "";
            rtC.Text = "";
            rtD.Text = "";
            cbSubject.Text = "";
            rtContent.Text = "";
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string content = rtContent.Text;
            string A = rtA.Text;
            string B = rtA.Text;
            string C = rtC.Text;
            string D = rtD.Text;
            string crr = "";
            if (rdA.Checked)
                crr = "_a";
            if (rdB.Checked)
                crr = "_b";
            if (rdC.Checked)
                crr = "_c";
            if (rdD.Checked)
                crr = "_d";
            string subject = cbSubject.Text;
            if (subject.Equals("Topnotch 1"))
                subject = "TN1";
            if (subject.Equals("Topnotch 2"))
                subject = "TN2";
            if (subject.Equals("Topnotch 3"))
                subject = "TN3";
            if (subject.Equals("Summit 1"))
                subject = "SUM1";
            AdminModel dt = new AdminModel();
            if (dt.Update(id, content, A, B, C, D, subject, crr))
            {
                dataGridView1.DataSource = dt.GetConnection();
                ResetGUI();
                MessageBox.Show("Update Success");
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtQID.Text;
            AdminModel model= new AdminModel();
            dataGridView1.DataSource = model.SearchByID(id);
        }

        private void btnCheckIDE_Click(object sender, EventArgs e)
        {
            string id = txtCheckExamCode.Text;
            AdminModel model = new AdminModel();
            if (model.CheckExist(id) == false)
            {
                MessageBox.Show("ID Question Existed");
            }
            else
            {
                MessageBox.Show("Chua co ma nay nhap di!");
                addCkeck = true;
            }
        
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Manage_Exam me = new Manage_Exam();
            string sid = cbSubjectQE.SelectedItem.ToString();
            if (sid.Equals("Topnotch 1"))
                sid = "TN1";
            if (sid.Equals("Topnotch 2"))
                sid = "TN2";
            if (sid.Equals("Topnotch 3"))
                sid = "TN3";
            if (sid.Equals("Summit 1"))
                sid = "SUM1";

            list = me.GetRandomQuestion(sid);
            MessageBox.Show("Load Question Success");
            btnCreateQE.Enabled = true;
        }

        private void btnCreateQE_Click(object sender, EventArgs e)
        {
            string ExamCode = txtCheckExamCode.Text;
            string date = txtDateQE.Text;
            Manage_Exam me = new Manage_Exam();
            if (me.AddExam(ExamCode, date))
            {
                foreach (var item in list)
                    {
                    me.AddExamDetail(ExamCode, item.id);
                }
                MessageBox.Show("Create success!");
            }
            else
                MessageBox.Show("Create failed");
        }

        private void btnUpdateQE_Click(object sender, EventArgs e)
        {

            string id = txtCheckExamCode.Text;
            string date = txtDateQE.Text;
            string status = cbStatusQE.Text;
            Manage_Exam me = new Manage_Exam();
            if (me.UpdateQE(id,date,status))
            {
                dataGridView2.DataSource = me.GetConnection();
                ResetGUI();
                MessageBox.Show("Update Success");
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCheckExamCode.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDateQE.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbStatusQE.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void btnSearchQE_Click(object sender, EventArgs e)
        {
            string id = txtSearchQE.Text;
            Manage_Exam me = new Manage_Exam();
            dataGridView2.DataSource = me.SearchByIDQE(id);
        }
    }
}
 

