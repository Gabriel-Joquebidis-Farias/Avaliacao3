using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao
{
    public partial class frmMovimento : Form
    {
        static List<contaBancaria> _listConta = new List<contaBancaria>();
        private contaBancaria _contaAtual = null;
        private int operacao = 0;
        private String teclado = "";
        private Boolean verificar = false;
        private Boolean contaValida = false;

        public frmMovimento()
        {
            InitializeComponent();
            this.Size = new Size(685, 265);
            _listConta = contaBancaria.geraContas();
            txtLimite.Enabled = false;
            txtSaldo.Enabled = false;
            rdComum.Enabled = false;
            rdEspecial.Enabled = false;
            btnSair.Focus();
        }

        private void carregaCompos()
        {
            txtLimite.Text = Convert.ToString(_contaAtual.Limite);
            txtSaldo.Text = Convert.ToString(_contaAtual.Saldo);
            contaValida = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            teclado = txtConta.Text.ToString();

           

        }

        private void txtConta_MouseLeave(object sender, EventArgs e)
        {
            


        }

        private void txtConta_MouseHover(object sender, EventArgs e)
        {          
            
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            foreach (contaBancaria c in _listConta)
            {
                if (c.CodigoConta == teclado)
                {
                    if (c.Tipo == 0)
                    {
                        rdComum.Checked = true;
                        txtLimite.Text = c.Limite.ToString();
                        txtSaldo.Text = c.Saldo.ToString();
                        contaValida = true;
                        _contaAtual = c;
                    }
                    else
                    {
                        rdEspecial.Checked = true;
                        txtLimite.Text = c.Limite.ToString();
                        txtSaldo.Text = c.Saldo.ToString();
                        contaValida = true;
                        _contaAtual = c;
                    }
                }

            }
            
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (contaValida == true)
            {

                this.Size = new Size(685, 365);
                operacao = 1;
                groupBox.Enabled = false;
                btnDepositar.Enabled = false;
                btnSacar.Enabled = false;
                btnSair.Enabled = false;
            }
            else
            {
                MessageBox.Show("Conta Invalida", "Aviso Do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConta.Focus();
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (contaValida == true)
            {
                this.Size = new Size(685, 365);
                operacao = 2;
                groupBox.Enabled = false;
                btnDepositar.Enabled = false;
                btnSacar.Enabled = false;
                btnSair.Enabled = false;
            }
            else
            {
                MessageBox.Show("Conta Invalida", "Aviso Do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConta.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Deseja sair?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dtpData_Leave(object sender, EventArgs e)
        {
            if( (dtpData.Value.DayOfWeek == DayOfWeek.Sunday) ||
                (dtpData.Value.DayOfWeek == DayOfWeek.Saturday))
            {
                MessageBox.Show("Data Inválida!","Aviso Do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dtpData.Focus();
            }

        }

        private void txtLimite_Leave(object sender, EventArgs e)
        {
             
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            if (valor < 1)
            {
                MessageBox.Show("Valor invalido", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
            }
            

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(operacao == 1)
            {
                double v = Convert.ToDouble(txtValor.Text);
                double s = Convert.ToDouble(txtSaldo.Text);
                _contaAtual.Saldo = v + s;
                this.Size = new Size(685, 265);
                groupBox.Enabled = true;
                txtConta.Enabled = true;
                btnDepositar.Enabled = true;
                btnSacar.Enabled = true;
                btnSair.Enabled = true;
                carregaCompos();
            }
            if (operacao == 2)
            {
               double saque = _contaAtual.Saldo + _contaAtual.Limite;
                double va = Convert.ToDouble(txtValor.Text);
                if (va > saque)
                {
                    MessageBox.Show("Valor invalido", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor.Focus();
                }
                else
                {
                    _contaAtual.Saldo = _contaAtual.Saldo - va;
                    this.Size = new Size(685, 265);
                    groupBox.Enabled = true;
                    txtConta.Enabled = true;
                    btnDepositar.Enabled = true;
                    btnSacar.Enabled = true;
                    btnSair.Enabled = true;
                    carregaCompos();
                }
            }
            
        }

        private void txtConta_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void txtConta_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
    }

