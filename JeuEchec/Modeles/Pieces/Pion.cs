namespace JeuEchec.Pieces
{
    public class Pion : Piece
    {
        private bool premierDeplacementFait;

        public Pion(bool couleur)
        {
            this.couleurPiece = couleur;
        }
        
        public override string obtenirIdentifiantPiece()
        {
            if (couleurPiece)
                return "P";
            return "p";
        }
    }
}