using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuEchec
{
    public class JeuEchec
    {
        private List<Partie> parties;
        private List<Joueur> joueurs;
        private FormMenu menuJeu;
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            JeuEchec leJeu = new JeuEchec();
            
            Application.Run(leJeu.MenuJeu);

        }

        public JeuEchec()
        {
            menuJeu = new FormMenu(this);
            parties = new List<Partie>();
            joueurs = new List<Joueur>();
        }

        public FormMenu MenuJeu => menuJeu;

        /**
         * Créer une nouvelle partie
         */
        public void nouvellePartie()
        {
            parties.Add(new Partie(this));
        }

        /**
         * Supprimer une partie de la liste des parties
         */
        public void terminerPartie(Partie partie)
        {
            parties.Remove(partie);
        }
    }
}