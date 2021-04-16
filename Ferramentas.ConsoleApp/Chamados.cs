using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.ConsoleApp
{
    public class Chamados
    {
        public int idChamados;
        public string tituloChamado;
        public string descricaoChamado;
        public DateTime dataChamado;
     
        public Chamados(int idChamados, string tituloChamado, string descricaoChamado, DateTime dataChamado)
        {
            this.IdChamados = idChamados;
            this.TituloChamado = tituloChamado;
            this.DescricaoChamado = descricaoChamado;
            this.dataChamado = dataChamado;
        }
        public Chamados() 
        {
            
        }
        public String exibirChamados()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();
            return "=======================CHAMADOS=======================" + "\n" +

                     " TITULO CHAMADO:.......................... " + tituloChamado + "\n" +
                     " DESCRIÇÃO DO CHAMADO:.................... " + descricaoChamado + "\n" +
                     " DATA DO CHAMADO:......................... " + dataChamado + "\n" +

                    "=====================================================" + "\n";
            
            
        }
        public void editarChamados() 
        {
            tituloChamado = Console.ReadLine();
            descricaoChamado = Console.ReadLine();
            dataChamado = Convert.ToDateTime(Console.ReadLine());
        }
        public int IdChamados { get => idChamados; set => idChamados = value; }
        public string TituloChamado { get => tituloChamado; set => tituloChamado = value; }
        public string DescricaoChamado { get => descricaoChamado; set => descricaoChamado = value; }
      
    }
}
