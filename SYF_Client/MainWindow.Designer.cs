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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.pnContent = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.picBox = new SYF_Client.Controls.WebCamPictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
      this.SuspendLayout();
      // 
      // pnContent
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.pnContent, 6);
      this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnContent.Location = new System.Drawing.Point(153, 616);
      this.pnContent.Name = "pnContent";
      this.tableLayoutPanel1.SetRowSpan(this.pnContent, 3);
      this.pnContent.Size = new System.Drawing.Size(718, 149);
      this.pnContent.TabIndex = 3;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 8;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.Controls.Add(this.picBox, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.pnContent, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.671957F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.32804F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 768);
      this.tableLayoutPanel1.TabIndex = 6;
      // 
      // picBox
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.picBox, 6);
      this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBox.ErrorImage")));
      this.picBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox.InitialImage")));
      this.picBox.Location = new System.Drawing.Point(153, 50);
      this.picBox.Name = "picBox";
      this.picBox.Size = new System.Drawing.Size(718, 560);
      this.picBox.TabIndex = 4;
      this.picBox.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(336, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(352, 47);
      this.label1.TabIndex = 5;
      this.label1.Text = "show your face";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1024, 768);
      this.ControlBox = false;
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainWindow";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "SYF";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
      this.Resize += new System.EventHandler(this.MainWindow_Resize);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Controls.WebCamPictureBox picBox;
        private System.Windows.Forms.Label label1;

    }
}

