namespace SYF_Client.Controls
{
  partial class MainMessage
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
      this.tlpMainMessage = new System.Windows.Forms.TableLayoutPanel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSend = new System.Windows.Forms.Button();
      this.lblMessage = new System.Windows.Forms.Label();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.tlpMainMessage.SuspendLayout();
      this.SuspendLayout();
      // 
      // tlpMainMessage
      // 
      this.tlpMainMessage.ColumnCount = 7;
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMainMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMainMessage.Controls.Add(this.btnCancel, 3, 3);
      this.tlpMainMessage.Controls.Add(this.btnSend, 4, 2);
      this.tlpMainMessage.Controls.Add(this.lblMessage, 1, 0);
      this.tlpMainMessage.Controls.Add(this.tbPassword, 2, 2);
      this.tlpMainMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpMainMessage.Location = new System.Drawing.Point(0, 0);
      this.tlpMainMessage.Name = "tlpMainMessage";
      this.tlpMainMessage.RowCount = 5;
      this.tlpMainMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tlpMainMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tlpMainMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tlpMainMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tlpMainMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpMainMessage.Size = new System.Drawing.Size(442, 173);
      this.tlpMainMessage.TabIndex = 0;
      // 
      // btnCancel
      // 
      this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnCancel.Location = new System.Drawing.Point(183, 108);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 29);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSend
      // 
      this.btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnSend.Location = new System.Drawing.Point(265, 73);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(134, 29);
      this.btnSend.TabIndex = 2;
      this.btnSend.Text = "Senden";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // lblMessage
      // 
      this.lblMessage.AutoSize = true;
      this.tlpMainMessage.SetColumnSpan(this.lblMessage, 5);
      this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMessage.Location = new System.Drawing.Point(23, 0);
      this.lblMessage.Name = "lblMessage";
      this.tlpMainMessage.SetRowSpan(this.lblMessage, 2);
      this.lblMessage.Size = new System.Drawing.Size(396, 70);
      this.lblMessage.TabIndex = 0;
      this.lblMessage.Text = "Bitte fahren SIe mit dem Finger über den Sensor";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblMessage.UseCompatibleTextRendering = true;
      // 
      // tbPassword
      // 
      this.tlpMainMessage.SetColumnSpan(this.tbPassword, 2);
      this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbPassword.Location = new System.Drawing.Point(43, 73);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.Size = new System.Drawing.Size(216, 31);
      this.tbPassword.TabIndex = 1;
      // 
      // MainMessage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tlpMainMessage);
      this.Name = "MainMessage";
      this.Size = new System.Drawing.Size(442, 173);
      this.tlpMainMessage.ResumeLayout(false);
      this.tlpMainMessage.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tlpMainMessage;
    private System.Windows.Forms.Label lblMessage;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.TextBox tbPassword;
  }
}
