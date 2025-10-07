using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modbusTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            IPAddress address;
            if(IPAddress.TryParse(this.textBoxAdresseIP.Text, out address))
            {
                this.textBoxStatut.Text = "Connexion au serveur : " + this.textBoxAdresseIP.Text;
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ep = new IPEndPoint(address, 502);
                    socket.Connect(ep);
                    this.textBoxStatut.Text = "Connexion effectué !";
                }
                catch(Exception Exc)
                {
                    this.textBoxStatut.Text = Exc.Message;
                }
            }
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Close();
                this.textBoxStatut.Text = "Deconnexion effectué !";
            }
            catch (Exception Exc)
            {
                this.textBoxStatut.Text = Exc.Message;
            }
        }
    }
}
