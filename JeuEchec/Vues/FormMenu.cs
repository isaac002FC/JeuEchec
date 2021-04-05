using System;
using System.Windows.Forms;

namespace JeuEchec
{
    public partial class FormMenu : Form
    {
        private JeuEchec controllerJeuEchec;
        
        public FormMenu(JeuEchec leJeu)
        {
            controllerJeuEchec = leJeu;
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }
        private void btnLancerPartie_Click(object sender, EventArgs e)
        {
            controllerJeuEchec.nouvellePartie();
        }

        private void cmbJoueur1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbJoueur2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnModifierJoueur_Click(object sender, EventArgs e)
        {
        }
    }
}