using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CilientApp1
{
    public partial class Form1 : Form
    {
        public string ExamCode = null;
        List<Question> listQuestion = null;
        List<string> qID = null;
        Question CurrentQuestion = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            ExamCode = lg.Current;
                this.Text = "Welcome to:" + lg.UserName;
            LoadQuestionID(ExamCode);
            LoadQuestion();
        }
        private void LoadQuestion()
        {
            ListQuestion = new List<Question>();
            CilientModel CModel = new CilientModel();
            foreach(var item in qID)
            {
                listQuestion.Add(CModel.GetQuestionByID(item));

            }
        }
        private void LoadQuestionID(string ExamCode)
        {
            CilientModel CModel = new CilientModel();
            qID = CModel.GetQuestionByExam(ExamCode);
            foreach(var item in qID)
           {
                listQuestion.Items.Add(item);
            }
        }
        private void lbQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lbQL.SelectedItem.ToString();
            foreach(var item in listQuestion)
            {
                if (item.ID.Equals(id))
                    CurrentQuestion = item;
            }
            rtContent.Text = CurrentQuestion.Content;
            txtrdA.Text = CurrentQuestion.A;
            txtrdB.Text = CurrentQuestion.B;
            txtrdC.Text = CurrentQuestion.C;
            txtrdD.Text = CurrentQuestion.D;
            if(CurrentQuestion.Choice=null)
            {
                rdA.Checked = false;
                rdB.Checked = false;
                rdC.Checked = false;
                rdD.Checked = false;
            }
            else
            {

                if (CurrentQuestion.Choice.Equals("_a"))
                    rdA.Checked = true;
                if (CurrentQuestion.Choice.Equals("_b"))
                    rdB.Checked = true;
                if (CurrentQuestion.Choice.Equals("_c"))
                    rdC.Checked = true;
                if (CurrentQuestion.Choice.Equals("_d"))
                    rdD.Checked = true;
            }

        }
    }
}
