using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste_project.Models
{
    [Table("Alimentos")]
    public class Alimento
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de calorias!")]
        public  int Calorias { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de carboidratos!")]
        public  int Caorboidratos { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de total de Açúcares!")]
        public  int AcucaresTotais { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de Proteínas!")]
        public  int Proteinas { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade total de Gorduras Saturadas!")]
        public  int GordurasSaturadas { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de Fibras Alimentares!")]
        public  int FibrasAlimentares { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de Sódio!")]
        public  int Sodio { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de VitaminaB1!")]
        public int VitaminaB1 { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de VitaminaB2!")]
        public int VitaminaB2 { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de VitaminaB6!")]
        public int VitaminaB6 { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de Cálcio!")]
        public int Calcio { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a quantidade de Ferro!")]
        public int Ferro { get; set; }
    }

}
