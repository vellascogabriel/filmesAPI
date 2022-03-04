﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;
using FilmesAPI.Models;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }
        
        [JsonIgnore]
        public virtual Cinema Cinema { get; set; }
    }
}
