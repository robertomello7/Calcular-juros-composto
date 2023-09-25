using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}

    private void btnMontante_Click(object sender, EventArgs e)
    {
        double Capital = double.Parse(tbxCapital.Text);
        double Taxa_de_juro = double.Parse(tbxTaxa_de_juros.Text);
        double Tempo = double.Parse(tbxTempo.Text);
        double valor_do_montante = Capital * Math.Pow(1 + (Taxa_de_juro / 100),Tempo);
        lblMontante.Text = valor_do_montante.ToString();

    }

    private void bntCalcular_Click(object sender, EventArgs e)
    {
        double Capital2 = double.Parse(tbxCapital2.Text);   
        double Montante = double.Parse(tbxMontante.Text);
        double Juros = Montante - Capital2;
        lblJuros.Text = Juros.ToString();

    }
}
}
