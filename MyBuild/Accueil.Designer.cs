﻿namespace MyBuild
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.btn_Gestion = new System.Windows.Forms.Button();
            this.btn_programme = new System.Windows.Forms.Button();
            this.btn_Entrainements = new System.Windows.Forms.Button();
            this.btn_Exercices = new System.Windows.Forms.Button();
            this.btn_Equipements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gestion
            // 
            this.btn_Gestion.Location = new System.Drawing.Point(83, 96);
            this.btn_Gestion.Name = "btn_Gestion";
            this.btn_Gestion.Size = new System.Drawing.Size(188, 56);
            this.btn_Gestion.TabIndex = 0;
            this.btn_Gestion.Text = "Gestion";
            this.btn_Gestion.UseVisualStyleBackColor = true;
            this.btn_Gestion.Click += new System.EventHandler(this.btn_Gestion_Click);
            // 
            // btn_programme
            // 
            this.btn_programme.Location = new System.Drawing.Point(83, 197);
            this.btn_programme.Name = "btn_programme";
            this.btn_programme.Size = new System.Drawing.Size(188, 56);
            this.btn_programme.TabIndex = 1;
            this.btn_programme.Text = "Mes Programmes";
            this.btn_programme.UseVisualStyleBackColor = true;
            this.btn_programme.Click += new System.EventHandler(this.btn_programme_Click);
            // 
            // btn_Entrainements
            // 
            this.btn_Entrainements.Location = new System.Drawing.Point(320, 97);
            this.btn_Entrainements.Name = "btn_Entrainements";
            this.btn_Entrainements.Size = new System.Drawing.Size(90, 23);
            this.btn_Entrainements.TabIndex = 3;
            this.btn_Entrainements.Text = "Entrainements";
            this.btn_Entrainements.UseVisualStyleBackColor = true;
            this.btn_Entrainements.Visible = false;
            this.btn_Entrainements.Click += new System.EventHandler(this.btn_Entrainements_Click);
            // 
            // btn_Exercices
            // 
            this.btn_Exercices.Location = new System.Drawing.Point(416, 96);
            this.btn_Exercices.Name = "btn_Exercices";
            this.btn_Exercices.Size = new System.Drawing.Size(75, 23);
            this.btn_Exercices.TabIndex = 4;
            this.btn_Exercices.Text = "Exercices";
            this.btn_Exercices.UseVisualStyleBackColor = true;
            this.btn_Exercices.Visible = false;
            this.btn_Exercices.Click += new System.EventHandler(this.btn_Exercices_Click);
            // 
            // btn_Equipements
            // 
            this.btn_Equipements.Location = new System.Drawing.Point(497, 96);
            this.btn_Equipements.Name = "btn_Equipements";
            this.btn_Equipements.Size = new System.Drawing.Size(86, 23);
            this.btn_Equipements.TabIndex = 5;
            this.btn_Equipements.Text = "Equipements";
            this.btn_Equipements.UseVisualStyleBackColor = true;
            this.btn_Equipements.Visible = false;
            this.btn_Equipements.Click += new System.EventHandler(this.btn_Equipements_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 373);
            this.Controls.Add(this.btn_Equipements);
            this.Controls.Add(this.btn_Exercices);
            this.Controls.Add(this.btn_Entrainements);
            this.Controls.Add(this.btn_programme);
            this.Controls.Add(this.btn_Gestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.Text = "MyBuild";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gestion;
        private System.Windows.Forms.Button btn_programme;
        private System.Windows.Forms.Button btn_Entrainements;
        private System.Windows.Forms.Button btn_Exercices;
        private System.Windows.Forms.Button btn_Equipements;
    }
}

