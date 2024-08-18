using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//uso de imagens
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//messagem box
using System.Windows.Forms;
//conexão com banco de dados (tabela) mysql primeiro passo aqui! seguir o passo a passo do NuGet antes de usar essa biblioteca.
using MySql.Data.MySqlClient;
//tudo ligado a indioma e outros vai está aqui.
using System.Globalization;
using System.Web;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class formularioclientes : Form
    {
        //construtor
        public formularioclientes()
        {
            InitializeComponent();
        }
        //variavel do tipo string pode ser usada e chamada depois
        //posso usar isso com outras coisas no código.
        string strcon = "Server=127.0.0.1;port=3306;Database=base_clientes;User=root;Password=";

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        /*AQUI É ONDE FAZENDO O TAB E O ENTER SER UMA COISA SÓ
         * KeyEventArgs é uma classe cujo argumento serve para falar qual a tecla que vc apertou atraves do "e"
         * 
         */
        private void formularioclientes_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            //TODA VEZ QUE O C# identificar que eu apertei a tecla enter ....
         if(e.KeyCode == Keys.Enter)
            {
                //...ele vai enviar no lugar da tecla enter a tecla TAB
                SendKeys.Send("{TAB}");
                //CÓDIGO ACIMA NÃO FUNCIONOU!!!!
                //falta adicionar todos os campos com os quais vou trabalhar acima tudo do formulario.
            }*/


            Funcoes.BuscaSql("SELECT * FROM CLIENTES");

        }
        //botão sair ou fechar a janela.
        private void button3_Click(object sender, EventArgs e)
        {
            //fechar o botão no click duplo
            Close();
        }

        //botão salvar aqui vamos conectar o nosso banco de dados MySql.
        private void btsalvar_Click(object sender, EventArgs e)
        {
            /*if (Validacoes() == true)
                return;
            SalvarClienteMySql();*/


            //chamei a variavel strcon
            using (MySqlConnection Conexao = new MySqlConnection(strcon))
            {
                Conexao.Open();

                //mysql .....
                using (MySqlCommand cmd = Conexao.CreateCommand())
                {

                    if (txtid.Text == "")
                    {
                        cmd.CommandText = "INSERT INTO clientes (nome,documento,genero,rg,estado_civil,data_nascimento,cep," +
                            "endereco,numero,bairro,cidade,estado,celular,email,obs,situacao) VALUES (@nome,@doc,@genero," +
                            "@rg,@estado_civil,@data_nascimento,@cep,@endereco," +
                            "@numero,@bairro,@cidade,@estado,@situacao)";
                    }
                    else
                    {
                        //
                        cmd.CommandText = "UPDATE Clientes SET nome = ";
                    }

                    cmd.Parameters.AddWithValue("@nome,", txtnome);
                    cmd.Parameters.AddWithValue("@doc", txtdoc);

                    if(opm.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Masculino");
                    }
                    else if (opf.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Feminino");
                    }
                     if(outros.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Outros");
                    }

                    cmd.Parameters.AddWithValue("@rg", txtrg);
                    cmd.Parameters.AddWithValue("@estado_civil", cbestadocivil);
                    cmd.Parameters.AddWithValue("@data_nascimento", txtnascimento);

                    if(txtnascimento.Text == "  /  /")
                    {
                        cmd.Parameters.AddWithValue("@data_nascimento", DBNull.Value);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@data_nascimento", Convert.ToDateTime(txtnascimento.Text));
                        
                    }
                        

                    cmd.Parameters.AddWithValue("@cep", txtcep);
                    cmd.Parameters.AddWithValue("@endereco", cbendereco);
                    cmd.Parameters.AddWithValue("@numero", txtnumero);
                    cmd.Parameters.AddWithValue("@bairro", cbbairro);
                    cmd.Parameters.AddWithValue("@cidade", cbcidade);
                    cmd.Parameters.AddWithValue("@estado", cbestado);
                    cmd.Parameters.AddWithValue("@celular", txtcelular);
                    cmd.Parameters.AddWithValue("@email", txtemail);
                    cmd.Parameters.AddWithValue("@observacao", txtobs);

                    if(cksituacao.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@situacao", "ativo");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@situacao", "cancelado");
                    }

                    cmd.ExecuteNonQuery();

                    if (txtid.Text == "")
                    {
                        cmd.CommandText = "SELECT @@INDENTITY";
                        txtid.Text = cmd.ExecuteScalar().ToString();
                    }
                }
  
                MessageBox.Show("OK");
            
            }

        }
        //Validações de campos do formulário do usuario verdadeiro ou falso.
        private bool Validacoes()
        {
            //validar campo nome
            if(txtnome.Text == "")
            {
                Funcoes.MsgErro("Campo Nome é Obrigatório!");
                //Focus coloca o click do mouse de volta na caixa do txtnome
                txtnome.Focus();
            
                return true;
            }

            if(cpf.Checked == false && cnpj.Checked == false)
            {
                // ESSE "\r" serve para quebrar a linha
                Funcoes.MsgAlerta("Marque o tipo de documentaçãor\rCPF ou CNPJ!");
                return true;
            }
            if(txtdoc.Text =="")
            {
                if (cpf.Checked == true)
                    Funcoes.MsgErro("Digite o CPF!");
                else
                    Funcoes.MsgErro("Digite o CNPJ!");
                txtdoc.Focus();
                return true;
            }
            //verifica se marcou uma das 3 opções
            if(opm.Checked == false && opf.Checked == false && outros.Checked == false)
            {
                Funcoes.MsgErro("Selecione o Gênero!");
                return true;
            }

            //validar data erro concertar!!!
            if (txtnascimento.Text != "  /  /")
            {
                try
                {
                    Convert.ToDateTime(txtnascimento.Text);
                }
                catch (Exception)
                {
                    Funcoes.MsgErro("Data de Nascimento Invalida!");
                    return true;
                }
            }

            return false;
        }


        //botão novo
        private void btnovo_Click(object sender, EventArgs e)
        {
            if (Funcoes.Pergunta ("Deseja de Fato Limpar Todos os Campos?")== false)
                return;
            
            //abaixo os campos que vão ser limpos!
            txtid.Text = "";
            imgcliente.Image = Properties.Resources.avatar_2092113_6401;
            txtnome.Text = "";
            cpf.Checked = false;
            cnpj.Checked = false;
            txtdoc.Text = "";
            opm.Checked = false;
            opf.Checked = false;
            outros.Checked = false;
            txtrg.Text = "";
            cbestadocivil.Text = "";
            txtnascimento.Text = "";
            txtcep.Text = "";
            cbendereco.Text = "";
            txtnumero.Text = "";
            cbbairro.Text = "";
            cbcidade.Text = "";
            cbestado.Text = "";
            txtcelular.Text = "";
            //opcional
            //txtcelular.Text= string.Empty;
            txtemail.Text = "";
            txtobs.Text = "";
            cksituacao.Checked = true;
            btsalvar.Text = "Salvar";



        }


        //CLICK DUPLO no radio button cpf com a maskara
        private void cpf_CheckedChanged(object sender, EventArgs e)
        {
            //no click a maskara muda
            if (cpf.Checked == true)
            {
                txtdoc.Mask = "000,000,000-00";
                txtdoc.Focus();
            }
        }

        //click duplo no radio button cnpf com a maskara
        private void cnpj_CheckedChanged(object sender, EventArgs e)
        {
            //no click a maskara muda
            if (cnpj.Checked == true)
            {
                txtdoc.Mask = "00,000,000/0000-00";
                txtdoc.Focus();
            }
        }

        private void opm_CheckedChanged(object sender, EventArgs e)
        {
            txtrg.Focus();
        }

        private void opf_CheckedChanged(object sender, EventArgs e)
        {
            txtrg.Focus();
        }

        private void outros_CheckedChanged(object sender, EventArgs e)
        {
            txtrg.Focus();
        }

        private void txtnascimento_Validating(object sender, CancelEventArgs e)
        {
            if (txtnascimento.Text == "  /  /")
                return;
            try
            {
               txtnascimento.Text = Convert.ToDateTime(txtnascimento.Text).ToString();
            }
            catch(Exception)
            {
                //usando a classinstanciada "Funcoes" + "MsgErro" já classificadas
                Funcoes.MsgErro("Data de Nascimento Invalida!");

            }
            
        }

        //validar estado civil
        private void cbestadocivil_Validating(object sender, CancelEventArgs e)
        {
            if (cbestadocivil.Text == "")
                return;
            if(cbestadocivil.SelectedIndex == -1)
            {
                Funcoes.MsgErro("Selecione um Item da Lista!");
                e.Cancel = true;
            }
        }

        //validar estado
        private void cbestado_Validating(object sender, CancelEventArgs e)
        {
            //quando o usuario inventar um novo nome que não estiver na lista aplica-se um erro!
            if (cbestado.Text == "")
                return;
            if (cbestado.SelectedIndex == -1)
            {
                Funcoes.MsgErro("Selecione um Item da Lista!");
                e.Cancel = true;
            }
        }

        //2 click validação do campo nome
        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            //chama a função da classe.
            Funcoes.PriMaiuscula(txtnome);

        }


        //no geral valida as informações incompletas do campo cep
        private void txtcep_Validating(object sender, CancelEventArgs e)
        {
            if(txtcep.Text.Replace("", "").Length == 0)
                return;
            if (txtcep.Text.Replace("","").Length < 8)
            {
                Funcoes.MsgErro("Informação Incompleta!");
                e.Cancel = true;
            }
        }


        //documento validação de campo vazio
        private void txtdoc_Validating(object sender, CancelEventArgs e)
        {
            if (txtdoc.Text == "")
                return;

            if (cpf.Checked == true && txtdoc.Text.Replace("", "").Length < 11)
            {
                Funcoes.MsgErro("Informação Incompleta!");
                e.Cancel = true;
            }
            if (cnpj.Checked == true && txtdoc.Text.Replace("", "").Length < 14)
            {
                Funcoes.MsgErro("Informação Incompleta!");
                e.Cancel = true;
            }
        }

        private void cbendereco_TextChanged(object sender, EventArgs e)
        {
            //chamar as Funcoes
            Funcoes.PriMaiuscula(cbendereco);

            
        }

        private void cbbairro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbairro_TextChanged(object sender, EventArgs e)
        {

            Funcoes.PriMaiuscula(cbbairro);
        }

        private void cbcidade_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(cbcidade);
        }

        //botão imagem 2 clicks*
        private void btaddfoto_Click(object sender, EventArgs e)
        {

            if(txtid.Text =="")
            {
                Funcoes.MsgErro("Salve os Dados do Cliente Primeiro!");
                return;
            }

            //aqui foi instanciada o OpenFileDialog na variavel caixa.
            OpenFileDialog caixa = new OpenFileDialog();

            //filtrar por imagem
            caixa.Filter = "Arquivo de Imagem |*.jpg;*.png;*.gif;*.bpm";


            //aqui chama a "caixa dialogo" que nada mais é a caixa de documento do usuario com tudo (imagens, documentos pdf e etc.).
            //tratando a função é chamada de forma para não retornar caixa vazia caso selecione outras opções.
            if (caixa.ShowDialog() == DialogResult)
            {
                //Funcoes.MsgOK(caixa.FileName);

                //puxando da caixa imgcliente usando imagem junto com using usado na ferramenta para colocar imagem
                imgcliente.Image = Image.FromFile(caixa.FileName);
                //aqui é vamos usar o file com o using.IO e vamos ver se é copia, deletar ou outro
                //AppDomain.CurrentDomain.BaseDirectory usamos para saber onde está o diretorio para salvar.
                File.Copy(caixa.FileName, AppDomain.CurrentDomain.BaseDirectory + "/fotos/" + txtid.Text + ".png");
            }

        }

        private void btremovefoto_Click(object sender, EventArgs e)
        {
            if (Funcoes.Pergunta("Deseja de Fato Remover essa Foto? ") == false)
                return;

            imgcliente.Image = Properties.Resources.avatar_2092113_6401;

            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/fotos/" + txtid.Text + ".png");

            if (txtid.Text == "")
            {
                Funcoes.MsgErro("Não há Foto para ser removida");
                return;
            }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/fotos/" + txtid.Text + ".png") == false)
                return;
            {
                Funcoes.MsgErro("Não há Fotos para Remover!");
                return;
            }
            
        }


        //evento load colocar o mysql
        private void formularioclientes_Load(object sender, EventArgs e)
        {

            //acess
            //função mysql com controle endereço <>(diferente em sql) e ''(campo vazio ou "" em sql)
            //campo vazio e consultas do formulario ou registros....
            /* cbendereco.DataSource = Funcoes.BuscaSql("SELECT DISTINCT endereço FROM clientes WHERE endereço <> '' ");
             cbendereco.DisplayMember = "endereço";
             cbendereco.SelectedIndex = -1;

             cbcidade.DataSource = Funcoes.BuscaSql("SELECT DISTINCT cidade FROM clientes WHERE cidade <> '' ");
             cbcidade.DisplayMember = "cidade";
             cbcidade.SelectedIndex = -1;

             cbbairro.DataSource = Funcoes.BuscaSql("SELECT DISTINCT bairro FROM clientes WHERE bairro <> '' ");
             cbbairro.DisplayMember = "bairro";
             cbbairro.SelectedIndex = -1;*/




            if (txtid.Text == "")
            {
                return;
            }
            
            //chamando o data para incluir no parametro abaixo não é necessario agora....
            //DataTable dt = Funcoes.BuscaSql("SELECT endereco FROM clientes WHERE id" + txtid.Text);


            //não é necessario agora....
            /*txtnome.Text = dt.Rows[0]["nome"] ToString();
            txtrg.Text = dt.Rows[0]["rg"] ToString();
            txtrg.Text = dt.Rows[0]["rg"] ToString();*/
        }
    }
 }
