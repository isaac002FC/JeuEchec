using JeuEchec.Pieces;

namespace JeuEchec
{
    public class Case
    {
        private Piece pieceSurCase; //Pièce sur cette case

        public Case()
        {
            pieceSurCase = null;
        }

        public Case(Piece piece)
        {
            this.pieceSurCase = piece;
        }

        public Piece PieceSurCase
        {
            get
            { 
                return pieceSurCase;
            }
            set
            {
                pieceSurCase = value;
            }
        }
    }
}