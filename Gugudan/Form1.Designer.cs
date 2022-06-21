namespace Gugudan
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
            this.TBresult = new System.Windows.Forms.TextBox();
            this.BTrun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBresult
            // 
            this.TBresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBresult.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBresult.Location = new System.Drawing.Point(0, 86);
            this.TBresult.Multiline = true;
            this.TBresult.Name = "TBresult";
            this.TBresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBresult.Size = new System.Drawing.Size(800, 364);
            this.TBresult.TabIndex = 0;
            this.TBresult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTrun
            // 
            this.BTrun.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BTrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTrun.Location = new System.Drawing.Point(0, 0);
            this.BTrun.Margin = new System.Windows.Forms.Padding(10);
            this.BTrun.Name = "BTrun";
            this.BTrun.Size = new System.Drawing.Size(800, 86);
            this.BTrun.TabIndex = 1;
            this.BTrun.Text = "실행";
            this.BTrun.UseVisualStyleBackColor = false;
            this.BTrun.Click += new System.EventHandler(this.BTrun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBresult);
            this.Controls.Add(this.BTrun);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TBresult;
        private Button BTrun;
    }
}