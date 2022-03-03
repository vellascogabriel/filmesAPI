﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {

        [Required(ErrorMessage = "O Campo Titulo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "O genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A Duração deve ser entre 1 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
