namespace Ukol1_metody_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.strana_ctverce = new System.Windows.Forms.TextBox();
            this.strana_a2 = new System.Windows.Forms.TextBox();
            this.strana_a = new System.Windows.Forms.TextBox();
            this.strana_b = new System.Windows.Forms.TextBox();
            this.strana_b2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.strana_c2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.strana_krychle = new System.Windows.Forms.TextBox();
            this.obsah_ctverce = new System.Windows.Forms.Button();
            this.obsah_obdelniku = new System.Windows.Forms.Button();
            this.objem_kvadru = new System.Windows.Forms.Button();
            this.objem_krychle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // strana_ctverce
            // 
            this.strana_ctverce.Location = new System.Drawing.Point(125, 22);
            this.strana_ctverce.Name = "strana_ctverce";
            this.strana_ctverce.Size = new System.Drawing.Size(100, 20);
            this.strana_ctverce.TabIndex = 0;
            // 
            // strana_a2
            // 
            this.strana_a2.Location = new System.Drawing.Point(125, 128);
            this.strana_a2.Name = "strana_a2";
            this.strana_a2.Size = new System.Drawing.Size(100, 20);
            this.strana_a2.TabIndex = 1;
            // 
            // strana_a
            // 
            this.strana_a.Location = new System.Drawing.Point(125, 64);
            this.strana_a.Name = "strana_a";
            this.strana_a.Size = new System.Drawing.Size(100, 20);
            this.strana_a.TabIndex = 2;
            // 
            // strana_b
            // 
            this.strana_b.Location = new System.Drawing.Point(125, 90);
            this.strana_b.Name = "strana_b";
            this.strana_b.Size = new System.Drawing.Size(100, 20);
            this.strana_b.TabIndex = 3;
            // 
            // strana_b2
            // 
            this.strana_b2.Location = new System.Drawing.Point(125, 152);
            this.strana_b2.Name = "strana_b2";
            this.strana_b2.Size = new System.Drawing.Size(100, 20);
            this.strana_b2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zadej délku strany:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Čtverec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Obdélník";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Krychle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kvádr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zadej délku strany A:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Zadej délku strany B:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Zadej délku strany A:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Zadej délku strany B:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Zadej délku strany C:";
            // 
            // strana_c2
            // 
            this.strana_c2.Location = new System.Drawing.Point(125, 178);
            this.strana_c2.Name = "strana_c2";
            this.strana_c2.Size = new System.Drawing.Size(100, 20);
            this.strana_c2.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Zadej délku strany:";
            // 
            // strana_krychle
            // 
            this.strana_krychle.Location = new System.Drawing.Point(125, 216);
            this.strana_krychle.Name = "strana_krychle";
            this.strana_krychle.Size = new System.Drawing.Size(100, 20);
            this.strana_krychle.TabIndex = 17;
            // 
            // obsah_ctverce
            // 
            this.obsah_ctverce.Location = new System.Drawing.Point(231, 20);
            this.obsah_ctverce.Name = "obsah_ctverce";
            this.obsah_ctverce.Size = new System.Drawing.Size(93, 23);
            this.obsah_ctverce.TabIndex = 18;
            this.obsah_ctverce.Text = "Vypočítat obsah";
            this.obsah_ctverce.UseVisualStyleBackColor = true;
            this.obsah_ctverce.Click += new System.EventHandler(this.obsah_ctverce_Click);
            // 
            // obsah_obdelniku
            // 
            this.obsah_obdelniku.Location = new System.Drawing.Point(231, 75);
            this.obsah_obdelniku.Name = "obsah_obdelniku";
            this.obsah_obdelniku.Size = new System.Drawing.Size(93, 23);
            this.obsah_obdelniku.TabIndex = 19;
            this.obsah_obdelniku.Text = "Vypočítat obsah";
            this.obsah_obdelniku.UseVisualStyleBackColor = true;
            this.obsah_obdelniku.Click += new System.EventHandler(this.obsah_obdelniku_Click);
            // 
            // objem_kvadru
            // 
            this.objem_kvadru.Location = new System.Drawing.Point(231, 150);
            this.objem_kvadru.Name = "objem_kvadru";
            this.objem_kvadru.Size = new System.Drawing.Size(93, 23);
            this.objem_kvadru.TabIndex = 20;
            this.objem_kvadru.Text = "Vypočítat objem";
            this.objem_kvadru.UseVisualStyleBackColor = true;
            this.objem_kvadru.Click += new System.EventHandler(this.objem_kvadru_Click);
            // 
            // objem_krychle
            // 
            this.objem_krychle.Location = new System.Drawing.Point(231, 214);
            this.objem_krychle.Name = "objem_krychle";
            this.objem_krychle.Size = new System.Drawing.Size(93, 23);
            this.objem_krychle.TabIndex = 21;
            this.objem_krychle.Text = "Vypočítat objem";
            this.objem_krychle.UseVisualStyleBackColor = true;
            this.objem_krychle.Click += new System.EventHandler(this.objem_krychle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 249);
            this.Controls.Add(this.objem_krychle);
            this.Controls.Add(this.objem_kvadru);
            this.Controls.Add(this.obsah_obdelniku);
            this.Controls.Add(this.obsah_ctverce);
            this.Controls.Add(this.strana_krychle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.strana_c2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strana_b2);
            this.Controls.Add(this.strana_b);
            this.Controls.Add(this.strana_a);
            this.Controls.Add(this.strana_a2);
            this.Controls.Add(this.strana_ctverce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulačka obsahu/objemu těles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox strana_ctverce;
        private System.Windows.Forms.TextBox strana_a2;
        private System.Windows.Forms.TextBox strana_a;
        private System.Windows.Forms.TextBox strana_b;
        private System.Windows.Forms.TextBox strana_b2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox strana_c2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox strana_krychle;
        private System.Windows.Forms.Button obsah_ctverce;
        private System.Windows.Forms.Button obsah_obdelniku;
        private System.Windows.Forms.Button objem_kvadru;
        private System.Windows.Forms.Button objem_krychle;
    }
}

