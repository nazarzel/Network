using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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

namespace Scaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }
        public void PortOpen(int port)
        {
                ListBoxPorts.Items.Add("Порт " + port + " відкритий");
        }

        public void PortClose(int port)
        {

                ListBoxPorts.Items.Add("Порт " + port + " закритий");
        }

        private void Button_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            int StartPort = Convert.ToInt32(MinVal.Text);

            int EndPort = Convert.ToInt32(MaxVal.Text);

            for (int CurrPort = StartPort; CurrPort <= EndPort; CurrPort++)
            {

                TcpClient TcpScan = new System.Net.Sockets.TcpClient();
                try
                {

                    TcpScan.Connect(IPVal.Text, CurrPort);

                    PortOpen(CurrPort);
                }
                catch
                {

                    PortClose(CurrPort);
                }

            }
        }
    }
}
