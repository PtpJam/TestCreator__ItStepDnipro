using System.Collections.Generic;
using System.Windows.Forms;
using TestCreator__ItStepDnipro.Controller;
using TestCreator__ItStepDnipro.View.Custom;

namespace TestCreator__ItStepDnipro
{
    public partial class StartForm : Form
    {
        List<UserControl> userControls = new List<UserControl>();
        protected TestController testController = null;
        Button next_BTN;
        int controlIndex = -1;
        public StartForm()
        {
            InitializeComponent();

            testController = new TestController("");

            InitUserControls();

            nextControl();
        }

        public void InitUserControls()
        {
            userControls.Clear();
            userControls.Add(new Auth_UserControl(testController));
            userControls.Add(new TestName_UserControl(testController));
            userControls.Add(new Test_UserControl(testController));
        }

        private void Next_Btn_Click(object sender, System.EventArgs e)
        {
            nextControl();
        }

        protected void nextControl()
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(userControls[++controlIndex]);
            if (controlIndex + 1 < userControls.Count)
            {

                CreateNextBtn();
            }
        }
        public void CreateNextBtn()
        {
            next_BTN = new Button()
            {
                Text = " ===> ",
                Location = new System.Drawing.Point(513, 100)
            };
            next_BTN.Click += Next_Btn_Click;
            panel1.Controls.Add(next_BTN);
        }
        private void infoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new AboutBox1().ShowDialog(this);
        }
    }
}
