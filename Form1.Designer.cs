
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImportarDados = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.cnpj_cpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.razao_social = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fantasia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnImportarDados
            // 
            this.btnImportarDados.Location = new System.Drawing.Point(689, 23);
            this.btnImportarDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImportarDados.Name = "btnImportarDados";
            this.btnImportarDados.Size = new System.Drawing.Size(142, 38);
            this.btnImportarDados.TabIndex = 0;
            this.btnImportarDados.Text = "Importar Dados";
            this.btnImportarDados.UseVisualStyleBackColor = true;
            this.btnImportarDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 14);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(23, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(656, 570);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // cnpj_cpf
            // 
            this.cnpj_cpf.Location = new System.Drawing.Point(786, 83);
            this.cnpj_cpf.Name = "cnpj_cpf";
            this.cnpj_cpf.Size = new System.Drawing.Size(233, 23);
            this.cnpj_cpf.TabIndex = 3;
            this.cnpj_cpf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "CNPJ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razão Social:";
            // 
            // razao_social
            // 
            this.razao_social.Location = new System.Drawing.Point(786, 112);
            this.razao_social.Name = "razao_social";
            this.razao_social.Size = new System.Drawing.Size(233, 23);
            this.razao_social.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fantasia:";
            // 
            // fantasia
            // 
            this.fantasia.Location = new System.Drawing.Point(786, 141);
            this.fantasia.Name = "fantasia";
            this.fantasia.Size = new System.Drawing.Size(233, 23);
            this.fantasia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Endereço:";
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(786, 170);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(233, 23);
            this.endereco.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bairro:";
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(786, 199);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(233, 23);
            this.bairro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cidade:";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(786, 228);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(233, 23);
            this.cidade.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "UF";
            // 
            // uf
            // 
            this.uf.Location = new System.Drawing.Point(786, 257);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(233, 23);
            this.uf.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cep:";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(786, 286);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(233, 23);
            this.cep.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(691, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fone:";
            // 
            // fone
            // 
            this.fone.Location = new System.Drawing.Point(786, 315);
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(233, 23);
            this.fone.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(691, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(786, 344);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(233, 23);
            this.email.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 603);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fantasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.razao_social);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnpj_cpf);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnImportarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar CNPJ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_CnpjCpfReceita_FormClosing);
            this.Load += new System.EventHandler(this.FRM_CnpjCpfReceita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportarDados;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox cnpj_cpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox razao_social;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fantasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email;
    }
}

