namespace PIM_V
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.BtnEnt = new System.Windows.Forms.Button();
            this.LblLog = new System.Windows.Forms.Label();
            this.LblSen = new System.Windows.Forms.Label();
            this.BtnCad = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnt
            // 
            this.BtnEnt.Location = new System.Drawing.Point(423, 222);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(75, 23);
            this.BtnEnt.TabIndex = 0;
            this.BtnEnt.Text = "Entrar";
            this.BtnEnt.UseVisualStyleBackColor = true;
            this.BtnEnt.Click += new System.EventHandler(this.BtnEnt_Click);
            // 
            // LblLog
            // 
            this.LblLog.AutoSize = true;
            this.LblLog.Location = new System.Drawing.Point(307, 129);
            this.LblLog.Name = "LblLog";
            this.LblLog.Size = new System.Drawing.Size(33, 13);
            this.LblLog.TabIndex = 1;
            this.LblLog.Text = "Login";
            // 
            // LblSen
            // 
            this.LblSen.AutoSize = true;
            this.LblSen.Location = new System.Drawing.Point(307, 169);
            this.LblSen.Name = "LblSen";
            this.LblSen.Size = new System.Drawing.Size(38, 13);
            this.LblSen.TabIndex = 2;
            this.LblSen.Text = "Senha";
            // 
            // BtnCad
            // 
            this.BtnCad.Location = new System.Drawing.Point(314, 222);
            this.BtnCad.Name = "BtnCad";
            this.BtnCad.Size = new System.Drawing.Size(75, 23);
            this.BtnCad.TabIndex = 3;
            this.BtnCad.Text = "Cadastre-se";
            this.BtnCad.UseVisualStyleBackColor = true;
            this.BtnCad.Click += new System.EventHandler(this.BtnCad_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(358, 126);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(149, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(358, 166);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(149, 20);
            this.TxtSenha.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.BtnCad);
            this.Controls.Add(this.LblSen);
            this.Controls.Add(this.LblLog);
            this.Controls.Add(this.BtnEnt);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnt;
        private System.Windows.Forms.Label LblLog;
        private System.Windows.Forms.Label LblSen;
        private System.Windows.Forms.Button BtnCad;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}