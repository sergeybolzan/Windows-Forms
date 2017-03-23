using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMenu
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ArrayOfPRODUCER
    {

        private ArrayOfPRODUCERPRODUCER[] pRODUCERField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRODUCER")]
        public ArrayOfPRODUCERPRODUCER[] PRODUCER
        {
            get
            {
                return this.pRODUCERField;
            }
            set
            {
                this.pRODUCERField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArrayOfPRODUCERPRODUCER
    {

        private byte idField;

        private string nAMEField;

        private System.DateTime dATEField;

        private ushort fEEField;

        /// <remarks/>
        public byte ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public ushort FEE
        {
            get
            {
                return this.fEEField;
            }
            set
            {
                this.fEEField = value;
            }
        }
    }


}
