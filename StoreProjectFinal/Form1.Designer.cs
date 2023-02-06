namespace StoreProjectFinal
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inregistrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosDeCumparaturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricCumparaturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtModif = new System.Windows.Forms.TextBox();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.numericUpDownProdus = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProdus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilizatorToolStripMenuItem,
            this.magazinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilizatorToolStripMenuItem
            // 
            this.utilizatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectareToolStripMenuItem,
            this.inregistrareToolStripMenuItem,
            this.stergereContToolStripMenuItem});
            this.utilizatorToolStripMenuItem.Name = "utilizatorToolStripMenuItem";
            this.utilizatorToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.utilizatorToolStripMenuItem.Text = "Utilizator";
            // 
            // conectareToolStripMenuItem
            // 
            this.conectareToolStripMenuItem.Name = "conectareToolStripMenuItem";
            this.conectareToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.conectareToolStripMenuItem.Text = "Conectare";
            this.conectareToolStripMenuItem.Click += new System.EventHandler(this.conectareToolStripMenuItem_Click_1);
            // 
            // inregistrareToolStripMenuItem
            // 
            this.inregistrareToolStripMenuItem.Name = "inregistrareToolStripMenuItem";
            this.inregistrareToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.inregistrareToolStripMenuItem.Text = "Creare Cont";
            this.inregistrareToolStripMenuItem.Click += new System.EventHandler(this.inregistrareToolStripMenuItem_Click);
            // 
            // stergereContToolStripMenuItem
            // 
            this.stergereContToolStripMenuItem.Name = "stergereContToolStripMenuItem";
            this.stergereContToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.stergereContToolStripMenuItem.Text = "Stergere Cont";
            this.stergereContToolStripMenuItem.Click += new System.EventHandler(this.stergereContToolStripMenuItem_Click);
            // 
            // magazinToolStripMenuItem
            // 
            this.magazinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusToolStripMenuItem,
            this.cosDeCumparaturiToolStripMenuItem,
            this.istoricCumparaturiToolStripMenuItem});
            this.magazinToolStripMenuItem.Name = "magazinToolStripMenuItem";
            this.magazinToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.magazinToolStripMenuItem.Text = "Magazin";
            // 
            // adaugareProdusToolStripMenuItem
            // 
            this.adaugareProdusToolStripMenuItem.Name = "adaugareProdusToolStripMenuItem";
            this.adaugareProdusToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.adaugareProdusToolStripMenuItem.Text = "Adaugare produs";
            this.adaugareProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugareProdusToolStripMenuItem_Click);
            // 
            // cosDeCumparaturiToolStripMenuItem
            // 
            this.cosDeCumparaturiToolStripMenuItem.Name = "cosDeCumparaturiToolStripMenuItem";
            this.cosDeCumparaturiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cosDeCumparaturiToolStripMenuItem.Text = "Adauga in Cos";
            this.cosDeCumparaturiToolStripMenuItem.Click += new System.EventHandler(this.cosDeCumparaturiToolStripMenuItem_Click);
            // 
            // istoricCumparaturiToolStripMenuItem
            // 
            this.istoricCumparaturiToolStripMenuItem.Name = "istoricCumparaturiToolStripMenuItem";
            this.istoricCumparaturiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.istoricCumparaturiToolStripMenuItem.Text = "Istoric Cumparaturi";
            this.istoricCumparaturiToolStripMenuItem.Click += new System.EventHandler(this.istoricCumparaturiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestionare Magazin";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(203, 189);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtModif
            // 
            this.txtModif.Location = new System.Drawing.Point(97, 99);
            this.txtModif.Name = "txtModif";
            this.txtModif.Size = new System.Drawing.Size(100, 20);
            this.txtModif.TabIndex = 5;
            // 
            // txtCauta
            // 
            this.txtCauta.Location = new System.Drawing.Point(97, 139);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(100, 20);
            this.txtCauta.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cumparare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cautare";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(203, 97);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(96, 23);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Adauga in Cos";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(203, 139);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 10;
            this.btnCauta.Text = "cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // numericUpDownProdus
            // 
            this.numericUpDownProdus.Location = new System.Drawing.Point(317, 99);
            this.numericUpDownProdus.Name = "numericUpDownProdus";
            this.numericUpDownProdus.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownProdus.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 366);
            this.Controls.Add(this.numericUpDownProdus);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.txtModif);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProdus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilizatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inregistrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosDeCumparaturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricCumparaturiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem conectareToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtModif;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.NumericUpDown numericUpDownProdus;
    }
}

