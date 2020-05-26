//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Enrollment = new HashSet<Enrollment>();
        }
    
        public int CourseID { get; set; }
        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(30, ErrorMessage = "Se permite como máximo 30 caracteres")]
        public string Title { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Range(0, 5, ErrorMessage = "Como máximo son 5 créditos")]
        public Nullable<int> Credits { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
