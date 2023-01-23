namespace aplikacijaZaBiblioteku
{
    partial class Pregled
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbOdabir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProvjera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 72);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(242, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // cmbOdabir
            // 
            this.cmbOdabir.FormattingEnabled = true;
            this.cmbOdabir.Items.AddRange(new object[] {
            "Korisnik",
            "Knjiga"});
            this.cmbOdabir.Location = new System.Drawing.Point(12, 21);
            this.cmbOdabir.Name = "cmbOdabir";
            this.cmbOdabir.Size = new System.Drawing.Size(242, 21);
            this.cmbOdabir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(241, 258);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pregled:";
            // 
            // btnProvjera
            // 
            this.btnProvjera.Location = new System.Drawing.Point(79, 393);
            this.btnProvjera.Name = "btnProvjera";
            this.btnProvjera.Size = new System.Drawing.Size(102, 37);
            this.btnProvjera.TabIndex = 5;
            this.btnProvjera.Text = "Provjeri";
            this.btnProvjera.UseVisualStyleBackColor = true;
            this.btnProvjera.Click += new System.EventHandler(this.btnProvjera_Click);
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 442);
            this.Controls.Add(this.btnProvjera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdabir);
            this.Controls.Add(this.txtNaziv);
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbOdabir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProvjera;
    }
}