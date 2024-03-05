
namespace KPFU_2_sem_programming
{
    partial class FormAbout
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
            this.Label_Main = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Main
            // 
            this.Label_Main.AutoSize = true;
            this.Label_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Main.Location = new System.Drawing.Point(12, 53);
            this.Label_Main.Name = "Label_Main";
            this.Label_Main.Size = new System.Drawing.Size(360, 29);
            this.Label_Main.TabIndex = 0;
            this.Label_Main.Text = "Башмаков Владислав 2231122";
            this.Label_Main.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.Label_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Main;
    }
}