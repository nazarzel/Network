using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace ScanerPorts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int StartPort = Convert.ToInt32(MinVal.Text);

            int EndPort = Convert.ToInt32(MaxVal.Text);

            for (int CurrPort = StartPort; CurrPort <= EndPort; CurrPort++)
            {

                System.Net.Sockets.TcpClient TcpScan = new System.Net.Sockets.TcpClient();
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



        public void PortOpen(int port)
        {
            try
            {

                    ListBoxPorts.Items.Add("Порт " + port + " відкритий");
            }
            catch (Exception ex)
            {

            }
        }

        public void PortClose(int port)
                {
                    try
                    {
                        ListBoxPorts.Items.Add("Порт " + port + " закритий");
                    }
                    catch (Exception ex)
                    {

                    }
                     
                
               }
    }

}
