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
    
    public partial class Switch
    {
        public int ID { get; set; }
        public string IP_address { get; set; }
        public string Name { get; set; }
        public string VLAN_subscriber { get; set; }
        public string Firmware { get; set; }
        public string Features { get; set; }
        public string Notes { get; set; }
        public int Address_ID { get; set; }
        public int VLAN_manag_ID { get; set; }
        public int Model_ID { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Model Model { get; set; }
        public virtual VLAN_manag VLAN_manag { get; set; }
    }
}
