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
            this.txt_NomEntrainement = new System.Windows.Forms.TextBox();
            this.lbl_NomEntrainement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_nbTours = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Recompense = new System.Windows.Forms.TextBox();
            this.cbx_TypeEntrainement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxExercices = new System.Windows.Forms.GroupBox();
            this.btn_RemoveExo = new System.Windows.Forms.Button();
            this.btn_AddExo = new System.Windows.Forms.Button();
            this.btn_AjouterExercices = new System.Windows.Forms.Button();
            this.gbx_Entrainement = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_numeroTour = new System.Windows.Forms.Label();
            this.btn_RemoveTour = new System.Windows.Forms.Button();
            this.btn_AddTour = new System.Windows.Forms.Button();
            this.tbx_Id = new System.Windows.Forms.TextBox();
            this.rtxt_log = new System.Windows.Forms.RichTextBox();
            this.btn_ValiderEntrainement = new System.Windows.Forms.Button();
            this.gbxExercices.SuspendLayout();
            this.gbx_Entrainement.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // txt_NomEntrainement
            // 
            this.txt_NomEntrainement.Location = new System.Drawing.Point(133, 19);
            this.txt_NomEntrainement.Name = "txt_NomEntrainement";
            this.txt_NomEntrainement.Size = new System.Drawing.Size(134, 20);
            this.txt_NomEntrainement.TabIndex = 1;
            this.txt_NomEntrainement.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.gbxExercices.Controls.Add(this.btn_RemoveExo);
            this.gbxExercices.Controls.Add(this.btn_AddExo);
            this.gbxExercices.Controls.Add(this.btn_AjouterExercices);
            this.gbxExercices.Location = new System.Drawing.Point(25, 64);
            this.gbxExercices.Name = "gbxExercices";
            this.gbxExercices.Size = new System.Drawing.Size(309, 260);
            this.gbxExercices.TabIndex = 10;
            this.gbxExercices.TabStop = false;
            this.gbxExercices.Text = "Exercices";
            // 
            // btn_RemoveExo
            // 
            this.btn_RemoveExo.Location = new System.Drawing.Point(51, 19);
            this.btn_RemoveExo.Name = "btn_RemoveExo";
            this.btn_RemoveExo.Size = new System.Drawing.Size(26, 23);
            this.btn_RemoveExo.TabIndex = 14;
            this.btn_RemoveExo.Text = "-";
            this.btn_RemoveExo.UseVisualStyleBackColor = true;
            this.btn_RemoveExo.Click += new System.EventHandler(this.btn_RemoveExo_Click);
            // 
            // btn_AddExo
            // 
            this.btn_AddExo.Location = new System.Drawing.Point(19, 19);
            this.btn_AddExo.Name = "btn_AddExo";
            this.btn_AddExo.Size = new System.Drawing.Size(26, 23);
            this.btn_AddExo.TabIndex = 13;
            this.btn_AddExo.Text = "+";
            this.btn_AddExo.UseVisualStyleBackColor = true;
            this.btn_AddExo.Click += new System.EventHandler(this.btn_AddExo_Click);
            // 
            // btn_AjouterExercices
            // 
            this.btn_AjouterExercices.Location = new System.Drawing.Point(228, 74);
            this.btn_AjouterExercices.Name = "btn_AjouterExercices";
            this.btn_AjouterExercices.Size = new System.Drawing.Size(75, 23);
            this.btn_AjouterExercices.TabIndex = 12;
            this.btn_AjouterExercices.Text = "Ajouter";
            this.btn_AjouterExercices.UseVisualStyleBackColor = true;
            this.btn_AjouterExercices.Visible = false;
            this.btn_AjouterExercices.Click += new System.EventHandler(this.btn_AjouterExercices_Click);
            // 
            // gbx_Entrainement
            // 
            this.gbx_Entrainement.Controls.Add(this.btn_ValiderEntrainement);
            this.gbx_Entrainement.Controls.Add(this.groupBox1);
            this.gbx_Entrainement.Controls.Add(this.txt_NomEntrainement);
            this.gbx_Entrainement.Controls.Add(this.lbl_NomEntrainement);
            this.gbx_Entrainement.Controls.Add(this.label3);
            this.gbx_Entrainement.Controls.Add(this.label2);
            this.gbx_Entrainement.Controls.Add(this.cbx_TypeEntrainement);
            this.gbx_Entrainement.Controls.Add(this.cbx_nbTours);
            this.gbx_Entrainement.Controls.Add(this.tbx_Recompense);
            this.gbx_Entrainement.Controls.Add(this.label1);
            this.gbx_Entrainement.Location = new System.Drawing.Point(12, 62);
            this.gbx_Entrainement.Name = "gbx_Entrainement";
            this.gbx_Entrainement.Size = new System.Drawing.Size(416, 559);
            this.gbx_Entrainement.TabIndex = 11;
            this.gbx_Entrainement.TabStop = false;
            this.gbx_Entrainement.Text = "Entrainement";
            this.gbx_Entrainement.Visible = false;
            this.gbx_Entrainement.Enter += new System.EventHandler(this.gbx_Entrainement_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_numeroTour);
            this.groupBox1.Controls.Add(this.btn_RemoveTour);
            this.groupBox1.Controls.Add(this.gbxExercices);
            this.groupBox1.Controls.Add(this.btn_AddTour);
            this.groupBox1.Location = new System.Drawing.Point(19, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 341);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour";
            // 
            // lbl_numeroTour
            // 
            this.lbl_numeroTour.AutoSize = true;
            this.lbl_numeroTour.Location = new System.Drawing.Point(114, 28);
            this.lbl_numeroTour.Name = "lbl_numeroTour";
            this.lbl_numeroTour.Size = new System.Drawing.Size(0, 13);
            this.lbl_numeroTour.TabIndex = 17;
            // 
            // btn_RemoveTour
            // 
            this.btn_RemoveTour.Location = new System.Drawing.Point(76, 19);
            this.btn_RemoveTour.Name = "btn_RemoveTour";
            this.btn_RemoveTour.Size = new System.Drawing.Size(26, 23);
            this.btn_RemoveTour.TabIndex = 16;
            this.btn_RemoveTour.Text = "-";
            this.btn_RemoveTour.UseVisualStyleBackColor = true;
            this.btn_RemoveTour.Click += new System.EventHandler(this.btn_RemoveTour_Click);
            // 
            // btn_AddTour
            // 
            this.btn_AddTour.Location = new System.Drawing.Point(44, 19);
            this.btn_AddTour.Name = "btn_AddTour";
            this.btn_AddTour.Size = new System.Drawing.Size(26, 23);
            this.btn_AddTour.TabIndex = 15;
            this.btn_AddTour.Text = "+";
            this.btn_AddTour.UseVisualStyleBackColor = true;
            this.btn_AddTour.Click += new System.EventHandler(this.btn_AddTour_Click);
            // 
            // tbx_Id
            // 
            this.tbx_Id.Location = new System.Drawing.Point(12, 3);
            this.tbx_Id.Name = "tbx_Id";
            this.tbx_Id.Size = new System.Drawing.Size(100, 20);
            this.tbx_Id.TabIndex = 12;
            this.tbx_Id.Visible = false;
            // 
            // rtxt_log
            // 
            this.rtxt_log.Location = new System.Drawing.Point(465, 192);
            this.rtxt_log.Name = "rtxt_log";
            this.rtxt_log.Size = new System.Drawing.Size(353, 212);
            this.rtxt_log.TabIndex = 13;
            this.rtxt_log.Text = "";
            // 
            // btn_ValiderEntrainement
            // 
            this.btn_ValiderEntrainement.Location = new System.Drawing.Point(298, 528);
            this.btn_ValiderEntrainement.Name = "btn_ValiderEntrainement";
            this.btn_ValiderEntrainement.Size = new System.Drawing.Size(75, 23);
            this.btn_ValiderEntrainement.TabIndex = 12;
            this.btn_ValiderEntrainement.Text = "Valider";
            this.btn_ValiderEntrainement.UseVisualStyleBackColor = true;
            this.btn_ValiderEntrainement.Click += new System.EventHandler(this.btn_ValiderEntrainement_Click);
            // 
            // Entrainement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 706);
            this.Controls.Add(this.rtxt_log);
            this.Controls.Add(this.tbx_Id);
            this.Controls.Add(this.gbx_Entrainement);
            this.Controls.Add(this.btn_AjouterEntrainement);
            this.Name = "Entrainement_Form";
            this.Text = "Entrainement";
            this.Load += new System.EventHandler(this.Entrainement_Form_Load);
            this.gbxExercices.ResumeLayout(false);
            this.gbx_Entrainement.ResumeLayout(false);
            this.gbx_Entrainement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AjouterEntrainement;
        private System.Windows.Forms.TextBox txt_NomEntrainement;
        private System.Windows.Forms.Label lbl_NomEntrainement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_nbTours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Recompense;
        private System.Windows.Forms.ComboBox cbx_TypeEntrainement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxExercices;
        private System.Windows.Forms.Button btn_AjouterExercices;
        private System.Windows.Forms.GroupBox gbx_Entrainement;
        private System.Windows.Forms.TextBox tbx_Id;
        private System.Windows.Forms.Button btn_AddExo;
        private System.Windows.Forms.Button btn_RemoveExo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_RemoveTour;
        private System.Windows.Forms.Button btn_AddTour;
        private System.Windows.Forms.Label lbl_numeroTour;
        private System.Windows.Forms.RichTextBox rtxt_log;
        private System.Windows.Forms.Button btn_ValiderEntrainement;
    }
}