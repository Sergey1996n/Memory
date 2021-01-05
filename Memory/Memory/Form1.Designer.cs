namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Game = new System.Windows.Forms.ToolStripMenuItem();
            this.New_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.Parameters = new System.Windows.Forms.ToolStripMenuItem();
            this.Decor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowReference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.OtherGames = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Game,
            this.Reference});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Game
            // 
            this.Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_Game,
            this.toolStripMenuItem1,
            this.Statistics,
            this.Parameters,
            this.Decor,
            this.toolStripMenuItem2,
            this.Exit});
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(45, 20);
            this.Game.Text = "&Игра";
            // 
            // New_Game
            // 
            this.New_Game.Name = "New_Game";
            this.New_Game.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.New_Game.Size = new System.Drawing.Size(218, 22);
            this.New_Game.Text = "&Новая игра";
            this.New_Game.Click += new System.EventHandler(this.New_Game_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            // 
            // Statistics
            // 
            this.Statistics.Name = "Statistics";
            this.Statistics.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.Statistics.Size = new System.Drawing.Size(218, 22);
            this.Statistics.Text = "С&татистика";
            // 
            // Parameters
            // 
            this.Parameters.Name = "Parameters";
            this.Parameters.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Parameters.Size = new System.Drawing.Size(218, 22);
            this.Parameters.Text = "П&араметры";
            // 
            // Decor
            // 
            this.Decor.Name = "Decor";
            this.Decor.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.Decor.Size = new System.Drawing.Size(218, 22);
            this.Decor.Text = "&Изменить оформление";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(218, 22);
            this.Exit.Text = "В&ыход";
            // 
            // Reference
            // 
            this.Reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowReference,
            this.toolStripMenuItem3,
            this.About,
            this.toolStripMenuItem4,
            this.OtherGames});
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(64, 20);
            this.Reference.Text = "&Справка";
            // 
            // ShowReference
            // 
            this.ShowReference.Name = "ShowReference";
            this.ShowReference.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ShowReference.Size = new System.Drawing.Size(210, 22);
            this.ShowReference.Text = "Прос&мотреть справку";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 6);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(210, 22);
            this.About.Text = "&О программе";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(207, 6);
            // 
            // OtherGames
            // 
            this.OtherGames.Name = "OtherGames";
            this.OtherGames.Size = new System.Drawing.Size(210, 22);
            this.OtherGames.Text = "Дру&гие игры в интернете";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fon.bmp");
            this.imageList1.Images.SetKeyName(1, "бараш.bmp");
            this.imageList1.Images.SetKeyName(2, "биби.bmp");
            this.imageList1.Images.SetKeyName(3, "ёжик.bmp");
            this.imageList1.Images.SetKeyName(4, "крош.bmp");
            this.imageList1.Images.SetKeyName(5, "лили.bmp");
            this.imageList1.Images.SetKeyName(6, "нюша.bmp");
            this.imageList1.Images.SetKeyName(7, "пим.bmp");
            this.imageList1.Images.SetKeyName(8, "совунья.bmp");
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 344);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Game;
        private System.Windows.Forms.ToolStripMenuItem New_Game;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Statistics;
        private System.Windows.Forms.ToolStripMenuItem Parameters;
        private System.Windows.Forms.ToolStripMenuItem Decor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Reference;
        private System.Windows.Forms.ToolStripMenuItem ShowReference;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem OtherGames;
        private System.Windows.Forms.ImageList imageList1;
    }
}

