using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Models;
using System.Collections.Generic;
using System;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return filmes;
        }
    }
}
