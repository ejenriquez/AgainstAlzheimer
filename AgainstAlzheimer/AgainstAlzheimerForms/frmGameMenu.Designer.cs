namespace AgainstAlzheimerForms
{
    partial class frmGameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLaberynth = new System.Windows.Forms.Button();
            this.btnMemorama = new System.Windows.Forms.Button();
            this.btnJigsawPuzzle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLaberynth);
            this.groupBox1.Controls.Add(this.btnMemorama);
            this.groupBox1.Controls.Add(this.btnJigsawPuzzle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AgainstAlzheimerForms.Properties.Resources.JigsawPuzzle;
            this.pictureBox2.Location = new System.Drawing.Point(38, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgainstAlzheimerForms.Properties.Resources.Memorama;
            this.pictureBox1.Location = new System.Drawing.Point(269, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnBack.Location = new System.Drawing.Point(288, 369);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLaberynth
            // 
            this.btnLaberynth.AutoSize = true;
            this.btnLaberynth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLaberynth.Location = new System.Drawing.Point(500, 265);
            this.btnLaberynth.Name = "btnLaberynth";
            this.btnLaberynth.Size = new System.Drawing.Size(150, 32);
            this.btnLaberynth.TabIndex = 2;
            this.btnLaberynth.Text = "Laberinto";
            this.btnLaberynth.UseVisualStyleBackColor = true;
            this.btnLaberynth.Click += new System.EventHandler(this.btnLaberynth_Click);
            // 
            // btnMemorama
            // 
            this.btnMemorama.AutoSize = true;
            this.btnMemorama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnMemorama.Location = new System.Drawing.Point(269, 265);
            this.btnMemorama.Name = "btnMemorama";
            this.btnMemorama.Size = new System.Drawing.Size(150, 32);
            this.btnMemorama.TabIndex = 1;
            this.btnMemorama.Text = "Memorama";
            this.btnMemorama.UseVisualStyleBackColor = true;
            this.btnMemorama.Click += new System.EventHandler(this.btnMemorama_Click);
            // 
            // btnJigsawPuzzle
            // 
            this.btnJigsawPuzzle.AutoSize = true;
            this.btnJigsawPuzzle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnJigsawPuzzle.Location = new System.Drawing.Point(38, 265);
            this.btnJigsawPuzzle.Name = "btnJigsawPuzzle";
            this.btnJigsawPuzzle.Size = new System.Drawing.Size(150, 32);
            this.btnJigsawPuzzle.TabIndex = 0;
            this.btnJigsawPuzzle.Text = "Rompecabezas";
            this.btnJigsawPuzzle.UseVisualStyleBackColor = true;
            this.btnJigsawPuzzle.Click += new System.EventHandler(this.btnJigsawPuzzle_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AgainstAlzheimerForms.Properties.Resources.Laberynth;
            this.pictureBox3.Location = new System.Drawing.Point(500, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // frmGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgainstAlzheimerForms.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de Juegos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLaberynth;
        private System.Windows.Forms.Button btnMemorama;
        private System.Windows.Forms.Button btnJigsawPuzzle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}