namespace appliPourGit
{
    partial class Employer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Employer_saisi_Nom = new System.Windows.Forms.TextBox();
            this.Employer_saisi_prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // Employer_saisi_Nom
            // 
            this.Employer_saisi_Nom.Location = new System.Drawing.Point(98, 72);
            this.Employer_saisi_Nom.Name = "Employer_saisi_Nom";
            this.Employer_saisi_Nom.Size = new System.Drawing.Size(161, 22);
            this.Employer_saisi_Nom.TabIndex = 1;
            // 
            // Employer_saisi_prenom
            // 
            this.Employer_saisi_prenom.Location = new System.Drawing.Point(98, 138);
            this.Employer_saisi_prenom.Name = "Employer_saisi_prenom";
            this.Employer_saisi_prenom.Size = new System.Drawing.Size(161, 22);
            this.Employer_saisi_prenom.TabIndex = 3;
            this.Employer_saisi_prenom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(70, 207);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "annuler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.Employer_saisi_prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Employer_saisi_Nom);
            this.Controls.Add(this.label1);
            this.Name = "Employer";
            this.Text = "Employer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Employer_saisi_Nom;
        private System.Windows.Forms.TextBox Employer_saisi_prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button button1;
    }
}