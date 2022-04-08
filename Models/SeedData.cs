using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PetShopApp.Models
{
    public static class SeedData
    {
        public static void Inicializar(IServiceProvider serviceProvider)
        {
            using(var context = new PetShopAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PetShopAppContext>>()))
            {
            // verificar se há dados no banco
            

            if(!context.Proprietario.Any() && context.Produto.Any()){
                context.Proprietario.AddRange(
                    new Proprietario
                    {
                        Nome ="Agatha Esther da Rocha",
                        Cpf ="081.878.098-33",
                        Endereco ="Rua Independência, 600",
                        Telefone ="(14) 98524-1532",
                        Email ="agatha.esther.darocha@granvale.com.br",
                        DtNascimento = DateTime.Parse("1983-04-01"),
                    },
                    new Proprietario
                    {
                        Nome ="Lorenzo Leonardo Eduardo Campos",
                        Cpf ="663.537.628-36",
                        Endereco ="Rua Adhemar de Barros",
                        Telefone ="(14) 2747-5408",
                        Email ="lorenzo_campos@systrix.com.br",
                        DtNascimento = DateTime.Parse("1950-03-19"),
                    },
                    new Proprietario
                    {
                        Nome ="Luna Gabriela Rezende",
                        Cpf ="157.760.728-75",
                        Endereco ="Rua Maria Felix de Brito Martinhon",
                        Telefone ="(14) 3766-3490",
                        Email ="luna_gabriela_rezende@omnibrasil.com.br",
                        DtNascimento = DateTime.Parse("1993-01-19"),
                    },
                    new Proprietario
                    {
                        Nome ="Isabel Camila Figueiredo",
                        Cpf ="289.720.058-86",
                        Endereco ="Rua Eurípedes Soares da Rocha",
                        Telefone ="(14) 3646-4921",
                        Email ="isabelcamilafigueiredo@rj.net",
                        DtNascimento = DateTime.Parse("2000-01-06"),
                    }
                );
            }
            else if(context.Proprietario.Any() && !context.Produto.Any()){
                context.Produto.AddRange(
                    new Produto
                    {
                        Nome ="Agatha Esther da Rocha",
                        Descricao ="081.878.098-33",
                        QuantidadeEstoque ="Rua Independência, 600",
                        PrecoCompra ="(14) 98524-1532",
                        PrecoVenda ="agatha.esther.darocha@granvale.com.br",
                    },
                    new Produto
                    {
                        Nome ="Agatha Esther da Rocha",
                        Descricao ="081.878.098-33",
                        QuantidadeEstoque ="Rua Independência, 600",
                        PrecoCompra ="(14) 98524-1532",
                        PrecoVenda ="agatha.esther.darocha@granvale.com.br",
                    }
                );
            }
            else if(!context.Proprietario.Any() && !context.Produto.Any()){
                    context.Produto.AddRange(
                    new Produto
                    {
                        Nome ="Agatha Esther da Rocha",
                        Descricao ="081.878.098-33",
                        QuantidadeEstoque ="Rua Independência, 600",
                        PrecoCompra ="(14) 98524-1532",
                        PrecoVenda ="agatha.esther.darocha@granvale.com.br",
                    },
                    new Produto
                    {
                        Nome ="Agatha Esther da Rocha",
                        Descricao ="081.878.098-33",
                        QuantidadeEstoque ="Rua Independência, 600",
                        PrecoCompra ="(14) 98524-1532",
                        PrecoVenda ="agatha.esther.darocha@granvale.com.br",
                    }
                    );
                    context.Proprietario.AddRange(
                        new Proprietario
                        {
                            Nome ="Agatha Esther da Rocha",
                            Cpf ="081.878.098-33",
                            Endereco ="Rua Independência, 600",
                            Telefone ="(14) 98524-1532",
                            Email ="agatha.esther.darocha@granvale.com.br",
                            DtNascimento = DateTime.Parse("1983-04-01"),
                        },
                        new Proprietario
                        {
                            Nome ="Lorenzo Leonardo Eduardo Campos",
                            Cpf ="663.537.628-36",
                            Endereco ="Rua Adhemar de Barros",
                            Telefone ="(14) 2747-5408",
                            Email ="lorenzo_campos@systrix.com.br",
                            DtNascimento = DateTime.Parse("1950-03-19"),
                        },
                        new Proprietario
                        {
                            Nome ="Luna Gabriela Rezende",
                            Cpf ="157.760.728-75",
                            Endereco ="Rua Maria Felix de Brito Martinhon",
                            Telefone ="(14) 3766-3490",
                            Email ="luna_gabriela_rezende@omnibrasil.com.br",
                            DtNascimento = DateTime.Parse("1993-01-19"),
                        },
                        new Proprietario
                        {
                            Nome ="Isabel Camila Figueiredo",
                            Cpf ="289.720.058-86",
                            Endereco ="Rua Eurípedes Soares da Rocha",
                            Telefone ="(14) 3646-4921",
                            Email ="isabelcamilafigueiredo@rj.net",
                            DtNascimento = DateTime.Parse("2000-01-06"),
                        }
                    );
                }else{
                    return;
                }               
                context.SaveChanges();
            }
        }
    }
}