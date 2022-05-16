namespace ProvasMariana.WinApp.ModuloProva
{
    partial class TelaCadastroProvasForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnGravarQuestao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listAlternativasQuestaoProva = new System.Windows.Forms.ListBox();
            this.cmbDisciplinaQuestaoProva = new System.Windows.Forms.ComboBox();
            this.cmbMateriaQuestaoProva = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGravarProva = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.txtQuantidadeQuestoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "Você deve escolher disciplina e matéria, ou não haverá gravação.";
            // 
            // btnGravarQuestao
            // 
            this.btnGravarQuestao.Location = new System.Drawing.Point(619, 194);
            this.btnGravarQuestao.Name = "btnGravarQuestao";
            this.btnGravarQuestao.Size = new System.Drawing.Size(133, 23);
            this.btnGravarQuestao.TabIndex = 64;
            this.btnGravarQuestao.Text = "Gravar Questoes";
            this.btnGravarQuestao.UseVisualStyleBackColor = true;
            this.btnGravarQuestao.Click += new System.EventHandler(this.btnGravarQuestao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Data";
            // 
            // listAlternativasQuestaoProva
            // 
            this.listAlternativasQuestaoProva.FormattingEnabled = true;
            this.listAlternativasQuestaoProva.ItemHeight = 15;
            this.listAlternativasQuestaoProva.Location = new System.Drawing.Point(123, 249);
            this.listAlternativasQuestaoProva.Name = "listAlternativasQuestaoProva";
            this.listAlternativasQuestaoProva.Size = new System.Drawing.Size(629, 229);
            this.listAlternativasQuestaoProva.TabIndex = 61;
            // 
            // cmbDisciplinaQuestaoProva
            // 
            this.cmbDisciplinaQuestaoProva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplinaQuestaoProva.FormattingEnabled = true;
            this.cmbDisciplinaQuestaoProva.Location = new System.Drawing.Point(165, 65);
            this.cmbDisciplinaQuestaoProva.Name = "cmbDisciplinaQuestaoProva";
            this.cmbDisciplinaQuestaoProva.Size = new System.Drawing.Size(100, 23);
            this.cmbDisciplinaQuestaoProva.TabIndex = 58;
            // 
            // cmbMateriaQuestaoProva
            // 
            this.cmbMateriaQuestaoProva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaQuestaoProva.FormattingEnabled = true;
            this.cmbMateriaQuestaoProva.Location = new System.Drawing.Point(165, 108);
            this.cmbMateriaQuestaoProva.Name = "cmbMateriaQuestaoProva";
            this.cmbMateriaQuestaoProva.Size = new System.Drawing.Size(100, 23);
            this.cmbMateriaQuestaoProva.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Disciplina*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Matéria:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(165, 151);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(587, 23);
            this.txtConteudo.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Conteudo";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(165, 22);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Número:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(265, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 67);
            this.label8.TabIndex = 67;
            this.label8.Text = "}";
            // 
            // btnGravarProva
            // 
            this.btnGravarProva.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravarProva.Location = new System.Drawing.Point(604, 538);
            this.btnGravarProva.Name = "btnGravarProva";
            this.btnGravarProva.Size = new System.Drawing.Size(75, 42);
            this.btnGravarProva.TabIndex = 68;
            this.btnGravarProva.Text = "Gravar";
            this.btnGravarProva.UseVisualStyleBackColor = true;
            this.btnGravarProva.Click += new System.EventHandler(this.btnGravarProva_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(685, 538);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 42);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dateData
            // 
            this.dateData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateData.Location = new System.Drawing.Point(165, 194);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(96, 23);
            this.dateData.TabIndex = 70;
            // 
            // txtQuantidadeQuestoes
            // 
            this.txtQuantidadeQuestoes.Location = new System.Drawing.Point(379, 197);
            this.txtQuantidadeQuestoes.Name = "txtQuantidadeQuestoes";
            this.txtQuantidadeQuestoes.Size = new System.Drawing.Size(217, 23);
            this.txtQuantidadeQuestoes.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "Qtd Questoes";
            // 
            // TelaCadastroProvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 593);
            this.Controls.Add(this.txtQuantidadeQuestoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateData);
            this.Controls.Add(this.btnGravarProva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGravarQuestao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listAlternativasQuestaoProva);
            this.Controls.Add(this.cmbDisciplinaQuestaoProva);
            this.Controls.Add(this.cmbMateriaQuestaoProva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "TelaCadastroProvasForm";
            this.Text = "TelaCadastroProvasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGravarQuestao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listAlternativasQuestaoProva;
        private System.Windows.Forms.ComboBox cmbDisciplinaQuestaoProva;
        private System.Windows.Forms.ComboBox cmbMateriaQuestaoProva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGravarProva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.TextBox txtQuantidadeQuestoes;
        private System.Windows.Forms.Label label6;
    }
}