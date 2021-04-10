using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Pratico
{
    public partial class Form1 : Form
    {
        int v = 0; // numero de variaveis
        int r = 0; // numero de restricoes
        double Dmenor;
        int linhaPivo = 0, colPivo = 0;
        bool teste = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void encontrarLinhaPivoMin()
        {
            linhaPivo = 0;
            Dmenor = double.MaxValue;
            double num = 0;
            for (int i = 0; i < r; i++)
            {
                num = Convert.ToDouble(dgv2[v + r, i].Value);
                if (num < Dmenor)
                    Dmenor = num;
            }
            if (Dmenor >= 0)
            {
                valoresOtimos();
            }
            else
            {
                for (int i = 0; i < (r + v); i++)
                {
                    if (Convert.ToDouble(dgv2[v + r, i].Value) == Dmenor)
                    {
                        break;
                    }
                    linhaPivo++;
                }
                encontrarColunaPivoMin();
            }

        }

        public void encontrarColunaPivoMin()
        {
            // colo um try pra caso tds os valores forem <= 0
            colPivo = 0;
            double[] comp = new double[r + v];
            double menor = double.MaxValue;
            double n1, n2 = 0;
            for (int i = 0; i < r + v; i++)
            {
                n1 = Convert.ToDouble(dgv2[i, r].Value);
                n2 = Convert.ToDouble(dgv2[i, linhaPivo].Value);
                if (n1 > 0 & Math.Abs(n2) > 0)
                {
                    comp[i] = n1 / Math.Abs(n2);
                }
            }

            for (int i = 0; i < r + v; i++)
            {
                if (comp[i] < menor && comp[i] > 0.0)
                {
                    menor = comp[i];
                }
            }
            for (int i = 0; i < v + r; i++)
            {
                if (comp[i] == menor)
                {
                    break;
                }
                colPivo++;
            }
            dgv2[colPivo, linhaPivo].Style.BackColor = Color.Yellow;
        }

        public void encontrarColunaPivoMax()
        {
            colPivo = 0;
            Dmenor = double.MaxValue;
            double num;
            for (int i = 0; i < (r + v); i++)
            {
                num = Convert.ToDouble(dgv2[i, r].Value);
                if (num < Dmenor)
                    Dmenor = num;
            }
            if (Dmenor >= 0)
            {
                valoresOtimos();
            }
            else
            {
                for (int i = 0; i < (r + v + 1); i++)
                {
                    if (Convert.ToDouble(dgv2[i, r].Value) == Dmenor)
                    {
                        break;
                    }
                    colPivo++;
                }
                encontrarLinhaPivoMax();
            }

        }

        public void encontrarLinhaPivoMax()
        {
            // colo um try pra caso tds os valores forem <= 0
            linhaPivo = 0;
            double[] comp = new double[r];
            double menor = double.MaxValue;
            int R = r + v;
            double n1, n2 = 0;
            for (int i = 0; i < r; i++)
            {
                n1 = Convert.ToDouble(dgv2[R, i].Value);
                n2 = Convert.ToDouble(dgv2[colPivo, i].Value);
                if (n1 > 0.0 & n2 > 0.0)
                {
                    comp[i] = n1 / n2;
                }
            }


            for (int i = 0; i < r; i++)
            {
                if (comp[i] < menor && comp[i] > 0.0)
                {
                    menor = comp[i];
                }
            }
            for (int i = 0; i < r; i++)
            {
                if (comp[i] == menor)
                {
                    break;
                }
                linhaPivo++;
            }
            dgv2.Rows[linhaPivo].Cells[colPivo].Style.BackColor = Color.Yellow;
        }

        public void montarTabela()
        {
            Resultado.Items.Clear();
            dgv2.Rows.Clear();
            v = Convert.ToInt32(variaveis.Text);
            r = Convert.ToInt32(restricoes.Text);
            dgv2.ColumnCount = (v + r + 1);

            for (int i = 0; i < v; i++)
                dgv2.Columns[i].Name = ("X" + (i + 1));

            for (int i = 0; i < r; i++)
                dgv2.Columns[i + v].Name = ("S" + (i + 1));

            dgv2.Columns[v + r].Name = "L";
            dgv2.RowCount = r + 1;
            dgv2.Rows[r].HeaderCell.Value = "Z";

            for (int i = 0; i < r; i++)
                dgv2.Rows[i].HeaderCell.Value = ("S" + (i + 1));


            for (int i = 0; i <= r + v - 1; i++)
                dgv2.Columns[i].Width = 40;
            dgv2.Columns[v + r].Width = 55;
            dgv2.RowHeadersWidth = 55;

        }

        public void valoresOtimos()
        {
            string aux = "";
            Resultado.Items.Clear();
            Resultado.Items.Add(dgv2.Rows[r].HeaderCell.Value + "= " + dgv2.Rows[r].Cells[dgv2.ColumnCount - 1].Value);

            for (int i = 0; i < v; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    aux = dgv2.Columns[i].HeaderCell.Value.ToString();
                    if (aux == dgv2.Rows[j].HeaderCell.Value.ToString())
                    {
                        Resultado.Items.Add(aux + "= " + dgv2.Rows[j].Cells[dgv2.ColumnCount - 1].Value);
                        break;
                    }
                    else if (j + 1 == r)
                    {
                        Resultado.Items.Add(aux + "= 0");
                    }
                }
            }

        }

        private void preencher_Click(object sender, EventArgs e)
        {
            try
            {
                montarTabela();
                if (radioMax.Checked)
                {
                    double[] z = new double[v];
                    for (int i = 0; i < v; i++)//inverter os valores de z
                        z[i] = (Convert.ToDouble(dgv1.Rows[r].Cells[i].Value) * -1);

                    for (int i = 0; i < v; i++)//preencher os valores de z
                    {
                        dgv2[i, r].Value = z[i];
                    }

                    for (int i = (v); i < (r + v + 1); i++)//preencher com 0 outros campos de z
                    {
                        dgv2[i, r].Value = 0;
                    }

                    for (int i = 0; i < r; i++)
                    {
                        for (int j = 0; j < v; j++)
                        {
                            dgv2[j, i].Value = dgv1[j, i].Value;
                        }
                    }

                    for (int i = 0; i < r; i++)//preencher com 1 ou -1
                    {
                        for (int j = 0; j < r; j++)
                        {
                            if (dgv1[v, i].Value.ToString() == "<=")
                            {
                                if (i == j)
                                    dgv2[j + (v), i].Value = 1;
                                else
                                    dgv2[j + (v), i].Value = 0;
                            }
                            else
                            {
                                if (i == j)
                                    dgv2[j + (v), i].Value = -1;
                                else
                                    dgv2[j + (v), i].Value = 0;
                            }

                        }
                    }

                    for (int i = 0; i < r; i++)
                    {
                        dgv2[v + r, i].Value = dgv1[v + 1, i].Value;
                    }
                }
                else if (radioMin.Checked)
                {
                    double[] l = new double[r];
                    for (int i = 0; i < r; i++)
                    {
                        l[i] = (Convert.ToDouble(dgv1[v + 1, i].Value) * -1);
                    }
                    for (int i = 0; i < r; i++)//preencher os valores de l
                    {
                        dgv2[v + r, i].Value = l[i];
                    }
                    for (int i = 0; i < r; i++)
                    {
                        for (int j = 0; j < v; j++)
                        {
                            dgv2[j, i].Value = Convert.ToDouble(dgv1[j, i].Value) * -1;
                        }
                    }
                    for (int i = 0; i < r; i++)//preencher com 1 ou -1
                    {
                        for (int j = 0; j < r; j++)
                        {
                            if (dgv1[v, i].Value.ToString() == "<=")
                            {
                                if (i == j)
                                    dgv2[j + (v), i].Value = 1;
                                else
                                    dgv2[j + (v), i].Value = 0;
                            }
                            else
                            {
                                if (i == j)
                                    dgv2[j + (v), i].Value = -1;
                                else
                                    dgv2[j + (v), i].Value = 0;
                            }

                        }
                    }
                    for (int i = 0; i < r; i++)
                    {
                        dgv2[i, r].Value = dgv1[i, r].Value;
                    }
                    for (int i = (v); i < (r + v + 1); i++)//preencher com 0 outros campos de z
                    {
                        dgv2[i, r].Value = 0;
                    }
                    dgv2.Rows[r].HeaderCell.Value = "-Z";
                }
                else
                {
                    MessageBox.Show("Marcar se é max ou min");
                }
            }
            catch
            {
                MessageBox.Show("Primeiro, crie a tabela!");
            }

        }

        private void pivo_Click(object sender, EventArgs e)
        {
            try
            {
                teste = true;
                for (int i = 0; i < v + r + 1; i++)
                {
                    for (int j = 0; j <= r; j++)
                    {
                        dgv2[i, j].Style.BackColor = Color.White;
                    }
                }

                if (radioMax.Checked)
                {
                    encontrarColunaPivoMax();

                }
                else if (radioMin.Checked)
                {
                    encontrarLinhaPivoMin();

                }
                else
                {
                    MessageBox.Show("Marcar se é max ou min");
                }
            }
            catch
            {
                MessageBox.Show("Primeiro, crie a tabela!");
            }        
        }

        private void solucionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (teste)
                {
                    teste = false;
                    double auxPivo = Convert.ToDouble(dgv2[colPivo, linhaPivo].Value);
                    double aux = 0;
                    for (int i = 0; i < r + v + 1; i++)
                    {
                        aux = Convert.ToDouble(dgv2[i, linhaPivo].Value);
                        dgv2[i, linhaPivo].Value = (aux / auxPivo);
                    }

                    Dmenor *= -1;
                    int nColunas = dgv2.ColumnCount;
                    int nLinhas = dgv2.RowCount;
                    double[] lPiv = new double[nColunas];

                    for (int i = 0; i < nColunas; i++)//calcula a nova linha do pivo 
                        lPiv[i] = Convert.ToDouble(dgv2[i, linhaPivo].Value) * Dmenor;
                    for (int i = 0; i < nColunas; i++)//calcular nova linha Z
                        dgv2[i, r].Value = Convert.ToDouble(dgv2[i, r].Value) + lPiv[i];


                    //*********************************************************************************


                    double[] col = new double[nLinhas];
                    double[] nrenPivo = new double[nColunas];
                    for (int i = 0; i < nLinhas; i++)//salvando a coluna do pivo no vetor 
                    {
                        col[i] = Convert.ToDouble(dgv2.Rows[i].Cells[colPivo].Value);
                        col[i] = col[i] / Convert.ToDouble(dgv2.Rows[linhaPivo].Cells[colPivo].Value);
                    }
                    for (int i = 0; i < nColunas; i++)
                    {
                        nrenPivo[i] = Convert.ToDouble(dgv2.Rows[linhaPivo].Cells[i].Value);
                    }
                    double elePiv = Convert.ToDouble(dgv2[colPivo, linhaPivo].Value);
                    for (int i = 0; i < nLinhas; i++)
                    {
                        for (int j = 0; j < nColunas; j++)
                        {
                            if (i != linhaPivo)
                            {
                                dgv2[j, i].Value = ((col[i] * -1) * nrenPivo[j]) + Convert.ToDouble(dgv2[j, i].Value);
                            }
                        }
                    }
                    dgv2.Rows[linhaPivo].HeaderCell.Value = dgv2.Columns[colPivo].Name;
                    for (int i = 0; i < v + r + 1; i++)
                    {
                        for (int j = 0; j <= r; j++)
                        {
                            dgv2[i, j].Style.BackColor = Color.White;
                        }
                    }
                }
                else
                    MessageBox.Show("Primeiro, marque o pivo!");

            }            
            catch
            {
                MessageBox.Show("Primeiro, crie a tabela!");
            }         
        }

        public bool acabouMax()
        {
            for (int i = 0; i < r + v; i++)
            {
                if (Convert.ToDouble(dgv2[i, r].Value) < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool acabouMin()
        {
            for (int i = 0; i < r; i++)
            {
                if (Convert.ToDouble(dgv2[v+r, i].Value) < 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void otimos_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioMax.Checked)
                {
                    do
                    {
                        pivo_Click(sender, e);
                        solucionar_Click(sender, e);
                    } while (acabouMax());                 
                }
                else if (radioMin.Checked)
                {
                    do
                    {
                        pivo_Click(sender, e);
                        solucionar_Click(sender, e);
                    } while (acabouMin());
                }
                else
                {
                    MessageBox.Show("Marcar se é max ou min");
                }

                valoresOtimos();
            }
            catch
            {
                MessageBox.Show("Crie a tabela primeiro");
            }
            
        }

        private void marcaSolucionar_Click(object sender, EventArgs e)
        {
            try
            {
                pivo_Click(sender, e);
                solucionar_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Crie a tabela primeiro");
            }
            
        }

        private void criarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado.Items.Clear();
                dgv1.Rows.Clear();
                dgv1.Columns.Clear();
                dgv2.Rows.Clear();
                dgv2.Columns.Clear();

                v = Convert.ToInt32(variaveis.Text);
                r = Convert.ToInt32(restricoes.Text);

                Dmenor = 0;
                colPivo = 0;
                linhaPivo = 0;

                dgv1.ColumnCount = v;
                dgv1.RowCount = r + 1;

                for (int i = 0; i < v; i++)
                {
                    dgv1.Columns[i].Name = ("X" + (i + 1));
                }
                dgv1.Rows[r].HeaderCell.Value = "Max Z =";


                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.Items.Add("<=");
                cmb.Items.Add(">=");
                cmb.HeaderText = "";
                cmb.Width = 50;


                dgv1.Columns.Add(cmb);
                for (int i = 0; i < r; i++)
                    dgv1.Rows[i].HeaderCell.Value = "Rest. " + (i + 1);
                for (int i = 0; i < v; i++)
                    dgv1.Columns[i].Width = 50;
                dgv1.RowHeadersWidth = 90;
                dgv1.Columns.Add("L", "L");
                dgv1.Rows[r].Cells[v + 1].Style.BackColor = Color.Gray;
                dgv1.Rows[r].Cells[v].ReadOnly = true;
                for (int i = 0; i < r; i++)
                    dgv1.Rows[i].Cells[v].Value = "<=";
            }
            catch
            {
                MessageBox.Show("Preencher o numero de variaveis e restrições");
            }

        }
    }
}
