namespace Base_de_données
{
    partial class Form1
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
            this.nom = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.labelnom = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.labelage = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.labelprenom = new System.Windows.Forms.Label();
            this.labelcin = new System.Windows.Forms.Label();
            this.cin = new System.Windows.Forms.TextBox();
            this.inser = new System.Windows.Forms.RadioButton();
            this.updat = new System.Windows.Forms.RadioButton();
            this.delet = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(193, 164);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(149, 38);
            this.nom.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(377, 364);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(73, 48);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(508, 364);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(73, 48);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(636, 364);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(73, 48);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Location = new System.Drawing.Point(79, 175);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(29, 13);
            this.labelnom.TabIndex = 11;
            this.labelnom.Text = "Nom";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(193, 290);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(149, 42);
            this.age.TabIndex = 14;
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Location = new System.Drawing.Point(82, 307);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(26, 13);
            this.labelage.TabIndex = 16;
            this.labelage.Text = "Age";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(193, 228);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(149, 38);
            this.prenom.TabIndex = 17;
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Location = new System.Drawing.Point(79, 243);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(43, 13);
            this.labelprenom.TabIndex = 18;
            this.labelprenom.Text = "Prenom";
            // 
            // labelcin
            // 
            this.labelcin.AutoSize = true;
            this.labelcin.Location = new System.Drawing.Point(79, 111);
            this.labelcin.Name = "labelcin";
            this.labelcin.Size = new System.Drawing.Size(25, 13);
            this.labelcin.TabIndex = 19;
            this.labelcin.Text = "CIN";
            // 
            // cin
            // 
            this.cin.Location = new System.Drawing.Point(193, 98);
            this.cin.Multiline = true;
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(149, 39);
            this.cin.TabIndex = 20;
            this.cin.TextChanged += new System.EventHandler(this.cin_TextChanged);
            // 
            // inser
            // 
            this.inser.AutoSize = true;
            this.inser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inser.Location = new System.Drawing.Point(94, 26);
            this.inser.Name = "inser";
            this.inser.Size = new System.Drawing.Size(83, 29);
            this.inser.TabIndex = 24;
            this.inser.TabStop = true;
            this.inser.Text = "Insert";
            this.inser.UseVisualStyleBackColor = true;
            this.inser.CheckedChanged += new System.EventHandler(this.inse_CheckedChanged);
            // 
            // updat
            // 
            this.updat.AutoSize = true;
            this.updat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updat.Location = new System.Drawing.Point(258, 26);
            this.updat.Name = "updat";
            this.updat.Size = new System.Drawing.Size(99, 29);
            this.updat.TabIndex = 25;
            this.updat.TabStop = true;
            this.updat.Text = "Update";
            this.updat.UseVisualStyleBackColor = true;
            this.updat.CheckedChanged += new System.EventHandler(this.upda_CheckedChanged);
            // 
            // delet
            // 
            this.delet.AutoSize = true;
            this.delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet.Location = new System.Drawing.Point(472, 26);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(92, 29);
            this.delet.TabIndex = 26;
            this.delet.TabStop = true;
            this.delet.Text = "Delete";
            this.delet.UseVisualStyleBackColor = true;
            this.delet.CheckedChanged += new System.EventHandler(this.dele_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.updat);
            this.Controls.Add(this.inser);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.labelcin);
            this.Controls.Add(this.labelprenom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.age);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.nom);
            this.Name = "Form1";
            this.Text = "Formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.Label labelcin;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.RadioButton inser;
        private System.Windows.Forms.RadioButton updat;
        private System.Windows.Forms.RadioButton delet;
    }
}

