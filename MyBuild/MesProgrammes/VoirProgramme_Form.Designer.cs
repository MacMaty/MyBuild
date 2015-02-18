namespace MyBuild.MesProgrammes
{
    partial class VoirProgramme_Form
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
            this.lbx_Entrainement = new System.Windows.Forms.ListBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_Entrainement
            // 
            this.lbx_Entrainement.FormattingEnabled = true;
            this.lbx_Entrainement.Location = new System.Drawing.Point(114, 103);
            this.lbx_Entrainement.Name = "lbx_Entrainement";
            this.lbx_Entrainement.Size = new System.Drawing.Size(120, 238);
            this.lbx_Entrainement.TabIndex = 1;
            this.lbx_Entrainement.SelectedIndexChanged += new System.EventHandler(this.lbx_Entrainement_SelectedIndexChanged);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(114, 370);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 2;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // VoirProgramme_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1031, 613);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.lbx_Entrainement);
            this.Name = "VoirProgramme_Form";
            this.Text = "VoirProgramme";
            this.Load += new System.EventHandler(this.VoirProgramme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Entrainement;
        private System.Windows.Forms.Button btn_Supprimer;
    }
}