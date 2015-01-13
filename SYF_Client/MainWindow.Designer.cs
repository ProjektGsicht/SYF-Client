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
      this.btnFingerprint = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnPassword = new System.Windows.Forms.Button();
      this.btnPic = new System.Windows.Forms.Button();
      this.picBox = new SYF_Client.Controls.WebCamPictureBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
      this.SuspendLayout();
      // 
      // btnFingerprint
      // 
      this.btnFingerprint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnFingerprint.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnFingerprint.Location = new System.Drawing.Point(142, 412);
      this.btnFingerprint.Name = "btnFingerprint";
      this.btnFingerprint.Size = new System.Drawing.Size(84, 25);
      this.btnFingerprint.TabIndex = 1;
      this.btnFingerprint.Text = "fingerprint";
      this.btnFingerprint.UseVisualStyleBackColor = true;
      this.btnFingerprint.Click += new System.EventHandler(this.btnFingerprint_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 7;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
      this.tableLayoutPanel1.Controls.Add(this.btnPassword, 4, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnFingerprint, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnPic, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.picBox, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.456221F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.54378F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 475);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // btnPassword
      // 
      this.btnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPassword.Location = new System.Drawing.Point(322, 412);
      this.btnPassword.Name = "btnPassword";
      this.btnPassword.Size = new System.Drawing.Size(84, 25);
      this.btnPassword.TabIndex = 3;
      this.btnPassword.Text = "password";
      this.btnPassword.UseVisualStyleBackColor = true;
      this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
      // 
      // btnPic
      // 
      this.btnPic.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPic.Location = new System.Drawing.Point(232, 383);
      this.btnPic.Name = "btnPic";
      this.btnPic.Size = new System.Drawing.Size(84, 23);
      this.btnPic.TabIndex = 2;
      this.btnPic.Text = "take photo";
      this.btnPic.UseVisualStyleBackColor = true;
      this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
      // 
      // picBox
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.picBox, 5);
      this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picBox.Location = new System.Drawing.Point(53, 16);
      this.picBox.Name = "picBox";
      this.picBox.Size = new System.Drawing.Size(442, 361);
      this.picBox.TabIndex = 4;
      this.picBox.TabStop = false;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 475);
      this.ControlBox = false;
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainWindow";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Form1";
      this.TopMost = true;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
      this.Resize += new System.EventHandler(this.MainWindow_Resize);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFingerprint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnPassword;
        private Controls.WebCamPictureBox picBox;
    }
}

