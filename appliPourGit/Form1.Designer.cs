namespace appliPourGit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Emplyer_Nom = new System.Windows.Forms.TextBox();
            this.Employer_Nom_Label = new System.Windows.Forms.Label();
            this.Employer_Prenom_Label = new System.Windows.Forms.Label();
            this.Employer_Prenom = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Emplyer_Nom
            // 
            this.Emplyer_Nom.Location = new System.Drawing.Point(26, 62);
            this.Emplyer_Nom.Name = "Emplyer_Nom";
            this.Emplyer_Nom.Size = new System.Drawing.Size(195, 22);
            this.Emplyer_Nom.TabIndex = 0;
            // 
            // Employer_Nom_Label
            // 
            this.Employer_Nom_Label.AutoSize = true;
            this.Employer_Nom_Label.Location = new System.Drawing.Point(23, 42);
            this.Employer_Nom_Label.Name = "Employer_Nom_Label";
            this.Employer_Nom_Label.Size = new System.Drawing.Size(37, 17);
            this.Employer_Nom_Label.TabIndex = 1;
            this.Employer_Nom_Label.Text = "Nom";
            // 
            // Employer_Prenom_Label
            // 
            this.Employer_Prenom_Label.AutoSize = true;
            this.Employer_Prenom_Label.Location = new System.Drawing.Point(23, 91);
            this.Employer_Prenom_Label.Name = "Employer_Prenom_Label";
            this.Employer_Prenom_Label.Size = new System.Drawing.Size(57, 17);
            this.Employer_Prenom_Label.TabIndex = 3;
            this.Employer_Prenom_Label.Text = "Prenom";
            // 
            // Employer_Prenom
            // 
            this.Employer_Prenom.Location = new System.Drawing.Point(26, 111);
            this.Employer_Prenom.Name = "Employer_Prenom";
            this.Employer_Prenom.Size = new System.Drawing.Size(195, 22);
            this.Employer_Prenom.TabIndex = 2;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(29, 157);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(146, 157);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_annuler);
            this.groupBox1.Controls.Add(this.btn_valider);
            this.groupBox1.Controls.Add(this.Employer_Prenom_Label);
            this.groupBox1.Controls.Add(this.Employer_Prenom);
            this.groupBox1.Controls.Add(this.Employer_Nom_Label);
            this.groupBox1.Controls.Add(this.Emplyer_Nom);
            this.groupBox1.Location = new System.Drawing.Point(331, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 225);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisir un nouvelle emplyer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label Employer_Prenom_Label;
        private System.Windows.Forms.TextBox Employer_Prenom;
        private System.Windows.Forms.Label Employer_Nom_Label;
        private System.Windows.Forms.TextBox Emplyer_Nom;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

