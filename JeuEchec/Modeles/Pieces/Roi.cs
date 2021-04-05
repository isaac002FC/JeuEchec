namespace JeuEchec.Pieces
{
    public class Roi : Piece
    {
        public Roi(bool couleur)
        {
            this.couleurPiece = couleur;
        }
        
        public override string obtenirIdentifiantPiece()
        {
            if (couleurPiece)
                return "R";
            return "r";
        }
    }
}