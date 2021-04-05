using System.ComponentModel;

namespace JeuEchec
{
    partial class FormEchiquier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pnlEchiquier = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlEchiquier
            // 
            this.pnlEchiquier.Location = new System.Drawing.Point(17, 29);
            this.pnlEchiquier.Name = "pnlEchiquier";
            this.pnlEchiquier.Size = new System.Drawing.Size(400, 400);
            this.pnlEchiquier.TabIndex = 0;
            this.pnlEchiquier.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEchiquier_Paint);
            this.pnlEchiquier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlEchiquier_MouseClick);
            // 
            // FormEchiquier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 475);
            this.Controls.Add(this.pnlEchiquier);
            this.Name = "FormEchiquier";
            this.Text = "FormEchiquier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEchiquier_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlEchiquier;

        #endregion
    }
}