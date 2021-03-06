﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace SYF_Client.Controls
{
  public partial class Verification : UserControl
  {
    // logging
    private static readonly ILog log =
                        LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

    public MainWindow MainWindow { get; set; }

    public Verification(MainWindow mainwindow)
    {
      MainWindow = mainwindow;
      InitializeComponent();
    }

    // start verification with faceimage
    private void btnPic_Click(object sender, EventArgs e)
    {
      MainWindow.UnlockWindows(MainWindow.Runtime.VerifiyUserByPic(MainWindow.picBox.takePic()));
    }

    // start verification with password
    private void btnPassword_Click(object sender, EventArgs e)
    {
      var messageControl = new MainMessage(SYF_Server.Messages.MessageType.Text);
      MainWindow.ShowMessage(messageControl);
    }

    // start enrollment
    private void btnEnrollment_Click(object sender, EventArgs e)
    {
      MainWindow.ChangeToUserEnrollment();
    }
  }
}
