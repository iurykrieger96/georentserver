//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeoRentWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class message
    {
        public int idMessage { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public string message1 { get; set; }
        public Nullable<System.DateTime> dateTime { get; set; }
        public Nullable<int> resource { get; set; }
        public string path { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}