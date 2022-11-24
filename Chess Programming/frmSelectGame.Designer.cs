namespace Chess_Programming
{
    partial class frmSelectGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectGame));
            this.pbVsPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbVsCPU = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVsHuman = new System.Windows.Forms.Button();
            this.btnVsCPU = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoiLAN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVsPlayer
            // 
            this.pbVsPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbVsPlayer.BackgroundImage")));
            this.pbVsPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbVsPlayer.Location = new System.Drawing.Point(37, 89);
            this.pbVsPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pbVsPlayer.Name = "pbVsPlayer";
            this.pbVsPlayer.Size = new System.Drawing.Size(141, 125);
            this.pbVsPlayer.TabIndex = 0;
            this.pbVsPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn chế độ chơi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chơi offline 2 người";
            // 
            // pbVsCPU
            // 
            this.pbVsCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbVsCPU.BackgroundImage")));
            this.pbVsCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbVsCPU.Location = new System.Drawing.Point(229, 89);
            this.pbVsCPU.Margin = new System.Windows.Forms.Padding(2);
            this.pbVsCPU.Name = "pbVsCPU";
            this.pbVsCPU.Size = new System.Drawing.Size(141, 125);
            this.pbVsCPU.TabIndex = 3;
            this.pbVsCPU.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(449, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chơi với máy";
            // 
            // btnVsHuman
            // 
            this.btnVsHuman.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVsHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsHuman.Location = new System.Drawing.Point(53, 223);
            this.btnVsHuman.Margin = new System.Windows.Forms.Padding(2);
            this.btnVsHuman.Name = "btnVsHuman";
            this.btnVsHuman.Size = new System.Drawing.Size(114, 38);
            this.btnVsHuman.TabIndex = 5;
            this.btnVsHuman.Text = "Chọn";
            this.btnVsHuman.UseVisualStyleBackColor = true;
            this.btnVsHuman.Click += new System.EventHandler(this.btnVsHuman_Click);
            // 
            // btnVsCPU
            // 
            this.btnVsCPU.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnVsCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsCPU.Location = new System.Drawing.Point(435, 223);
            this.btnVsCPU.Margin = new System.Windows.Forms.Padding(2);
            this.btnVsCPU.Name = "btnVsCPU";
            this.btnVsCPU.Size = new System.Drawing.Size(114, 38);
            this.btnVsCPU.TabIndex = 6;
            this.btnVsCPU.Text = "Chọn";
            this.btnVsCPU.UseVisualStyleBackColor = true;
            this.btnVsCPU.Click += new System.EventHandler(this.btnVsCPU_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(425, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 125);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoiLAN
            // 
            this.btnChoiLAN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChoiLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiLAN.Location = new System.Drawing.Point(242, 223);
            this.btnChoiLAN.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoiLAN.Name = "btnChoiLAN";
            this.btnChoiLAN.Size = new System.Drawing.Size(114, 38);
            this.btnChoiLAN.TabIndex = 8;
            this.btnChoiLAN.Text = "Chọn";
            this.btnChoiLAN.UseVisualStyleBackColor = true;
            this.btnChoiLAN.Click += new System.EventHandler(this.btnChoiLAN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(239, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chơi mạng LAN";
            // 
            // frmSelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChoiLAN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVsCPU);
            this.Controls.Add(this.btnVsHuman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbVsCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbVsPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn chế độ chơi";
            this.Load += new System.EventHandler(this.frmSelectGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVsPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVsCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVsPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbVsCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVsHuman;
        private System.Windows.Forms.Button btnVsCPU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChoiLAN;
        private System.Windows.Forms.Label label4;
    }
}