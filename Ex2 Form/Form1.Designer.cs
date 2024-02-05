namespace Ex2_Form
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBase10 = new System.Windows.Forms.TextBox();
            this.textBase2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBase10
            // 
            this.txtBase10.Location = new System.Drawing.Point(67, 120);
            this.txtBase10.Name = "txtBase10";
            this.txtBase10.Size = new System.Drawing.Size(100, 22);
            this.txtBase10.TabIndex = 0;
            // 
            // textBase2
            // 
            this.textBase2.Location = new System.Drawing.Point(439, 120);
            this.textBase2.Name = "textBase2";
            this.textBase2.Size = new System.Drawing.Size(100, 22);
            this.textBase2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 324);
            this.Controls.Add(this.textBase2);
            this.Controls.Add(this.txtBase10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase10;
        private System.Windows.Forms.TextBox textBase2;
    }
}

