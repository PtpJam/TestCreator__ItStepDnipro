namespace TestCreator__ItStepDnipro.View.Custom
{
    partial class Test_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_UserControl));
            this.button1 = new System.Windows.Forms.Button();
            this.PrevQuestion_Btn = new System.Windows.Forms.Button();
            this.Ans_4_CB = new System.Windows.Forms.CheckBox();
            this.Ans_4_TB = new System.Windows.Forms.TextBox();
            this.Ans_3_CB = new System.Windows.Forms.CheckBox();
            this.Ans_3_TB = new System.Windows.Forms.TextBox();
            this.Ans_2_CB = new System.Windows.Forms.CheckBox();
            this.Ans_2_TB = new System.Windows.Forms.TextBox();
            this.Ans_1_CB = new System.Windows.Forms.CheckBox();
            this.Ans_1_TB = new System.Windows.Forms.TextBox();
            this.Question_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Finish_Btn = new System.Windows.Forms.Button();
            this.testNumb_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddQuestion_Btn_Click);
            // 
            // PrevQuestion_Btn
            // 
            resources.ApplyResources(this.PrevQuestion_Btn, "PrevQuestion_Btn");
            this.PrevQuestion_Btn.Name = "PrevQuestion_Btn";
            this.PrevQuestion_Btn.UseVisualStyleBackColor = true;
            this.PrevQuestion_Btn.Click += new System.EventHandler(this.PrevQuestion_Btn_Click);
            // 
            // Ans_4_CB
            // 
            resources.ApplyResources(this.Ans_4_CB, "Ans_4_CB");
            this.Ans_4_CB.Name = "Ans_4_CB";
            this.Ans_4_CB.UseVisualStyleBackColor = true;
            this.Ans_4_CB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_4_CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_KeyDown);
            this.Ans_4_CB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_4_TB
            // 
            resources.ApplyResources(this.Ans_4_TB, "Ans_4_TB");
            this.Ans_4_TB.Name = "Ans_4_TB";
            this.Ans_4_TB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_4_TB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_3_CB
            // 
            resources.ApplyResources(this.Ans_3_CB, "Ans_3_CB");
            this.Ans_3_CB.Name = "Ans_3_CB";
            this.Ans_3_CB.UseVisualStyleBackColor = true;
            this.Ans_3_CB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_3_CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_KeyDown);
            this.Ans_3_CB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_3_TB
            // 
            resources.ApplyResources(this.Ans_3_TB, "Ans_3_TB");
            this.Ans_3_TB.Name = "Ans_3_TB";
            this.Ans_3_TB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_3_TB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_2_CB
            // 
            resources.ApplyResources(this.Ans_2_CB, "Ans_2_CB");
            this.Ans_2_CB.Name = "Ans_2_CB";
            this.Ans_2_CB.UseVisualStyleBackColor = true;
            this.Ans_2_CB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_2_CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_KeyDown);
            this.Ans_2_CB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_2_TB
            // 
            resources.ApplyResources(this.Ans_2_TB, "Ans_2_TB");
            this.Ans_2_TB.Name = "Ans_2_TB";
            this.Ans_2_TB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_2_TB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_1_CB
            // 
            resources.ApplyResources(this.Ans_1_CB, "Ans_1_CB");
            this.Ans_1_CB.BackColor = System.Drawing.SystemColors.Control;
            this.Ans_1_CB.Name = "Ans_1_CB";
            this.Ans_1_CB.UseVisualStyleBackColor = false;
            this.Ans_1_CB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_1_CB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CB_KeyDown);
            this.Ans_1_CB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Ans_1_TB
            // 
            resources.ApplyResources(this.Ans_1_TB, "Ans_1_TB");
            this.Ans_1_TB.Name = "Ans_1_TB";
            this.Ans_1_TB.Enter += new System.EventHandler(this.TB_Enter);
            this.Ans_1_TB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // Question_TB
            // 
            resources.ApplyResources(this.Question_TB, "Question_TB");
            this.Question_TB.Name = "Question_TB";
            this.Question_TB.Enter += new System.EventHandler(this.TB_Enter);
            this.Question_TB.Leave += new System.EventHandler(this.TB_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Finish_Btn
            // 
            resources.ApplyResources(this.Finish_Btn, "Finish_Btn");
            this.Finish_Btn.Name = "Finish_Btn";
            this.Finish_Btn.UseVisualStyleBackColor = true;
            this.Finish_Btn.Click += new System.EventHandler(this.Finish_Btn_Click);
            // 
            // testNumb_Label
            // 
            resources.ApplyResources(this.testNumb_Label, "testNumb_Label");
            this.testNumb_Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testNumb_Label.Name = "testNumb_Label";
            // 
            // Test_UserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testNumb_Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Finish_Btn);
            this.Controls.Add(this.PrevQuestion_Btn);
            this.Controls.Add(this.Ans_4_CB);
            this.Controls.Add(this.Ans_4_TB);
            this.Controls.Add(this.Ans_3_CB);
            this.Controls.Add(this.Ans_3_TB);
            this.Controls.Add(this.Ans_2_CB);
            this.Controls.Add(this.Ans_2_TB);
            this.Controls.Add(this.Ans_1_CB);
            this.Controls.Add(this.Ans_1_TB);
            this.Controls.Add(this.Question_TB);
            this.Controls.Add(this.label1);
            this.Name = "Test_UserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PrevQuestion_Btn;
        private System.Windows.Forms.CheckBox Ans_4_CB;
        private System.Windows.Forms.TextBox Ans_4_TB;
        private System.Windows.Forms.CheckBox Ans_3_CB;
        private System.Windows.Forms.TextBox Ans_3_TB;
        private System.Windows.Forms.CheckBox Ans_2_CB;
        private System.Windows.Forms.TextBox Ans_2_TB;
        private System.Windows.Forms.CheckBox Ans_1_CB;
        private System.Windows.Forms.TextBox Ans_1_TB;
        private System.Windows.Forms.TextBox Question_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Finish_Btn;
        private System.Windows.Forms.Label testNumb_Label;
    }
}
