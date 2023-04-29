using System.ComponentModel.DataAnnotations;
namespace P2_2020CG601_2020MR602_2020RO601.Models
{
    public class Generos
    {
        [Key]
        public int id_genero { get; set; }
        public string nombre_genero { get; set; }
    }
}
