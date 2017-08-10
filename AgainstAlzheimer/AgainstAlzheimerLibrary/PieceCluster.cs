using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AgainstAlzheimerLibrary
{
    public class PieceCluster
    {
        public int ID { get; set; }

        // =========================================
        // The following properties are similar to those in "Piece" class.
        // Their values may change when the pieces are snapped and 
        // combined together.
        // =========================================
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle BoardLocation { get; set; }
        public Rectangle SourcePictureLocation { get; set; }
        public GraphicsPath MovableFigure { get; set; }
        public GraphicsPath StaticFigure { get; set; }
        public Bitmap Picture { get; set; }
        // =========================================

        /// <summary>
        /// Stores inidividual jigsaw pieces.
        /// </summary>
        public List<Piece> Pieces { get; set; }
    }
}
