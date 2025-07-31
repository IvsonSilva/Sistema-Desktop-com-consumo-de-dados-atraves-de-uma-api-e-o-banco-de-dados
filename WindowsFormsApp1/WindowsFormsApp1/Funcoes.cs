ip﻿//messagem box
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;
//datable
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System;
using System.Drawing;
using System.Text.RegularExpressions;



namespace WindowsFormsApp1
{
    //aqui escreva o codigo e depois cite ele em qualquer parametro para chamar ele no projeto em forma de função já com as instancias.
    internal class Funcoes
    {
        //string referenciada a conexão
        public static string strMySQL = "Server=seu ip;port=port;Database=base_clientes;User=root;Password=";

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
        public static  DataTable BuscaSql (string ComandoSql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection Conexao = new MySqlConnection(Funcoes.strMySQL))
            {
                Conexao.Open();

                using (MySqlCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = ComandoSql;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        //tratar o error
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //???? ver depois
        public static void CarregarCombobox(ComboBox cb, string tabela, string campo)
        {
            cb.DataSource = Funcoes.BuscaSql("SELECT DISTINCT " + campo + " FROM " + tabela + " WHERE " + campo + " <> '' ");
            cb.DisplayMember = campo;
            cb.SelectedIndex = -1;
        }


    }
}

