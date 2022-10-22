namespace Chess
{
    partial class FormChess
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
            this.pictureBoxChess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChess)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChess
            // 
            this.pictureBoxChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxChess.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxChess.Name = "pictureBoxChess";
            this.pictureBoxChess.Size = new System.Drawing.Size(800, 800);
            this.pictureBoxChess.TabIndex = 0;
            this.pictureBoxChess.TabStop = false;
            this.pictureBoxChess.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.pictureBoxChess);
            this.Name = "FormChess";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxChess;
    }
}