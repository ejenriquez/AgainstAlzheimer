using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgainstAlzheimerLibrary
{
    public class CWalker
    {
        private int[,] mMatrix;
        public int mRow, mColumn;
        private int mM, mN;

        public CWalker()
        {
            mRow = 0; mColumn = 0;
            mM = 0; mN = 0;
        }

        public void CreateMatrix(int r, int c)
        {
            mMatrix = new int[r, c];
            mM = r; mN = c;
        }

        public void InitializeMatrix(int[,] a)
        {
            int i, j;

            for (i = 0; i < mM; i++)
                for (j = 0; j < mN; j++)
                    mMatrix[i, j] = a[i, j];
        }

        public void InitializeRoad()
        {
            mRow = 0; mColumn = 0;
        }

        public void LocalizeStart()
        {
            int i, j;

            for (i = 0; i < mM; i++)
                for (j = 0; j < mN; j++)
                    if (mMatrix[i, j] == 2)
                    {
                        mRow = i;
                        mColumn = j;
                    }
        }

        public void MoveRightSideLaberynth(PictureBox picLaberynth)
        {
            picLaberynth.Left = picLaberynth.Left + 20;
            mColumn--;
        }

        public void MoveLeftSideLaberynth(PictureBox picLaberynth)
        {
            picLaberynth.Left = picLaberynth.Left - 20;
            mColumn++;
        }

        public void MoveRightSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left + 20;
            mColumn++;
        }

        public void MoveLeftSide(PictureBox picWalker)
        {
            picWalker.Left = picWalker.Left - 20;
            mColumn--;
        }

        public void MoveUpSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top - 20;
            mRow--;
        }

        public void MoveDownSide(PictureBox picWalker)
        {
            picWalker.Top = picWalker.Top + 20;
            mRow++;
        }

        public void ControlMovesInLaberynth(PictureBox picWalker, KeyEventArgs e, PictureBox picLaberynth)
        {
            if (mMatrix[mRow, mColumn] != 3)
            {
                if (mColumn > 7 && mColumn < 49)
                {
                    if (e.KeyCode == Keys.Right)
                        if (mMatrix[mRow, mColumn + 1] != 0)
                            MoveLeftSideLaberynth(picLaberynth);
                    if (e.KeyCode == Keys.Left)
                        if (mMatrix[mRow, mColumn - 1] != 0)
                            MoveRightSideLaberynth(picLaberynth);
                    if (e.KeyCode == Keys.Up)
                        if (mMatrix[mRow - 1, mColumn] != 0)
                            MoveUpSide(picWalker);
                    if (e.KeyCode == Keys.Down)
                        if (mMatrix[mRow + 1, mColumn] != 0)
                            MoveDownSide(picWalker);
                    if (mMatrix[mRow, mColumn] == 3)
                        MessageBox.Show("Felicitaciones, buen trabajo.", "Mensaje de control");
                    
                    
                }
                else
                {
                    if (e.KeyCode == Keys.Right)
                        if (mMatrix[mRow, mColumn + 1] != 0)
                            MoveRightSide(picWalker);
                    if (e.KeyCode == Keys.Left)
                        if (mMatrix[mRow, mColumn - 1] != 0)
                            MoveLeftSide(picWalker);
                    if (e.KeyCode == Keys.Up)
                        if (mMatrix[mRow - 1, mColumn] != 0)
                            MoveUpSide(picWalker);
                    if (e.KeyCode == Keys.Down)
                        if (mMatrix[mRow + 1, mColumn] != 0)
                            MoveDownSide(picWalker);
                    if (mMatrix[mRow, mColumn] == 3)
                        MessageBox.Show("Felicitaciones, buen trabajo.", "Mensaje de control");
                }
            }
        }

        public void ControlMovesInLaberynth(PictureBox picWalker, KeyEventArgs e)
        {
            if (mMatrix[mRow, mColumn] != 3)
            {
                if (e.KeyCode == Keys.Right)
                    if (mMatrix[mRow, mColumn + 1] != 0)
                        MoveRightSide(picWalker);
                if (e.KeyCode == Keys.Left)
                    if (mMatrix[mRow, mColumn - 1] != 0)
                        MoveLeftSide(picWalker);
                if (e.KeyCode == Keys.Up)
                    if (mMatrix[mRow - 1, mColumn] != 0)
                        MoveUpSide(picWalker);
                if (e.KeyCode == Keys.Down)
                    if (mMatrix[mRow + 1, mColumn] != 0)
                        MoveDownSide(picWalker);
                if (mMatrix[mRow, mColumn] == 3)
                    MessageBox.Show("Felicitaciones, buen trabajo.", "Mensaje de control");
            }
        }
    }
}
