namespace Brackettattack
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PlayerIconList = new System.Windows.Forms.ImageList(this.components);
            this.NewPlayerName = new System.Windows.Forms.TextBox();
            this.CurrentPlayerList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.RemovePlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerImageList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerIconList
            // 
            this.PlayerIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.PlayerIconList.ImageSize = new System.Drawing.Size(16, 16);
            this.PlayerIconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NewPlayerName
            // 
            this.NewPlayerName.Location = new System.Drawing.Point(12, 393);
            this.NewPlayerName.Name = "NewPlayerName";
            this.NewPlayerName.Size = new System.Drawing.Size(163, 20);
            this.NewPlayerName.TabIndex = 0;
            this.NewPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPlayerName.TextChanged += new System.EventHandler(this.NewPlayerName_TextChanged);
            // 
            // CurrentPlayerList
            // 
            this.CurrentPlayerList.FormattingEnabled = true;
            this.CurrentPlayerList.Location = new System.Drawing.Point(556, 343);
            this.CurrentPlayerList.Name = "CurrentPlayerList";
            this.CurrentPlayerList.Size = new System.Drawing.Size(232, 95);
            this.CurrentPlayerList.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(181, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 95);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(431, 343);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(89, 44);
            this.AddPlayerButton.TabIndex = 3;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // RemovePlayerButton
            // 
            this.RemovePlayerButton.Location = new System.Drawing.Point(431, 393);
            this.RemovePlayerButton.Name = "RemovePlayerButton";
            this.RemovePlayerButton.Size = new System.Drawing.Size(89, 45);
            this.RemovePlayerButton.TabIndex = 4;
            this.RemovePlayerButton.Text = "Remove Player";
            this.RemovePlayerButton.UseVisualStyleBackColor = true;
            this.RemovePlayerButton.Click += new System.EventHandler(this.RemovePlayerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Player List";
            // 
            // PlayerImageList
            // 
            this.PlayerImageList.FormattingEnabled = true;
            this.PlayerImageList.Items.AddRange(new object[] {
            "Mario",
            "Donkey Kong",
            "Link",
            "Samus",
            "Dark Samus",
            "Yoshi",
            "Kirby",
            "Fox",
            "Pikachu",
            "Luigi",
            "Ness",
            "Captain Falcon",
            "Jigglypuff",
            "Peach",
            "Daisy",
            "Bowser",
            "Ice Climbers",
            "Sheik",
            "Zelda",
            "Dr.Mario",
            "Pichu",
            "Falco",
            "Marth",
            "Lucina",
            "Young Link",
            "Ganondorf",
            "Mewtwo",
            "Roy",
            "Mr.Game & Watch",
            "Meta Knight",
            "Pit",
            "Dark Pit",
            "Zero Suit Samus",
            "Wario",
            "Ike",
            "Pokemon Trainer",
            "Diddy Kong",
            "Lucas",
            "Sonic",
            "King Dedede",
            "R.O.B.",
            "Toon Link",
            "Wolf",
            "Villager",
            "Megaman",
            "Wii Fit Trainer",
            "Rosalina & Luma",
            "Little Mac",
            "Greninja",
            "Mii Fighter",
            "Palutena",
            "Pac-man",
            "Robin",
            "Shulk",
            "Bowser Jr.",
            "Duck Hunt",
            "Ryu",
            "Ken",
            "Cloud",
            "Corrin",
            "Bayonetta",
            "Inkling",
            "Ridley",
            "Simon",
            "Richter",
            "King K. Rool",
            "Isabelle",
            "Incineroar",
            "Piranha Plant",
            "Joker",
            "Hero",
            "Banjo & Kazooie",
            "Terry",
            "Byleth",
            "Min Min"});
            this.PlayerImageList.Location = new System.Drawing.Point(292, 343);
            this.PlayerImageList.Name = "PlayerImageList";
            this.PlayerImageList.Size = new System.Drawing.Size(120, 95);
            this.PlayerImageList.TabIndex = 6;
            this.PlayerImageList.SelectedIndexChanged += new System.EventHandler(this.PlayerImageList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Player Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerImageList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemovePlayerButton);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CurrentPlayerList);
            this.Controls.Add(this.NewPlayerName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "The Bracketteer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList PlayerIconList;
        private System.Windows.Forms.TextBox NewPlayerName;
        private System.Windows.Forms.ListBox CurrentPlayerList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Button RemovePlayerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PlayerImageList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

