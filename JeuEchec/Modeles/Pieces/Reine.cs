namespace JeuEchec.Pieces
{
    public class Reine : Piece
    {
        public Reine(bool couleur)
        {
            this.couleurPiece = couleur;
        }
        
        public override string obtenirIdentifiantPiece()
        {
            if (couleurPiece)
                return "Q";
            return "q";
        }
    }
}