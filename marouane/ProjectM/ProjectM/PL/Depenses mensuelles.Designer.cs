namespace ProjectM.PL
{
    partial class Depenses_mensuelles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_New_Immo = new MaterialSkin.Controls.MaterialCheckBox();
            this.dp_Immo = new System.Windows.Forms.DateTimePicker();
            this.btn_Sub_Immo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrix_Immo = new System.Windows.Forms.TextBox();
            this.txtN_Immo = new System.Windows.Forms.TextBox();
            this.cb_Choix = new System.Windows.Forms.ComboBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_New_Dep = new MaterialSkin.Controls.MaterialCheckBox();
            this.dp_Dep = new System.Windows.Forms.DateTimePicker();
            this.btn_Sub_Dep = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Prix_Dep = new System.Windows.Forms.TextBox();
            this.txtN_Dep = new System.Windows.Forms.TextBox();
            this.cb_Choix_Dep = new System.Windows.Forms.ComboBox();
            this.txt_Desc_Dep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb_New_Immo);
            this.panel1.Controls.Add(this.dp_Immo);
            this.panel1.Controls.Add(this.btn_Sub_Immo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrix_Immo);
            this.panel1.Controls.Add(this.txtN_Immo);
            this.panel1.Controls.Add(this.cb_Choix);
            this.panel1.Controls.Add(this.txt_Desc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 454);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Choix_Immobilisation";
            // 
            // cb_New_Immo
            // 
            this.cb_New_Immo.AutoSize = true;
            this.cb_New_Immo.Depth = 0;
            this.cb_New_Immo.Font = new System.Drawing.Font("Roboto", 10F);
            this.cb_New_Immo.Location = new System.Drawing.Point(186, 263);
            this.cb_New_Immo.Margin = new System.Windows.Forms.Padding(0);
            this.cb_New_Immo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cb_New_Immo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_New_Immo.Name = "cb_New_Immo";
            this.cb_New_Immo.Ripple = true;
            this.cb_New_Immo.Size = new System.Drawing.Size(175, 30);
            this.cb_New_Immo.TabIndex = 28;
            this.cb_New_Immo.Text = "Noveau_Immobilisation";
            this.cb_New_Immo.UseVisualStyleBackColor = true;
            this.cb_New_Immo.CheckedChanged += new System.EventHandler(this.Cb_New_Immo_CheckedChanged);
            // 
            // dp_Immo
            // 
            this.dp_Immo.CalendarFont = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_Immo.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.dp_Immo.Location = new System.Drawing.Point(179, 4);
            this.dp_Immo.Name = "dp_Immo";
            this.dp_Immo.Size = new System.Drawing.Size(252, 27);
            this.dp_Immo.TabIndex = 15;
            // 
            // btn_Sub_Immo
            // 
            this.btn_Sub_Immo.Depth = 0;
            this.btn_Sub_Immo.Location = new System.Drawing.Point(186, 297);
            this.btn_Sub_Immo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Sub_Immo.Name = "btn_Sub_Immo";
            this.btn_Sub_Immo.Primary = true;
            this.btn_Sub_Immo.Size = new System.Drawing.Size(95, 28);
            this.btn_Sub_Immo.TabIndex = 14;
            this.btn_Sub_Immo.Text = "Enregistrer";
            this.btn_Sub_Immo.UseVisualStyleBackColor = true;
            this.btn_Sub_Immo.Click += new System.EventHandler(this.Btn_Sub_Immo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "N_Immobilisation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dh";
            // 
            // txtPrix_Immo
            // 
            this.txtPrix_Immo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix_Immo.Location = new System.Drawing.Point(186, 226);
            this.txtPrix_Immo.Name = "txtPrix_Immo";
            this.txtPrix_Immo.Size = new System.Drawing.Size(118, 26);
            this.txtPrix_Immo.TabIndex = 6;
            // 
            // txtN_Immo
            // 
            this.txtN_Immo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN_Immo.Location = new System.Drawing.Point(186, 131);
            this.txtN_Immo.Name = "txtN_Immo";
            this.txtN_Immo.Size = new System.Drawing.Size(118, 26);
            this.txtN_Immo.TabIndex = 5;
            // 
            // cb_Choix
            // 
            this.cb_Choix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Choix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Choix.FormattingEnabled = true;
            this.cb_Choix.Location = new System.Drawing.Point(186, 192);
            this.cb_Choix.Name = "cb_Choix";
            this.cb_Choix.Size = new System.Drawing.Size(223, 28);
            this.cb_Choix.TabIndex = 4;
            // 
            // txt_Desc
            // 
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc.Location = new System.Drawing.Point(186, 160);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(223, 26);
            this.txt_Desc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les immobilisations";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Cb_New_Dep);
            this.panel2.Controls.Add(this.dp_Dep);
            this.panel2.Controls.Add(this.btn_Sub_Dep);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_Prix_Dep);
            this.panel2.Controls.Add(this.txtN_Dep);
            this.panel2.Controls.Add(this.cb_Choix_Dep);
            this.panel2.Controls.Add(this.txt_Desc_Dep);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(445, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 454);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Choix_Depense";
            // 
            // Cb_New_Dep
            // 
            this.Cb_New_Dep.AutoSize = true;
            this.Cb_New_Dep.Depth = 0;
            this.Cb_New_Dep.Font = new System.Drawing.Font("Roboto", 10F);
            this.Cb_New_Dep.Location = new System.Drawing.Point(198, 263);
            this.Cb_New_Dep.Margin = new System.Windows.Forms.Padding(0);
            this.Cb_New_Dep.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Cb_New_Dep.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cb_New_Dep.Name = "Cb_New_Dep";
            this.Cb_New_Dep.Ripple = true;
            this.Cb_New_Dep.Size = new System.Drawing.Size(136, 30);
            this.Cb_New_Dep.TabIndex = 27;
            this.Cb_New_Dep.Text = "Noveau_Depense";
            this.Cb_New_Dep.UseVisualStyleBackColor = true;
            this.Cb_New_Dep.CheckedChanged += new System.EventHandler(this.Cb_New_Dep_CheckedChanged);
            // 
            // dp_Dep
            // 
            this.dp_Dep.CalendarFont = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_Dep.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.dp_Dep.Location = new System.Drawing.Point(168, 4);
            this.dp_Dep.Name = "dp_Dep";
            this.dp_Dep.Size = new System.Drawing.Size(252, 27);
            this.dp_Dep.TabIndex = 16;
            // 
            // btn_Sub_Dep
            // 
            this.btn_Sub_Dep.Depth = 0;
            this.btn_Sub_Dep.Location = new System.Drawing.Point(198, 297);
            this.btn_Sub_Dep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Sub_Dep.Name = "btn_Sub_Dep";
            this.btn_Sub_Dep.Primary = true;
            this.btn_Sub_Dep.Size = new System.Drawing.Size(95, 28);
            this.btn_Sub_Dep.TabIndex = 26;
            this.btn_Sub_Dep.Text = "Enregistrer";
            this.btn_Sub_Dep.UseVisualStyleBackColor = true;
            this.btn_Sub_Dep.Click += new System.EventHandler(this.Btn_Sub_Dep_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Prix";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "N_Depense";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Dh";
            // 
            // txt_Prix_Dep
            // 
            this.txt_Prix_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prix_Dep.Location = new System.Drawing.Point(198, 226);
            this.txt_Prix_Dep.Name = "txt_Prix_Dep";
            this.txt_Prix_Dep.Size = new System.Drawing.Size(118, 26);
            this.txt_Prix_Dep.TabIndex = 19;
            // 
            // txtN_Dep
            // 
            this.txtN_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN_Dep.Location = new System.Drawing.Point(198, 131);
            this.txtN_Dep.Name = "txtN_Dep";
            this.txtN_Dep.Size = new System.Drawing.Size(118, 26);
            this.txtN_Dep.TabIndex = 18;
            // 
            // cb_Choix_Dep
            // 
            this.cb_Choix_Dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Choix_Dep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Choix_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Choix_Dep.FormattingEnabled = true;
            this.cb_Choix_Dep.Location = new System.Drawing.Point(198, 192);
            this.cb_Choix_Dep.Name = "cb_Choix_Dep";
            this.cb_Choix_Dep.Size = new System.Drawing.Size(223, 28);
            this.cb_Choix_Dep.TabIndex = 17;
            this.cb_Choix_Dep.SelectedIndexChanged += new System.EventHandler(this.Cb_Choix_Dep_SelectedIndexChanged);
            this.cb_Choix_Dep.TextChanged += new System.EventHandler(this.Cb_Choix_Dep_TextChanged);
            // 
            // txt_Desc_Dep
            // 
            this.txt_Desc_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc_Dep.Location = new System.Drawing.Point(198, 160);
            this.txt_Desc_Dep.Name = "txt_Desc_Dep";
            this.txt_Desc_Dep.Size = new System.Drawing.Size(223, 26);
            this.txt_Desc_Dep.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(165, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Les depenses";
            // 
            // Depenses_mensuelles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Depenses_mensuelles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depenses_mensuelles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrix_Immo;
        private System.Windows.Forms.TextBox txtN_Immo;
        private System.Windows.Forms.ComboBox cb_Choix;
        private System.Windows.Forms.TextBox txt_Desc;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Sub_Immo;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Sub_Dep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Prix_Dep;
        private System.Windows.Forms.TextBox txtN_Dep;
        private System.Windows.Forms.ComboBox cb_Choix_Dep;
        private System.Windows.Forms.TextBox txt_Desc_Dep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dp_Immo;
        private System.Windows.Forms.DateTimePicker dp_Dep;
        private MaterialSkin.Controls.MaterialCheckBox Cb_New_Dep;
        private MaterialSkin.Controls.MaterialCheckBox cb_New_Immo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
    }
}