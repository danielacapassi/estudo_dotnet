using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Repositorio
    {
        public int id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
    }

}