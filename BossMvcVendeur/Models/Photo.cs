//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BossMvcVendeur.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Photo()
        {
            this.PhotoTag = new HashSet<PhotoTag>();
        }
    
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public int IDVendeur { get; set; }
        public string Path { get; set; }
    
        public virtual Vendeur Vendeur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhotoTag> PhotoTag { get; set; }
    }
}
