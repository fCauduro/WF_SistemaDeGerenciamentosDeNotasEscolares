﻿//using MySql.Data.MySqlClient;
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
    partial class login
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
            label1 = new Label();
            usuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            senha = new TextBox();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(663, 29);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gerenciamento de Notas Escolares - login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // usuario
            // 
            usuario.Location = new Point(152, 95);
            usuario.Name = "usuario";
            usuario.Size = new Size(100, 23);
            usuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 97);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 154);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // senha
            // 
            senha.Location = new Point(152, 152);
            senha.Name = "senha";
            senha.PasswordChar = '#';
            senha.Size = new Size(100, 23);
            senha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(152, 215);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 37);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.senac_logo;
            pictureBox1.Location = new Point(318, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Controls.Add(label3);
            Controls.Add(senha);
            Controls.Add(label2);
            Controls.Add(usuario);
            Controls.Add(label1);
            Name = "login";
            Text = "Sistema de Gerenciamento de Notas Escolares";
            Load += login_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usuario;
        private Label label2;
        private Label label3;
        private TextBox senha;
        private Button btnEntrar;
        private PictureBox pictureBox1;
    }
}
