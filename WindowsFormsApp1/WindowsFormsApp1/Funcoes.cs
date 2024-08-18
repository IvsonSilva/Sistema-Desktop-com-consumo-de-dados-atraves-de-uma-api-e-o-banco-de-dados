//messagem box
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;
//datable
using System.Data;
using System.Runtime.Remoting.Messaging;


namespace WindowsFormsApp1
{
    //aqui escreva o codigo e depois cite ele em qualquer parametro para chamar ele no projeto em forma de função já com as instancias.
    internal class Funcoes
    {
        //criando o primeiro alerta em mensagem com o "MsgErro" para parametro a ser citado no código
        public static void MsgErro(string Msg)
        {
            MessageBox.Show(Msg,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        //segundo alerta com "MsgAlerta" a ser citado no código.
        public static void MsgAlerta(string Msg)
        {
            MessageBox.Show(Msg,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        //Terceiro alerta com "MsgOK" a ser citado no código
        public static void MsgOK(string Msg)
        {
            MessageBox.Show(Msg,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //função caixa de dialogo verdadeira ou falsa para pergunta numa caixa de dialogo
        public static bool Pergunta(string Msg)
        {
           if ( MessageBox.Show(Msg,
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
           else 
                return false;
        }

        public static void PriMaiuscula (Control ctr)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            string t = ctr.Text;

            t = textInfo.ToTitleCase(t);

            t = t.Replace("Das", "das")
                 .Replace("Da", "da")
                 .Replace("Dos", "dos")
                 .Replace("Do", "do")
                 .Replace("De", "de");

            ctr.Text = t;

            if(ctr is TextBox txt)
            {
                txt.SelectionStart = txt.Text.Length;
            }
            else if(ctr is ComboBox cb)
            {
                cb.SelectionStart = cb.Text.Length;
            }

        }



        //função busca sql que retorna o datatable
        public static DataTable BuscaSql (string ComandoSql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;port=3306;Database=base_clientes;User=root;Password="))
            {
                conexao.Open();

                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = ComandoSql;

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

            }
            return dt;
        }


        public static void CarregarCombobox()
        {

        }
    }
}

