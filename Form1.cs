using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            }
        }
    }
}
