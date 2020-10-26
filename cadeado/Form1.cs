using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_calcular(object sender, EventArgs e)
        {
            List<string> lstStrChaves = new List<string>();
            string[] arrStrSequenciaChaves;
            string[] arrStrOpcoesChaves;
            string strSequenciaChaves = string.Empty;
            int intTamanhoSequenciaChaves;

            arrStrSequenciaChaves = txtSequenciaChaves.Text.Split();
            arrStrOpcoesChaves = txtOpcoesChaves.Text.Split();

            foreach (string str in arrStrSequenciaChaves)
                strSequenciaChaves = strSequenciaChaves + str;

            intTamanhoSequenciaChaves = (int)nudChavesSeletoras.Value;

            GeraNovaChave(lstStrChaves, arrStrOpcoesChaves, intTamanhoSequenciaChaves, string.Empty);

            lstCadeado.Items.Clear();

            foreach (string chave in lstStrChaves)
            {
                lstCadeado.Items.Add(string.Format("{0}", chave));

                if (chave == strSequenciaChaves)
                {
                    lstCadeado.SetSelected(lstCadeado.Items.Count - 1, true);
                    lblSeraAbertEm.Text = chave;
                }
            }
        }

        private void GeraNovaChave(List<string> lista, string[] array, int tamanho, string chaveAtual)
        {
            string chaveCorrente = chaveAtual;

            for (int i = 0; i < array.Length; i++)
            {
                chaveCorrente += array[i];

                if (chaveCorrente.Length >= tamanho)
                {
                    lista.Add(chaveCorrente);
                    chaveCorrente = chaveAtual;
                }
                else
                {
                    GeraNovaChave(lista, array, tamanho, chaveCorrente);
                    chaveCorrente = chaveAtual;
                }
            }
        }
    }
}
