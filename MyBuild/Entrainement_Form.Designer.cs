namespace MyBuild
{
    partial class Entrainement_Form
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
            this.btn_AjouterEntrainement = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_NomEntrainement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_nbTours = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Recompense = new System.Windows.Forms.TextBox();
            this.cbx_TypeEntrainement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxExercices = new System.Windows.Forms.GroupBox();
            this.btn_AjouterExercices = new System.Windows.Forms.Button();
            this.cbx_nbrExercices = new System.Windows.Forms.ComboBox();
            this.lbl_NbExercices = new System.Windows.Forms.Label();
            this.lbl_CompteurTours = new System.Windows.Forms.Label();
            this.gbx_Entrainement = new System.Windows.Forms.GroupBox();
            this.tbx_Id = new System.Windows.Forms.TextBox();
            this.gbxExercices.SuspendLayout();
            this.gbx_Entrainement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AjouterEntrainement
            // 
            this.btn_AjouterEntrainement.Location = new System.Drawing.Point(97, 33);
            this.btn_AjouterEntrainement.Name = "btn_AjouterEntrainement";
            this.btn_AjouterEntrainement.Size = new System.Drawing.Size(75, 23);
            this.btn_AjouterEntrainement.TabIndex = 0;
            this.btn_AjouterEntrainement.Text = "Ajouter";
            this.btn_AjouterEntrainement.UseVisualStyleBackColor = true;
            this.btn_AjouterEntrainement.Click += new System.EventHandler(this.btn_AjouterEntrainement_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_NomEntrainement
            // 
            this.lbl_NomEntrainement.AutoSize = true;
            this.lbl_NomEntrainement.Location = new System.Drawing.Point(72, 19);
            this.lbl_NomEntrainement.Name = "lbl_NomEntrainement";
            this.lbl_NomEntrainement.Size = new System.Drawing.Size(29, 13);
            this.lbl_NomEntrainement.TabIndex = 3;
            this.lbl_NomEntrainement.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de tours";
            // 
            // cbx_nbTours
            // 
            this.cbx_nbTours.FormattingEnabled = true;
            this.cbx_nbTours.Location = new System.Drawing.Point(133, 102);
            this.cbx_nbTours.Name = "cbx_nbTours";
            this.cbx_nbTours.Size = new System.Drawing.Size(35, 21);
            this.cbx_nbTours.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Récompenses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_Recompense
            // 
            this.tbx_Recompense.Location = new System.Drawing.Point(133, 49);
            this.tbx_Recompense.Name = "tbx_Recompense";
            this.tbx_Recompense.Size = new System.Drawing.Size(134, 20);
            this.tbx_Recompense.TabIndex = 7;
            // 
            // cbx_TypeEntrainement
            // 
            this.cbx_TypeEntrainement.FormattingEnabled = true;
            this.cbx_TypeEntrainement.Location = new System.Drawing.Point(133, 75);
            this.cbx_TypeEntrainement.Name = "cbx_TypeEntrainement";
            this.cbx_TypeEntrainement.Size = new System.Drawing.Size(112, 21);
            this.cbx_TypeEntrainement.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbxExercices
            // 
            this.gbxExercices.Controls.Add(this.lbl_CompteurTours);
            this.gbxExercices.Controls.Add(this.cbx_nbrExercices);
            this.gbxExercices.Controls.Add(this.btn_AjouterExercices);
            this.gbxExercices.Controls.Add(this.lbl_NbExercices);
            this.gbxExercices.Location = new System.Drawing.Point(10, 129);
            this.gbxExercices.Name = "gbxExercices";
            this.gbxExercices.Size = new System.Drawing.Size(271, 211);
            this.gbxExercices.TabIndex = 10;
            this.gbxExercices.TabStop = false;
            this.gbxExercices.Text = "Exercices";
            // 
            // btn_AjouterExercices
            // 
            this.btn_AjouterExercices.Location = new System.Drawing.Point(6, 19);
            this.btn_AjouterExercices.Name = "btn_AjouterExercices";
            this.btn_AjouterExercices.Size = new System.Drawing.Size(75, 23);
            this.btn_AjouterExercices.TabIndex = 12;
            this.btn_AjouterExercices.Text = "Ajouter";
            this.btn_AjouterExercices.UseVisualStyleBackColor = true;
            this.btn_AjouterExercices.Click += new System.EventHandler(this.btn_AjouterExercices_Click);
            // 
            // cbx_nbrExercices
            // 
            this.cbx_nbrExercices.FormattingEnabled = true;
            this.cbx_nbrExercices.Location = new System.Drawing.Point(123, 57);
            this.cbx_nbrExercices.Name = "cbx_nbrExercices";
            this.cbx_nbrExercices.Size = new System.Drawing.Size(35, 21);
            this.cbx_nbrExercices.TabIndex = 12;
            this.cbx_nbrExercices.Visible = false;
            // 
            // lbl_NbExercices
            // 
            this.lbl_NbExercices.AutoSize = true;
            this.lbl_NbExercices.Location = new System.Drawing.Point(6, 57);
            this.lbl_NbExercices.Name = "lbl_NbExercices";
            this.lbl_NbExercices.Size = new System.Drawing.Size(100, 13);
            this.lbl_NbExercices.TabIndex = 11;
            this.lbl_NbExercices.Text = "Nombre d\'exercices";
            this.lbl_NbExercices.Visible = false;
            // 
            // lbl_CompteurTours
            // 
            this.lbl_CompteurTours.AutoSize = true;
            this.lbl_CompteurTours.Location = new System.Drawing.Point(101, 24);
            this.lbl_CompteurTours.Name = "lbl_CompteurTours";
            this.lbl_CompteurTours.Size = new System.Drawing.Size(85, 13);
            this.lbl_CompteurTours.TabIndex = 11;
            this.lbl_CompteurTours.Text = "Nombre de tours";
            this.lbl_CompteurTours.Visible = false;
            // 
            // gbx_Entrainement
            // 
            this.gbx_Entrainement.Controls.Add(this.textBox1);
            this.gbx_Entrainement.Controls.Add(this.gbxExercices);
            this.gbx_Entrainement.Controls.Add(this.lbl_NomEntrainement);
            this.gbx_Entrainement.Controls.Add(this.label3);
            this.gbx_Entrainement.Controls.Add(this.label2);
            this.gbx_Entrainement.Controls.Add(this.cbx_TypeEntrainement);
            this.gbx_Entrainement.Controls.Add(this.cbx_nbTours);
            this.gbx_Entrainement.Controls.Add(this.tbx_Recompense);
            this.gbx_Entrainement.Controls.Add(this.label1);
            this.gbx_Entrainement.Location = new System.Drawing.Point(12, 62);
            this.gbx_Entrainement.Name = "gbx_Entrainement";
            this.gbx_Entrainement.Size = new System.Drawing.Size(325, 370);
            this.gbx_Entrainement.TabIndex = 11;
            this.gbx_Entrainement.TabStop = false;
            this.gbx_Entrainement.Text = "Entrainement";
            this.gbx_Entrainement.Visible = false;
            // 
            // tbx_Id
            // 
            this.tbx_Id.Location = new System.Drawing.Point(12, 3);
            this.tbx_Id.Name = "tbx_Id";
            this.tbx_Id.Size = new System.Drawing.Size(100, 20);
            this.tbx_Id.TabIndex = 12;
            this.tbx_Id.Visible = false;
            // 
            // Entrainement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 486);
            this.Controls.Add(this.tbx_Id);
            this.Controls.Add(this.gbx_Entrainement);
            this.Controls.Add(this.btn_AjouterEntrainement);
            this.Name = "Entrainement_Form";
            this.Text = "Entrainement";
            this.Load += new System.EventHandler(this.Entrainement_Form_Load);
            this.gbxExercices.ResumeLayout(false);
            this.gbxExercices.PerformLayout();
            this.gbx_Entrainement.ResumeLayout(false);
            this.gbx_Entrainement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AjouterEntrainement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_NomEntrainement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_nbTours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Recompense;
        private System.Windows.Forms.ComboBox cbx_TypeEntrainement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxExercices;
        private System.Windows.Forms.Label lbl_CompteurTours;
        private System.Windows.Forms.ComboBox cbx_nbrExercices;
        private System.Windows.Forms.Button btn_AjouterExercices;
        private System.Windows.Forms.Label lbl_NbExercices;
        private System.Windows.Forms.GroupBox gbx_Entrainement;
        private System.Windows.Forms.TextBox tbx_Id;
    }
}