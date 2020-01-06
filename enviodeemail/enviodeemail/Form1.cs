using Limilabs.Client.SMTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enviodeemail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstArquivos.Items.Clear();
        }

        

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {


            try
            {
                email Email = new email();
                string vSSL = "N";

                if (chkSSL.Checked)
                    vSSL = "S";

                //Email.ComporCamposEmailParaEnvio(txtEmail.Text, txtSenha.Text, txtEmailPara.Text, txtAssunto.Text, txtMensagem.Text, txtHost.Text, vSSL, int.Parse(txtPort.Text), txtCaminhoArquivo.Text) ;

                //List<string> vListaDeArquivos;
                string[] vListaDeArquivos = new string[lstArquivos.Items.Count];

                for (int aux = 0;aux < lstArquivos.Items.Count; aux++)
                {
                    vListaDeArquivos[aux] = lstArquivos.Items[aux].ToString(); ;
                }

                Email.ComporCamposEmailParaEnvio(txtEmail.Text, txtSenha.Text, txtEmailPara.Text, txtAssunto.Text, txtMensagem.Text, txtHost.Text, vSSL, int.Parse(txtPort.Text), vListaDeArquivos) ;

                if (Email.vMensagemErro == "")
                {
                    Email.EnviarEmail();
                    MessageBox.Show("Email enviado com sucesso"); 
                }
                else
                    MessageBox.Show("" + Email.vMensagemErro, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

       

        private void chkVerSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerSenha.Checked)
                txtSenha.PasswordChar = char.Parse("\0");
            else
                txtSenha.PasswordChar = char.Parse("*");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMensagem.Text = "";
            txtAssunto.Text = "";
        }


        private void btnCarregarArquivos_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Selecionar Arquivo";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                lstArquivos.Items.Add(openFileDialog1.FileName);
        }

        private void btnRetirarArquivo_Click(object sender, EventArgs e)
        {
            lstArquivos.Items.Remove(lstArquivos.SelectedItem);
        }
    }
}