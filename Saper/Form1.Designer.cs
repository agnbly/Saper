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
            this.trybGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.początkującyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniozaawansowanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaawansowanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.TextBox();
            this.bomby = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.toolStripSeparator1,
            this.trybGryToolStripMenuItem,
            this.personalizujToolStripMenuItem,
            this.toolStripSeparator2,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            // 
            // trybGryToolStripMenuItem
            // 
            this.trybGryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.początkującyToolStripMenuItem,
            this.średniozaawansowanyToolStripMenuItem,
            this.zaawansowanyToolStripMenuItem});
            this.trybGryToolStripMenuItem.Name = "trybGryToolStripMenuItem";
            this.trybGryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trybGryToolStripMenuItem.Text = "Tryb gry";
            // 
            // początkującyToolStripMenuItem
            // 
            this.początkującyToolStripMenuItem.Name = "początkującyToolStripMenuItem";
            this.początkującyToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.początkującyToolStripMenuItem.Text = "Początkujący";
            // 
            // średniozaawansowanyToolStripMenuItem
            // 
            this.średniozaawansowanyToolStripMenuItem.Name = "średniozaawansowanyToolStripMenuItem";
            this.średniozaawansowanyToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.średniozaawansowanyToolStripMenuItem.Text = "Średniozaawansowany";
            // 
            // zaawansowanyToolStripMenuItem
            // 
            this.zaawansowanyToolStripMenuItem.Name = "zaawansowanyToolStripMenuItem";
            this.zaawansowanyToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.zaawansowanyToolStripMenuItem.Text = "Zaawansowany";
            // 
            // personalizujToolStripMenuItem
            // 
            this.personalizujToolStripMenuItem.Name = "personalizujToolStripMenuItem";
            this.personalizujToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personalizujToolStripMenuItem.Text = "Personalizuj";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(198, 36);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(74, 20);
            this.timer.TabIndex = 1;
            this.timer.Text = "czas";
            // 
            // bomby
            // 
            this.bomby.Location = new System.Drawing.Point(12, 36);
            this.bomby.Name = "bomby";
            this.bomby.Size = new System.Drawing.Size(74, 20);
            this.bomby.TabIndex = 2;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(105, 36);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.bomby);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem trybGryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem początkującyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniozaawansowanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaawansowanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.TextBox bomby;
        private System.Windows.Forms.Button reset;
    }
}

