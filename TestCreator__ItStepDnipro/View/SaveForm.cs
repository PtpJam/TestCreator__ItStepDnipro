using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TestCreator__ItStepDnipro.Adapters;
using TestCreator__ItStepDnipro.Controller;

namespace TestCreator__ItStepDnipro.View
{
    public partial class SaveForm : Form
    {
        TestController testController;
        public SaveForm(TestController testController)
        {
            InitializeComponent();
            this.testController = testController;
        }

        private void Return_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveTXT_Btn_Click(object sender, EventArgs e)
        {
            new SaveController().Save(testController.getTest(), new TestToTxtAdapter());
            Process.Start(Directory.GetCurrentDirectory());
        }

        private void SaveJSON_Btn_Click(object sender, EventArgs e)
        {
            new SaveController().Save(testController.getTest(), new TestToJsonAdapter());
            Process.Start(Directory.GetCurrentDirectory());
        }
    }
}
