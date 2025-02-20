using API_Filmes_SENAI.Context;
using API_Filmes_SENAI.Domains;
using API_Filmes_SENAI.Interfaces;
using API_Filmes_SENAI.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace API_Filmes_SENAI.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Filmes_Context _context;

        /// <summary>
        /// Construtor do Repositório
        /// Aqui, toda vez que o construtor for chamado, os dados do contexto estão disponíveis.
        /// </summary>
        /// <param name="contexto">Dados do contexto</param>


        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }


        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorID(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Método para Cadastrar o Genero
        /// </summary>
        /// <param name="novoGenero">Objeto genero a ser Cadastrado</param>


        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                // Adiciona um novo Genero na tabela Generos(BD)
                _context.Genero.Add(novoGenero);

                // Após o cadastro, salva as alterações(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros = _context.Genero.ToList();

                return listaGeneros;
            }
            catch (Exception)
            {
                throw;
            }

                }

            }
        }
   