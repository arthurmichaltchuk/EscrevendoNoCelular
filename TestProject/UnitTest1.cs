using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscrevendoNoCelular.ConsoleApp;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarSempreAcessoODojopuzzles()
        {
            Numeros numero = new Numeros();
            numero.mensagem = "SEMPRE ACESSO O DOJOPUZZLES";
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", numero.ConverterMensagem());
        }

        [TestMethod]
        public void TestarVazio()
        {
            Numeros numero = new Numeros();
            numero.mensagem = "";
            Assert.AreEqual("Mensagem vazia, erro!", numero.ConverterMensagem());
        }

        [TestMethod]
        public void TestarLimiteDeCaracteres()
        {
            Numeros numero = new Numeros();
            numero.mensagem = "77773367_7773302_222337777_777766606660366656667889999_999955533777777773367_7773302_222337777_777766606660366656667889999_999955533777777773367_7773302_222337777_777766606660366656667889999_999955533777777773367_7773302_222337777_777766606660366656667889999_999955533777777773367_7773302_222337777";
            Assert.AreEqual("Mensagem com mais de 255 caracteres!", numero.ConverterMensagem());
        }

        [TestMethod]
        public void TestarMensagemComDigito()
        {
            Numeros numero = new Numeros();
            numero.mensagem = "SEMPRE 3ACESSO O DOJOPUZZLES";
            Assert.AreEqual("Mensagem contem digito, use somente números!", numero.ConverterMensagem());
        }

        [TestMethod]
        public void TestarTodosCaracteres()
        {
            Numeros numero = new Numeros();
            numero.mensagem = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Assert.AreEqual("2_22_2223_33_3334_44_4445_55_5556_66_6667_77_777_77778_88_8889_99_999_9999", numero.ConverterMensagem());
        }
    }
}
