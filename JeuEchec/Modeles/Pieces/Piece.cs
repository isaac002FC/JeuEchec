namespace JeuEchec.Pieces
{
    public abstract class Piece
    {
        protected string nomPiece;
        protected bool couleurPiece; //true = noir, false = blanc

        /**
         * Majuscule = Noir, Minuscule = Blanc
         * p = pion
         * t = tour
         * c = chevalier
         * f = fou
         * q = reine
         * r = roi
         */
        public abstract string obtenirIdentifiantPiece();
    }
    
    
    
}