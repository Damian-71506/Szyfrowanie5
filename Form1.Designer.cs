namespace Szyfrowanie5
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDrawSin = new System.Windows.Forms.Button();
            this.btnDrawCosinus = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDrawSin
            // 
            this.btnDrawSin.Location = new System.Drawing.Point(36, 31);
            this.btnDrawSin.Name = "btnDrawSin";
            this.btnDrawSin.Size = new System.Drawing.Size(87, 23);
            this.btnDrawSin.TabIndex = 0;
            this.btnDrawSin.Text = "Draw Sinus";
            this.btnDrawSin.UseVisualStyleBackColor = true;
            this.btnDrawSin.Click += new System.EventHandler(this.btnDrawSin_Click);
            // 
            // btnDrawCosinus
            // 
            this.btnDrawCosinus.Location = new System.Drawing.Point(36, 78);
            this.btnDrawCosinus.Name = "btnDrawCosinus";
            this.btnDrawCosinus.Size = new System.Drawing.Size(87, 23);
            this.btnDrawCosinus.TabIndex = 1;
            this.btnDrawCosinus.Text = "Draw Cosinus";
            this.btnDrawCosinus.UseVisualStyleBackColor = true;
            this.btnDrawCosinus.Click += new System.EventHandler(this.btnDrawCosinus_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(235, 31);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(492, 349);
            this.panelDraw.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.btnDrawCosinus);
            this.Controls.Add(this.btnDrawSin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawSin;
        private System.Windows.Forms.Button btnDrawCosinus;
        private System.Windows.Forms.Panel panelDraw;
    }
}

