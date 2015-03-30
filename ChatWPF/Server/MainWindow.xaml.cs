using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Server
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpListener list;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                list = new TcpListener(
                    IPAddress.Parse(IpVol.Text),
                    Convert.ToInt32(PortVol.Text));

                list.Start();

                Thread thread = new Thread(
                    new ThreadStart(ThreadFun));
                thread.IsBackground = true;

                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ThreadFun()
        {
            while (true)
            {
                TcpClient cl = list.AcceptTcpClient();
                StreamReader sr = new StreamReader(
                    cl.GetStream(),
                    Encoding.Unicode);
                string s = sr.ReadLine();
                messageList.Items.Add(s);
                cl.Close();
                if (s.ToUpper() == "EXIT")
                {
                    list.Stop();
                    this.Close();
                }
            }
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            if (list != null)
                list.Stop();
        }
    }
}
