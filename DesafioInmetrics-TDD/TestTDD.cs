using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace DesafioInmetrics_TDD
{
    [TestClass]
    public class TestTDD
    {
        private ChromeDriver Browser;
        private readonly string uri = "https://imprensa.globo.com/";

        [TestMethod]
        public void TestMethod1()
        {
        
            this.Browser = new ChromeDriver();

            this.Browser.Navigate().GoToUrl(uri);

            //Botão-Novo-Cadastro
            this.Browser.FindElement(By.LinkText("Novo Cadastro")).Click();

            //Nome
            this.Browser.FindElement(By.Id("id_first_name")).SendKeys("nome");//.SendKeys("nome");

            //Sobrenome
            this.Browser.FindElement(By.Name("last_name")).SendKeys("nominho");

            //Como Gostaria de ser chamado
            this.Browser.FindElement(By.Name("como_gostaria_de_ser_chamado")).SendKeys("Apelido");

            //Genero
            new SelectElement(this.Browser.FindElement(By.Id("id_sexo"))).SelectByIndex(1);

            //Email
            this.Browser.FindElement(By.Name("username")).SendKeys("jeanfelippe40@gmail.com");

            //Cargo
            new SelectElement(this.Browser.FindElement(By.Name("cargo"))).SelectByIndex(1);

            //Editoria
            new SelectElement(this.Browser.FindElement(By.Name("editoria"))).SelectByIndex(2);

            //Veiculo
            this.Browser.FindElement(By.Name("veiculo")).SendKeys("carrolouco");

            //País
            this.Browser.FindElement(By.Name("pais")).SendKeys("Brasil");

            //Estado
            new SelectElement(this.Browser.FindElement(By.Name("estado"))).SelectByIndex(4);

            //Cidade
            this.Browser.FindElement(By.Name("cidade")).SendKeys("Rio de Janeiro");

            //DDD
            this.Browser.FindElement(By.Name("telefone_ddd")).SendKeys("021");

            //Telefone
            this.Browser.FindElement(By.Name("telefone_numero")).SendKeys("39760853");

            //Ramal
            this.Browser.FindElement(By.Name("telefone_ramal")).SendKeys("10");

            //DDD
            this.Browser.FindElement(By.Name("celular_ddd")).SendKeys("021");

            //Celular
            this.Browser.FindElement(By.Name("celular_numero")).SendKeys("986380744");

            //Twitter
            this.Browser.FindElement(By.Name("twitter")).SendKeys("boom");

            //Instagram
            this.Browser.FindElement(By.Name("instagram")).SendKeys("boooum");

            //Check nas categorias
            new SelectElement(this.Browser.FindElement(By.Name("estado"))).SelectByIndex(4);

            var categoria_interesse = this.Browser.FindElement(By.Id("id_categorias_de_interesse_1"));
            categoria_interesse.Click();

            //senha
            this.Browser.FindElement(By.Name("password1")).SendKeys("Jean!102030");

            //confirma senha
            this.Browser.FindElement(By.Name("password2")).SendKeys("Jean!102030");

            //marcar no check do Li e no check do Sim
            var checkTermos = this.Browser.FindElement(By.Id("id_termos"));
            checkTermos.Click();

            var checkReleases = this.Browser.FindElement(By.Id("id_deseja_receber_releases"));
            checkReleases.Click();

            //Clicar em Solicitar Cadastro
            this.Browser.FindElement(By.XPath("//button[@class='btn btn-preto']")).Click();




        }
    }
}

