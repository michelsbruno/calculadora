namespace Calculadora
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
            txt_resultado = new TextBox();
            btn_zero = new Button();
            btn_quatro = new Button();
            btn_sete = new Button();
            btn_nove = new Button();
            btn_oito = new Button();
            btn_seis = new Button();
            btn_tres = new Button();
            btn_cinco = new Button();
            btn_dois = new Button();
            btn_um = new Button();
            btn_adicao = new Button();
            btn_multiplicacao = new Button();
            btn_divisao = new Button();
            btn_igual = new Button();
            btn_subtracao = new Button();
            btn_limpar = new Button();
            lb_operacao = new Label();
            btn_virgula = new Button();
            txt_operacao = new TextBox();
            SuspendLayout();
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_resultado.Location = new Point(26, 41);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(277, 27);
            txt_resultado.TabIndex = 0;
            txt_resultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_zero
            // 
            btn_zero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_zero.Location = new Point(97, 319);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(65, 65);
            btn_zero.TabIndex = 1;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = true;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn_quatro
            // 
            btn_quatro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_quatro.Location = new Point(26, 177);
            btn_quatro.Name = "btn_quatro";
            btn_quatro.Size = new Size(65, 65);
            btn_quatro.TabIndex = 2;
            btn_quatro.Text = "4";
            btn_quatro.UseVisualStyleBackColor = true;
            btn_quatro.Click += btn_quatro_Click;
            // 
            // btn_sete
            // 
            btn_sete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sete.Location = new Point(26, 107);
            btn_sete.Name = "btn_sete";
            btn_sete.Size = new Size(65, 65);
            btn_sete.TabIndex = 3;
            btn_sete.Text = "7";
            btn_sete.UseVisualStyleBackColor = true;
            btn_sete.Click += btn_sete_Click;
            // 
            // btn_nove
            // 
            btn_nove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_nove.Location = new Point(167, 107);
            btn_nove.Name = "btn_nove";
            btn_nove.Size = new Size(65, 65);
            btn_nove.TabIndex = 4;
            btn_nove.Text = "9";
            btn_nove.UseVisualStyleBackColor = true;
            btn_nove.Click += btn_nove_Click;
            // 
            // btn_oito
            // 
            btn_oito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_oito.Location = new Point(96, 107);
            btn_oito.Name = "btn_oito";
            btn_oito.Size = new Size(65, 65);
            btn_oito.TabIndex = 5;
            btn_oito.Text = "8";
            btn_oito.UseVisualStyleBackColor = true;
            btn_oito.Click += btn_oito_Click;
            // 
            // btn_seis
            // 
            btn_seis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_seis.Location = new Point(167, 177);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(65, 65);
            btn_seis.TabIndex = 6;
            btn_seis.Text = "6";
            btn_seis.UseVisualStyleBackColor = true;
            btn_seis.Click += btn_seis_Click;
            // 
            // btn_tres
            // 
            btn_tres.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tres.Location = new Point(167, 248);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(65, 65);
            btn_tres.TabIndex = 7;
            btn_tres.Text = "3";
            btn_tres.UseVisualStyleBackColor = true;
            btn_tres.Click += btn_tres_Click;
            // 
            // btn_cinco
            // 
            btn_cinco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cinco.Location = new Point(96, 177);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(65, 65);
            btn_cinco.TabIndex = 8;
            btn_cinco.Text = "5";
            btn_cinco.UseVisualStyleBackColor = true;
            btn_cinco.Click += btn_cinco_Click;
            // 
            // btn_dois
            // 
            btn_dois.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dois.Location = new Point(96, 248);
            btn_dois.Name = "btn_dois";
            btn_dois.Size = new Size(65, 65);
            btn_dois.TabIndex = 9;
            btn_dois.Text = "2";
            btn_dois.UseVisualStyleBackColor = true;
            btn_dois.Click += btn_dois_Click;
            // 
            // btn_um
            // 
            btn_um.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_um.Location = new Point(26, 248);
            btn_um.Name = "btn_um";
            btn_um.Size = new Size(65, 65);
            btn_um.TabIndex = 10;
            btn_um.Text = "1";
            btn_um.UseVisualStyleBackColor = true;
            btn_um.Click += btn_um_Click;
            // 
            // btn_adicao
            // 
            btn_adicao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adicao.Location = new Point(238, 248);
            btn_adicao.Name = "btn_adicao";
            btn_adicao.Size = new Size(65, 65);
            btn_adicao.TabIndex = 11;
            btn_adicao.Text = "+";
            btn_adicao.UseVisualStyleBackColor = true;
            btn_adicao.Click += btn_adicao_Click;
            // 
            // btn_multiplicacao
            // 
            btn_multiplicacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_multiplicacao.Location = new Point(238, 177);
            btn_multiplicacao.Name = "btn_multiplicacao";
            btn_multiplicacao.Size = new Size(65, 65);
            btn_multiplicacao.TabIndex = 12;
            btn_multiplicacao.Text = "*";
            btn_multiplicacao.UseVisualStyleBackColor = true;
            btn_multiplicacao.Click += btn_multiplicacao_Click;
            // 
            // btn_divisao
            // 
            btn_divisao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_divisao.Location = new Point(238, 107);
            btn_divisao.Name = "btn_divisao";
            btn_divisao.Size = new Size(65, 65);
            btn_divisao.TabIndex = 13;
            btn_divisao.Text = "/";
            btn_divisao.UseVisualStyleBackColor = true;
            btn_divisao.Click += btn_divisao_Click;
            // 
            // btn_igual
            // 
            btn_igual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_igual.Location = new Point(168, 319);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(65, 65);
            btn_igual.TabIndex = 14;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = true;
            btn_igual.Click += btn_igual_Click;
            // 
            // btn_subtracao
            // 
            btn_subtracao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_subtracao.Location = new Point(238, 319);
            btn_subtracao.Name = "btn_subtracao";
            btn_subtracao.Size = new Size(65, 65);
            btn_subtracao.TabIndex = 16;
            btn_subtracao.Text = "-";
            btn_subtracao.UseVisualStyleBackColor = true;
            btn_subtracao.Click += btn_subtracao_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = SystemColors.ButtonHighlight;
            btn_limpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar.Location = new Point(238, 69);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(65, 29);
            btn_limpar.TabIndex = 17;
            btn_limpar.Text = "C";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // lb_operacao
            // 
            lb_operacao.AutoSize = true;
            lb_operacao.BackColor = SystemColors.ControlLightLight;
            lb_operacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_operacao.Location = new Point(30, 44);
            lb_operacao.Name = "lb_operacao";
            lb_operacao.Size = new Size(0, 20);
            lb_operacao.TabIndex = 18;
            // 
            // btn_virgula
            // 
            btn_virgula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_virgula.Location = new Point(26, 317);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(65, 65);
            btn_virgula.TabIndex = 19;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = true;
            btn_virgula.Click += btn_virgula_Click;
            // 
            // txt_operacao
            // 
            txt_operacao.BackColor = SystemColors.ScrollBar;
            txt_operacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_operacao.Location = new Point(178, 8);
            txt_operacao.Name = "txt_operacao";
            txt_operacao.Size = new Size(125, 27);
            txt_operacao.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(320, 395);
            Controls.Add(txt_operacao);
            Controls.Add(btn_virgula);
            Controls.Add(lb_operacao);
            Controls.Add(btn_limpar);
            Controls.Add(btn_subtracao);
            Controls.Add(btn_igual);
            Controls.Add(btn_divisao);
            Controls.Add(btn_multiplicacao);
            Controls.Add(btn_adicao);
            Controls.Add(btn_um);
            Controls.Add(btn_dois);
            Controls.Add(btn_cinco);
            Controls.Add(btn_tres);
            Controls.Add(btn_seis);
            Controls.Add(btn_oito);
            Controls.Add(btn_nove);
            Controls.Add(btn_sete);
            Controls.Add(btn_quatro);
            Controls.Add(btn_zero);
            Controls.Add(txt_resultado);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_resultado;
        private Button btn_zero;
        private Button btn_quatro;
        private Button btn_sete;
        private Button btn_nove;
        private Button btn_oito;
        private Button btn_seis;
        private Button btn_tres;
        private Button btn_cinco;
        private Button btn_dois;
        private Button btn_um;
        private Button btn_adicao;
        private Button btn_multiplicacao;
        private Button btn_divisao;
        private Button btn_igual;

        private Button btn_subtracao;
        private Button btn_limpar;
        private Label lb_operacao;
        private Button btn_virgula;
        private TextBox txt_operacao;
    }
}