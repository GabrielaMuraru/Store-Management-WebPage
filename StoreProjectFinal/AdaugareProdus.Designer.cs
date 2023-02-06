namespace StoreProjectFinal
{
    partial class AdaugareProdus
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenum = new System.Windows.Forms.TextBox();
            this.richTxtDescriere = new System.Windows.Forms.RichTextBox();
            this.dateTimeIntrare = new System.Windows.Forms.DateTimePicker();
            this.dateTimeExpirare = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdaugProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCant)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cantitate de produse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Data de valabilitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data de Intrare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descrierea Produsului";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Denumire Produs";
            // 
            // txtDenum
            // 
            this.txtDenum.Location = new System.Drawing.Point(151, 71);
            this.txtDenum.Name = "txtDenum";
            this.txtDenum.Size = new System.Drawing.Size(100, 20);
            this.txtDenum.TabIndex = 32;
            // 
            // richTxtDescriere
            // 
            this.richTxtDescriere.Location = new System.Drawing.Point(151, 103);
            this.richTxtDescriere.Name = "richTxtDescriere";
            this.richTxtDescriere.Size = new System.Drawing.Size(168, 57);
            this.richTxtDescriere.TabIndex = 33;
            this.richTxtDescriere.Text = "";
            // 
            // dateTimeIntrare
            // 
            this.dateTimeIntrare.Location = new System.Drawing.Point(151, 180);
            this.dateTimeIntrare.Name = "dateTimeIntrare";
            this.dateTimeIntrare.Size = new System.Drawing.Size(168, 20);
            this.dateTimeIntrare.TabIndex = 34;
            // 
            // dateTimeExpirare
            // 
            this.dateTimeExpirare.Location = new System.Drawing.Point(151, 215);
            this.dateTimeExpirare.Name = "dateTimeExpirare";
            this.dateTimeExpirare.Size = new System.Drawing.Size(168, 20);
            this.dateTimeExpirare.TabIndex = 35;
            // 
            // numericUpDownCant
            // 
            this.numericUpDownCant.Location = new System.Drawing.Point(151, 249);
            this.numericUpDownCant.Name = "numericUpDownCant";
            this.numericUpDownCant.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownCant.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Adaugare de Produs nou";
            // 
            // btnAdaugProd
            // 
            this.btnAdaugProd.Location = new System.Drawing.Point(283, 290);
            this.btnAdaugProd.Name = "btnAdaugProd";
            this.btnAdaugProd.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugProd.TabIndex = 38;
            this.btnAdaugProd.Text = "Adaugare";
            this.btnAdaugProd.UseVisualStyleBackColor = true;
            this.btnAdaugProd.Click += new System.EventHandler(this.btnAdaugProd_Click);
            // 
            // AdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 325);
            this.Controls.Add(this.btnAdaugProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCant);
            this.Controls.Add(this.dateTimeExpirare);
            this.Controls.Add(this.dateTimeIntrare);
            this.Controls.Add(this.richTxtDescriere);
            this.Controls.Add(this.txtDenum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareProdus";
            this.Text = "AdaugareProdus";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenum;
        private System.Windows.Forms.RichTextBox richTxtDescriere;
        private System.Windows.Forms.DateTimePicker dateTimeIntrare;
        private System.Windows.Forms.DateTimePicker dateTimeExpirare;
        private System.Windows.Forms.NumericUpDown numericUpDownCant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdaugProd;
    }
}