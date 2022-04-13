using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kLib
{
    public class Email
    {
        public string Id { get; set; }
        public string Assunto { get; set; }
        public string De { get; set; }
        public string Para { get; set; }
        public DateTime Data { get; set; }
        public string ConteudoTexto { get; set; }
        public string ConteudoHtml { get; set; }

        public static List<Email> _emails = new List<Email>();
        public static string _pophostname = "outlook.office365.com"; // Host do seu servidor POP3. Por exemplo, pop.gmail.com para o servidor do Gmail.
        //public static string _smtphostname = "smtp.gmail.com"; //Host do seu servidor smtp
        public static string _smtphostname = "smtp.live.com"; //Host do seu servidor smtp
        public static int _popport = 995; // Porta utilizada pelo host. Por exemplo, 995 para o servidor do Gmail.
                                          //public static int _smtpport = 587; //Porta utilizada pelo host. Por exemplo 587 para o servidor do Gmail.
        public static int _smtpport = 587; //Porta utilizada pelo host. Por exemplo 587 para o servidor do Gmail.
        public static bool _useSsl = true; // Indicação se o servidor POP3 utiliza SSL para autenticação. Por exemplo, o servidor do Gmail utiliza SSL, então, "true".
        public static string _popusername = "klassifis@hotmail.com";  // Usuário do servidor POP3. Por exemplo, seuemail@gmail.com.
        public static string _smtpusername = "klassifis@hotmail.com";        // Usuário do servidor POP3. Por exemplo, seuemail@gmail.com.
        public static string _password = "rfds3142365.";               // Senha do servidor POP3.
    }
}
