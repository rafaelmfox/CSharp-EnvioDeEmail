using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace enviodeemail
{
    class email
    {
        SmtpClient smtp;
        MailMessage mail;
        public string vMensagemErro = "";


        public void ComporCamposEmailParaEnvio(string vEmail,string vSenha,string vEmailDestinatario,string vAssunto,string vMensagem,string vHost,string vSSL,int vPort,string[] vCaminhoArquivo, string vCc,string vCco)
        {
            mail = new MailMessage();

            if (ValidaEmail(vEmail))
                mail.From = new MailAddress(vEmail);
            else
                vMensagemErro += "Por favor verifique se o email foi digitado corretamente\n";
            if (ValidaEmail(vEmailDestinatario))
                mail.To.Add(vEmailDestinatario);
            else
                vMensagemErro += "Por favor verifique se o email do destinatario foi digitado corretamente\n";

            if ((vAssunto != null) || (vAssunto != ""))
                mail.Subject = vAssunto;
            else
                vMensagemErro += "Por favor insira um assunto para o email\n";

            if ((vMensagem != null) || (vMensagem != ""))
                mail.Body = vMensagem;
            else
                vMensagemErro += "Por favor insira uma mensagem para o email\n";

            if ((vCaminhoArquivo != null))
            {
                for (int aux = 0; aux < vCaminhoArquivo.Length; aux++)
                {
                    Attachment data = new Attachment(vCaminhoArquivo[aux], MediaTypeNames.Application.Octet);
                    mail.Attachments.Add(data);
                }
            }

            /* if ((vCaminhoArquivo != null) || (vCaminhoArquivo != ""))
             {
                 Attachment data = new Attachment(vCaminhoArquivo, MediaTypeNames.Application.Octet);
                 mail.Attachments.Add(data);
             }*/

           if (vCc != "")
                if (ValidaEmail(vCc))
                    mail.CC.Add(vCc);
                else
                    vMensagemErro += "Por favor verifique se o email do com copia foi digitado corretamente\n";


            if (vCco != "")
                if (ValidaEmail(vCco))
                    mail.CC.Add(vCco);
                else
                    vMensagemErro += "Por favor verifique se o email do com copia oculta foi digitado corretamente\n";


            if ((vMensagem != null) || (vMensagem != ""))
                smtp = new SmtpClient(vHost);
            else
                vMensagemErro += "Por favor verifique se o dns smtp foi digitado corretamente\n";

            if (vSSL == "S")
                smtp.EnableSsl = true;
            else
                smtp.EnableSsl = false;

            if(vPort != null)
                smtp.Port = vPort;
            else
                vMensagemErro += "Por favor verifique a porta de cominucação\n";
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            if ((ValidaEmail(vEmail)) && ((vSenha != null) || (vSenha != "")))
                smtp.Credentials = new NetworkCredential(vEmail, vSenha);
            else
                vMensagemErro += "Por favor verifique a senha se foi digitada corretamente\n";
        }



        public void EnviarEmail()
        {
            smtp.Send(mail);
        }


        public bool ValidaEmail(string vEmail)
        {
            bool retorno = false;

            if ((vEmail.Contains("@")) && (vEmail.Contains(".com")))
                retorno = true;
            if ((vEmail == null) || (vEmail == ""))
                retorno = false;

            if (vEmail.Contains(","))
            {
                string[] vEmailArray = vEmail.Split(',');

                for (int aux = 0; aux < vEmailArray.Length; aux++)
                {
                    if ((vEmailArray[aux].Contains("@")) && (vEmailArray[aux].Contains(".com")))
                        retorno = true;
                    else
                        return false;
                }

            }



            return retorno;

        }





    }
}