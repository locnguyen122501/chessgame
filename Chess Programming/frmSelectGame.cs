using Chess_Usercontrol;
using DevComponents.DotNetBar.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chess_Programming
{
    public partial class frmSelectGame : Form
    {
        public frmSelectGame()
        {
            InitializeComponent();
        }

        public ChessSide eOwnSide;
        public GameMode eGameMode;
        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;

        private void frmSelectGame_Load(object sender, EventArgs e)
        {

        }

        private void btnVsHuman_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn chơi 2 người 1 máy?", "Thông báo", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.OK)
            //{
            //    eGameMode = GameMode.VsHuman;
            //    eOwnSide = ChessSide.White;
            //}
            eGameMode = GameMode.VsHuman;
            eOwnSide = ChessSide.White;
            frmMain.signal = 0;
            
        }

        private void btnVsCPU_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng vẫn đang tiến hành hoàn thiện","Thông báo");
            eGameMode = GameMode.VsComputer;
            eOwnSide = ChessSide.White;

            frmMain.signal = 1;

            
        }

        MessageBoxButtons YesNoButton = MessageBoxButtons.YesNo;

        private void btnChoiLAN_Click(object sender, EventArgs e)
        {
            frmMain.signal = 3;

        }
    }
}
