using System;
using System.Collections.Generic;
using System.Text;
using Chess_Usercontrol;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace Chess_Programming
{
    public class clsOptions
    {
        private int _CellSize;
        private int _PieceSize;
        private bool _PlaySound;
        private ChessPieceStyle _PieceStyle;
        private ChessBoardStyle _BoardStyle;
        private string path=Application .StartupPath +"\\Config.xml";
        public clsOptions()
        {
            this._CellSize = 80;
            this._PieceSize = 64;
            this._PieceStyle = ChessPieceStyle.Wooden3D;
            this._BoardStyle = ChessBoardStyle.Wooden;
            this.PlaySound = true;                        
        }




        public int CellSize
        {
            get
            {
                return this._CellSize;
            }
            set
            {
                this._CellSize = value;
            }
        }

        public int PieceSize
        {
            get
            {
                return this._PieceSize;
            }
            set
            {
                this._PieceSize = value;
            }
        }

        public ChessBoardStyle  BoardStyle
        {
            get
            {
                return this._BoardStyle;
            }
            set
            {
                this._BoardStyle = value;
            }
        }

        public ChessPieceStyle  PieceStyle
        {
            get
            {
                return this._PieceStyle;
            }
            set
            {
                this._PieceStyle = value;
            }
        }

        public bool PlaySound
        {
            get
            {
                return this._PlaySound;
            }
            set
            {
                this._PlaySound = value;
            }
        }



    }
}
