//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            this.OrganizationComment = new HashSet<OrganizationComment>();
        }
    
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int ParticipantId { get; set; }
        public string Comment1 { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual Participant Participant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationComment> OrganizationComment { get; set; }
    }
}
