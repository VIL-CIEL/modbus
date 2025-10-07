using System.Net;
using System.Net.Sockets;

namespace modbusTP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAdresseIP = new System.Windows.Forms.Label();
            this.textBoxAdresseIP = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.textBoxStatut = new System.Windows.Forms.TextBox();
            this.buttonLireTension = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTensionMoteur = new System.Windows.Forms.Label();
            this.textBoxTensionLire = new System.Windows.Forms.TextBox();
            this.textBoxThermique = new System.Windows.Forms.TextBox();
            this.labelThermique = new System.Windows.Forms.Label();
            this.buttonThermique = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdresseIP
            // 
            this.labelAdresseIP.AutoSize = true;
            this.labelAdresseIP.Location = new System.Drawing.Point(12, 15);
            this.labelAdresseIP.Name = "labelAdresseIP";
            this.labelAdresseIP.Size = new System.Drawing.Size(57, 13);
            this.labelAdresseIP.TabIndex = 0;
            this.labelAdresseIP.Text = "IP Serveur";
            // 
            // textBoxAdresseIP
            // 
            this.textBoxAdresseIP.Location = new System.Drawing.Point(75, 12);
            this.textBoxAdresseIP.Name = "textBoxAdresseIP";
            this.textBoxAdresseIP.Size = new System.Drawing.Size(154, 20);
            this.textBoxAdresseIP.TabIndex = 1;
            this.textBoxAdresseIP.Text = "172.17.50.124";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(265, 12);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(75, 23);
            this.buttonConnexion.TabIndex = 2;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(346, 12);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(86, 23);
            this.buttonDeconnexion.TabIndex = 3;
            this.buttonDeconnexion.Text = "Deconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // textBoxStatut
            // 
            this.textBoxStatut.Location = new System.Drawing.Point(438, 12);
            this.textBoxStatut.Multiline = true;
            this.textBoxStatut.Name = "textBoxStatut";
            this.textBoxStatut.ReadOnly = true;
            this.textBoxStatut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatut.Size = new System.Drawing.Size(350, 364);
            this.textBoxStatut.TabIndex = 4;
            // 
            // buttonLireTension
            // 
            this.buttonLireTension.Location = new System.Drawing.Point(13, 33);
            this.buttonLireTension.Name = "buttonLireTension";
            this.buttonLireTension.Size = new System.Drawing.Size(44, 23);
            this.buttonLireTension.TabIndex = 5;
            this.buttonLireTension.Text = "Lire";
            this.buttonLireTension.UseVisualStyleBackColor = true;
            this.buttonLireTension.Click += new System.EventHandler(this.buttonLireTension_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxThermique);
            this.panel1.Controls.Add(this.labelThermique);
            this.panel1.Controls.Add(this.buttonThermique);
            this.panel1.Controls.Add(this.textBoxTensionLire);
            this.panel1.Controls.Add(this.labelTensionMoteur);
            this.panel1.Controls.Add(this.buttonLireTension);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 324);
            this.panel1.TabIndex = 6;
            // 
            // labelTensionMoteur
            // 
            this.labelTensionMoteur.AutoSize = true;
            this.labelTensionMoteur.Location = new System.Drawing.Point(22, 11);
            this.labelTensionMoteur.Name = "labelTensionMoteur";
            this.labelTensionMoteur.Size = new System.Drawing.Size(116, 13);
            this.labelTensionMoteur.TabIndex = 6;
            this.labelTensionMoteur.Text = "Tension moteur en Volt";
            // 
            // textBoxTensionLire
            // 
            this.textBoxTensionLire.Location = new System.Drawing.Point(63, 36);
            this.textBoxTensionLire.Name = "textBoxTensionLire";
            this.textBoxTensionLire.ReadOnly = true;
            this.textBoxTensionLire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTensionLire.Size = new System.Drawing.Size(88, 20);
            this.textBoxTensionLire.TabIndex = 7;
            this.textBoxTensionLire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxThermique
            // 
            this.textBoxThermique.Location = new System.Drawing.Point(63, 104);
            this.textBoxThermique.Name = "textBoxThermique";
            this.textBoxThermique.ReadOnly = true;
            this.textBoxThermique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxThermique.Size = new System.Drawing.Size(88, 20);
            this.textBoxThermique.TabIndex = 10;
            this.textBoxThermique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelThermique
            // 
            this.labelThermique.AutoSize = true;
            this.labelThermique.Location = new System.Drawing.Point(22, 79);
            this.labelThermique.Name = "labelThermique";
            this.labelThermique.Size = new System.Drawing.Size(121, 13);
            this.labelThermique.TabIndex = 9;
            this.labelThermique.Text = "Pourcentage Thermique";
            // 
            // buttonThermique
            // 
            this.buttonThermique.Location = new System.Drawing.Point(13, 101);
            this.buttonThermique.Name = "buttonThermique";
            this.buttonThermique.Size = new System.Drawing.Size(44, 23);
            this.buttonThermique.TabIndex = 8;
            this.buttonThermique.Text = "Lire";
            this.buttonThermique.UseVisualStyleBackColor = true;
            this.buttonThermique.Click += new System.EventHandler(this.buttonThermique_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxStatut);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxAdresseIP);
            this.Controls.Add(this.labelAdresseIP);
            this.Name = "Form1";
            this.Text = "Barrière Modbus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdresseIP;
        private System.Windows.Forms.TextBox textBoxAdresseIP;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TextBox textBoxStatut;
        private System.Windows.Forms.Button buttonLireTension;
        private System.Windows.Forms.Panel panel1;

        private Socket socket;
        private IPEndPoint ep;
        private System.Windows.Forms.TextBox textBoxTensionLire;
        private System.Windows.Forms.Label labelTensionMoteur;
        private System.Windows.Forms.TextBox textBoxThermique;
        private System.Windows.Forms.Label labelThermique;
        private System.Windows.Forms.Button buttonThermique;
    }
}

