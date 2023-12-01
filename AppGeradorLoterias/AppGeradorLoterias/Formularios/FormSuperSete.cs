using AppGeradorLoterias.RegrasNegocios;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormSuperSete : Form
    {
        List<NumerosDaSorte> numGerados = new List<NumerosDaSorte>();
        public FormSuperSete()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void analiseBotao(string[] col)
        {
            int count = 0;
            string[] teste = new string[7];

            foreach (RadioButton rb in gb1.Controls)
            {
                if (rb.Checked)
                    teste[0] = rb.Text;
            }
            
            foreach (RadioButton rb in gb2.Controls)
            {
                if (rb.Checked)
                    teste[1] = rb.Text;
            }

            foreach (RadioButton rb in gb3.Controls)
            {
                if (rb.Checked)
                    teste[2] = rb.Text;
            }

            foreach (RadioButton rb in gb4.Controls)
            {
                if (rb.Checked)
                    teste[3] = rb.Text;
            }

            foreach (RadioButton rb in gb5.Controls)
            {
                if (rb.Checked)
                    teste[4] = rb.Text;
            }

            foreach (RadioButton rb in gb6.Controls)
            {
                if (rb.Checked)
                    teste[5] = rb.Text;
            }

            foreach (RadioButton rb in gb7.Controls)
            {
                if (rb.Checked) 
                    teste[6] = rb.Text;
            }


            for (int i = 0; i < col.Length; i++)
            {
                if (col[i] == teste[i])
                {
                    count++;
                }                
            }

            switch (count)
            {
                case 1:
                    lbAcertos.Text = "ACERTOS: 1";
                    break;
                case 2:
                    lbAcertos.Text = "ACERTOS: 2";
                    break;
                case 3:
                    lbAcertos.Text = "ACERTOS: 3";
                    break;
                case 4:
                    lbAcertos.Text = "ACERTOS: 4";
                    break;

                case 5:
                    lbAcertos.Text = "ACERTOS: 5";
                    break;

                case 6:
                    lbAcertos.Text = "ACERTOS: 6";
                    break;

                case 7:
                    lbAcertos.Text = "ACERTOS: 7";
                    break;

                default:
                    lbAcertos.Text = "ACERTOS: 0";
                    break;
                
            }
        }

        private void AnalisarJogo(int par, int impar)
        {
            if (impar == 4)
            {
                lbClass.Text = "Excelente Jogo!";
                lbClass.ForeColor = Color.Green;
            }
            if (impar == 3) { lbClass.Text = "Ótimo Jogo!"; lbClass.ForeColor = Color.Green; }
            if (impar == 5) { lbClass.Text = "Bom Jogo!"; lbClass.ForeColor = Color.Orange; }
            if (impar == 2) { lbClass.Text = "Jogo Regular!"; lbClass.ForeColor = Color.OrangeRed; }
            if (impar == 6) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
            if (impar == 1) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
            if (impar == 7) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
            if (impar == 0) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            int contador = 0, qtdPar = 0, qtdImpar = 0, temporario = 0;
            string[] numCol = new string[7];
            Random randomico = new Random(); //gerar numeros aleatorios

            while (contador < 7)
            {
                temporario = randomico.Next(0, 10);

                NumerosDaSorte numeroSorteado = new NumerosDaSorte();
                numeroSorteado.Numero = temporario;
                numGerados.Add(numeroSorteado);
                if (temporario % 2 == 0) qtdPar++;
                if (temporario % 2 == 1) qtdImpar++;

                numCol[contador] = Convert.ToString(temporario);

                contador++;
            }
            dgvNumeros.DataSource = numGerados.ToList();
            btGerar.Enabled = false;
            lbPar.Text = "Números Pares: " + qtdPar;
            lbImpar.Text = "Números Ímpares: " + qtdImpar;
            analiseBotao(numCol);
            AnalisarJogo(qtdPar, qtdImpar);

        }
    

        private void btLimpar_Click(object sender, EventArgs e)
        {
            numGerados.Clear();
            dgvNumeros.DataSource = numGerados.ToList();
            btGerar.Enabled = true;
            lbPar.Text = "PARES";
            lbImpar.Text = "IMPARES";
            lbClass.Text = "CLASSIFIÇÃO";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook(@"C:\Users\patri\Excel\loteria.xlsx");

            var planilha = pasta.Worksheet(4);

            int qtdColunas = planilha.ColumnsUsed().Count();

            int qtdLinhas = planilha.RowsUsed().Count();

            int colunregistro = qtdColunas + 1;

            int linhas = qtdLinhas + 1;

            colunregistro = 1;

            foreach (var i in numGerados.OrderBy(ns => ns.Numero).ToList())
            {
                planilha.Cell(linhas, colunregistro).Value = i.Numero;
                colunregistro++;
            }
            planilha.Cell(linhas, colunregistro).Value = lbPar.Text.Substring(15);
            colunregistro++;
            planilha.Cell(linhas, colunregistro).Value = lbImpar.Text.Substring(17);
            colunregistro++;
            planilha.Cell(linhas, colunregistro).Value = lbClass.Text;
            colunregistro++;
            planilha.Cell(linhas, colunregistro).Value = lbAcertos.Text;

            pasta.Save();

            MessageBox.Show("Os dados foram salvos no Excel", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }    
}
