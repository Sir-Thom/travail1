using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace travail1
{
    public partial class FromCamionneur : Form
    {
        Camionneur camionneur;
        
        public FromCamionneur()
        {
            InitializeComponent();
        }

        internal Camionneur Camionneur { get => camionneur; set => camionneur = value; }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            string nom;
            string prenom;
            prenom = txt_Prenom.Text;
            nom = txt_Nom.Text;
             camionneur = new Camionneur(prenom,nom);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
           // txt_Prenom.Text = PrenomCamionneur;
            //txt_Nom.Text = NomCamionneur;
        }

        private void FromCamionneur_Load(object sender, EventArgs e)
        {

        }
    }
}
