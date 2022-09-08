
namespace ExerciceDes
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
            this.buttonBrasser = new System.Windows.Forms.Button();
            this.labelResultat = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBrasser
            // 
            this.buttonBrasser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrasser.Location = new System.Drawing.Point(29, 194);
            this.buttonBrasser.Name = "buttonBrasser";
            this.buttonBrasser.Size = new System.Drawing.Size(154, 43);
            this.buttonBrasser.TabIndex = 0;
            this.buttonBrasser.Text = "Brasser";
            this.buttonBrasser.UseVisualStyleBackColor = true;
            this.buttonBrasser.Click += new System.EventHandler(this.buttonBrasser_Click);
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultat.Location = new System.Drawing.Point(58, 30);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(93, 25);
            this.labelResultat.TabIndex = 1;
            this.labelResultat.Text = "Résultat :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(84, 122);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(67, 25);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "Total :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(24, 75);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(127, 25);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type de dé  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 267);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.buttonBrasser);
            this.Name = "Form1";
            this.Text = "Jeu de dés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrasser;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelType;
    }
}

