namespace PIM_V
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNom = new System.Windows.Forms.Label();
            this.LblSenh = new System.Windows.Forms.Label();
            this.LblCar = new System.Windows.Forms.Label();
            this.BtnSal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CbbBar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(259, 140);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(35, 13);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nome";
            // 
            // LblSenh
            // 
            this.LblSenh.AutoSize = true;
            this.LblSenh.Location = new System.Drawing.Point(259, 176);
            this.LblSenh.Name = "LblSenh";
            this.LblSenh.Size = new System.Drawing.Size(38, 13);
            this.LblSenh.TabIndex = 1;
            this.LblSenh.Text = "Senha";
            // 
            // LblCar
            // 
            this.LblCar.AutoSize = true;
            this.LblCar.Location = new System.Drawing.Point(259, 220);
            this.LblCar.Name = "LblCar";
            this.LblCar.Size = new System.Drawing.Size(35, 13);
            this.LblCar.TabIndex = 2;
            this.LblCar.Text = "Cargo";
            // 
            // BtnSal
            // 
            this.BtnSal.Location = new System.Drawing.Point(333, 274);
            this.BtnSal.Name = "BtnSal";
            this.BtnSal.Size = new System.Drawing.Size(75, 23);
            this.BtnSal.TabIndex = 3;
            this.BtnSal.Text = "Salvar";
            this.BtnSal.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 5;
            // 
            // CbbBar
            // 
            this.CbbBar.FormattingEnabled = true;
            this.CbbBar.Items.AddRange(new object[] {
            "",
            "Diretor",
            "Professor",
            "Coordenador",
            "Administrativo"});
            this.CbbBar.Location = new System.Drawing.Point(351, 220);
            this.CbbBar.Name = "CbbBar";
            this.CbbBar.Size = new System.Drawing.Size(151, 21);
            this.CbbBar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbbBar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSal);
            this.Controls.Add(this.LblCar);
            this.Controls.Add(this.LblSenh);
            this.Controls.Add(this.LblNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblSenh;
        private System.Windows.Forms.Label LblCar;
        private System.Windows.Forms.Button BtnSal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox CbbBar;
    }
}

