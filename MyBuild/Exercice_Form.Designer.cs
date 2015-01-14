namespace MyBuild
{
    partial class Exercice_Form
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
            this.txt_IdExercice = new System.Windows.Forms.TextBox();
            this.txt_NomExercice = new System.Windows.Forms.TextBox();
            this.txt_Recompense = new System.Windows.Forms.TextBox();
            this.cbx_IdTypeEntrainement = new System.Windows.Forms.ComboBox();
            this.cbx_IdEquipement = new System.Windows.Forms.ComboBox();
            this.btn_AjouterExercice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IdExercice
            // 
            this.txt_IdExercice.Location = new System.Drawing.Point(2, 13);
            this.txt_IdExercice.Name = "txt_IdExercice";
            this.txt_IdExercice.Size = new System.Drawing.Size(100, 20);
            this.txt_IdExercice.TabIndex = 0;
            this.txt_IdExercice.Visible = false;
            // 
            // txt_NomExercice
            // 
            this.txt_NomExercice.Location = new System.Drawing.Point(137, 118);
            this.txt_NomExercice.Name = "txt_NomExercice";
            this.txt_NomExercice.Size = new System.Drawing.Size(121, 20);
            this.txt_NomExercice.TabIndex = 1;
            // 
            // txt_Recompense
            // 
            this.txt_Recompense.Location = new System.Drawing.Point(137, 153);
            this.txt_Recompense.Name = "txt_Recompense";
            this.txt_Recompense.Size = new System.Drawing.Size(121, 20);
            this.txt_Recompense.TabIndex = 2;
            // 
            // cbx_IdTypeEntrainement
            // 
            this.cbx_IdTypeEntrainement.FormattingEnabled = true;
            this.cbx_IdTypeEntrainement.Location = new System.Drawing.Point(137, 192);
            this.cbx_IdTypeEntrainement.Name = "cbx_IdTypeEntrainement";
            this.cbx_IdTypeEntrainement.Size = new System.Drawing.Size(121, 21);
            this.cbx_IdTypeEntrainement.TabIndex = 3;
            // 
            // cbx_IdEquipement
            // 
            this.cbx_IdEquipement.FormattingEnabled = true;
            this.cbx_IdEquipement.Location = new System.Drawing.Point(137, 229);
            this.cbx_IdEquipement.Name = "cbx_IdEquipement";
            this.cbx_IdEquipement.Size = new System.Drawing.Size(121, 21);
            this.cbx_IdEquipement.TabIndex = 4;
            // 
            // btn_AjouterExercice
            // 
            this.btn_AjouterExercice.Location = new System.Drawing.Point(137, 283);
            this.btn_AjouterExercice.Name = "btn_AjouterExercice";
            this.btn_AjouterExercice.Size = new System.Drawing.Size(75, 23);
            this.btn_AjouterExercice.TabIndex = 5;
            this.btn_AjouterExercice.Text = "button1";
            this.btn_AjouterExercice.UseVisualStyleBackColor = true;
            this.btn_AjouterExercice.Click += new System.EventHandler(this.btn_AjouterExercice_Click);
            // 
            // Exercice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 569);
            this.Controls.Add(this.btn_AjouterExercice);
            this.Controls.Add(this.cbx_IdEquipement);
            this.Controls.Add(this.cbx_IdTypeEntrainement);
            this.Controls.Add(this.txt_Recompense);
            this.Controls.Add(this.txt_NomExercice);
            this.Controls.Add(this.txt_IdExercice);
            this.Name = "Exercice_Form";
            this.Text = "Exercice_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdExercice;
        private System.Windows.Forms.TextBox txt_NomExercice;
        private System.Windows.Forms.TextBox txt_Recompense;
        private System.Windows.Forms.ComboBox cbx_IdTypeEntrainement;
        private System.Windows.Forms.ComboBox cbx_IdEquipement;
        private System.Windows.Forms.Button btn_AjouterExercice;
    }
}