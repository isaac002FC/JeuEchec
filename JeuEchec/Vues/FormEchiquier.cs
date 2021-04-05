using System.Drawing;
using System.Windows.Forms;

namespace JeuEchec
{
    public partial class FormEchiquier : Form
    {
        
        private Partie partie;
        private int caseX;
        private int caseY;
        public FormEchiquier(Partie laPartie)
        {
            partie = laPartie;
            InitializeComponent();
        }

        private void pnlEchiquier_Paint(object sender, PaintEventArgs e)
        {
            Bitmap imgPiece = null;
            char[] tabEchiquier = null;

            //Charger tabEchiquier par Partie
            if (this.partie != null)
            {
                tabEchiquier = this.partie.ToString().ToCharArray();
            }

            Graphics graph = pnlEchiquier.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Chocolate);
            
            graph.DrawRectangle(new Pen(Color.Chocolate), 0, 0, 399, 399);
            for (int c = 0; c < 8; c++)
                for (int r = c % 2 == 0 ? 1 : 0; r < 8; r += 2)
                    graph.FillRectangle(brush, r * 50, c * 50, 50, 50);

            for (int c = 0; c < 8; c++)
            {
                for (int r = 0; r < 8; r++)
                {
                    if (partie != null)
                    {
                        switch (tabEchiquier[c * 8 + r])
                        {
                            case 'P':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\pion-n.bmp");
                                break;
                            case 'p':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\pion-b.bmp");
                                break;
                            case 'T':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\tour-n.bmp");
                                break;
                            case 't':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\tour-b.bmp");
                                break;
                            case 'F':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\fou-n.bmp");
                                break;
                            case 'f':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\fou-b.bmp");
                                break;
                            case 'C':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\chevalier-n.bmp");
                                break;
                            case 'c':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\chevalier-b.bmp");
                                break;
                            case 'Q':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\reine-n.bmp");
                                break;
                            case 'q':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\reine-b.bmp");
                                break;
                            case 'R':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\roi-n.bmp");
                                break;
                            case 'r':
                                imgPiece = new Bitmap("D:\\Document\\Notes\\Session 4 - Technique de l'informatique\\COO\\JeuEchec\\JeuEchec\\Images\\roi-b.bmp");
                                break;
                            default:
                                imgPiece = null;
                                break;
                        }

                        if (imgPiece != null)
                        {
                            imgPiece.MakeTransparent(imgPiece.GetPixel(1, 1));
                            graph.DrawImage(imgPiece, r * 50, c * 50);
                        }
                    }
                }
            }

        }

        private void pnlEchiquier_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void FormEchiquier_FormClosing(object sender, FormClosingEventArgs e)
        {
            partie.quitterPartie();
        }
    }
}