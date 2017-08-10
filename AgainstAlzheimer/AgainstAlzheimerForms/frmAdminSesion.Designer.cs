namespace AgainstAlzheimerForms
{
    partial class frmAdminSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminSesion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picRemindersEdit = new System.Windows.Forms.PictureBox();
            this.picAccounts = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRemindersEdit = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemindersEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picRemindersEdit);
            this.groupBox1.Controls.Add(this.picAccounts);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnRemindersEdit);
            this.groupBox1.Controls.Add(this.btnAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picRemindersEdit
            // 
            this.picRemindersEdit.Image = ((System.Drawing.Image)(resources.GetObject("picRemindersEdit.Image")));
            this.picRemindersEdit.Location = new System.Drawing.Point(360, 53);
            this.picRemindersEdit.Name = "picRemindersEdit";
            this.picRemindersEdit.Size = new System.Drawing.Size(200, 200);
            this.picRemindersEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemindersEdit.TabIndex = 13;
            this.picRemindersEdit.TabStop = false;
            // 
            // picAccounts
            // 
            this.picAccounts.Image = ((System.Drawing.Image)(resources.GetObject("picAccounts.Image")));
            this.picAccounts.Location = new System.Drawing.Point(94, 53);
            this.picAccounts.Name = "picAccounts";
            this.picAccounts.Size = new System.Drawing.Size(200, 200);
            this.picAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccounts.TabIndex = 11;
            this.picAccounts.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnHome.Location = new System.Drawing.Point(243, 365);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 33);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Volver al inicio";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRemindersEdit
            // 
            this.btnRemindersEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRemindersEdit.Location = new System.Drawing.Point(361, 259);
            this.btnRemindersEdit.Name = "btnRemindersEdit";
            this.btnRemindersEdit.Size = new System.Drawing.Size(200, 36);
            this.btnRemindersEdit.TabIndex = 9;
            this.btnRemindersEdit.Text = "Editar Recordatorios";
            this.btnRemindersEdit.UseVisualStyleBackColor = true;
            this.btnRemindersEdit.Click += new System.EventHandler(this.btnRemindersEdit_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAccount.Location = new System.Drawing.Point(94, 259);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 36);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Cuenta";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // frmAdminSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgainstAlzheimerForms.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesión de Administrador";
            this.Load += new System.EventHandler(this.frmAdminSesion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRemindersEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRemindersEdit;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.PictureBox picRemindersEdit;
        private System.Windows.Forms.PictureBox picAccounts;
    }
}