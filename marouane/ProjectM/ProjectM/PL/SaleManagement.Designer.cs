namespace ProjectMarouane.PL
{
    partial class SaleManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actualizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterUneVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suprimerUneVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRs = new System.Windows.Forms.TextBox();
            this.ttlVente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFactureE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNonEff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalTousFact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Invoices = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizerToolStripMenuItem,
            this.toolStripSeparator2,
            this.ajouterUneVenteToolStripMenuItem,
            this.suprimerUneVenteToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 104);
            // 
            // actualizerToolStripMenuItem
            // 
            this.actualizerToolStripMenuItem.Name = "actualizerToolStripMenuItem";
            this.actualizerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.actualizerToolStripMenuItem.Text = "Actualiser";
            this.actualizerToolStripMenuItem.Click += new System.EventHandler(this.ActualizerToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // ajouterUneVenteToolStripMenuItem
            // 
            this.ajouterUneVenteToolStripMenuItem.Name = "ajouterUneVenteToolStripMenuItem";
            this.ajouterUneVenteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ajouterUneVenteToolStripMenuItem.Text = "Ajouter une vente";
            this.ajouterUneVenteToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneVenteToolStripMenuItem_Click);
            // 
            // suprimerUneVenteToolStripMenuItem
            // 
            this.suprimerUneVenteToolStripMenuItem.Name = "suprimerUneVenteToolStripMenuItem";
            this.suprimerUneVenteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.suprimerUneVenteToolStripMenuItem.Text = "Suprimer une vente";
            this.suprimerUneVenteToolStripMenuItem.Click += new System.EventHandler(this.SuprimerUneVenteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Trouvez facture :";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Control;
            this.Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(131, 126);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(148, 20);
            this.Search.TabIndex = 34;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // to
            // 
            this.to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.to.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.Location = new System.Drawing.Point(551, 82);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(258, 27);
            this.to.TabIndex = 36;
            this.to.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(131, 89);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(252, 27);
            this.from.TabIndex = 37;
            this.from.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "de :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(467, 520);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 19);
            this.label19.TabIndex = 42;
            this.label19.Text = "Payer";
            // 
            // txtPayer
            // 
            this.txtPayer.BackColor = System.Drawing.SystemColors.Control;
            this.txtPayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPayer.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayer.ForeColor = System.Drawing.Color.Black;
            this.txtPayer.Location = new System.Drawing.Point(515, 519);
            this.txtPayer.Name = "txtPayer";
            this.txtPayer.Size = new System.Drawing.Size(113, 20);
            this.txtPayer.TabIndex = 43;
            this.txtPayer.TextChanged += new System.EventHandler(this.TxtPayer_TextChanged);
            this.txtPayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPayer_KeyPress);
            this.txtPayer.Validated += new System.EventHandler(this.TxtPayer_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Reste";
            // 
            // txtRs
            // 
            this.txtRs.BackColor = System.Drawing.SystemColors.Control;
            this.txtRs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRs.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRs.ForeColor = System.Drawing.Color.Black;
            this.txtRs.Location = new System.Drawing.Point(696, 519);
            this.txtRs.Name = "txtRs";
            this.txtRs.ReadOnly = true;
            this.txtRs.Size = new System.Drawing.Size(113, 20);
            this.txtRs.TabIndex = 45;
            // 
            // ttlVente
            // 
            this.ttlVente.BackColor = System.Drawing.Color.Silver;
            this.ttlVente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlVente.Location = new System.Drawing.Point(739, 583);
            this.ttlVente.Name = "ttlVente";
            this.ttlVente.ReadOnly = true;
            this.ttlVente.Size = new System.Drawing.Size(70, 21);
            this.ttlVente.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total des ventes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Effactuer";
            // 
            // txtFactureE
            // 
            this.txtFactureE.BackColor = System.Drawing.SystemColors.Control;
            this.txtFactureE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFactureE.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactureE.ForeColor = System.Drawing.Color.Black;
            this.txtFactureE.Location = new System.Drawing.Point(92, 519);
            this.txtFactureE.Name = "txtFactureE";
            this.txtFactureE.ReadOnly = true;
            this.txtFactureE.Size = new System.Drawing.Size(113, 20);
            this.txtFactureE.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Non effactuer";
            // 
            // txtNonEff
            // 
            this.txtNonEff.BackColor = System.Drawing.SystemColors.Control;
            this.txtNonEff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNonEff.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNonEff.ForeColor = System.Drawing.Color.Black;
            this.txtNonEff.Location = new System.Drawing.Point(308, 519);
            this.txtNonEff.Name = "txtNonEff";
            this.txtNonEff.ReadOnly = true;
            this.txtNonEff.Size = new System.Drawing.Size(113, 20);
            this.txtNonEff.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Total facture :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(431, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 93);
            this.panel1.TabIndex = 54;
            // 
            // totalTousFact
            // 
            this.totalTousFact.BackColor = System.Drawing.SystemColors.Control;
            this.totalTousFact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTousFact.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTousFact.ForeColor = System.Drawing.Color.Black;
            this.totalTousFact.Location = new System.Drawing.Point(92, 554);
            this.totalTousFact.Name = "totalTousFact";
            this.totalTousFact.ReadOnly = true;
            this.totalTousFact.Size = new System.Drawing.Size(113, 20);
            this.totalTousFact.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tous";
            // 
            // dgv_Invoices
            // 
            this.dgv_Invoices.AllowUserToAddRows = false;
            this.dgv_Invoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Invoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoices.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Invoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Invoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Invoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Invoices.ColumnHeadersHeight = 50;
            this.dgv_Invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Invoices.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Invoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Invoices.EnableHeadersVisualStyles = false;
            this.dgv_Invoices.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Invoices.Location = new System.Drawing.Point(0, 180);
            this.dgv_Invoices.MultiSelect = false;
            this.dgv_Invoices.Name = "dgv_Invoices";
            this.dgv_Invoices.ReadOnly = true;
            this.dgv_Invoices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Invoices.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Invoices.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoices.Size = new System.Drawing.Size(819, 253);
            this.dgv_Invoices.TabIndex = 57;
            this.dgv_Invoices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Invoices_MouseClick_1);
            this.dgv_Invoices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Invoices_MouseDoubleClick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Location = new System.Drawing.Point(131, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 4);
            this.panel2.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(92, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 4);
            this.panel3.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Location = new System.Drawing.Point(308, 538);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(113, 4);
            this.panel4.TabIndex = 60;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Location = new System.Drawing.Point(515, 537);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 4);
            this.panel5.TabIndex = 61;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel6.Location = new System.Drawing.Point(696, 539);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(113, 4);
            this.panel6.TabIndex = 62;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel7.Location = new System.Drawing.Point(92, 573);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(113, 4);
            this.panel7.TabIndex = 63;
            // 
            // SaleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 616);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_Invoices);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalTousFact);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNonEff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFactureE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttlVente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRs);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.from);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleManagement";
            this.Load += new System.EventHandler(this.SaleManagement_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtPayer;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtRs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox ttlVente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suprimerUneVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtFactureE;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNonEff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox totalTousFact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem actualizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.DataGridView dgv_Invoices;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}