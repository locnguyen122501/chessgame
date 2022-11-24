namespace Chess_Programming
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnNewGame = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnInfo = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnGVHD = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.btnChessRule = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.AppCommandTheme = new DevComponents.DotNetBar.Command();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.pnlCapturedPiece2 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOptions = new DevComponents.DotNetBar.ButtonItem();
            this.btnGetFen = new DevComponents.DotNetBar.ButtonItem();
            this.btnScreenCapture = new DevComponents.DotNetBar.ButtonItem();
            this.btnUndo = new DevComponents.DotNetBar.ButtonItem();
            this.btnHint = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(749, 112);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click_1);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar7);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(749, 55);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            this.ribbonBar7.ContainerControlProcessDialogKey = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.ribbonBar7.Location = new System.Drawing.Point(84, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(39, 52);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar7.TabIndex = 5;
            this.ribbonBar7.Text = "Thoát";
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExit.Image = global::Chess_Programming.Properties.Resources.Exit;
            this.btnExit.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnExit.ImagePaddingHorizontal = 6;
            this.btnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExit.Name = "btnExit";
            this.btnExit.RibbonWordWrap = false;
            this.btnExit.SubItemsExpandWidth = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNewGame});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(81, 52);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Chế độ chơi";
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoCollapseOnClick = false;
            this.btnNewGame.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNewGame.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGame.Image")));
            this.btnNewGame.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnNewGame.ImagePaddingHorizontal = 6;
            this.btnNewGame.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNewGame.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.RibbonWordWrap = false;
            this.btnNewGame.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnNewGame.SubItemsExpandWidth = 14;
            this.btnNewGame.Text = "Single Play";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(749, 55);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInfo});
            this.ribbonBar3.Location = new System.Drawing.Point(103, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(100, 52);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "Nhóm 1";
            // 
            // btnInfo
            // 
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.SubItemsExpandWidth = 14;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGVHD});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(100, 52);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "GV hướng dẫn";
            // 
            // btnGVHD
            // 
            this.btnGVHD.Image = ((System.Drawing.Image)(resources.GetObject("btnGVHD.Image")));
            this.btnGVHD.Name = "btnGVHD";
            this.btnGVHD.SubItemsExpandWidth = 14;
            this.btnGVHD.Click += new System.EventHandler(this.btnGVHD_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Trang Chủ";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Thông tin thêm";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            // 
            // btnChessRule
            // 
            this.btnChessRule.Name = "btnChessRule";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            // 
            // AppCommandTheme
            // 
            this.AppCommandTheme.Executed += new System.EventHandler(this.AppCommandTheme_Executed);
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.pnlCapturedPiece2);
            this.ribbonClientPanel1.Controls.Add(this.pnlCapturedPiece1);
            this.ribbonClientPanel1.Controls.Add(this.panel1);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(4, 113);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(749, 723);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 1;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            this.ribbonClientPanel1.Click += new System.EventHandler(this.ribbonClientPanel1_Click);
            // 
            // pnlCapturedPiece2
            // 
            this.pnlCapturedPiece2.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece2.Location = new System.Drawing.Point(501, 212);
            this.pnlCapturedPiece2.Name = "pnlCapturedPiece2";
            this.pnlCapturedPiece2.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece2.TabIndex = 2;
            this.pnlCapturedPiece2.Visible = false;
            // 
            // pnlCapturedPiece1
            // 
            this.pnlCapturedPiece1.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece1.Location = new System.Drawing.Point(501, 6);
            this.pnlCapturedPiece1.Name = "pnlCapturedPiece1";
            this.pnlCapturedPiece1.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece1.TabIndex = 1;
            this.pnlCapturedPiece1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 716);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 716);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnOptions
            // 
            this.btnOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnOptions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.RibbonWordWrap = false;
            this.btnOptions.SubItemsExpandWidth = 14;
            this.btnOptions.Text = "Tùy Chỉnh";
            // 
            // btnGetFen
            // 
            this.btnGetFen.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnGetFen.Image = ((System.Drawing.Image)(resources.GetObject("btnGetFen.Image")));
            this.btnGetFen.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnGetFen.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGetFen.Name = "btnGetFen";
            this.btnGetFen.RibbonWordWrap = false;
            this.btnGetFen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.btnGetFen.SubItemsExpandWidth = 14;
            this.btnGetFen.Text = "Sao Chép FEN";
            this.btnGetFen.Click += new System.EventHandler(this.btnGetFen_Click);
            // 
            // btnScreenCapture
            // 
            this.btnScreenCapture.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnScreenCapture.Image = global::Chess_Programming.Properties.Resources.ImageCapture;
            this.btnScreenCapture.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnScreenCapture.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnScreenCapture.Name = "btnScreenCapture";
            this.btnScreenCapture.RibbonWordWrap = false;
            this.btnScreenCapture.SubItemsExpandWidth = 14;
            this.btnScreenCapture.Text = "Chụp ảnh";
            this.btnScreenCapture.Click += new System.EventHandler(this.btnScreenCapture_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnUndo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.RibbonWordWrap = false;
            this.btnUndo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.btnUndo.SubItemsExpandWidth = 14;
            this.btnUndo.Text = "Quay Lại";
            this.btnUndo.Tooltip = "Ctrl + Z";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnHint
            // 
            this.btnHint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHint.Enabled = false;
            this.btnHint.Image = ((System.Drawing.Image)(resources.GetObject("btnHint.Image")));
            this.btnHint.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnHint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHint.Name = "btnHint";
            this.btnHint.RibbonWordWrap = false;
            this.btnHint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlH);
            this.btnHint.SubItemsExpandWidth = 14;
            this.btnHint.Text = "Gợi Ý";
            this.btnHint.Tooltip = "Ctrl + H";
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // frmMain
            // 
            this.BottomLeftCornerSize = 0;
            this.BottomRightCornerSize = 0;
            this.ClientSize = new System.Drawing.Size(757, 838);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ Vua 19DTHD4";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonItem btnOptions;
        private DevComponents.DotNetBar.ButtonItem btnUndo;
        private DevComponents.DotNetBar.Command AppCommandTheme;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonItem btnGetFen;
        private System.Windows.Forms.Panel pnlCapturedPiece2;
        private System.Windows.Forms.Panel pnlCapturedPiece1;
        private DevComponents.DotNetBar.ButtonItem btnNewGame;
        private DevComponents.DotNetBar.ButtonItem btnHint;
        private DevComponents.DotNetBar.ButtonItem btnScreenCapture;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
        private DevComponents.DotNetBar.ButtonItem btnChessRule;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnInfo;
        private DevComponents.DotNetBar.ButtonItem btnGVHD;
        private System.Windows.Forms.Panel panel2;
    }
}