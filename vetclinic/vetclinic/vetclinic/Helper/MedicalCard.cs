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
    
    public partial class MedicalCard
    {
        public int IdMedicalCard { get; set; }
        public int IdClient { get; set; }
        public int IdPet { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
