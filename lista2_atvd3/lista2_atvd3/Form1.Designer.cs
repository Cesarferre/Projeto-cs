namespace lista2_atvd3
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
            lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnumero = new TextBox();
            txttitular = new TextBox();
            txtvalor = new TextBox();
            lstresultado = new ListBox();
            btncalcular = new Button();
            cmbmovimentacao = new ComboBox();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(38, 41);
            lbl.Name = "lbl";
            lbl.Size = new Size(175, 24);
            lbl.TabIndex = 0;
            lbl.Text = "Número da conta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 82);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 1;
            label1.Text = "Titular:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 120);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 2;
            label2.Text = "Movimentação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 157);
            label3.Name = "label3";
            label3.Size = new Size(209, 24);
            label3.TabIndex = 3;
            label3.Text = "Valor de tranferencia:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(219, 42);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(100, 23);
            txtnumero.TabIndex = 4;
            // 
            // txttitular
            // 
            txttitular.Location = new Point(116, 83);
            txttitular.Name = "txttitular";
            txttitular.Size = new Size(100, 23);
            txttitular.TabIndex = 5;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(253, 158);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(100, 23);
            txtvalor.TabIndex = 7;
            // 
            // lstresultado
            // 
            lstresultado.FormattingEnabled = true;
            lstresultado.ItemHeight = 15;
            lstresultado.Location = new Point(409, 41);
            lstresultado.Name = "lstresultado";
            lstresultado.Size = new Size(193, 184);
            lstresultado.TabIndex = 8;
            // 
            // btncalcular
            // 
            btncalcular.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcular.Location = new Point(116, 197);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(131, 32);
            btncalcular.TabIndex = 9;
            btncalcular.Text = "Calcular Saldo";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += button1_Click;
            // 
            // cmbmovimentacao
            // 
            cmbmovimentacao.FormattingEnabled = true;
            cmbmovimentacao.Items.AddRange(new object[] { "Deposito", "Saque" });
            cmbmovimentacao.Location = new Point(197, 120);
            cmbmovimentacao.Name = "cmbmovimentacao";
            cmbmovimentacao.Size = new Size(121, 23);
            cmbmovimentacao.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(648, 251);
            Controls.Add(cmbmovimentacao);
            Controls.Add(btncalcular);
            Controls.Add(lstresultado);
            Controls.Add(txtvalor);
            Controls.Add(txttitular);
            Controls.Add(txtnumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtnumero;
        private TextBox txttitular;
        private TextBox txtvalor;
        private ListBox lstresultado;
        private Button btncalcular;
        private ComboBox cmbmovimentacao;
    }
}