using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar placa!")]
        public string Placa { get; set; }
    }
}
