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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxChess = new System.Windows.Forms.PictureBox();
            this.timerChess = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChess)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChess
            // 
            this.pictureBoxChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxChess.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxChess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxChess.Name = "pictureBoxChess";
            this.pictureBoxChess.Size = new System.Drawing.Size(800, 800);
            this.pictureBoxChess.TabIndex = 0;
            this.pictureBoxChess.TabStop = false;
            this.pictureBoxChess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxChess_MouseClick);
            // 
            // timerChess
            // 
            this.timerChess.Interval = 32;
            this.timerChess.Tick += new System.EventHandler(this.timerChess_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(276, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 1;
            // 
            // FormChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.pictureBoxChess);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChess";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxChess;
        private System.Windows.Forms.Timer timerChess;
        private Label label1;
    }
}