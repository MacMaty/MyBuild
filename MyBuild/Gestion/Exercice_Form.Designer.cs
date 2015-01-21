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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercice_Form));
            System.Windows.Forms.Label imgLabel;
            System.Windows.Forms.Label imgPathLabel;
            this.txt_IdExercice = new System.Windows.Forms.TextBox();
            this.txt_NomExercice = new System.Windows.Forms.TextBox();
            this.txt_Recompense = new System.Windows.Forms.TextBox();
            this.cbx_IdTypeEntrainement = new System.Windows.Forms.ComboBox();
            this.cbx_IdEquipement = new System.Windows.Forms.ComboBox();
            this.btn_AjouterExercice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dsMyBuild = new MyBuild.DsMyBuild();
            this.tableExerciceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableExerciceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tableExerciceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.btn_AddImg = new System.Windows.Forms.Button();
            this.imgPathLabel1 = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            imgPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsMyBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExerciceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExerciceBindingNavigator)).BeginInit();
            this.tableExerciceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
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
            this.btn_AjouterExercice.Location = new System.Drawing.Point(254, 382);
            this.btn_AjouterExercice.Name = "btn_AjouterExercice";
            this.btn_AjouterExercice.Size = new System.Drawing.Size(75, 23);
            this.btn_AjouterExercice.TabIndex = 5;
            this.btn_AjouterExercice.Text = "Ajouter";
            this.btn_AjouterExercice.UseVisualStyleBackColor = true;
            this.btn_AjouterExercice.Click += new System.EventHandler(this.btn_AjouterExercice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Récompense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type d\'entrainement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Équipement";
            // 
            // dsMyBuild
            // 
            this.dsMyBuild.DataSetName = "DsMyBuild";
            this.dsMyBuild.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableExerciceBindingSource
            // 
            this.tableExerciceBindingSource.DataMember = "TableExercice";
            this.tableExerciceBindingSource.DataSource = this.dsMyBuild;
            // 
            // tableExerciceBindingNavigator
            // 
            this.tableExerciceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableExerciceBindingNavigator.BindingSource = this.tableExerciceBindingSource;
            this.tableExerciceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableExerciceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableExerciceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableExerciceBindingNavigatorSaveItem});
            this.tableExerciceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableExerciceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableExerciceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableExerciceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableExerciceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableExerciceBindingNavigator.Name = "tableExerciceBindingNavigator";
            this.tableExerciceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableExerciceBindingNavigator.Size = new System.Drawing.Size(872, 25);
            this.tableExerciceBindingNavigator.TabIndex = 10;
            this.tableExerciceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // tableExerciceBindingNavigatorSaveItem
            // 
            this.tableExerciceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableExerciceBindingNavigatorSaveItem.Enabled = false;
            this.tableExerciceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableExerciceBindingNavigatorSaveItem.Image")));
            this.tableExerciceBindingNavigatorSaveItem.Name = "tableExerciceBindingNavigatorSaveItem";
            this.tableExerciceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableExerciceBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Location = new System.Drawing.Point(135, 289);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(27, 13);
            imgLabel.TabIndex = 11;
            imgLabel.Text = "Img:";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableExerciceBindingSource, "Img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(137, 305);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imgPictureBox.TabIndex = 12;
            this.imgPictureBox.TabStop = false;
            this.imgPictureBox.Click += new System.EventHandler(this.imgPictureBox_Click);
            // 
            // btn_AddImg
            // 
            this.btn_AddImg.Location = new System.Drawing.Point(243, 254);
            this.btn_AddImg.Name = "btn_AddImg";
            this.btn_AddImg.Size = new System.Drawing.Size(38, 23);
            this.btn_AddImg.TabIndex = 15;
            this.btn_AddImg.Text = "+";
            this.btn_AddImg.UseVisualStyleBackColor = true;
            this.btn_AddImg.Click += new System.EventHandler(this.btn_AddImg_Click);
            // 
            // imgPathLabel
            // 
            imgPathLabel.AutoSize = true;
            imgPathLabel.Location = new System.Drawing.Point(80, 259);
            imgPathLabel.Name = "imgPathLabel";
            imgPathLabel.Size = new System.Drawing.Size(51, 13);
            imgPathLabel.TabIndex = 15;
            imgPathLabel.Text = "img Path:";
            // 
            // imgPathLabel1
            // 
            this.imgPathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableExerciceBindingSource, "imgPath", true));
            this.imgPathLabel1.Location = new System.Drawing.Point(137, 259);
            this.imgPathLabel1.Name = "imgPathLabel1";
            this.imgPathLabel1.Size = new System.Drawing.Size(100, 23);
            this.imgPathLabel1.TabIndex = 16;
            this.imgPathLabel1.Text = "label5";
            // 
            // Exercice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 569);
            this.Controls.Add(imgPathLabel);
            this.Controls.Add(this.imgPathLabel1);
            this.Controls.Add(this.btn_AddImg);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.tableExerciceBindingNavigator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AjouterExercice);
            this.Controls.Add(this.cbx_IdEquipement);
            this.Controls.Add(this.cbx_IdTypeEntrainement);
            this.Controls.Add(this.txt_Recompense);
            this.Controls.Add(this.txt_NomExercice);
            this.Controls.Add(this.txt_IdExercice);
            this.Name = "Exercice_Form";
            this.Text = "Exercice";
            this.Load += new System.EventHandler(this.Exercice_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMyBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExerciceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableExerciceBindingNavigator)).EndInit();
            this.tableExerciceBindingNavigator.ResumeLayout(false);
            this.tableExerciceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DsMyBuild dsMyBuild;
        private System.Windows.Forms.BindingSource tableExerciceBindingSource;
        private System.Windows.Forms.BindingNavigator tableExerciceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableExerciceBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Button btn_AddImg;
        private System.Windows.Forms.Label imgPathLabel1;
    }
}