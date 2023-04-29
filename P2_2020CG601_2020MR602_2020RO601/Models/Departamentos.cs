using System.ComponentModel.DataAnnotations;
namespace P2_2020CG601_2020MR602_2020RO601.Models
{
    public class Departamentos
    {
        [Key]
        public int id_departamento { get; set; }
        public string nombre_departamento { get; set; }

    }
}
