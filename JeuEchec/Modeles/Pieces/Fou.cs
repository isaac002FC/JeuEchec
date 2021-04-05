namespace JeuEchec.Pieces
{
    public class Fou : Piece
    {
        public Fou(bool couleur)
        {
            this.couleurPiece = couleur;
        }

        public override string obtenirIdentifiantPiece()
        {
            if (couleurPiece)
                return "F";
            return "f";
        }
    }
}