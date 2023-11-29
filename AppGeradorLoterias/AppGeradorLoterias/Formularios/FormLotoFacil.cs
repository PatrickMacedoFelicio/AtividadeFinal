using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGeradorLoterias.RegrasNegocios;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.ExtendedProperties;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotoFacil : Form
    {
        List<NumerosDaSorte> numGerados = new List<NumerosDaSorte>();
        public FormLotoFacil()
        {
            InitializeComponent();
        }

        private void AnalisarJogo(int par, int impar)
        {
            if (impar == 8)
            {
                lbClass.Text = "Excelente Jogo!";
                lbClass.ForeColor = Color.Green;
            }
            if (impar == 7) { lbClass.Text = "Ótimo Jogo!"; lbClass.ForeColor = Color.Green; }
            if (impar == 9) { lbClass.Text = "Bom Jogo!"; lbClass.ForeColor = Color.Orange; }
            if (impar == 6) { lbClass.Text = "Jogo Regular!"; lbClass.ForeColor = Color.OrangeRed; }
            if (impar == 5) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
            if (impar == 10) { lbClass.Text = "Jogo Ruim!"; lbClass.ForeColor = Color.Red; }
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            int contador = 0, qtdPar = 0, qtdImpar = 0, temporario = 0;
            Random randomico = new Random(); //gerar numeros aleatorios

            while (contador < 15)
            {
                temporario = randomico.Next(1, 26);

                if (numGerados.Where(n => n.Numero == temporario).Count() == 0)
                {
                    NumerosDaSorte numeroSorteado = new NumerosDaSorte();
                    numeroSorteado.Numero = temporario;
                    numGerados.Add(numeroSorteado);
                    if (temporario % 2 == 0) qtdPar++;
                    if (temporario % 2 == 1) qtdImpar++;
                    contador++;
                }
                dgvNumeros.DataSource = numGerados.OrderBy(ns => ns.Numero).ToList();
                btGerar.Enabled = false;
                lbPar.Text = "Números Pares: " + qtdPar;
                lbImpar.Text = "Números Ímpares: " + qtdImpar;
                AnalisarJogo(qtdPar, qtdImpar);
            }
        }

        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            numGerados.Clear();
            dgvNumeros.DataSource = numGerados.ToList();
            btGerar.Enabled = true;
            lbPar.Text = "PARES";
            lbImpar.Text = "IMPARES";
            lbClass.Text = "CLASSIFIÇÃO";
        }

        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook(@"C:\Users\patri\Excel\loteria.xlsx");

            var planilha = pasta.Worksheet(1);

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

            pasta.Save();
        }
    }
}

