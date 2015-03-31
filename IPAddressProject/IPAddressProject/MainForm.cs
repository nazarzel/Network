using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace IPAddressProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnIPAddressGetInfo_Click(object sender, EventArgs e)
        {
            string dns = tbIPDNSAddress.Text;
            IPAddress ip;

            if (!IPAddress.TryParse(tbIPDNSAddress.Text, out ip) && String.IsNullOrEmpty(dns))
            {
                MessageBox.Show("Wrong IP/DNS address!");
                return;
            }

            IPHostEntry entry = (ip == null) ? entry = Dns.GetHostEntry(dns) : Dns.GetHostEntry(ip);

            PrintInfo(entry);
        }

        private IPAddress GetLocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                return null;

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
    
        private void PrintInfo(IPHostEntry entry)
        {
            var sb = new StringBuilder();
            sb.Append("Підключення до мережі: ");
            sb.AppendLine(NetworkInterface.GetIsNetworkAvailable().ToString());

            var localIP = GetLocalIPAddress();
            sb.Append("Локальна IP-адреса: ");
            sb.Append(localIP.ToString());
            sb.AppendLine(String.Format(" ({0})", localIP.AddressFamily.ToString()));

            sb.Append("Реальна назва хоста (DNS): ");
            sb.AppendLine(entry.HostName);

            sb.AppendLine("IP-адреси домену: ");
            foreach (var address in entry.AddressList)
            {
                sb.Append(address.ToString());
                sb.AppendLine(String.Format(" ({0})", address.AddressFamily.ToString()));
            }

            sb.AppendLine("Альтернативні адреси домену (Aliases): ");
            foreach (var alias in entry.Aliases)
                sb.AppendLine(alias.ToString());

            tbInfo.Text = sb.ToString();
        }
    }
}
