using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentaCars.EN
{
  public class Estado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int EstadoID { get; set; }
        [Required(ErrorMessage ="Campo no puede estar vacio")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Solo letras")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        

        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<TipoUsuario> TipoUsuario { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
        public virtual ICollection<Reserva> Reserva { get; set; }
        public virtual ICollection<Renta> Renta { get; set; }
    }
}
