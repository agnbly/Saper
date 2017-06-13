namespace Saper
{
    partial class Opcje_gry
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
            this.Opcje = new System.Windows.Forms.GroupBox();
            this.Latwy = new System.Windows.Forms.RadioButton();
            this.Sredni = new System.Windows.Forms.RadioButton();
            this.Trudny = new System.Windows.Forms.RadioButton();
            this.Personalizuj = new System.Windows.Forms.RadioButton();
            this.label_szerokosc = new System.Windows.Forms.Label();
            this.ustaw_szerokosc = new System.Windows.Forms.NumericUpDown();
            this.label_wysokosc = new System.Windows.Forms.Label();
            this.ustaw_wysokosc = new System.Windows.Forms.NumericUpDown();
            this.label_bomby = new System.Windows.Forms.Label();
            this.ustaw_bomby = new System.Windows.Forms.NumericUpDown();
            this.przycisk_ok = new System.Windows.Forms.Button();
            this.przycisk_anuluj = new System.Windows.Forms.Button();
            this.Opcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustaw_szerokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaw_wysokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaw_bomby)).BeginInit();
            this.SuspendLayout();
            // 
            // Opcje
            // 
            this.Opcje.Controls.Add(this.Personalizuj);
            this.Opcje.Controls.Add(this.Trudny);
            this.Opcje.Controls.Add(this.Sredni);
            this.Opcje.Controls.Add(this.Latwy);
            this.Opcje.Location = new System.Drawing.Point(39, 12);
            this.Opcje.Name = "Opcje";
            this.Opcje.Size = new System.Drawing.Size(200, 116);
            this.Opcje.TabIndex = 0;
            this.Opcje.TabStop = false;
            this.Opcje.Text = "Wybierz poziom trudności:";
            // 
            // Latwy
            // 
            this.Latwy.AutoSize = true;
            this.Latwy.Checked = true;
            this.Latwy.Location = new System.Drawing.Point(7, 20);
            this.Latwy.Name = "Latwy";
            this.Latwy.Size = new System.Drawing.Size(54, 17);
            this.Latwy.TabIndex = 0;
            this.Latwy.TabStop = true;
            this.Latwy.Text = "Łatwy";
            this.Latwy.UseVisualStyleBackColor = true;
            // 
            // Sredni
            // 
            this.Sredni.AutoSize = true;
            this.Sredni.Location = new System.Drawing.Point(7, 44);
            this.Sredni.Name = "Sredni";
            this.Sredni.Size = new System.Drawing.Size(55, 17);
            this.Sredni.TabIndex = 1;
            this.Sredni.Text = "Średni";
            this.Sredni.UseVisualStyleBackColor = true;
            // 
            // Trudny
            // 
            this.Trudny.AutoSize = true;
            this.Trudny.Location = new System.Drawing.Point(7, 68);
            this.Trudny.Name = "Trudny";
            this.Trudny.Size = new System.Drawing.Size(58, 17);
            this.Trudny.TabIndex = 2;
            this.Trudny.Text = "Trudny";
            this.Trudny.UseVisualStyleBackColor = true;
            // 
            // Personalizuj
            // 
            this.Personalizuj.AutoSize = true;
            this.Personalizuj.Location = new System.Drawing.Point(7, 92);
            this.Personalizuj.Name = "Personalizuj";
            this.Personalizuj.Size = new System.Drawing.Size(81, 17);
            this.Personalizuj.TabIndex = 3;
            this.Personalizuj.Text = "Personalizuj";
            this.Personalizuj.UseVisualStyleBackColor = true;
            // 
            // label_szerokosc
            // 
            this.label_szerokosc.AutoSize = true;
            this.label_szerokosc.Location = new System.Drawing.Point(12, 145);
            this.label_szerokosc.Name = "label_szerokosc";
            this.label_szerokosc.Size = new System.Drawing.Size(60, 13);
            this.label_szerokosc.TabIndex = 1;
            this.label_szerokosc.Text = "Szerokość:";
            // 
            // ustaw_szerokosc
            // 
            this.ustaw_szerokosc.Location = new System.Drawing.Point(78, 143);
            this.ustaw_szerokosc.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ustaw_szerokosc.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ustaw_szerokosc.Name = "ustaw_szerokosc";
            this.ustaw_szerokosc.Size = new System.Drawing.Size(50, 20);
            this.ustaw_szerokosc.TabIndex = 2;
            this.ustaw_szerokosc.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_wysokosc
            // 
            this.label_wysokosc.AutoSize = true;
            this.label_wysokosc.Location = new System.Drawing.Point(156, 145);
            this.label_wysokosc.Name = "label_wysokosc";
            this.label_wysokosc.Size = new System.Drawing.Size(60, 13);
            this.label_wysokosc.TabIndex = 3;
            this.label_wysokosc.Text = "Wysokość:";
            // 
            // ustaw_wysokosc
            // 
            this.ustaw_wysokosc.Location = new System.Drawing.Point(222, 143);
            this.ustaw_wysokosc.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ustaw_wysokosc.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ustaw_wysokosc.Name = "ustaw_wysokosc";
            this.ustaw_wysokosc.Size = new System.Drawing.Size(50, 20);
            this.ustaw_wysokosc.TabIndex = 4;
            this.ustaw_wysokosc.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label_bomby
            // 
            this.label_bomby.AutoSize = true;
            this.label_bomby.Location = new System.Drawing.Point(2, 183);
            this.label_bomby.Name = "label_bomby";
            this.label_bomby.Size = new System.Drawing.Size(70, 13);
            this.label_bomby.TabIndex = 5;
            this.label_bomby.Text = "Liczba bomb:";
            // 
            // ustaw_bomby
            // 
            this.ustaw_bomby.Location = new System.Drawing.Point(78, 181);
            this.ustaw_bomby.Maximum = new decimal(new int[] {
            667,
            0,
            0,
            0});
            this.ustaw_bomby.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ustaw_bomby.Name = "ustaw_bomby";
            this.ustaw_bomby.Size = new System.Drawing.Size(49, 20);
            this.ustaw_bomby.TabIndex = 6;
            this.ustaw_bomby.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // przycisk_ok
            // 
            this.przycisk_ok.Location = new System.Drawing.Point(39, 224);
            this.przycisk_ok.Name = "przycisk_ok";
            this.przycisk_ok.Size = new System.Drawing.Size(75, 23);
            this.przycisk_ok.TabIndex = 7;
            this.przycisk_ok.Text = "Ok";
            this.przycisk_ok.UseVisualStyleBackColor = true;
            // 
            // przycisk_anuluj
            // 
            this.przycisk_anuluj.Location = new System.Drawing.Point(163, 223);
            this.przycisk_anuluj.Name = "przycisk_anuluj";
            this.przycisk_anuluj.Size = new System.Drawing.Size(75, 23);
            this.przycisk_anuluj.TabIndex = 8;
            this.przycisk_anuluj.Text = "Anuluj";
            this.przycisk_anuluj.UseVisualStyleBackColor = true;
            // 
            // Opcje_gry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.przycisk_anuluj);
            this.Controls.Add(this.przycisk_ok);
            this.Controls.Add(this.ustaw_bomby);
            this.Controls.Add(this.label_bomby);
            this.Controls.Add(this.ustaw_wysokosc);
            this.Controls.Add(this.label_wysokosc);
            this.Controls.Add(this.ustaw_szerokosc);
            this.Controls.Add(this.label_szerokosc);
            this.Controls.Add(this.Opcje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opcje_gry";
            this.Text = "Opcje_gry";
            this.Opcje.ResumeLayout(false);
            this.Opcje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustaw_szerokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaw_wysokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustaw_bomby)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Opcje;
        private System.Windows.Forms.RadioButton Personalizuj;
        private System.Windows.Forms.RadioButton Trudny;
        private System.Windows.Forms.RadioButton Sredni;
        private System.Windows.Forms.RadioButton Latwy;
        private System.Windows.Forms.Label label_szerokosc;
        private System.Windows.Forms.NumericUpDown ustaw_szerokosc;
        private System.Windows.Forms.Label label_wysokosc;
        private System.Windows.Forms.NumericUpDown ustaw_wysokosc;
        private System.Windows.Forms.Label label_bomby;
        private System.Windows.Forms.NumericUpDown ustaw_bomby;
        private System.Windows.Forms.Button przycisk_ok;
        private System.Windows.Forms.Button przycisk_anuluj;
    }
}