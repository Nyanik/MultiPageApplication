//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiPageApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zapis_Kompl
    {
        public int ID { get; set; }
        public int ID_Zakup { get; set; }
        public int ID_Komplect { get; set; }
    
        public virtual Komplect Komplect { get; set; }
        public virtual Zakup Zakup { get; set; }
    }
}
