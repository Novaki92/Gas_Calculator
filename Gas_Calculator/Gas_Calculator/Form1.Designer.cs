namespace Gas_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_MPG = new System.Windows.Forms.TextBox();
            this.tb_Miles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.tb_Gas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_MPG
            // 
            this.tb_MPG.Location = new System.Drawing.Point(47, 26);
            this.tb_MPG.Name = "tb_MPG";
            this.tb_MPG.Size = new System.Drawing.Size(100, 20);
            this.tb_MPG.TabIndex = 0;
            this.tb_MPG.Text = "40";
            // 
            // tb_Miles
            // 
            this.tb_Miles.Location = new System.Drawing.Point(47, 52);
            this.tb_Miles.Name = "tb_Miles";
            this.tb_Miles.Size = new System.Drawing.Size(100, 20);
            this.tb_Miles.TabIndex = 1;
            this.tb_Miles.Text = "625";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MPG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(82, 130);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(100, 23);
            this.lbl_result.TabIndex = 5;
            this.lbl_result.Text = "42";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_result.Visible = false;
            // 
            // tb_Gas
            // 
            this.tb_Gas.Location = new System.Drawing.Point(47, 78);
            this.tb_Gas.Name = "tb_Gas";
            this.tb_Gas.Size = new System.Drawing.Size(100, 20);
            this.tb_Gas.TabIndex = 2;
            this.tb_Gas.Text = "3.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gas Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Gas);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Miles);
            this.Controls.Add(this.tb_MPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " Gas Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MPG;
        private System.Windows.Forms.TextBox tb_Miles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox tb_Gas;
        private System.Windows.Forms.Label label3;
    }
}

