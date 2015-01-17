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
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lblUsername = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSendEnrollment = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnBack = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbUsername
      // 
      this.tbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbUsername.Location = new System.Drawing.Point(189, 41);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(144, 24);
      this.tbUsername.TabIndex = 6;
      this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
      // 
      // tbPassword
      // 
      this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPassword.Location = new System.Drawing.Point(189, 71);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(144, 24);
      this.tbPassword.TabIndex = 7;
      this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUsername.Location = new System.Drawing.Point(39, 38);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(144, 30);
      this.lblUsername.TabIndex = 8;
      this.lblUsername.Text = "Username:";
      this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(39, 68);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(144, 30);
      this.label2.TabIndex = 9;
      this.label2.Text = "Password:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnSendEnrollment
      // 
      this.btnSendEnrollment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnSendEnrollment.Enabled = false;
      this.btnSendEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSendEnrollment.Location = new System.Drawing.Point(189, 101);
      this.btnSendEnrollment.Name = "btnSendEnrollment";
      this.btnSendEnrollment.Size = new System.Drawing.Size(144, 29);
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
      this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfo.Location = new System.Drawing.Point(39, 8);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(294, 30);
      this.lblInfo.TabIndex = 10;
      this.lblInfo.Text = "Noch 5 Bilder";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblInfo, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnSendEnrollment, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.tbPassword, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.tbUsername, 2, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 142);
      this.tableLayoutPanel1.TabIndex = 11;
      // 
      // btnBack
      // 
      this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBack.Location = new System.Drawing.Point(39, 101);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(144, 29);
      this.btnBack.TabIndex = 11;
      this.btnBack.Text = "Zurück";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // UserEnrollment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "UserEnrollment";
      this.Size = new System.Drawing.Size(373, 142);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox tbUsername;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSendEnrollment;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnBack;
  }
}
