namespace TestCreator__ItStepDnipro.View
{
    partial class SaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Return_Btn = new System.Windows.Forms.Button();
            this.SaveTXT_Btn = new System.Windows.Forms.Button();
            this.SaveJSON_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel and Save? ";
            // 
            // Return_Btn
            // 
            this.Return_Btn.Location = new System.Drawing.Point(12, 75);
            this.Return_Btn.Name = "Return_Btn";
            this.Return_Btn.Size = new System.Drawing.Size(69, 66);
            this.Return_Btn.TabIndex = 1;
            this.Return_Btn.Text = "Return";
            this.Return_Btn.UseVisualStyleBackColor = true;
            this.Return_Btn.Click += new System.EventHandler(this.Return_Btn_Click);
            // 
            // SaveTXT_Btn
            // 
            this.SaveTXT_Btn.Location = new System.Drawing.Point(272, 75);
            this.SaveTXT_Btn.Name = "SaveTXT_Btn";
            this.SaveTXT_Btn.Size = new System.Drawing.Size(69, 66);
            this.SaveTXT_Btn.TabIndex = 2;
            this.SaveTXT_Btn.Text = "Save as TXT";
            this.SaveTXT_Btn.UseVisualStyleBackColor = true;
            this.SaveTXT_Btn.Click += new System.EventHandler(this.SaveTXT_Btn_Click);
            // 
            // SaveJSON_Btn
            // 
            this.SaveJSON_Btn.Location = new System.Drawing.Point(197, 75);
            this.SaveJSON_Btn.Name = "SaveJSON_Btn";
            this.SaveJSON_Btn.Size = new System.Drawing.Size(69, 66);
            this.SaveJSON_Btn.TabIndex = 3;
            this.SaveJSON_Btn.Text = "Save as JSON";
            this.SaveJSON_Btn.UseVisualStyleBackColor = true;
            this.SaveJSON_Btn.Click += new System.EventHandler(this.SaveJSON_Btn_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 153);
            this.Controls.Add(this.SaveJSON_Btn);
            this.Controls.Add(this.SaveTXT_Btn);
            this.Controls.Add(this.Return_Btn);
            this.Controls.Add(this.label1);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Return_Btn;
        private System.Windows.Forms.Button SaveTXT_Btn;
        private System.Windows.Forms.Button SaveJSON_Btn;
    }
}