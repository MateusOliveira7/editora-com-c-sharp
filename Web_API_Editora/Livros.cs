//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_API_Editora
{
    using System;
    using System.Collections.Generic;
    
    public partial class Livros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livros()
        {
            this.livro_autor = new HashSet<livro_autor>();
        }
    
        public int Id { get; set; }
        public string titulo { get; set; }
        public string isbn { get; set; }
        public Nullable<int> ano { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<livro_autor> livro_autor { get; set; }
    }
}
