namespace MyBuild
{
    partial class Equipement_Form
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
            this.txt_IdEquipement = new System.Windows.Forms.TextBox();
            this.txt_NomEquipement = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IdEquipement
            // 
            this.txt_IdEquipement.Location = new System.Drawing.Point(13, 13);
            this.txt_IdEquipement.Name = "txt_IdEquipement";
            this.txt_IdEquipement.Size = new System.Drawing.Size(100, 20);
            this.txt_IdEquipement.TabIndex = 0;
            this.txt_IdEquipement.Visible = false;
            // 
            // txt_NomEquipement
            // 
            this.txt_NomEquipement.Location = new System.Drawing.Point(89, 92);
            this.txt_NomEquipement.Name = "txt_NomEquipement";
            this.txt_NomEquipement.Size = new System.Drawing.Size(100, 20);
            this.txt_NomEquipement.TabIndex = 1;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(102, 118);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 2;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // Equipement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.txt_NomEquipement);
            this.Controls.Add(this.txt_IdEquipement);
            this.Name = "Equipement_Form";
            this.Text = "Equipement_Form";
            this.Load += new System.EventHandler(this.Equipement_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdEquipement;
        private System.Windows.Forms.TextBox txt_NomEquipement;
        private System.Windows.Forms.Button btn_Valider;
    }
}