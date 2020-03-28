namespace Radix
{
    partial class overlay
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(overlay));
            this.button1 = new System.Windows.Forms.Button();
            this.password_1 = new System.Windows.Forms.TextBox();
            this.password_2 = new System.Windows.Forms.TextBox();
            this.encrypt_radio = new System.Windows.Forms.RadioButton();
            this.decrypt_radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(16, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_1
            // 
            this.password_1.BackColor = System.Drawing.SystemColors.WindowText;
            this.password_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_1.Location = new System.Drawing.Point(16, 29);
            this.password_1.Name = "password_1";
            this.password_1.Size = new System.Drawing.Size(91, 20);
            this.password_1.TabIndex = 1;
            this.password_1.UseSystemPasswordChar = true;
            // 
            // password_2
            // 
            this.password_2.BackColor = System.Drawing.SystemColors.WindowText;
            this.password_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_2.Location = new System.Drawing.Point(16, 68);
            this.password_2.Name = "password_2";
            this.password_2.Size = new System.Drawing.Size(91, 20);
            this.password_2.TabIndex = 2;
            this.password_2.UseSystemPasswordChar = true;
            // 
            // encrypt_radio
            // 
            this.encrypt_radio.AutoSize = true;
            this.encrypt_radio.Location = new System.Drawing.Point(16, 94);
            this.encrypt_radio.Name = "encrypt_radio";
            this.encrypt_radio.Size = new System.Drawing.Size(61, 17);
            this.encrypt_radio.TabIndex = 3;
            this.encrypt_radio.TabStop = true;
            this.encrypt_radio.Text = "Encrypt";
            this.encrypt_radio.UseVisualStyleBackColor = true;
            this.encrypt_radio.CheckedChanged += new System.EventHandler(this.encrypt_radio_CheckedChanged);
            // 
            // decrypt_radio
            // 
            this.decrypt_radio.AutoSize = true;
            this.decrypt_radio.Location = new System.Drawing.Point(16, 113);
            this.decrypt_radio.Name = "decrypt_radio";
            this.decrypt_radio.Size = new System.Drawing.Size(62, 17);
            this.decrypt_radio.TabIndex = 4;
            this.decrypt_radio.TabStop = true;
            this.decrypt_radio.Text = "Decrypt";
            this.decrypt_radio.UseVisualStyleBackColor = true;
            this.decrypt_radio.CheckedChanged += new System.EventHandler(this.decrypt_radio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Repeat Password:";
            // 
            // overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(124, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decrypt_radio);
            this.Controls.Add(this.encrypt_radio);
            this.Controls.Add(this.password_2);
            this.Controls.Add(this.password_1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "overlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password_1;
        private System.Windows.Forms.TextBox password_2;
        private System.Windows.Forms.RadioButton encrypt_radio;
        private System.Windows.Forms.RadioButton decrypt_radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

