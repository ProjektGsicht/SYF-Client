namespace SYF_Client.Controls
{
  partial class UserEnrollment
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEnrollment));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSendEnrollment = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.picBox = new SYF_Client.Controls.WebCamPictureBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
      this.SuspendLayout();
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
      this.tableLayoutPanel1.Controls.Add(this.tbUsername, 4, 2);
      this.tableLayoutPanel1.Controls.Add(this.tbPassword, 4, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblUsername, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnSendEnrollment, 3, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblInfo, 3, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.671957F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.32804F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 473);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // tbUsername
      // 
      this.tbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbUsername.Location = new System.Drawing.Point(353, 381);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(84, 20);
      this.tbUsername.TabIndex = 6;
      // 
      // tbPassword
      // 
      this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbPassword.Location = new System.Drawing.Point(353, 410);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(84, 20);
      this.tbPassword.TabIndex = 7;
      // 
      // lblUsername
      // 
      this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new System.Drawing.Point(289, 378);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(58, 29);
      this.lblUsername.TabIndex = 8;
      this.lblUsername.Text = "Username:";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(291, 407);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 31);
      this.label2.TabIndex = 9;
      this.label2.Text = "Password:";
      // 
      // btnSendEnrollment
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.btnSendEnrollment, 2);
      this.btnSendEnrollment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnSendEnrollment.Location = new System.Drawing.Point(265, 441);
      this.btnSendEnrollment.Name = "btnSendEnrollment";
      this.btnSendEnrollment.Size = new System.Drawing.Size(172, 29);
      this.btnSendEnrollment.TabIndex = 5;
      this.btnSendEnrollment.Text = "Senden";
      this.btnSendEnrollment.UseVisualStyleBackColor = true;
      this.btnSendEnrollment.Click += new System.EventHandler(this.btnSendEnrollment_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.lblInfo, 2);
      this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfo.Location = new System.Drawing.Point(265, 0);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(172, 29);
      this.lblInfo.TabIndex = 10;
      this.lblInfo.Text = "Noch 5 Bilder";
      // 
      // picBox
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.picBox, 6);
      this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBox.ErrorImage")));
      this.picBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox.InitialImage")));
      this.picBox.Location = new System.Drawing.Point(153, 32);
      this.picBox.Name = "picBox";
      this.picBox.Size = new System.Drawing.Size(396, 343);
      this.picBox.TabIndex = 4;
      this.picBox.TabStop = false;
      // 
      // UserEnrollment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "UserEnrollment";
      this.Size = new System.Drawing.Size(702, 473);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private WebCamPictureBox picBox;
    private System.Windows.Forms.TextBox tbUsername;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSendEnrollment;
    private System.Windows.Forms.Label lblInfo;
  }
}
