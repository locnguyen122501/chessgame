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
    public partial class frmManageProfile : Form
    {
        public frmManageProfile()
        {
            InitializeComponent();
        }

        private void frmManageProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string strPlayerName = txtPlayerName.Text.ToString();
            frmMain.localpc.Profile = strPlayerName;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Dispose();
            }
        }
    }
}
