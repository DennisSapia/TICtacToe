namespace TicTacToe
{
    partial class Startwindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startwindow));
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.Tick9 = new System.Windows.Forms.PictureBox();
            this.Tick8 = new System.Windows.Forms.PictureBox();
            this.Tick7 = new System.Windows.Forms.PictureBox();
            this.Tick6 = new System.Windows.Forms.PictureBox();
            this.Tick5 = new System.Windows.Forms.PictureBox();
            this.Tick4 = new System.Windows.Forms.PictureBox();
            this.Tick3 = new System.Windows.Forms.PictureBox();
            this.Tick2 = new System.Windows.Forms.PictureBox();
            this.Tick1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Spielerdran = new System.Windows.Forms.Label();
            this.loser = new System.Windows.Forms.Label();
            this.player1namae = new System.Windows.Forms.Label();
            this.player2name = new System.Windows.Forms.Label();
            this.gewinnermessage = new System.Windows.Forms.Label();
            this.winnername = new System.Windows.Forms.Label();
            this.esistdrantext1 = new System.Windows.Forms.Label();
            this.esistdrantext2 = new System.Windows.Forms.Label();
            this.Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tick9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.Grid.ColumnCount = 3;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.Grid.Controls.Add(this.Tick9, 2, 2);
            this.Grid.Controls.Add(this.Tick8, 1, 2);
            this.Grid.Controls.Add(this.Tick7, 0, 2);
            this.Grid.Controls.Add(this.Tick6, 2, 1);
            this.Grid.Controls.Add(this.Tick5, 1, 1);
            this.Grid.Controls.Add(this.Tick4, 0, 1);
            this.Grid.Controls.Add(this.Tick3, 2, 0);
            this.Grid.Controls.Add(this.Tick2, 1, 0);
            this.Grid.Controls.Add(this.Tick1, 0, 0);
            this.Grid.Location = new System.Drawing.Point(411, 185);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 3;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Grid.Size = new System.Drawing.Size(533, 504);
            this.Grid.TabIndex = 0;
            // 
            // Tick9
            // 
            this.Tick9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick9.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick9.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick9.InitialImage")));
            this.Tick9.Location = new System.Drawing.Point(358, 339);
            this.Tick9.Name = "Tick9";
            this.Tick9.Size = new System.Drawing.Size(170, 160);
            this.Tick9.TabIndex = 9;
            this.Tick9.TabStop = false;
            this.Tick9.Click += new System.EventHandler(this.Tick9_Click);
            // 
            // Tick8
            // 
            this.Tick8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick8.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick8.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick8.InitialImage")));
            this.Tick8.Location = new System.Drawing.Point(181, 339);
            this.Tick8.Name = "Tick8";
            this.Tick8.Size = new System.Drawing.Size(169, 160);
            this.Tick8.TabIndex = 8;
            this.Tick8.TabStop = false;
            this.Tick8.Click += new System.EventHandler(this.Tick8_Click);
            // 
            // Tick7
            // 
            this.Tick7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick7.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick7.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick7.InitialImage")));
            this.Tick7.Location = new System.Drawing.Point(5, 339);
            this.Tick7.Name = "Tick7";
            this.Tick7.Size = new System.Drawing.Size(168, 160);
            this.Tick7.TabIndex = 7;
            this.Tick7.TabStop = false;
            this.Tick7.Click += new System.EventHandler(this.Tick7_Click);
            // 
            // Tick6
            // 
            this.Tick6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick6.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick6.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick6.InitialImage")));
            this.Tick6.Location = new System.Drawing.Point(358, 172);
            this.Tick6.Name = "Tick6";
            this.Tick6.Size = new System.Drawing.Size(170, 159);
            this.Tick6.TabIndex = 6;
            this.Tick6.TabStop = false;
            this.Tick6.Click += new System.EventHandler(this.Tick6_Click);
            // 
            // Tick5
            // 
            this.Tick5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick5.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick5.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick5.InitialImage")));
            this.Tick5.Location = new System.Drawing.Point(181, 172);
            this.Tick5.Name = "Tick5";
            this.Tick5.Size = new System.Drawing.Size(169, 159);
            this.Tick5.TabIndex = 5;
            this.Tick5.TabStop = false;
            this.Tick5.Click += new System.EventHandler(this.Tick5_Click);
            // 
            // Tick4
            // 
            this.Tick4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick4.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick4.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick4.InitialImage")));
            this.Tick4.Location = new System.Drawing.Point(5, 172);
            this.Tick4.Name = "Tick4";
            this.Tick4.Size = new System.Drawing.Size(168, 159);
            this.Tick4.TabIndex = 4;
            this.Tick4.TabStop = false;
            this.Tick4.Click += new System.EventHandler(this.Tick4_Click);
            // 
            // Tick3
            // 
            this.Tick3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick3.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick3.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick3.InitialImage")));
            this.Tick3.Location = new System.Drawing.Point(358, 5);
            this.Tick3.Name = "Tick3";
            this.Tick3.Size = new System.Drawing.Size(170, 159);
            this.Tick3.TabIndex = 3;
            this.Tick3.TabStop = false;
            this.Tick3.Click += new System.EventHandler(this.Tick3_Click);
            // 
            // Tick2
            // 
            this.Tick2.BackColor = System.Drawing.Color.Black;
            this.Tick2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick2.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick2.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick2.InitialImage")));
            this.Tick2.Location = new System.Drawing.Point(181, 5);
            this.Tick2.Name = "Tick2";
            this.Tick2.Size = new System.Drawing.Size(169, 159);
            this.Tick2.TabIndex = 2;
            this.Tick2.TabStop = false;
            this.Tick2.Click += new System.EventHandler(this.Tick2_Click);
            // 
            // Tick1
            // 
            this.Tick1.BackColor = System.Drawing.Color.Black;
            this.Tick1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tick1.Image = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.Tick1.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tick1.InitialImage")));
            this.Tick1.Location = new System.Drawing.Point(5, 5);
            this.Tick1.Name = "Tick1";
            this.Tick1.Size = new System.Drawing.Size(168, 159);
            this.Tick1.TabIndex = 1;
            this.Tick1.TabStop = false;
            this.Tick1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label5.Location = new System.Drawing.Point(1009, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Exit (x)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Spielerdran
            // 
            this.Spielerdran.AutoSize = true;
            this.Spielerdran.BackColor = System.Drawing.Color.MidnightBlue;
            this.Spielerdran.Font = new System.Drawing.Font("Ravie", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spielerdran.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Spielerdran.Location = new System.Drawing.Point(323, 789);
            this.Spielerdran.Name = "Spielerdran";
            this.Spielerdran.Size = new System.Drawing.Size(608, 35);
            this.Spielerdran.TabIndex = 6;
            this.Spielerdran.Text = "Der erste Spieler macht seinen Zug";
            // 
            // loser
            // 
            this.loser.AutoSize = true;
            this.loser.BackColor = System.Drawing.Color.Black;
            this.loser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loser.Font = new System.Drawing.Font("Mistral", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loser.ForeColor = System.Drawing.Color.Red;
            this.loser.Location = new System.Drawing.Point(486, 129);
            this.loser.Name = "loser";
            this.loser.Size = new System.Drawing.Size(339, 53);
            this.loser.TabIndex = 7;
            this.loser.Text = "It\'s a Tie! Try again??";
            this.loser.Visible = false;
            this.loser.Click += new System.EventHandler(this.label6_Click);
            // 
            // player1namae
            // 
            this.player1namae.AutoSize = true;
            this.player1namae.BackColor = System.Drawing.Color.Black;
            this.player1namae.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1namae.ForeColor = System.Drawing.Color.Aqua;
            this.player1namae.Location = new System.Drawing.Point(390, 71);
            this.player1namae.Name = "player1namae";
            this.player1namae.Size = new System.Drawing.Size(104, 26);
            this.player1namae.TabIndex = 8;
            this.player1namae.Text = "Player 1";
            // 
            // player2name
            // 
            this.player2name.AutoSize = true;
            this.player2name.BackColor = System.Drawing.Color.Black;
            this.player2name.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2name.ForeColor = System.Drawing.Color.Yellow;
            this.player2name.Location = new System.Drawing.Point(827, 67);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(104, 26);
            this.player2name.TabIndex = 9;
            this.player2name.Text = "Player 2";
            // 
            // gewinnermessage
            // 
            this.gewinnermessage.AutoSize = true;
            this.gewinnermessage.BackColor = System.Drawing.Color.Black;
            this.gewinnermessage.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gewinnermessage.ForeColor = System.Drawing.Color.Aqua;
            this.gewinnermessage.Location = new System.Drawing.Point(411, 156);
            this.gewinnermessage.Name = "gewinnermessage";
            this.gewinnermessage.Size = new System.Drawing.Size(170, 26);
            this.gewinnermessage.TabIndex = 13;
            this.gewinnermessage.Text = "The winner is:";
            this.gewinnermessage.Visible = false;
            // 
            // winnername
            // 
            this.winnername.AutoSize = true;
            this.winnername.BackColor = System.Drawing.Color.Black;
            this.winnername.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnername.ForeColor = System.Drawing.Color.Aqua;
            this.winnername.Location = new System.Drawing.Point(764, 156);
            this.winnername.Name = "winnername";
            this.winnername.Size = new System.Drawing.Size(61, 26);
            this.winnername.TabIndex = 14;
            this.winnername.Text = "The ";
            this.winnername.Visible = false;
            // 
            // esistdrantext1
            // 
            this.esistdrantext1.AutoSize = true;
            this.esistdrantext1.BackColor = System.Drawing.Color.Transparent;
            this.esistdrantext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esistdrantext1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.esistdrantext1.Location = new System.Drawing.Point(24, 777);
            this.esistdrantext1.Name = "esistdrantext1";
            this.esistdrantext1.Size = new System.Drawing.Size(134, 48);
            this.esistdrantext1.TabIndex = 15;
            this.esistdrantext1.Text = "Es ist ";
            this.esistdrantext1.Visible = false;
            // 
            // esistdrantext2
            // 
            this.esistdrantext2.AutoSize = true;
            this.esistdrantext2.BackColor = System.Drawing.Color.Transparent;
            this.esistdrantext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esistdrantext2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.esistdrantext2.Location = new System.Drawing.Point(829, 777);
            this.esistdrantext2.Name = "esistdrantext2";
            this.esistdrantext2.Size = new System.Drawing.Size(115, 48);
            this.esistdrantext2.TabIndex = 16;
            this.esistdrantext2.Text = "dran!";
            this.esistdrantext2.Visible = false;
            // 
            // Startwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.tictactoe_start_image;
            this.ClientSize = new System.Drawing.Size(1071, 862);
            this.Controls.Add(this.esistdrantext2);
            this.Controls.Add(this.esistdrantext1);
            this.Controls.Add(this.winnername);
            this.Controls.Add(this.gewinnermessage);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1namae);
            this.Controls.Add(this.loser);
            this.Controls.Add(this.Spielerdran);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Startwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tick9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.PictureBox Tick9;
        private System.Windows.Forms.PictureBox Tick8;
        private System.Windows.Forms.PictureBox Tick7;
        private System.Windows.Forms.PictureBox Tick6;
        private System.Windows.Forms.PictureBox Tick5;
        private System.Windows.Forms.PictureBox Tick4;
        private System.Windows.Forms.PictureBox Tick3;
        private System.Windows.Forms.PictureBox Tick2;
        private System.Windows.Forms.PictureBox Tick1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Spielerdran;
        private System.Windows.Forms.Label loser;
        private System.Windows.Forms.Label player1namae;
        private System.Windows.Forms.Label player2name;
        private System.Windows.Forms.Label gewinnermessage;
        private System.Windows.Forms.Label winnername;
        private System.Windows.Forms.Label esistdrantext1;
        private System.Windows.Forms.Label esistdrantext2;
    }
}

