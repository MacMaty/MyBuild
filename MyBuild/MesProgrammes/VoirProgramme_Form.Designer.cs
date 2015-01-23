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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbx_Entrainement = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(600, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // VoirProgramme_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 613);
            this.Controls.Add(this.lbx_Entrainement);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VoirProgramme_Form";
            this.Text = "VoirProgramme";
            this.Load += new System.EventHandler(this.VoirProgramme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbx_Entrainement;
    }
}