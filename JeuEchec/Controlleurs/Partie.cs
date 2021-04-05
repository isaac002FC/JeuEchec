using System.Windows.Forms;

namespace JeuEchec
{
    public class Partie
    {
        private JeuEchec controlleurJeu;
        private FormEchiquier formEchiquier;
        private Echiquier plateau;

        public Partie(JeuEchec jeuEchec)
        {
            controlleurJeu = jeuEchec;
            plateau = new Echiquier();
            formEchiquier = new FormEchiquier(this);
            formEchiquier.Show();
        }

        public void quitterPartie()
        {
            controlleurJeu.terminerPartie(this);
        }

        public override string ToString()
        {
            return plateau.ToString();
        }
    }
}