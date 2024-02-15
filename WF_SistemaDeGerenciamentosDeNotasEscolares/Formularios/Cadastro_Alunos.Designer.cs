
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
            lblCadastroAlunos = new Label();
            Nome = new Label();
            txtnome = new TextBox();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtTelefone = new TextBox();
            label4 = new Label();
            txtMatricula = new TextBox();
            label5 = new Label();
            txtCPF = new TextBox();
            CPF = new Label();
            txtNascimento = new TextBox();
            label6 = new Label();
            txtUsuario = new TextBox();
            label7 = new Label();
            txtSenha = new TextBox();
            label8 = new Label();
            btnEntrar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblCadastroAlunos
            // 
            lblCadastroAlunos.AutoSize = true;
            lblCadastroAlunos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCadastroAlunos.Location = new Point(189, -2);
            lblCadastroAlunos.Name = "lblCadastroAlunos";
            lblCadastroAlunos.Size = new Size(266, 37);
            lblCadastroAlunos.TabIndex = 0;
            lblCadastroAlunos.Text = "Cadastro de Alunos";
            lblCadastroAlunos.TextAlign = ContentAlignment.TopCenter;
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
            // txtEndereco
            // 
            txtEndereco.Location = new Point(101, 235);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(633, 23);
            txtEndereco.TabIndex = 4;
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
            // txtEmail
            // 
            txtEmail.Location = new Point(101, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(354, 23);
            txtEmail.TabIndex = 6;
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
            // txtTelefone
            // 
            txtTelefone.Location = new Point(101, 165);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(259, 23);
            txtTelefone.TabIndex = 8;
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
            // txtMatricula
            // 
            txtMatricula.Location = new Point(101, 131);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(259, 23);
            txtMatricula.TabIndex = 10;
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
            // txtCPF
            // 
            txtCPF.Location = new Point(101, 95);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(259, 23);
            txtCPF.TabIndex = 12;
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
            // txtNascimento
            // 
            txtNascimento.Location = new Point(101, 277);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(259, 23);
            txtNascimento.TabIndex = 18;
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
            // txtUsuario
            // 
            txtUsuario.Location = new Point(101, 311);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(354, 23);
            txtUsuario.TabIndex = 16;
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
            // txtSenha
            // 
            txtSenha.Location = new Point(101, 347);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(633, 23);
            txtSenha.TabIndex = 14;
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
            btnEntrar.Location = new Point(144, 390);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(142, 37);
            btnEntrar.TabIndex = 19;
            btnEntrar.Text = "Cadastrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(337, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 37);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(513, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 37);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadAlu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnEntrar);
            Controls.Add(txtNascimento);
            Controls.Add(label6);
            Controls.Add(txtUsuario);
            Controls.Add(label7);
            Controls.Add(txtSenha);
            Controls.Add(label8);
            Controls.Add(txtCPF);
            Controls.Add(CPF);
            Controls.Add(txtMatricula);
            Controls.Add(label5);
            Controls.Add(txtTelefone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtEndereco);
            Controls.Add(label2);
            Controls.Add(txtnome);
            Controls.Add(Nome);
            Controls.Add(lblCadastroAlunos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadAlu";
            Text = "Cadastro de Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroAlunos;
        private Label Nome;
        private TextBox txtnome;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtTelefone;
        private Label label4;
        private TextBox txtMatricula;
        private Label label5;
        private TextBox txtCPF;
        private Label CPF;
        private TextBox txtNascimento;
        private Label label6;
        private TextBox txtUsuario;
        private Label label7;
        private TextBox txtSenha;
        private Label label8;
        private Button btnEntrar;
        private Button btnEditar;
        private Button btnCancelar;
    }
}