namespace TestCreator__ItStepDnipro.View.Custom
{
    partial class TestName_UserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestName_UserControl));
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestName_TB = new System.Windows.Forms.TextBox();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestNameLabel
            // 
            resources.ApplyResources(this.TestNameLabel, "TestNameLabel");
            this.TestNameLabel.Name = "TestNameLabel";
            // 
            // TestName_TB
            // 
            resources.ApplyResources(this.TestName_TB, "TestName_TB");
            this.TestName_TB.Name = "TestName_TB";
            this.TestName_TB.Leave += new System.EventHandler(this.TestName_TB_Leave);
            // 
            // Clear_Btn
            // 
            resources.ApplyResources(this.Clear_Btn, "Clear_Btn");
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            // 
            // TestName_UserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.TestName_TB);
            this.Controls.Add(this.TestNameLabel);
            this.Name = "TestName_UserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.TextBox TestName_TB;
        private System.Windows.Forms.Button Clear_Btn;
    }
}
