using System;
using System.Windows.Forms;
using TestCreator__ItStepDnipro.Controller;

namespace TestCreator__ItStepDnipro.View.Custom
{
    public partial class TestName_UserControl : UserControl
    {
        protected TestController testController = null;

        public TestName_UserControl(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
            TestName_TB.Focus();
        }

        private void TestName_TB_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TestName_TB.Text))
            {
                testController.TestProperty.Name = TestName_TB.Text;
            }

        }
    }
}
