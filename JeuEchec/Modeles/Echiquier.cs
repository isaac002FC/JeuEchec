using JeuEchec.Pieces;

namespace JeuEchec
{
    public class Echiquier
    {
        private Case[ , ] plateauCases;

        public Echiquier()
        {
            bool noir = true;
            bool blanc = false;
            plateauCases = new Case[8 , 8];

            //Initialiser tours noires
            plateauCases[0, 0] = new Case(new Tour(noir));
            plateauCases[0, 7] = new Case(new Tour(noir));
            
            //Initialiser chevaliers noirs
            plateauCases[0, 1] = new Case(new Chevalier(noir));
            plateauCases[0, 6] = new Case(new Chevalier(noir));
            
            //Initialiser fous noirs
            plateauCases[0, 2] = new Case(new Fou(noir));
            plateauCases[0, 5] = new Case(new Fou(noir));
            
            //Initialiser reine noire
            plateauCases[0, 3] = new Case(new Reine(noir));
            
            //Initialiser roi noir
            plateauCases[0, 4] = new Case(new Roi(noir));
            
            //Initialiser pions noirs
            for (int i = 0; i < 8; i++)
            {
                plateauCases[1, i] = new Case(new Pion(noir));
            }
            
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    plateauCases[i, j] = new Case();
                }
            }
            
            //Initialiser tours blanches
            plateauCases[7, 0] = new Case(new Tour(blanc));
            plateauCases[7, 7] = new Case(new Tour(blanc));
            
            //Initialiser chevaliers noirs
            plateauCases[7, 1] = new Case(new Chevalier(blanc));
            plateauCases[7, 6] = new Case(new Chevalier(blanc));
            
            //Initialiser fous noirs
            plateauCases[7, 2] = new Case(new Fou(blanc));
            plateauCases[7, 5] = new Case(new Fou(blanc));
            
            //Initialiser reine noire
            plateauCases[7, 4] = new Case(new Reine(blanc));
            
            //Initialiser roi noir
            plateauCases[7, 3] = new Case(new Roi(blanc));
            
            //Initialiser pions noirs
            for (int i = 0; i < plateauCases.GetLength(0); i++)
            {
                plateauCases[6, i] = new Case(new Pion(blanc));
            }
        }

        /*
         * Retourne une chaine de caratères identifiants les pieces sur chacune des cases (n si aucune pièce sur la case)
         */
        public override string ToString()
        {
            string echiquier = "";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (plateauCases[i, j].PieceSurCase != null)
                    {
                        echiquier += plateauCases[i, j].PieceSurCase.obtenirIdentifiantPiece();
                    }
                    else
                    {
                        echiquier += "n";
                    }
                }
            }

            return echiquier;
        }
    }
    
}