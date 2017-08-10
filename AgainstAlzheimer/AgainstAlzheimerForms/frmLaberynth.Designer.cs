namespace AgainstAlzheimerForms
{
    partial class frmLaberynth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaberynth));
            this.lblCronometro = new System.Windows.Forms.Label();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reiciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picWalker = new System.Windows.Forms.PictureBox();
            this.picLaberynth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblCronometro.Location = new System.Drawing.Point(227, 546);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(88, 22);
            this.lblCronometro.TabIndex = 34;
            this.lblCronometro.Text = "00:00:00";
            // 
            // Cronometro
            // 
            this.Cronometro.Interval = 1000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // picCheese
            // 
            this.picCheese.Image = global::AgainstAlzheimerForms.Properties.Resources.ima_queso;
            this.picCheese.Location = new System.Drawing.Point(404, 526);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(75, 75);
            this.picCheese.TabIndex = 30;
            this.picCheese.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Image = global::AgainstAlzheimerForms.Properties.Resources.raton_perez;
            this.picMouse.Location = new System.Drawing.Point(12, 37);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(75, 105);
            this.picMouse.TabIndex = 27;
            this.picMouse.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiciarToolStripMenuItem,
            this.volverAlMenúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reiciarToolStripMenuItem
            // 
            this.reiciarToolStripMenuItem.Name = "reiciarToolStripMenuItem";
            this.reiciarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reiciarToolStripMenuItem.Text = "Reiniciar";
            this.reiciarToolStripMenuItem.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // volverAlMenúToolStripMenuItem
            // 
            this.volverAlMenúToolStripMenuItem.Name = "volverAlMenúToolStripMenuItem";
            this.volverAlMenúToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.volverAlMenúToolStripMenuItem.Text = "Volver al menú...";
            this.volverAlMenúToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picWalker
            // 
            this.picWalker.Image = global::AgainstAlzheimerForms.Properties.Resources.raton;
            this.picWalker.Location = new System.Drawing.Point(144, 57);
            this.picWalker.Name = "picWalker";
            this.picWalker.Size = new System.Drawing.Size(20, 20);
            this.picWalker.TabIndex = 41;
            this.picWalker.TabStop = false;
            // 
            // picLaberynth
            // 
            this.picLaberynth.Image = global::AgainstAlzheimerForms.Properties.Resources.ExpertLaberynth;
            this.picLaberynth.Location = new System.Drawing.Point(104, 37);
            this.picLaberynth.Name = "picLaberynth";
            this.picLaberynth.Size = new System.Drawing.Size(1161, 481);
            this.picLaberynth.TabIndex = 40;
            this.picLaberynth.TabStop = false;
            // 
            // frmLaberynth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgainstAlzheimerForms.Properties.Resources.FondoLab;
            this.ClientSize = new System.Drawing.Size(491, 605);
            this.Controls.Add(this.picWalker);
            this.Controls.Add(this.picLaberynth);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picMouse);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLaberynth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laberinto";
            this.Load += new System.EventHandler(this.frmLaberynth_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLaberynth_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaberynth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox picWalker;
        private System.Windows.Forms.PictureBox picLaberynth;
        private System.Windows.Forms.ToolStripMenuItem reiciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenúToolStripMenuItem;
    }
}