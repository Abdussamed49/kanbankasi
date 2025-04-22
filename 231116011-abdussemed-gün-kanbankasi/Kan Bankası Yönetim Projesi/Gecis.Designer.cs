namespace Kan_Bankası_Yönetim_Projesi
{
    partial class Gecis
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            gecisProgBar = new CuoreUI.Controls.cuiCircleProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 30);
            label1.TabIndex = 1;
            label1.Text = "Kan Bankası Yönetim Sistemi";
            // 
            // gecisProgBar
            // 
            gecisProgBar.BorderWidth = 12;
            gecisProgBar.Location = new Point(69, 42);
            gecisProgBar.MaximumValue = 100;
            gecisProgBar.MinimumSize = new Size(24, 24);
            gecisProgBar.MinimumValue = 0;
            gecisProgBar.Name = "gecisProgBar";
            gecisProgBar.NormalColor = Color.Black;
            gecisProgBar.ProgressColor = Color.Red;
            gecisProgBar.ProgressValue = 0;
            gecisProgBar.RoundedEnds = true;
            gecisProgBar.Size = new Size(242, 225);
            gecisProgBar.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Gecis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(397, 287);
            Controls.Add(gecisProgBar);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gecis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Gecis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
		private CuoreUI.Controls.cuiCircleProgressBar gecisProgBar;
		private System.Windows.Forms.Timer timer1;
	}
}
