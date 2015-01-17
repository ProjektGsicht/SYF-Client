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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
      this.btnPic = new System.Windows.Forms.Button();
      this.btnEnrollment = new System.Windows.Forms.Button();
      this.btnPassword = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.picBox = new SYF_Client.Controls.WebCamPictureBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
      this.SuspendLayout();
      // 
      // btnPic
      // 
      this.btnPic.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPic.Location = new System.Drawing.Point(343, 413);
      this.btnPic.Name = "btnPic";
      this.btnPic.Size = new System.Drawing.Size(84, 23);
      this.btnPic.TabIndex = 2;
      this.btnPic.Text = "take photo";
      this.btnPic.UseVisualStyleBackColor = true;
      this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
      // 
      // btnEnrollment
      // 
      this.btnEnrollment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnEnrollment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnEnrollment.Location = new System.Drawing.Point(253, 442);
      this.btnEnrollment.Name = "btnEnrollment";
      this.btnEnrollment.Size = new System.Drawing.Size(84, 25);
      this.btnEnrollment.TabIndex = 1;
      this.btnEnrollment.Text = "Enrollment";
      this.btnEnrollment.UseVisualStyleBackColor = true;
      this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);
      // 
      // btnPassword
      // 
      this.btnPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnPassword.Location = new System.Drawing.Point(433, 442);
      this.btnPassword.Name = "btnPassword";
      this.btnPassword.Size = new System.Drawing.Size(84, 25);
      this.btnPassword.TabIndex = 3;
      this.btnPassword.Text = "password";
      this.btnPassword.UseVisualStyleBackColor = true;
      this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 7;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
      this.tableLayoutPanel1.Controls.Add(this.btnPassword, 4, 3);
      this.tableLayoutPanel1.Controls.Add(this.btnEnrollment, 2, 3);
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
      this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 505);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // picBox
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.picBox, 5);
      this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBox.ErrorImage")));
      this.picBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox.InitialImage")));
      this.picBox.Location = new System.Drawing.Point(153, 17);
      this.picBox.Name = "picBox";
      this.picBox.Size = new System.Drawing.Size(464, 390);
      this.picBox.TabIndex = 4;
      this.picBox.TabStop = false;
      // 
      // Verification
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Verification";
      this.Size = new System.Drawing.Size(770, 505);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private WebCamPictureBox picBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnPassword;
    private System.Windows.Forms.Button btnEnrollment;
    private System.Windows.Forms.Button btnPic;

  }
}
