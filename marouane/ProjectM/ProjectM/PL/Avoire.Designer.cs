namespace ProjectM.PL
{
    partial class Avoire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgv_avoiredetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.effcerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Invoices = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumAV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumBO = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumAchat = new System.Windows.Forms.TextBox();
            this.txtNumPrd = new System.Windows.Forms.TextBox();
            this.txtNomPrd = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_avoiredetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Indigo;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(17, 91);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 25);
            this.btnSubmit.TabIndex = 89;
            this.btnSubmit.Text = "Valider";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(104, 91);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 25);
            this.btnNew.TabIndex = 88;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // dgv_avoiredetails
            // 
            this.dgv_avoiredetails.AllowUserToAddRows = false;
            this.dgv_avoiredetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            this.dgv_avoiredetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_avoiredetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_avoiredetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_avoiredetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_avoiredetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_avoiredetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_avoiredetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_avoiredetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_avoiredetails.ColumnHeadersHeight = 50;
            this.dgv_avoiredetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_avoiredetails.ColumnHeadersVisible = false;
            this.dgv_avoiredetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_avoiredetails.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_avoiredetails.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_avoiredetails.EnableHeadersVisualStyles = false;
            this.dgv_avoiredetails.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_avoiredetails.Location = new System.Drawing.Point(21, 395);
            this.dgv_avoiredetails.MultiSelect = false;
            this.dgv_avoiredetails.Name = "dgv_avoiredetails";
            this.dgv_avoiredetails.ReadOnly = true;
            this.dgv_avoiredetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_avoiredetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_avoiredetails.RowHeadersVisible = false;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_avoiredetails.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_avoiredetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_avoiredetails.Size = new System.Drawing.Size(722, 89);
            this.dgv_avoiredetails.TabIndex = 87;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 87.05584F;
            this.Column1.HeaderText = "N° Achat";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 87.05584F;
            this.Column2.HeaderText = "N° Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 87.05584F;
            this.Column3.HeaderText = "Nom de produit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 87.05584F;
            this.Column4.HeaderText = "Categorie";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 87.05584F;
            this.Column5.HeaderText = "Qte retourner";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 87.05584F;
            this.Column6.HeaderText = "Prix";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.toolStripSeparator1,
            this.effcerToolStripMenuItem,
            this.effacerToutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 76);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.ModifierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // effcerToolStripMenuItem
            // 
            this.effcerToolStripMenuItem.Name = "effcerToolStripMenuItem";
            this.effcerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.effcerToolStripMenuItem.Text = "Effacer ";
            this.effcerToolStripMenuItem.Click += new System.EventHandler(this.EffcerToolStripMenuItem_Click);
            // 
            // effacerToutToolStripMenuItem
            // 
            this.effacerToutToolStripMenuItem.Name = "effacerToutToolStripMenuItem";
            this.effacerToutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.effacerToutToolStripMenuItem.Text = "Effacer tout";
            this.effacerToutToolStripMenuItem.Click += new System.EventHandler(this.EffacerToutToolStripMenuItem_Click);
            // 
            // dgv_Invoices
            // 
            this.dgv_Invoices.AllowUserToAddRows = false;
            this.dgv_Invoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            this.dgv_Invoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Invoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Invoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Invoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_Invoices.ColumnHeadersHeight = 50;
            this.dgv_Invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Invoices.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_Invoices.EnableHeadersVisualStyles = false;
            this.dgv_Invoices.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Invoices.Location = new System.Drawing.Point(22, 220);
            this.dgv_Invoices.MultiSelect = false;
            this.dgv_Invoices.Name = "dgv_Invoices";
            this.dgv_Invoices.ReadOnly = true;
            this.dgv_Invoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_Invoices.RowHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Invoices.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_Invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoices.Size = new System.Drawing.Size(721, 117);
            this.dgv_Invoices.TabIndex = 80;
            this.dgv_Invoices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Invoices_CellMouseDoubleClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(382, 145);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 79;
            this.materialLabel2.Text = "N° Avoire";
            // 
            // txtNumAV
            // 
            this.txtNumAV.Depth = 0;
            this.txtNumAV.Enabled = false;
            this.txtNumAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumAV.Hint = "";
            this.txtNumAV.Location = new System.Drawing.Point(484, 143);
            this.txtNumAV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumAV.Name = "txtNumAV";
            this.txtNumAV.PasswordChar = '\0';
            this.txtNumAV.SelectedText = "";
            this.txtNumAV.SelectionLength = 0;
            this.txtNumAV.SelectionStart = 0;
            this.txtNumAV.Size = new System.Drawing.Size(127, 23);
            this.txtNumAV.TabIndex = 78;
            this.txtNumAV.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 145);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 77;
            this.materialLabel1.Text = "N° Achat";
            // 
            // txtNumBO
            // 
            this.txtNumBO.Depth = 0;
            this.txtNumBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBO.Hint = "";
            this.txtNumBO.Location = new System.Drawing.Point(106, 145);
            this.txtNumBO.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumBO.Name = "txtNumBO";
            this.txtNumBO.PasswordChar = '\0';
            this.txtNumBO.SelectedText = "";
            this.txtNumBO.SelectionLength = 0;
            this.txtNumBO.SelectionStart = 0;
            this.txtNumBO.Size = new System.Drawing.Size(127, 23);
            this.txtNumBO.TabIndex = 76;
            this.txtNumBO.UseSystemPasswordChar = false;
            this.txtNumBO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumBO_KeyPress);
            this.txtNumBO.Validated += new System.EventHandler(this.TxtNumBO_Validated);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "N° Achat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(142, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "N° Produit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(262, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 93;
            this.label4.Text = "Nom de produit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(382, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 94;
            this.label5.Text = "Categorie";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(502, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "Qte retourner";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(622, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = "Prix";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumAchat
            // 
            this.txtNumAchat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNumAchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAchat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumAchat.Location = new System.Drawing.Point(22, 370);
            this.txtNumAchat.Name = "txtNumAchat";
            this.txtNumAchat.Size = new System.Drawing.Size(121, 19);
            this.txtNumAchat.TabIndex = 97;
            this.txtNumAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumPrd
            // 
            this.txtNumPrd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNumPrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPrd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumPrd.Location = new System.Drawing.Point(142, 370);
            this.txtNumPrd.Name = "txtNumPrd";
            this.txtNumPrd.Size = new System.Drawing.Size(121, 19);
            this.txtNumPrd.TabIndex = 98;
            this.txtNumPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomPrd
            // 
            this.txtNomPrd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNomPrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomPrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPrd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNomPrd.Location = new System.Drawing.Point(262, 370);
            this.txtNomPrd.Name = "txtNomPrd";
            this.txtNomPrd.Size = new System.Drawing.Size(121, 19);
            this.txtNomPrd.TabIndex = 99;
            this.txtNomPrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCat.Location = new System.Drawing.Point(382, 370);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(121, 19);
            this.txtCat.TabIndex = 100;
            this.txtCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtQte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQte.Location = new System.Drawing.Point(502, 370);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(121, 19);
            this.txtQte.TabIndex = 101;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumBO_KeyPress);
            this.txtQte.Validated += new System.EventHandler(this.TxtQte_Validated);
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrix.Location = new System.Drawing.Point(622, 370);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(121, 19);
            this.txtPrix.TabIndex = 102;
            this.txtPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrix_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(378, 183);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(87, 19);
            this.materialLabel3.TabIndex = 103;
            this.materialLabel3.Text = "Date Avoire";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 24);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // Avoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 514);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtNomPrd);
            this.Controls.Add(this.txtNumPrd);
            this.Controls.Add(this.txtNumAchat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgv_avoiredetails);
            this.Controls.Add(this.dgv_Invoices);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNumAV);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNumBO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Avoire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avoire";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_avoiredetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.DataGridView dgv_avoiredetails;
        public System.Windows.Forms.DataGridView dgv_Invoices;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumAV;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumBO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumAchat;
        private System.Windows.Forms.TextBox txtNumPrd;
        private System.Windows.Forms.TextBox txtNomPrd;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.TextBox txtPrix;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem effcerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}