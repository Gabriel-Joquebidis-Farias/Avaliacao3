namespace Avaliacao
{
    partial class frmMovimento
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdEspecial = new System.Windows.Forms.RadioButton();
            this.rdComum = new System.Windows.Forms.RadioButton();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBoxMovimento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.groupBoxMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rdEspecial);
            this.groupBox.Controls.Add(this.rdComum);
            this.groupBox.Controls.Add(this.txtSaldo);
            this.groupBox.Controls.Add(this.txtLimite);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtConta);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(645, 119);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // rdEspecial
            // 
            this.rdEspecial.AutoSize = true;
            this.rdEspecial.Location = new System.Drawing.Point(155, 41);
            this.rdEspecial.Name = "rdEspecial";
            this.rdEspecial.Size = new System.Drawing.Size(102, 19);
            this.rdEspecial.TabIndex = 2;
            this.rdEspecial.TabStop = true;
            this.rdEspecial.Text = "Conta Especial";
            this.rdEspecial.UseVisualStyleBackColor = true;
            // 
            // rdComum
            // 
            this.rdComum.AutoSize = true;
            this.rdComum.Location = new System.Drawing.Point(155, 17);
            this.rdComum.Name = "rdComum";
            this.rdComum.Size = new System.Drawing.Size(104, 19);
            this.rdComum.TabIndex = 2;
            this.rdComum.TabStop = true;
            this.rdComum.Text = "Conta Comum";
            this.rdComum.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(472, 37);
            this.txtSaldo.MaxLength = 10;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(137, 23);
            this.txtSaldo.TabIndex = 1;
            this.txtSaldo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(299, 39);
            this.txtLimite.MaxLength = 10;
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(127, 23);
            this.txtLimite.TabIndex = 1;
            this.txtLimite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtLimite.Leave += new System.EventHandler(this.txtLimite_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(6, 37);
            this.txtConta.MaxLength = 10;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(116, 23);
            this.txtConta.TabIndex = 1;
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            this.txtConta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtConta_MouseDown);
            this.txtConta.MouseLeave += new System.EventHandler(this.txtConta_MouseLeave);
            this.txtConta.MouseHover += new System.EventHandler(this.txtConta_MouseHover);
            this.txtConta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtConta_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Limite";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDepositar.Location = new System.Drawing.Point(12, 148);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(134, 76);
            this.btnDepositar.TabIndex = 1;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Tomato;
            this.btnSacar.Location = new System.Drawing.Point(167, 148);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(134, 76);
            this.btnSacar.TabIndex = 1;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(484, 148);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 76);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "S A I R";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBoxMovimento
            // 
            this.groupBoxMovimento.Controls.Add(this.btnLancar);
            this.groupBoxMovimento.Controls.Add(this.label5);
            this.groupBoxMovimento.Controls.Add(this.label4);
            this.groupBoxMovimento.Controls.Add(this.dtpData);
            this.groupBoxMovimento.Controls.Add(this.txtValor);
            this.groupBoxMovimento.Location = new System.Drawing.Point(18, 230);
            this.groupBoxMovimento.Name = "groupBoxMovimento";
            this.groupBoxMovimento.Size = new System.Drawing.Size(639, 84);
            this.groupBoxMovimento.TabIndex = 3;
            this.groupBoxMovimento.TabStop = false;
            this.groupBoxMovimento.Text = "Movimento";
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(478, 43);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(106, 23);
            this.btnLancar.TabIndex = 2;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(5, 44);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(80, 23);
            this.dtpData.TabIndex = 0;
            this.dtpData.Leave += new System.EventHandler(this.dtpData_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(205, 43);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(127, 23);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.groupBoxMovimento);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimento";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxMovimento.ResumeLayout(false);
            this.groupBoxMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdEspecial;
        private System.Windows.Forms.RadioButton rdComum;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBoxMovimento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtValor;
    }
}