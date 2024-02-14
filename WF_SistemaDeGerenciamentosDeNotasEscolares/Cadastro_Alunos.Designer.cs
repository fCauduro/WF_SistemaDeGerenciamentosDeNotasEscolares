
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WF_SistemaDeGerenciamentosDeNotasEscolares
{
    partial class CadAlu
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
            label1 = new Label();
            Nome = new Label();
            txtnome = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            CPF = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, -2);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Alunos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(17, 59);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 1;
            Nome.Text = "Nome:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(101, 56);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(468, 23);
            txtnome.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(633, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 238);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereço:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 202);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 23);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 168);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefone:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(101, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 23);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 134);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "Matricula:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 95);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(259, 23);
            textBox5.TabIndex = 12;
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Location = new Point(17, 98);
            CPF.Name = "CPF";
            CPF.Size = new Size(31, 15);
            CPF.TabIndex = 11;
            CPF.Text = "CPF:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(101, 277);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(259, 23);
            textBox6.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 280);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 17;
            label6.Text = "Nascimento:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(101, 311);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(354, 23);
            textBox7.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 314);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 15;
            label7.Text = "usuario:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(101, 347);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(633, 23);
            textBox8.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 350);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 13;
            label8.Text = "senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(189, 376);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(142, 37);
            btnEntrar.TabIndex = 19;
            btnEntrar.Text = "Cadastrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // CadAlu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(CPF);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtnome);
            Controls.Add(Nome);
            Controls.Add(label1);
            Name = "CadAlu";
            Text = "Cadastro de Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Nome;
        private TextBox txtnome;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label CPF;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private Button btnEntrar;
    }
}