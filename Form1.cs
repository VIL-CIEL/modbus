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
                socket = null;
                this.textBoxStatut.Text = "Deconnexion effectué !";
            }
            catch (Exception Exc)
            {
                this.textBoxStatut.Text = Exc.Message;
            }
        }

        private void buttonLireTension_Click(object sender, EventArgs e) // 3207
        {
            if (socket != null)
            {
                try
                {
                    // ENVOIE LA TRAME DE DEMANDE
                    var trameE = new byte[] {
                0x00, 0x01,  // L'identifiant de transaction    (2 octets)
                0x00, 0x00,  // ID de protocole                 (2 octets)
                0x00, 0x06,  // Taille                          (2 octets)
                0x01,        // Addresse Esclave                (1 octets)
                0x03,        // Code de fonction                (1 octets)
                0x0C, 0x86,  // L'adresse à demander : 3026     (2 octets)
                0x00, 0x01   // Nombres de registres            (2 octets)
                };
                    socket.Send(trameE);

                    // RECOIT LA TRAME DE REPONSE
                    var trameR = new byte[256];
                    var nb_bytes_lu = socket.Receive(trameR);

                    this.textBoxTensionLire.Text = String.Format("{0,10} V", trameR[9] * 256 + trameR[10]);
                }
                catch (Exception Exc)
                {
                    this.textBoxStatut.Text = Exc.Message;
                }
            }
        }

        private void buttonThermique_Click(object sender, EventArgs e) // 3209
        {
            if (socket != null)
            {
                try
                {
                    // ENVOIE LA TRAME DE DEMANDE
                    var trameE = new byte[] {
                    0x00, 0x01,  // L'identifiant de transaction    (2 octets)
                    0x00, 0x00,  // ID de protocole                 (2 octets)
                    0x00, 0x06,  // Taille                          (2 octets)
                    0x01,        // Addresse Esclave                (1 octets)
                    0x03,        // Code de fonction                (1 octets)
                    0x0C, 0x88,  // L'adresse à demander : 3208     (2 octets)
                    0x00, 0x01   // Nombres de registres            (2 octets)
                    };
                    socket.Send(trameE);

                    // RECOIT LA TRAME DE REPONSE
                    var trameR = new byte[256];
                    var nb_bytes_lu = socket.Receive(trameR);

                    this.textBoxThermique.Text = String.Format("{0,10} %", trameR[9] * 256 + trameR[10]);
                }
                catch (Exception Exc)
                {
                    this.textBoxStatut.Text = Exc.Message;
                }
            }
        }
    }
}
