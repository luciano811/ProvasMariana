namespace eAgenda.WinApp.Moduloquestao
{
    partial class TelaCadastroQuestaoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEnunciadoQuestao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMateriaQuestao = new System.Windows.Forms.ComboBox();
            this.cmbDisciplinaQuestao = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravarQuestao = new System.Windows.Forms.Button();
            this.listAlternativasQuestao = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlternativaQuestao = new System.Windows.Forms.TextBox();
            this.btnInserirAlternativa = new System.Windows.Forms.Button();
            this.btnEhCerta = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(112, 19);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // txtEnunciadoQuestao
            // 
            this.txtEnunciadoQuestao.Location = new System.Drawing.Point(112, 148);
            this.txtEnunciadoQuestao.Name = "txtEnunciadoQuestao";
            this.txtEnunciadoQuestao.Size = new System.Drawing.Size(587, 23);
            this.txtEnunciadoQuestao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enunciado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matéria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Disciplina*:";
            // 
            // cmbMateriaQuestao
            // 
            this.cmbMateriaQuestao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaQuestao.FormattingEnabled = true;
            this.cmbMateriaQuestao.Location = new System.Drawing.Point(112, 105);
            this.cmbMateriaQuestao.Name = "cmbMateriaQuestao";
            this.cmbMateriaQuestao.Size = new System.Drawing.Size(100, 23);
            this.cmbMateriaQuestao.TabIndex = 6;
            // 
            // cmbDisciplinaQuestao
            // 
            this.cmbDisciplinaQuestao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplinaQuestao.FormattingEnabled = true;
            this.cmbDisciplinaQuestao.Location = new System.Drawing.Point(112, 62);
            this.cmbDisciplinaQuestao.Name = "cmbDisciplinaQuestao";
            this.cmbDisciplinaQuestao.Size = new System.Drawing.Size(100, 23);
            this.cmbDisciplinaQuestao.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(624, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravarQuestao
            // 
            this.btnGravarQuestao.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravarQuestao.Location = new System.Drawing.Point(543, 489);
            this.btnGravarQuestao.Name = "btnGravarQuestao";
            this.btnGravarQuestao.Size = new System.Drawing.Size(75, 42);
            this.btnGravarQuestao.TabIndex = 7;
            this.btnGravarQuestao.Text = "Gravar";
            this.btnGravarQuestao.UseVisualStyleBackColor = true;
            this.btnGravarQuestao.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // listAlternativasQuestao
            // 
            this.listAlternativasQuestao.FormattingEnabled = true;
            this.listAlternativasQuestao.ItemHeight = 15;
            this.listAlternativasQuestao.Location = new System.Drawing.Point(12, 246);
            this.listAlternativasQuestao.Name = "listAlternativasQuestao";
            this.listAlternativasQuestao.Size = new System.Drawing.Size(687, 229);
            this.listAlternativasQuestao.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Alternativa:";
            // 
            // txtAlternativaQuestao
            // 
            this.txtAlternativaQuestao.Location = new System.Drawing.Point(112, 191);
            this.txtAlternativaQuestao.Name = "txtAlternativaQuestao";
            this.txtAlternativaQuestao.Size = new System.Drawing.Size(448, 23);
            this.txtAlternativaQuestao.TabIndex = 21;
            // 
            // btnInserirAlternativa
            // 
            this.btnInserirAlternativa.Location = new System.Drawing.Point(566, 191);
            this.btnInserirAlternativa.Name = "btnInserirAlternativa";
            this.btnInserirAlternativa.Size = new System.Drawing.Size(133, 23);
            this.btnInserirAlternativa.TabIndex = 22;
            this.btnInserirAlternativa.Text = "Inserir Alternativa";
            this.btnInserirAlternativa.UseVisualStyleBackColor = true;
            this.btnInserirAlternativa.Click += new System.EventHandler(this.btnInserirAlternativa_Click);
            // 
            // btnEhCerta
            // 
            this.btnEhCerta.AutoSize = true;
            this.btnEhCerta.Location = new System.Drawing.Point(112, 222);
            this.btnEhCerta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEhCerta.Name = "btnEhCerta";
            this.btnEhCerta.Size = new System.Drawing.Size(237, 19);
            this.btnEhCerta.TabIndex = 49;
            this.btnEhCerta.Text = "A alternativa acima é a resposta correta?";
            this.btnEhCerta.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "* A série já está inculsa (quando você atribuiu a matéria)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Você deve escolher disciplina e matéria, ou não haverá gravação.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(212, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 67);
            this.label8.TabIndex = 52;
            this.label8.Text = "}";
            // 
            // TelaCadastroQuestaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEhCerta);
            this.Controls.Add(this.btnInserirAlternativa);
            this.Controls.Add(this.txtAlternativaQuestao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listAlternativasQuestao);
            this.Controls.Add(this.btnGravarQuestao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbDisciplinaQuestao);
            this.Controls.Add(this.cmbMateriaQuestao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnunciadoQuestao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroQuestaoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Questões";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEnunciadoQuestao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMateriaQuestao;
        private System.Windows.Forms.ComboBox cmbDisciplinaQuestao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravarQuestao;
        private System.Windows.Forms.ListBox listAlternativasQuestao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlternativaQuestao;
        private System.Windows.Forms.Button btnInserirAlternativa;
        private System.Windows.Forms.CheckBox btnEhCerta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}