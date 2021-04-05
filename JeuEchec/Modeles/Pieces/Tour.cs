namespace JeuEchec.Pieces
{
    public class Tour : Piece
    {

        public Tour(bool couleur)
        {
            this.couleurPiece = couleur;
        }
        
        public override string obtenirIdentifiantPiece()
        {
            if (couleurPiece)
                return "T";
            return "t";
        }
    }
}