namespace multipleform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnhal2 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhal2
            // 
            this.btnhal2.Location = new System.Drawing.Point(292, 161);
            this.btnhal2.Name = "btnhal2";
            this.btnhal2.Size = new System.Drawing.Size(187, 93);
            this.btnhal2.TabIndex = 0;
            this.btnhal2.Text = "Halaman 2";
            this.btnhal2.UseVisualStyleBackColor = true;
            this.btnhal2.Click += new System.EventHandler(this.btnhal2_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(307, 272);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(172, 68);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnhal2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnhal2;
        private Button btnclose;
        private Label label1;
    }
}