using System;
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
using System.Xaml;
using System.Xml.Serialization;

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
            if (SpaceCheck())
            {
                MessageBox.Show("空欄があるため変更できません");
                
            }
            else
            {
                (Config.GetInstance()).UpdateStatus(
               tbSmtp.Text, tbUserName.Text,
               tbPassWord.Password,
               int.Parse(tbPort.Text), cbSsl.IsChecked ?? false);
            }
        }

        //OK
        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            btApply_Click(sender, e);
            if (!SpaceCheck())
            {
                this.Close();
            }
            
            

        }

        //キャンセル
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
           
            
        }
        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbSmtp.Text = Config.GetInstance().Smtp;
            tbPort.Text = Config.GetInstance().Port.ToString();
            tbSender.Text = Config.GetInstance().MailAddress;
            tbPassWord.Password = Config.GetInstance().PassWord;
            cbSsl.IsChecked = Config.GetInstance().Ssl;
            tbUserName.Text = Config.GetInstance().MailAddress;
        }

        private bool SpaceCheck()
        {
            if (tbSmtp.Text =="" || tbPort.Text =="" || tbSender.Text == "" || tbPassWord.Password =="" || tbUserName.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }  
        }


       
           
        private void Config_TextChanged(object sender, TextChangedEventArgs e)     
        {

          
             MessageBox.Show("なんか", "警告", MessageBoxButton.OKCancel);
        
        }
        
          

                
            
        
       
    }
}
