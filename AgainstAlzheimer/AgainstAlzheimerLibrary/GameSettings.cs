using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgainstAlzheimerLibrary
{
    public class GameSettings
    {
        public static readonly string BACKGROUND_PICTURE_NAME = "background_tile.bmp";

        public static readonly int MIN_PIECE_WIDTH = 40;    // Minimum width of jigsaw piece in pixels.
        public static readonly int MIN_PIECE_HEIGHT = 40;   // Minimum height of jigsaw piece in pixels.

        // It's recommended to set the number of rows and columns to be the same, otherwise,
        // the pieces may appear out of proportion.
        public static readonly int NUM_ROWS = 5;
        public static readonly int NUM_COLUMNS = 5;

        public static readonly int SNAP_TOLERANCE = 15;
        public static readonly byte GHOST_PICTURE_ALPHA = 127;

        public static readonly int PIECE_OUTLINE_WIDTH = 4;
        public static readonly bool DRAW_PIECE_OUTLINE = true;

        public static readonly int DROP_SHADOW_DEPTH = 3;
        public static readonly Color DROP_SHADOW_COLOR = Color.FromArgb(50, 50, 50);
    }
}
