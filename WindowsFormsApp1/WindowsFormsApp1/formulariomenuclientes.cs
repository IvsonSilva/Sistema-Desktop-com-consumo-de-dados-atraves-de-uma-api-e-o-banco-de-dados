using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class formulariomenuclientes : Form
    {
        public formulariomenuclientes()
        {
            InitializeComponent();
        }
        string PastaFotos = AppDomain.CurrentDomain.BaseDirectory + "/fotos/";

        //no click botão vai para segunda tela.
        private void btadd_Click(object sender, EventArgs e)
        {
            //passar para proxima tela
            formularioclientes frm = new formularioclientes();
            //caixa de formulario
            frm.ShowDialog();
        }

        //tabela
        private void formulariomenuclientes_Load(object sender, EventArgs e)
        {
            buscarclientes();
            //chamando função
            //reorganizartabela();
        }

        //config tabela
        private void dglista_Sorted(object sender, EventArgs e)
        {
            //chamando função
            reorganizartabela();
        }

        private void reorganizartabela()
        {
            //aqui chama os dados do jason
            //dglista.DataSource = Funcoes.BuscaSql("SELECT * FROM clientes");
        
            //marcar cancelados da lista
            foreach (DataGridViewRow lin in dglista.Rows)
            {
                if (lin.Cells["situacaocoluna"].Value.ToString() == "Cancelado")
                    lin.DefaultCellStyle.ForeColor = Color.Crimson;


                //se existir imagem na pasta subistitui a padrão.
                if (File.Exists(PastaFotos + lin.Cells["idcoluna"].Value.ToString() + ".png"))
                {
                    lin.Cells["fotocoluna"].Value =
                        Image.FromFile(PastaFotos + lin.Cells["idcoluna"].Value.ToString() + ".png");
                }
                else
                {
                    lin.Cells["fotocoluna"].Value = Properties.Resources.avatar_2092113_6401;
                }
                //limpa seleção de linha do começo...
                dglista.ClearSelection();

                //bt apagado full time
                bteditar.Enabled = false;
            }
        }


        //no click da celula liga
        private void dglista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             bteditar.Enabled = true;


        }


        // botão edição de lista do data
        private void bteditar_Click(object sender, EventArgs e)
        {
            //chamando o formulario....
            formularioclientes frm = new formularioclientes();
            
            /*pegando o Modifiers e trocando de private para public
             * chamamos o campo ID da coluna junto com o datagrid e sua respectiva celula
             * e convertemos a uma string para edição de cada celula
             */
            frm.txtid.Text = dglista.CurrentRow.Cells["idcoluna"].ToString();

            frm.ShowDialog();

            buscarclientes();
        }

        private void buscarclientes()
        {
            dglista.DataSource = Funcoes.BuscaSql("SELECT * FROM clientes");

            reorganizartabela();
        }
    }
}
