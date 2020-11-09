﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        SmtpClient sc = new SmtpClient();
        Config config = (Config.GetInstance());

        public MainWindow()
        {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }

        //送信完了イベント
        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("送信はキャンセルされました");
            }
            else
            {
                MessageBox.Show(e.Error?.Message ?? "送信完了");
            }
        }


        //メール送信処理
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage(config.MailAddress, tbTo.Text); 

                //msg.To.Add(tbTo.Text)上の使うならいらんらしい; 
                if (tbCc.Text != "")
                {
                    msg.CC.Add(tbCc.Text);
                }


                if (tbBcc.Text != "") 
                {
                    msg.Bcc.Add(tbBcc.Text);
                }
               
                

                msg.Subject = tbTitle.Text;//件名
                msg.Body = tbBody.Text;//本文

                
                sc.Host = config.Smtp; //SMTPサーバーの設定
                sc.Port = config.Port;
                sc.EnableSsl = config.Ssl;
                sc.Credentials = new NetworkCredential(config.MailAddress, config.PassWord);

                //sc.Send(msg);//送信
                sc.SendMailAsync(msg); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        //送信キャンセル
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定画面表示
        private void btConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindows configWindows = new ConfigWindows();　//設定画面のインスタンスを生成
            configWindows.ShowDialog(); //表示
        }

        //メインウィンドウがロードされるタイミングで
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
