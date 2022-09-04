namespace multipleform
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnHal1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldesk = new System.Windows.Forms.Label();
            this.lblteam = new System.Windows.Forms.Label();
            this.lbltextklub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHal1
            // 
            this.btnHal1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHal1.Location = new System.Drawing.Point(56, 427);
            this.btnHal1.Name = "btnHal1";
            this.btnHal1.Size = new System.Drawing.Size(127, 51);
            this.btnHal1.TabIndex = 0;
            this.btnHal1.Text = "Kembali";
            this.btnHal1.UseVisualStyleBackColor = true;
            this.btnHal1.Click += new System.EventHandler(this.btnHal1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(382, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldesk
            // 
            this.lbldesk.AutoSize = true;
            this.lbldesk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldesk.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbldesk.Location = new System.Drawing.Point(56, 250);
            this.lbldesk.Name = "lbldesk";
            this.lbldesk.Size = new System.Drawing.Size(425, 150);
            this.lbldesk.TabIndex = 6;
            this.lbldesk.Text = resources.GetString("lbldesk.Text");
            this.lbldesk.Click += new System.EventHandler(this.lbldesk_Click);
            // 
            // lblteam
            // 
            this.lblteam.AutoSize = true;
            this.lblteam.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblteam.Location = new System.Drawing.Point(56, 72);
            this.lblteam.Name = "lblteam";
            this.lblteam.Size = new System.Drawing.Size(214, 92);
            this.lblteam.TabIndex = 7;
            this.lblteam.Text = "Real Madrid \r\nC.F.";
            this.lblteam.Click += new System.EventHandler(this.lblteam_Click);
            // 
            // lbltextklub
            // 
            this.lbltextklub.AutoSize = true;
            this.lbltextklub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltextklub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbltextklub.Location = new System.Drawing.Point(60, 185);
            this.lbltextklub.Name = "lbltextklub";
            this.lbltextklub.Size = new System.Drawing.Size(145, 25);
            this.lbltextklub.TabIndex = 8;
            this.lbltextklub.Text = "Klub Sepak Bola";
            this.lbltextklub.Click += new System.EventHandler(this.lbltextklub_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(537, 614);
            this.Controls.Add(this.lbltextklub);
            this.Controls.Add(this.lblteam);
            this.Controls.Add(this.lbldesk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHal1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHal1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lbldesk;
        private Label lblteam;
        private Label lbltextklub;
    }
}