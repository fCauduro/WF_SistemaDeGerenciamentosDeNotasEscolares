namespace WF_SistemaDeGerenciamentosDeNotasEscolares
{
    partial class Gerenciamento_Notas
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Aluno Semestre 1 Nota 1 Nota 2 Nota 3 nota 4 Semestre 2 Nota 1 Nota 2 Nota 3 nota 4" });
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(720, 259);
            listBox1.TabIndex = 0;
            // 
            // Gerenciamento_Notas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Name = "Gerenciamento_Notas";
            Text = "Gerenciamento_Notas";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}