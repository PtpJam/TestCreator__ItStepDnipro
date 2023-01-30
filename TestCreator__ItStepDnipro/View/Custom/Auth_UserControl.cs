using System;
using System.Windows.Forms;
using TestCreator__ItStepDnipro.Controller;

namespace TestCreator__ItStepDnipro.View.Custom
{
    public partial class Auth_UserControl : UserControl
    {
        protected TestController testController = null;

        public Auth_UserControl(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
            Login_TB.Focus();
        }
        private void Login_TB_KeyDown(object sender, KeyEventArgs e)
        {
            this.testController.TestProperty.Autor = Login_TB.Text;
        }

        private void Cancel_Btn_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }

        //private void Go_Btn_Click(object sender, EventArgs e) => ShowTestForm();

        //public void ShowTestForm()
        //{
        //    new TestName_UserControl(testController).Show();
        //}
    }
}
