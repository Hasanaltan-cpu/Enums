namespace YMS5177_Enums
{
    partial class Form3
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
            this.txtPlakaKod = new System.Windows.Forms.TextBox();
            this.btnEnum = new System.Windows.Forms.Button();
            this.btnEnumCntrl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka No:";
            // 
            // txtPlakaKod
            // 
            this.txtPlakaKod.Location = new System.Drawing.Point(108, 22);
            this.txtPlakaKod.Name = "txtPlakaKod";
            this.txtPlakaKod.Size = new System.Drawing.Size(157, 20);
            this.txtPlakaKod.TabIndex = 2;
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(108, 48);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(157, 34);
            this.btnEnum.TabIndex = 3;
            this.btnEnum.Text = "Enum Değeri";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnEnumCntrl
            // 
            this.btnEnumCntrl.Location = new System.Drawing.Point(108, 88);
            this.btnEnumCntrl.Name = "btnEnumCntrl";
            this.btnEnumCntrl.Size = new System.Drawing.Size(157, 36);
            this.btnEnumCntrl.TabIndex = 4;
            this.btnEnumCntrl.Text = "Kontrollü Enum Değeri";
            this.btnEnumCntrl.UseVisualStyleBackColor = true;
            this.btnEnumCntrl.Click += new System.EventHandler(this.btnEnumCntrl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(57, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 238);
            this.listBox1.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnumCntrl);
            this.Controls.Add(this.btnEnum);
            this.Controls.Add(this.txtPlakaKod);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakaKod;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Button btnEnumCntrl;
        private System.Windows.Forms.ListBox listBox1;
    }
}