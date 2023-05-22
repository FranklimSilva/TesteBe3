using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteBe3.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Column("Name")]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Column("LastName")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Column("Aniversário")]
        [Display(Name = "Data Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        [Column("CPF")]
        [Required(ErrorMessage = "O campo 'CPF' é requerido!!")]
        [Display(Name = "CPF")]
        [StringLength(11, ErrorMessage = "{0} size should be between {2} and {1}")]

        public string CPF { get; set; }

        [Column("RG")]
        [Required(ErrorMessage = "O campo 'RG' é requerido!!")]
        [Display(Name = "RG")]
        [StringLength(9, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string RG { get; set; }

        [Column("UF")]
        [Required(ErrorMessage = "O campo 'UF' é requerido!!")]
        [Display(Name = "UF")]
        public string UF { get; set; }

        [Column("Email")]
        [Required(ErrorMessage = "O campo 'E-Mail' é requerido!!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Column("PhoneNumber")]
        [Required(ErrorMessage = "O campo 'Celular' é requerido!!")]
        [Display(Name = "Numero Celular")]
        public string PhoneNumber { get; set; }

        [Column("PhoneNumber2")]        
        [Display(Name = "Numero Fixo")]
        public string PhoneNumber2 { get; set; }

        [Column("HealthInsurance")]
        [Display(Name = "Convênio")]
        public string HealthInsurance { get; set; }

        [Column("NumberHealthInsurance")]
        [Display(Name = "Numero do Convênio")]
        public int NumberHealthInsurance { get; set; }

        [Column("ValidityHealthInsurance")]
        [Display(Name ="Validade do Convênio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime ValidityHealthInsurance { get;set; }

    }
}
