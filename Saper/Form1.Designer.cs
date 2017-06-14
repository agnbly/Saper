namespace Saper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.bomby = new System.Windows.Forms.Label();
            this.plansza = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.toolStripSeparator1,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Location = new System.Drawing.Point(105, 35);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(45, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(177, 35);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(52, 23);
            this.timer.TabIndex = 4;
            this.timer.Text = "czas";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bomby
            // 
            this.bomby.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bomby.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bomby.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bomby.Location = new System.Drawing.Point(28, 35);
            this.bomby.Name = "bomby";
            this.bomby.Size = new System.Drawing.Size(50, 23);
            this.bomby.TabIndex = 5;
            this.bomby.Text = "bomby";
            this.bomby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plansza
            // 
            this.plansza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plansza.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plansza.Location = new System.Drawing.Point(28, 74);
            this.plansza.Name = "plansza";
            this.plansza.Size = new System.Drawing.Size(201, 201);
            this.plansza.TabIndex = 6;
            this.plansza.Click += new System.EventHandler(this.plansza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(263, 287);
            this.Controls.Add(this.plansza);
            this.Controls.Add(this.bomby);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label bomby;
        private System.Windows.Forms.Panel plansza;
    }
}

