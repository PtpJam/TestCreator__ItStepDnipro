namespace TestCreator__ItStepDnipro.View.Custom
{
    partial class Auth_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth_UserControl));
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Btn
            // 
            resources.ApplyResources(this.Cancel_Btn, "Cancel_Btn");
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Login_TB
            // 
            resources.ApplyResources(this.Login_TB, "Login_TB");
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_TB_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Auth_UserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.label1);
            this.Name = "Auth_UserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Btn;
        public System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.Label label1;
    }
}
