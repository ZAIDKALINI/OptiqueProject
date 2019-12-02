namespace ProjectM.PL
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnFournisseur = new System.Windows.Forms.Button();
            this.btnAchat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjectM.Properties.Resources.icons8_manager_96;
            this.pictureBox5.Location = new System.Drawing.Point(5, 181);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjectM.Properties.Resources.icons8_sell_stock_100;
            this.pictureBox4.Location = new System.Drawing.Point(5, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 61);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseur.ForeColor = System.Drawing.Color.DimGray;
            this.btnFournisseur.Location = new System.Drawing.Point(3, 181);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(203, 61);
            this.btnFournisseur.TabIndex = 15;
            this.btnFournisseur.Text = "Gérer des fournisseurs";
            this.btnFournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFournisseur.UseVisualStyleBackColor = true;
            this.btnFournisseur.Click += new System.EventHandler(this.BtnFournisseur_Click);
            // 
            // btnAchat
            // 
            this.btnAchat.FlatAppearance.BorderSize = 0;
            this.btnAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAchat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAchat.ForeColor = System.Drawing.Color.DimGray;
            this.btnAchat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAchat.Location = new System.Drawing.Point(3, 104);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(203, 61);
            this.btnAchat.TabIndex = 14;
            this.btnAchat.Text = "Gérer des Achats";
            this.btnAchat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAchat.UseVisualStyleBackColor = true;
            this.btnAchat.Click += new System.EventHandler(this.BtnAchat_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::ProjectM.Properties.Resources.icons8_shutdown_96;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(172, 575);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 38);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnFournisseur);
            this.Controls.Add(this.btnAchat);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(222, 616);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnFournisseur;
        private System.Windows.Forms.Button btnAchat;
        private System.Windows.Forms.Button button5;
    }
}
