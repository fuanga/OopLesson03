﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// ConfigWindows.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindows : Window
    {
        public ConfigWindows()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, RoutedEventArgs e)
        {
            Config cf = (Config.GetInstance()).getDefaultStatus();

            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbSender.Text = tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
        }
        //適用(更新)
        private void btApply_Click(object sender, RoutedEventArgs e)
        {
            (Config.GetInstance()).UpdateStatus(tbSmtp.Text, tbUserName.Text, tbPassWord.Password, int.Parse(tbPort.Text), cbSsl.IsEnabled);
        }
    }
}
