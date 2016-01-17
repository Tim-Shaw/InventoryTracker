namespace FileHandlingAssignment
{
    partial class FrmMain
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
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGameInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdData = new System.Windows.Forms.SaveFileDialog();
            this.ofdData = new System.Windows.Forms.OpenFileDialog();
            this.cmbGames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInv = new System.Windows.Forms.TextBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnInv = new System.Windows.Forms.Button();
            this.mstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(543, 24);
            this.mstMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInventoryToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveInventoryToolStripMenuItem
            // 
            this.saveInventoryToolStripMenuItem.Name = "saveInventoryToolStripMenuItem";
            this.saveInventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveInventoryToolStripMenuItem.Text = "Save";
            this.saveInventoryToolStripMenuItem.Click += new System.EventHandler(this.saveInventoryToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGameToolStripMenuItem,
            this.removeGameToolStripMenuItem,
            this.changeGameInfoToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addNewGameToolStripMenuItem
            // 
            this.addNewGameToolStripMenuItem.Name = "addNewGameToolStripMenuItem";
            this.addNewGameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addNewGameToolStripMenuItem.Text = "Add New Game";
            this.addNewGameToolStripMenuItem.Click += new System.EventHandler(this.addNewGameToolStripMenuItem_Click);
            // 
            // removeGameToolStripMenuItem
            // 
            this.removeGameToolStripMenuItem.Name = "removeGameToolStripMenuItem";
            this.removeGameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeGameToolStripMenuItem.Text = "Remove Game";
            this.removeGameToolStripMenuItem.Click += new System.EventHandler(this.removeGameToolStripMenuItem_Click);
            // 
            // changeGameInfoToolStripMenuItem
            // 
            this.changeGameInfoToolStripMenuItem.Name = "changeGameInfoToolStripMenuItem";
            this.changeGameInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.changeGameInfoToolStripMenuItem.Text = "Change Game Info";
            this.changeGameInfoToolStripMenuItem.Click += new System.EventHandler(this.changeGameInfoToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // cmbGames
            // 
            this.cmbGames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbGames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGames.FormattingEnabled = true;
            this.cmbGames.Location = new System.Drawing.Point(274, 41);
            this.cmbGames.Name = "cmbGames";
            this.cmbGames.Size = new System.Drawing.Size(237, 21);
            this.cmbGames.TabIndex = 1;
            this.cmbGames.SelectedIndexChanged += new System.EventHandler(this.cmbGames_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Inventory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Developer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Platform:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Select a game to show its data";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(110, 75);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(129, 36);
            this.txtTitle.TabIndex = 23;
            // 
            // txtPlatform
            // 
            this.txtPlatform.Location = new System.Drawing.Point(110, 136);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(129, 20);
            this.txtPlatform.TabIndex = 24;
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(110, 179);
            this.txtDev.Name = "txtDev";
            this.txtDev.ReadOnly = true;
            this.txtDev.Size = new System.Drawing.Size(129, 20);
            this.txtDev.TabIndex = 25;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(110, 223);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(129, 20);
            this.txtGenre.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 270);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(129, 20);
            this.txtPrice.TabIndex = 27;
            // 
            // txtInv
            // 
            this.txtInv.Location = new System.Drawing.Point(110, 316);
            this.txtInv.Name = "txtInv";
            this.txtInv.Size = new System.Drawing.Size(129, 20);
            this.txtInv.TabIndex = 28;
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(260, 75);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(271, 261);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 29;
            this.picCover.TabStop = false;
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(110, 348);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(129, 30);
            this.btnInv.TabIndex = 30;
            this.btnInv.Text = "Change Inventory";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 390);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.txtInv);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDev);
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGames);
            this.Controls.Add(this.mstMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mstMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGameInfoToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdData;
        private System.Windows.Forms.OpenFileDialog ofdData;
        private System.Windows.Forms.ComboBox cmbGames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInv;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;

    }
}

