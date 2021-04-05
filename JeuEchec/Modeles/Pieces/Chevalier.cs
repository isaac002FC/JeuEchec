namespace JeuEchec.Pieces
{
    public class Chevalier : Piece
    {
        public Chevalier(bool couleur)
        {
            this.couleurPiece = couleur;
        }

        public override string obtenirIdentifiantPiece()
        {
            if (couleurPiece)
                return "C";
            return "c";
        }
    }
}