using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferramentas.ConsoleApp
{
    //  FEITO
//        Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos  


//         •  Deve ter um nome com no mínimo 6 caracteres;  
//         •  Deve ter um preço de aquisição;  
//         •  Deve ter um número de série;  
//         •  Deve ter uma data de fabricação;  
//         •  Deve ter uma fabricante;

    // FEITO
//    Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos registrados em seu inventário.

//         •  Deve mostrar o número;  
//         •  Deve mostrar o nome;  
//         •  Deve mostrar o preço; 
//         •  Deve mostrar a fabricante;   
//         •  Deve mostrar a data de fabricação;

    // FEITO
//    Requisito 1.3:  Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo que ele possa
//    editar todos os campos.


//         •  Deve ter os mesmos critérios que o Requisito 1.

    // FEITO

// Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja registrado.
 
//         •  A lista de equipamentos deve ser atualizada  


//2. Controle de Chamados

    // FALTA RELACIONAR ARRAYS

//Requisito 2.1:  Como funcionário Junior quer ter a possibilidade de registrar os chamados de manutenções que são
//efetuadas nos equipamentos registrados  


//         •  Deve ter a título do chamado;  
//         •  Deve ter a descrição do chamado;  
//         •  Deve ter um equipamento;  
//         •  Deve ter uma data de abertura;

    // FEITO
//    Requisito 2.2: Como funcionário Junior quer ter a possibilidade de visualizar todos os chamados registrados para controle.


//         •  Deve mostrar o título do chamado;  
//         •  Deve mostrar o equipamento;  
//         •  Deve mostrar a data de abertura;  
//         •  Número de dias que o chamado está aberto

    // FEITO
//Requisito 2.3: Como funcionário Junior quer ter a possibilidade de editar um chamado que esteja registrado, sendo que ele possa editar todos os campos.


//         •  Deve ter os mesmos critérios que o Requisito 5. 
    // FEITO
//Requisito 2.4: Como funcionário Junior quer ter a possibilidade de excluir um chamado.

    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            int id = 0, idChamados = 0;
            string cadastrar = "";
            float preco = 0;
            string nome = "", tituloChamado = "", descricaoChamados = "";
            string fabricante = "";
            int numeroDeSerie = 0;
            int contador = 0;

            DateTime dataFabricacao, dataChamado;
          
            // FERRAMENTAS
            Ferramentas ferramentas = new Ferramentas();
            //CHAMADOS
            Chamados chamados = new Chamados();
            // ARRAY FERRAMENTAS
            Ferramentas[] arrayFerramentas = new Ferramentas[100];
            //ARRAY CHAMADAS
            Chamados[] arrayChamados = new Chamados[100];
            
            while (opcao != "s")
            {
                opcao = MenuPrimcipal();

                if (opcao == "1")
                {
                    cadastrar = MenuFerramentas();

                    switch (cadastrar)
                    {
                        //CADASTRO FERRAMENTAS
                        case "1":
                            {
                                Console.WriteLine("Digite o ID");
                                id = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o preco da ferramenta");
                                preco = float.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o nome da ferramenta");
                                nome = (Console.ReadLine());

                                Console.WriteLine("Digite o nome do fabricante");
                                fabricante = (Console.ReadLine());

                                Console.WriteLine("Digite o numero de serie da ferramenta");
                                numeroDeSerie = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite data de fabricação");
                                dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                                arrayFerramentas[contador] = new Ferramentas(id, preco, nome, fabricante, numeroDeSerie, dataFabricacao);

                                contador++;
                                break;
                            }

                        //EDITAR FERRAMENTA
                        case "2":
                            {
                                int idEditar = 0;
                                Console.WriteLine("Digite o id da ferramenta que deseja editar");
                                idEditar = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayFerramentas[i].id == idEditar)
                                    {
                                        Console.WriteLine("Digite o preco da ferramenta");
                                        preco = float.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite o nome da ferramenta");
                                        nome = (Console.ReadLine());

                                        Console.WriteLine("Digite o nome do fabricante");
                                        fabricante = (Console.ReadLine());

                                        Console.WriteLine("Digite o numero de serie da ferramenta");
                                        numeroDeSerie = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Digite data de fabricação");
                                        dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                                        Console.ReadLine();

                                        arrayFerramentas[i] = new Ferramentas(idEditar, preco, nome, fabricante, numeroDeSerie, dataFabricacao);
                                    }
                                }

                                break;
                            }

                        //MOSTRAR FERRAMENTAS
                        case "3":

                            {
                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayFerramentas[i] != null)
                                    {
                                        Console.WriteLine(arrayFerramentas[i].monstrarFerramentas());
                                    }

                                }
                                break;
                            }
                        //EXLUIR FERRAMENTA
                        case "4":

                            {
                                //PEGANDO FERRAMENTA PELO ID
                                int idExcluir = 0;
                                Console.WriteLine("Digite o ID da ferramenta que vai pra dalas");
                                idExcluir = int.Parse(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayFerramentas[i].id == idExcluir)
                                    {
                                        arrayFerramentas[i] = null;
                                    }
                                }
                                break;
                            }
                    }


                }
                else if (opcao == "2")
                {
                    cadastrar = MenuChamados();

                    switch (cadastrar)
                    {
                        //INSERINDO CHAMADO
                        case "1":
                            {
                                Console.WriteLine("Digite o ID do chamado");
                                idChamados = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o TITULO do chamado");
                                tituloChamado = (Console.ReadLine());

                                Console.WriteLine("Digite a DESCRICAO do chamado");
                                descricaoChamados = (Console.ReadLine());

                                Console.WriteLine("Digite a data de abertura do chamadoo");
                                dataChamado = DateTime.Parse(Console.ReadLine());

                                arrayChamados[contador] = new Chamados(idChamados, tituloChamado, descricaoChamados, dataChamado);

                                contador++;
                                break;
                            }
                        //EDITAR CHAMADO
                        case "2":
                            {
                                int idEditar = 0;
                                Console.WriteLine("Digite o ID da Chamada que deseja EDITAR");
                                idEditar = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayChamados[i].idChamados == idEditar)
                                    {
                                        Console.WriteLine("Digite o NOVO titulo do Chamado");
                                        tituloChamado = (Console.ReadLine());

                                        Console.WriteLine("Digite a NOVA descrição do Chamado");
                                        descricaoChamados = (Console.ReadLine());

                                        Console.WriteLine("Digite a NOVA data do Chamado");
                                        dataChamado = Convert.ToDateTime(Console.ReadLine());

                                        Console.WriteLine();
                                        arrayChamados[i] = new Chamados(idEditar, tituloChamado, descricaoChamados, dataChamado);


                                    }
                                }
                                break;
                            }
                        //VIZUALIZANDO CHAMADO
                        case "3":
                            {
                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayChamados[i] != null)
                                    {
                                        Console.WriteLine(arrayChamados[i].exibirChamados());
                                    }

                                }

                                break;
                            }
                        //EXCLUIR CHAMADO
                        case "4":
                            {
                                int idExcluir = 0;
                                Console.WriteLine("Digite o ID da ferramenta que vai pra dalas");
                                idExcluir = int.Parse(Console.ReadLine());

                                for (int i = 0; i < contador; i++)
                                {
                                    if (arrayChamados[i].idChamados == idExcluir)
                                    {
                                        arrayChamados[i] = null;
                                    }
                                }
                                break;
                            }
                    }
                }
                else if (opcao == "3")
                {
                    break;
                }
                // DIGITOU CARACTER INVALIDO
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dados incorretos, Tente Novamente");
                    Console.ResetColor();
                    Console.ReadLine();

                    continue;
                }
            }
            Console.ReadLine();

        }

        private static string MenuChamados()
        {
            string cadastrar;
            Console.WriteLine("=============VER CHAMADOS=============");
            Console.WriteLine("Digite [1] para Inserir Chamados");
            Console.WriteLine("Digite [2] para Editar Chamados");
            Console.WriteLine("Digite [3] Para Mostrar Chamados");
            Console.WriteLine("Digite [4] Para Excluir Chamados");
            Console.WriteLine("======================================");
            cadastrar = Console.ReadLine();
            return cadastrar;
        }

        private static string MenuFerramentas()
        {
            string cadastrar;
            Console.WriteLine("==============FERRAMENTAS==============");
            Console.WriteLine("Digite [1] para inserir Ferramenta");
            Console.WriteLine("Digite [2] para Editar Ferramenta");
            Console.WriteLine("Digite [3] para Visualizar Ferramentas");
            Console.WriteLine("Digite [4] para Excluir uma Ferramenta");
            Console.WriteLine("=======================================");
            cadastrar = Console.ReadLine();
            return cadastrar;
        }

        private static string MenuPrimcipal()
        {
            string opcao;
            Console.WriteLine("==============FERRAMENTAS==============");
            Console.WriteLine("Digite [1] para ver as opções de ferramentas");
            Console.WriteLine("Digite [2] para ver as opções de chamados");
            Console.WriteLine("Digite [3] para sair");
            Console.WriteLine("========================================");
            opcao = Console.ReadLine();
            return opcao;
        }
    }
}
