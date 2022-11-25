using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chess_Usercontrol;
using System.IO;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System.Collections;
using System.Media;
using DigitalClock;
namespace Chess_Programming
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {

        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;


        private bool m_ColorSelected = false;
        public static ClsPC localpc;
        UcCapturedPieces ucCapturedPieces1, ucCapturedPieces2;
        UcMovesHistory UcMovesHistory1;
        UcCountDownTimer UcCountDownTimer1, UcCountDownTimer2;

        public static int signal;

        public static string name;


        short TimeBonus = 0;
        short TimeLimit = 1;
        //10 phút + 15s mỗi lượt

        private void buttonStyleCustom_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, e.Color);
        }


        private void buttonStyleCustom_SelectedColorChanged(object sender, System.EventArgs e)
        {
            m_ColorSelected = true; 
        }
        UcChessBoard Board;

        ChessSide _OwnSide;
        GameMode _GameMode;

        Label[] lblNotation = new Label[36];
        int intNotationSize;

        public frmMain()
        {
            InitializeComponent();
        }


        //Chơi với Người
        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();

                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();



                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 0;
                UcCountDownTimer2.Second = 0;
            }
            else
            {
                ucCapturedPieces1 = new UcCapturedPieces();
                ucCapturedPieces2 = new UcCapturedPieces();
                UcMovesHistory1 = new UcMovesHistory();
                UcCountDownTimer1 = new UcCountDownTimer();
                UcCountDownTimer2 = new UcCountDownTimer();


                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 1;
                UcCountDownTimer2.Second = 1;
            }

            
            pnlCapturedPiece1.Controls.Clear();
            pnlCapturedPiece2.Controls.Clear();
                      

            pnlCapturedPiece1.Visible = true;
            pnlCapturedPiece2.Visible = true;

            panel1.Visible = true;
            panel1.Controls.Clear();
            clsOptions obj = new clsOptions();
            Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, eOwnSide, eGameMode, obj.CellSize, obj.PieceSize, obj.PlaySound, strFEN);
            //Captured Piece Collector

            ucCapturedPieces1.PieceColor = Board.OwnSide;
            //Moves History            
            UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);



            

            if (Board.OwnSide == ChessSide.Black)
                ucCapturedPieces2.PieceColor = ChessSide.White;
            else
                ucCapturedPieces2.PieceColor = ChessSide.Black;

            pnlCapturedPiece1.Controls.Add(ucCapturedPieces1);
            pnlCapturedPiece2.Controls.Add(ucCapturedPieces2);


            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);
            Board.PieceCaptured += new UcChessBoard.PieceCapturedHandler(Board_PieceCaptured);
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);

            if (Board.GameMode == GameMode.VsComputer)
                btnHint.Enabled = true;
            else
                btnHint.Enabled = false;

            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((obj.CellSize * 38) / 100);

            AddNotation(obj.CellSize, eOwnSide);
            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(obj.CellSize * 8 + intNotationSize * 2, obj.CellSize * 8 + intNotationSize * 2);
            pnlCapturedPiece1.Size = ucCapturedPieces1.Size;
            pnlCapturedPiece2.Size = ucCapturedPieces2.Size;

            pnlCapturedPiece1.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, panel1.Location.Y + 2);
            pnlCapturedPiece2.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, this.ribbonClientPanel1.Height - pnlCapturedPiece2.Height - 2);

            if (Board.OwnSide == ChessSide.White)
                UcCountDownTimer2.StartTimer();
            else
                UcCountDownTimer1.StartTimer();
        }
        //Chơi với máy
        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, GameDifficulty eDifficulty, string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();

                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 0;
                UcCountDownTimer2.Second = 0;
            }
            else
            {
                ucCapturedPieces1 = new UcCapturedPieces();
                ucCapturedPieces2 = new UcCapturedPieces();
                UcMovesHistory1 = new UcMovesHistory();
            }



            
            pnlCapturedPiece1.Controls.Clear();
            pnlCapturedPiece2.Controls.Clear();
            pnlCapturedPiece1.Visible = true;
            pnlCapturedPiece2.Visible = true;



            panel1.Visible = true;
            panel1.Controls.Clear();
            clsOptions obj = new clsOptions();
            Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, eOwnSide, eGameMode, eDifficulty, obj.CellSize, obj.PieceSize, obj.PlaySound, strFEN);


            ucCapturedPieces1.PieceColor = Board.OwnSide;

            if (Board.OwnSide == ChessSide.Black)
                ucCapturedPieces2.PieceColor = ChessSide.White;
            else
                ucCapturedPieces2.PieceColor = ChessSide.Black;

            pnlCapturedPiece1.Controls.Add(ucCapturedPieces1);
            pnlCapturedPiece2.Controls.Add(ucCapturedPieces2);


            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);
            Board.PieceCaptured += new UcChessBoard.PieceCapturedHandler(Board_PieceCaptured);
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
            UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
            if (Board.GameMode == GameMode.VsComputer)
                btnHint.Enabled = true;
            else
                btnHint.Enabled = false;

            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((obj.CellSize * 38) / 100);
            this._GameMode = GameMode.VsComputer;
            this._OwnSide = ChessSide.White;
            AddNotation(obj.CellSize, eOwnSide);

            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(obj.CellSize * 8 + intNotationSize * 2, obj.CellSize * 8 + intNotationSize * 2);

            pnlCapturedPiece1.Size = ucCapturedPieces1.Size;
            pnlCapturedPiece2.Size = ucCapturedPieces2.Size;

            pnlCapturedPiece1.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, panel1.Location.Y + 2);
            pnlCapturedPiece2.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, this.ribbonClientPanel1.Height - pnlCapturedPiece2.Height - 2);
        }

        void MoveMaked(object sender, EventArgs e)
        {
            if (Board == null)
                return;



            if (Board.GameMode == GameMode.VsComputer)
            {
                Board.Enabled = true;
                if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
                {
                    
                    btnHint.Enabled = true;
                    btnUndo.Enabled = true;
                }
                else
                {
                    
                    btnHint.Enabled = false;
                    btnUndo.Enabled = false;
                }
                if (Board.GameStatus != GameStatus.NowPlaying)
                    btnHint.Enabled = false;
            }
            else
            {
                Board.Enabled = true;
                
                btnUndo.Enabled = true;
            }

            UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
        }


        void Board_PieceCaptured(object sender, EventArgs e)
        {
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
        }



        void AddNotation(int intCellSize, ChessSide eOwnSide)
        {

            for (int i = 0; i < 36; i++)
            {
                lblNotation[i] = new Label();
                lblNotation[i].Height = intCellSize;
                lblNotation[i].Width = intCellSize;
                lblNotation[i].Image = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, ChessBoardStyle.BoardEdge);

                lblNotation[i].TextAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].Font = new Font(FontFamily.GenericSansSerif, 14.0f);
                lblNotation[i].ImageAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].ForeColor = Color.White;
            }

            lblNotation[0].Height = intNotationSize;
            lblNotation[0].Width = intNotationSize;
            lblNotation[0].Location = new Point();
            lblNotation[0].BackColor = Color.Blue;
            panel1.Controls.Add(lblNotation[0]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[i].Text = Convert.ToChar(73 - i).ToString();
                }
                lblNotation[i].Location = new Point(intCellSize * (i - 1) + intNotationSize, 0);
                panel1.Controls.Add(lblNotation[i]);
            }
            lblNotation[9].Height = intNotationSize;
            lblNotation[9].Width = intNotationSize;
            lblNotation[9].BackColor = Color.Blue;
            lblNotation[9].Location = new Point(0, intNotationSize + intCellSize * 8);
            panel1.Controls.Add(lblNotation[9]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[9 + i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[9 + i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[9 + i].Text = Convert.ToChar(73 - i).ToString();
                }
                lblNotation[9 + i].Location = new Point(intCellSize * (i - 1) + intNotationSize, intNotationSize + intCellSize * 8);
                panel1.Controls.Add(lblNotation[9 + i]);
            }
            lblNotation[18].Height = intNotationSize;
            lblNotation[18].Width = intNotationSize;
            lblNotation[18].BackColor = Color.Blue;
            lblNotation[18].Location = new Point(intNotationSize + intCellSize * 8, 0);
            panel1.Controls.Add(lblNotation[18]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[18 + i].Width = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[18 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[18 + i].Text = Convert.ToString(i);
                }
                lblNotation[18 + i].Location = new Point(0, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[18 + i]);
            }

            lblNotation[27].Height = intNotationSize;
            lblNotation[27].Width = intNotationSize;
            lblNotation[27].BackColor = Color.Blue;
            lblNotation[27].Location = new Point(intNotationSize + intCellSize * 8, intNotationSize + intCellSize * 8);
            panel1.Controls.Add(lblNotation[27]);
            for (int i = 1; i <= 8; i++)
            {
                lblNotation[27 + i].Width = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[27 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[27 + i].Text = Convert.ToString(i);
                }
                lblNotation[27 + i].Location = new Point(intNotationSize + intCellSize * 8, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[27 + i]);
            }

        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string GetMoveList(Stack stkWhite, Stack stkBlack)
        {
            StringBuilder str = new StringBuilder();

            Stack MoveList = new Stack();
            if (stkWhite.Count > stkBlack.Count)
            {
                MoveList.Push(stkBlack.Pop());
            }
            //Lúc này 2 Stack bằng nhau
            while (stkWhite.Count > 0)
            {
                MoveList.Push(stkBlack.Pop());
                MoveList.Push(stkWhite.Pop());
            }

            foreach (string s in MoveList)
            {
                str.Append(s);
                str.Append(' ');
            }
            return str.ToString().Trim();
        }

        public ChessSide eOwnSide;
        public GameMode eGameMode;
        public GameDifficulty eDifficulty;
        string strFen = clsFEN.DefaultFENstring;
        

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmSelectGame frm = new frmSelectGame();
            frm.ShowDialog();

            if (signal == 0)
            {                
                GameMode eGameMode = GameMode.VsHuman;
                if (eGameMode == GameMode.VsHuman)
                {
                    eGameMode = GameMode.VsHuman;
                    eOwnSide = ChessSide.White;
                    CreateChessBoard(eOwnSide, eGameMode, strFen); //day la cua choi voi nguoi
                }
                
            }
            else if (signal == 1)
            {
                
                
                    eGameMode = GameMode.VsComputer;
                    if (eGameMode == GameMode.VsComputer)
                    {
                        eGameMode = GameMode.VsComputer;
                        eOwnSide = ChessSide.White;
                        CreateChessBoard(eOwnSide, eGameMode, eDifficulty, strFen); //day la cua choi voi may
                    }
                
            }
            else
            {
                try
                {
                    if (frmMain.localpc.Profile == null)
                    {
                        frmManageProfile frml = new frmManageProfile();
                        frml.ShowDialog();
                    }
                    this.Hide();
                    frmFindGame frms = new frmFindGame();
                    frms.ShowDialog();
                    this.Show();
                }
                catch
                {

                }
            }    
            frm.Dispose();
        }
        public void PlayMusic(SoundPlayer sound)
        {
            if (Board == null)
                return;
            if (Board.PlaySound == true)
            {
                sound.Play();
            }
        }

        private void buttonStyleOffice2007Blue_Click(object sender, EventArgs e)
        {

        }

        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eOffice2007ColorScheme colorScheme = (eOffice2007ColorScheme)Enum.Parse(typeof(eOffice2007ColorScheme), source.CommandParameter.ToString());
                
                ribbonControl1.Office2007ColorTable = colorScheme;
            }
            else if (source.CommandParameter is Color)
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, (Color)source.CommandParameter);
            }
            this.Invalidate();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
            {
                btnHint.Enabled = false;

                Board.Enabled = false;
                Board.Computer_Move(Board.OwnSide, Board.Difficulty);

            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (Board != null && (Board.stkBlackMoves.Count > 0 || Board.stkWhiteMoves.Count > 0))
            {


                if (Board.GameMode == GameMode.VsHuman)
                {
                    Board.UnDoMove();
                    ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
                    UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                }
                else
                {
                    if (Board.IsThinking == true)
                        return;

                    Board.UnDoMove();
                    Board.UnDoMove();
                    ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
                    ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
                    UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                }

                if (Board.stkBlackMoves.Count > 0 || Board.stkWhiteMoves.Count > 0)
                    btnUndo.Enabled = true;
                else
                {
                    btnUndo.Enabled = false;
                }
            }
        }



        private void btnGetFen_Click(object sender, EventArgs e)
        {
            if (Board != null)
            {
                string strFEN = clsFEN.GetFEN(Board);
                Clipboard.SetText(strFEN);

                MessageBox.Show(strFEN, "Đã lưu vào ClipBoard !!!");
            }
        }




        SoundPlayer soundNewGame;
        private void frmMain_Load(object sender, EventArgs e)
        {
            soundNewGame = new SoundPlayer(Properties.Resources.NewGame);
            soundNewGame.LoadAsync();
            frmMain.localpc = new ClsPC(28000);
        }

        private void btnScreenCapture_Click(object sender, EventArgs e)
        {
            if (Board != null)
            {
                try
                {
                    Bitmap bmp = Board.TakePicture(Board.Width, Board.Height);
                    Clipboard.SetImage(bmp);
                    MessageBox.Show("Đã Lưu ảnh Vào ClipBoard");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ribbonControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGVHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thầy Trần Gia Huy","Giảng viên hướng dẫn",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}