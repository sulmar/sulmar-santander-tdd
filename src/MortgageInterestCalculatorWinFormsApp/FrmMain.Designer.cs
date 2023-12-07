namespace MortgageInterestCalculatorWinFormsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lLeftToPaid = new Label();
            tRate = new TextBox();
            lRate = new Label();
            bCalculate = new Button();
            lInterest = new Label();
            tIntereset = new TextBox();
            nLeftToPaid = new NumericUpDown();
            lEmoji = new Label();
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            miCalculate = new ToolStripMenuItem();
            tLeftToPaid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nLeftToPaid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lLeftToPaid
            // 
            lLeftToPaid.AutoSize = true;
            lLeftToPaid.Location = new Point(33, 64);
            lLeftToPaid.Name = "lLeftToPaid";
            lLeftToPaid.Size = new Size(144, 15);
            lLeftToPaid.TabIndex = 1;
            lLeftToPaid.Text = "Kwota pozostała do spłaty";
            // 
            // tRate
            // 
            tRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tRate.Location = new Point(32, 153);
            tRate.Name = "tRate";
            tRate.Size = new Size(518, 23);
            tRate.TabIndex = 2;
            // 
            // lRate
            // 
            lRate.AutoSize = true;
            lRate.Location = new Point(32, 135);
            lRate.Name = "lRate";
            lRate.Size = new Size(138, 15);
            lRate.TabIndex = 3;
            lRate.Text = "Oprocentowanie kredytu";
            // 
            // bCalculate
            // 
            bCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bCalculate.Location = new Point(196, 232);
            bCalculate.MinimumSize = new Size(100, 70);
            bCalculate.Name = "bCalculate";
            bCalculate.Size = new Size(180, 70);
            bCalculate.TabIndex = 4;
            bCalculate.Text = "Oblicz odsetki";
            bCalculate.UseVisualStyleBackColor = true;
            bCalculate.Click += bCalculate_Click;
            // 
            // lInterest
            // 
            lInterest.AutoSize = true;
            lInterest.Location = new Point(33, 328);
            lInterest.Name = "lInterest";
            lInterest.Size = new Size(47, 15);
            lInterest.TabIndex = 5;
            lInterest.Text = "Odsetki";
            // 
            // tIntereset
            // 
            tIntereset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tIntereset.BorderStyle = BorderStyle.FixedSingle;
            tIntereset.Location = new Point(32, 346);
            tIntereset.Name = "tIntereset";
            tIntereset.ReadOnly = true;
            tIntereset.Size = new Size(512, 23);
            tIntereset.TabIndex = 6;
            // 
            // nLeftToPaid
            // 
            nLeftToPaid.Location = new Point(37, 82);
            nLeftToPaid.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nLeftToPaid.Name = "nLeftToPaid";
            nLeftToPaid.Size = new Size(504, 23);
            nLeftToPaid.TabIndex = 7;
            // 
            // lEmoji
            // 
            lEmoji.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lEmoji.AutoSize = true;
            lEmoji.Font = new Font("Segoe UI Emoji", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lEmoji.Location = new Point(634, 291);
            lEmoji.Name = "lEmoji";
            lEmoji.Size = new Size(96, 85);
            lEmoji.TabIndex = 8;
            lEmoji.Text = ":-)";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miCalculate });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // miCalculate
            // 
            miCalculate.Name = "miCalculate";
            miCalculate.Size = new Size(148, 22);
            miCalculate.Text = "Oblicz odsetki";
            miCalculate.Click += miCalculate_Click;
            // 
            // tLeftToPaid
            // 
            tLeftToPaid.Location = new Point(36, 36);
            tLeftToPaid.Name = "tLeftToPaid";
            tLeftToPaid.Size = new Size(508, 23);
            tLeftToPaid.TabIndex = 10;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 410);
            Controls.Add(tLeftToPaid);
            Controls.Add(lEmoji);
            Controls.Add(nLeftToPaid);
            Controls.Add(tIntereset);
            Controls.Add(lInterest);
            Controls.Add(bCalculate);
            Controls.Add(lRate);
            Controls.Add(tRate);
            Controls.Add(lLeftToPaid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(400, 300);
            Name = "FrmMain";
            Text = "Mortgage interest calculator";
            ((System.ComponentModel.ISupportInitialize)nLeftToPaid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lLeftToPaid;
        private TextBox tRate;
        private Label lRate;
        private Button bCalculate;
        private Label lInterest;
        private TextBox tIntereset;
        private NumericUpDown nLeftToPaid;
        private Label lEmoji;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem miCalculate;
        private TextBox tLeftToPaid;
    }
}
