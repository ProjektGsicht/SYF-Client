namespace SYF_Client
{
    partial class MainWindow
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
      this.picBox = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
      this.SuspendLayout();
      // 
      // picBox
      // 
      this.picBox.Location = new System.Drawing.Point(0, 0);
      this.picBox.Name = "picBox";
      this.picBox.Size = new System.Drawing.Size(544, 424);
      this.picBox.TabIndex = 0;
      this.picBox.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(72, 432);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 475);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.picBox);
      this.Name = "MainWindow";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button button1;
    }
}

