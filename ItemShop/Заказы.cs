//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItemShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказы()
        {
            this.Состав_заказа = new HashSet<Состав_заказа>();
        }
    
        public long id_Заказа { get; set; }
        public Nullable<System.DateTime> Дата_заказа { get; set; }
        public Nullable<System.DateTime> Дата_доставки { get; set; }
        public Nullable<int> Код_для_получения { get; set; }
        public Nullable<long> id_Пользователя { get; set; }
        public long id_Пункта_выдачи { get; set; }
        public long id_Статуса_заказа { get; set; }
    
        public virtual Пользователи Пользователи { get; set; }
        public virtual Пункт_выдачи Пункт_выдачи { get; set; }
        public virtual Статус_заказа Статус_заказа { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Состав_заказа> Состав_заказа { get; set; }
    }
}
