namespace SYF_Client.Controls
{
  partial class Verification
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
      this.btnEnrollment = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnPassword = new System.Windows.Forms.Button();
      this.btnPic = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnEnrollment
      // 
      this.btnEnrollment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnEnrollment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnEnrollment.Location = new System.Drawing.Point(27, 60);
      this.btnEnrollment.Name = "btnEnrollment";
      this.btnEnrollment.Size = new System.Drawing.Size(84, 34);
      this.btnEnrollment.TabIndex = 1;
      this.btnEnrollment.Text = "Enrollment";
      this.btnEnrollment.UseVisualStyleBackColor = true;
      this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 5;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.btnEnrollment, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnPassword, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.btnPic, 2, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 115);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // btnPassword
      // 
      this.btnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPassword.Location = new System.Drawing.Point(207, 60);
      this.btnPassword.Name = "btnPassword";
      this.btnPassword.Size = new System.Drawing.Size(84, 34);
      this.btnPassword.TabIndex = 3;
      this.btnPassword.Text = "password";
      this.btnPassword.UseVisualStyleBackColor = true;
      this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
      // 
      // btnPic
      // 
      this.btnPic.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPic.Location = new System.Drawing.Point(117, 20);
      this.btnPic.Name = "btnPic";
      this.btnPic.Size = new System.Drawing.Size(84, 34);
      this.btnPic.TabIndex = 2;
      this.btnPic.Text = "take photo";
      this.btnPic.UseVisualStyleBackColor = true;
      this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
      // 
      // Verification
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Verification";
      this.Size = new System.Drawing.Size(319, 115);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnEnrollment;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnPassword;
    private System.Windows.Forms.Button btnPic;

  }
}
