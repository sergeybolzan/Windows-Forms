//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDI_application
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public Address()
        {
            this.Switch = new HashSet<Switch>();
        }
    
        public int ID { get; set; }
        public string SwitchAddress { get; set; }
    
        public virtual ICollection<Switch> Switch { get; set; }
        public override string ToString()
        {
            return SwitchAddress;
        }
    }
}