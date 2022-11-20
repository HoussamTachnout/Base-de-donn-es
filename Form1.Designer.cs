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
            this.forinsert = new System.Windows.Forms.TextBox();
            this.forupdate = new System.Windows.Forms.TextBox();
            this.fordelete = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forinsert
            // 
            this.forinsert.Location = new System.Drawing.Point(193, 24);
            this.forinsert.Multiline = true;
            this.forinsert.Name = "forinsert";
            this.forinsert.Size = new System.Drawing.Size(149, 38);
            this.forinsert.TabIndex = 0;
            this.forinsert.TextChanged += new System.EventHandler(this.forinsert_TextChanged);
            // 
            // forupdate
            // 
            this.forupdate.Location = new System.Drawing.Point(193, 84);
            this.forupdate.Multiline = true;
            this.forupdate.Name = "forupdate";
            this.forupdate.Size = new System.Drawing.Size(149, 42);
            this.forupdate.TabIndex = 3;
            this.forupdate.TextChanged += new System.EventHandler(this.forupdate_TextChanged);
            // 
            // fordelete
            // 
            this.fordelete.Location = new System.Drawing.Point(193, 150);
            this.fordelete.Multiline = true;
            this.fordelete.Name = "fordelete";
            this.fordelete.Size = new System.Drawing.Size(149, 39);
            this.fordelete.TabIndex = 4;
            this.fordelete.TextChanged += new System.EventHandler(this.fordelete_TextChanged);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(27, 262);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(73, 48);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(166, 262);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(73, 48);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(304, 262);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(73, 48);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Valid
            // 
            this.Valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Valid.Location = new System.Drawing.Point(462, 262);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(73, 48);
            this.Valid.TabIndex = 8;
            this.Valid.Text = "Valid";
            this.Valid.UseVisualStyleBackColor = false;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cancel.Location = new System.Drawing.Point(588, 262);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 48);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Insert Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Update Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delete Name";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(520, 84);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 33);
            this.age.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.fordelete);
            this.Controls.Add(this.forupdate);
            this.Controls.Add(this.forinsert);
            this.Name = "Form1";
            this.Text = "Formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox forinsert;
        private System.Windows.Forms.TextBox forupdate;
        private System.Windows.Forms.TextBox fordelete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label label4;
    }
}

