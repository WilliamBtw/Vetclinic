//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vetclinic.Helper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diagnosis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diagnosis()
        {
            this.MedicalExamination = new HashSet<MedicalExamination>();
        }
    
        public int IdDiagnosis { get; set; }
        public string NameDIagnosis { get; set; }
        public string CodeDiagnosis { get; set; }
        public string DescriptionDIagnosis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalExamination> MedicalExamination { get; set; }
    }
}