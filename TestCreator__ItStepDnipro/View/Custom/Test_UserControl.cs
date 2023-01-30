using System;
using System.Drawing;
using System.Windows.Forms;
using TestCreator__ItStepDnipro.Controller;

namespace TestCreator__ItStepDnipro.View.Custom
{
    public partial class Test_UserControl : UserControl
    {
        protected readonly int STANDART_SIZE = 30;
        protected readonly int SELECT_SIZE = 100;

        protected readonly Color STANDART_COLOR = Color.AntiqueWhite;
        protected readonly Color SELECT_COLOR = Color.BlanchedAlmond;

        protected TestController testController = null;

        public Test_UserControl(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
            Question_TB.Focus();
        }
        private void TB_Enter(object sender, EventArgs e)
        {
            (sender as Control).Height = SELECT_SIZE;
            if (sender is CheckBox)
                (sender as CheckBox).BackColor = SELECT_COLOR;
            else
                (sender as Control).BackColor = SELECT_COLOR;

        }
        private void TB_Leave(object sender, EventArgs e)
        {
            (sender as Control).Height = STANDART_SIZE;
            (sender as Control).BackColor = Color.Empty;
            if (sender is CheckBox)
                SetChColorByState((sender as CheckBox));
        }

        private void ClearFiedls()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].BackColor = Color.Empty;
                if (this.Controls[i] is TextBox)
                    this.Controls[i].Text = String.Empty;
                if (this.Controls[i] is CheckBox)
                    (this.Controls[i] as CheckBox).Checked = false;
            }
        }
        private void AddQuestion()
        {
            var q = new Model.Question(0, this.Question_TB.Text);
            q.Answers.Add(new Model.Answer(1, this.Ans_1_TB.Text, this.Ans_1_CB.Checked));
            q.Answers.Add(new Model.Answer(2, this.Ans_2_TB.Text, this.Ans_2_CB.Checked));
            q.Answers.Add(new Model.Answer(3, this.Ans_3_TB.Text, this.Ans_3_CB.Checked));
            q.Answers.Add(new Model.Answer(4, this.Ans_4_TB.Text, this.Ans_4_CB.Checked));
            testController.AddQueesiont(q);
            this.Question_TB.Focus();
        }
        private void AddQuestion_Btn_Click(object sender, EventArgs e)
        {

            AddQuestion();
            ClearFiedls();
        }

        private void PrevQuestion_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Finish_Btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finish test and save?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AddQuestion();
                using (SaveForm form = new SaveForm(testController))
                {
                    form.ShowDialog();
                }
            }
        }

        private void CB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
                SetChColorByState((sender as CheckBox));
            }
        }

        private void SetChColorByState(CheckBox checkBox)
        {
            checkBox.BackColor = (checkBox.Checked == true) ? Color.PaleGreen : Color.IndianRed;
        }
    }
}
