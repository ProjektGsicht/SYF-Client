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
      this.pnContent = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // pnContent
      // 
      this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnContent.Location = new System.Drawing.Point(0, 0);
      this.pnContent.Name = "pnContent";
      this.pnContent.Size = new System.Drawing.Size(1024, 768);
      this.pnContent.TabIndex = 3;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1024, 768);
      this.ControlBox = false;
      this.Controls.Add(this.pnContent);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainWindow";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "SYF";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
      this.Resize += new System.EventHandler(this.MainWindow_Resize);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContent;

    }
}

