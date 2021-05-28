using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular.ConsoleApp
{
    public class Numeros
    {
        public string mensagem = "";
        public string ConverterMensagem()
        {
            string resposta = "";
            if (Validar() == "valido")
            {              
                foreach (char c in mensagem)
                {
                    if (resposta != "")
                    {
                        if (resposta.Last<char>() == ConverterCharParaNumero(c).First<char>())
                        {
                            resposta += "_";
                        }
                    }
                    resposta += ConverterCharParaNumero(c);
                }
                return resposta;
            }
            else           
                return Validar();
        }

        private string Validar()
        {
            if (mensagem.Length > 255)
            {
                return "Mensagem com mais de 255 caracteres!";
            }
            if (mensagem == "")
            {
                return "Mensagem vazia, erro!";
            }
            foreach (char c in mensagem)
            {
                if (char.IsDigit(c))
                {
                    return "Mensagem contem digito, use somente números!";
                }
            }
            return "valido";
        }

        public string ConverterCharParaNumero(char c)
        {
            switch (c)
            {
                case 'A': return "2";                   
                case 'B': return "22";                   
                case 'C': return "222"; 
                    
                case 'D': return "3";                   
                case 'E': return "33";                   
                case 'F': return "333";  
                    
                case 'G': return "4";
                case 'H': return "44";
                case 'I': return "444";

                case 'J': return "5";
                case 'K': return "55";
                case 'L': return "555";

                case 'M': return "6";
                case 'N': return "66";
                case 'O': return "666";

                case 'P': return "7";
                case 'Q': return "77";
                case 'R': return "777";
                case 'S': return "7777";

                case 'T': return "8";
                case 'U': return "88";
                case 'V': return "888";

                case 'W': return "9";
                case 'X': return "99";
                case 'Y': return "999";
                case 'Z': return "9999";

                case ' ': return "0";
                default: return "";
            }
        }
    }
}
