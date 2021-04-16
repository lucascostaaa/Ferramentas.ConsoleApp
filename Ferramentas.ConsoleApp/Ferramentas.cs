using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.ConsoleApp
{
    public class Ferramentas
    {
        public int id;
        public float preco;
        public string nome;
        public string fabricante;
        public int numeroDeSerie;
        public DateTime dataFabricacao;
        
      
        // CADASTRAR FERRAMENTAS
        public Ferramentas(int id, float preco, string nome, string fabricante, int numeroDeSerie, DateTime dataFabricacao)
        {
            this.id = id;
            this.Preco = preco;
            this.Nome = nome;
            this.Fabricante = fabricante;
            this.NumeroDeSerie = numeroDeSerie;
            this.dataFabricacao = dataFabricacao;
        }
        public Ferramentas() 
        {

        }
        // EXIBIR FERRAMENRAS
        public String monstrarFerramentas()
        {
            
            return "===================FERRAMENTA=======================" + "\n" +

                     " NUMERO DE SERIE:....................... " + numeroDeSerie + "\n" +
                     " NOME DA FERRAMENTA:.................... " + nome + "\n" +
                     " PREÇO DA FERRAMENTA:................... " + preco + "\n" +
                     " NOME DO FABRICANTE:.................... " + fabricante + "\n" +    
                     " DATA DE FABRICAÇÃO:.................... " + dataFabricacao + "\n" +

                    "===================================================" + "\n";
          
        }
        // EDITAR EQUIPAMENTOS
        public void editarFerramentas() 
        {
            Preco = float.Parse(Console.ReadLine());
            Nome = Console.ReadLine();
            Fabricante = Console.ReadLine();
            NumeroDeSerie = int.Parse(Console.ReadLine());

        }
        public int Id { get => id; set => id = value; }
        public float Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public int NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
    }
}
