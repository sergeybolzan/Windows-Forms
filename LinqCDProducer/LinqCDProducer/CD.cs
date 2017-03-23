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
    public partial class ArrayOfCD
    {

        private ArrayOfCDCD[] cdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CD")]
        public ArrayOfCDCD[] CD
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArrayOfCDCD
    {

        private string tITLEField;

        private string aRTISTField;

        private string cOUNTRYField;

        private string cOMPANYField;

        private decimal pRICEField;

        private ushort yEARField;

        private byte pRODUCERField;

        /// <remarks/>
        public string TITLE
        {
            get
            {
                return this.tITLEField;
            }
            set
            {
                this.tITLEField = value;
            }
        }

        /// <remarks/>
        public string ARTIST
        {
            get
            {
                return this.aRTISTField;
            }
            set
            {
                this.aRTISTField = value;
            }
        }

        /// <remarks/>
        public string COUNTRY
        {
            get
            {
                return this.cOUNTRYField;
            }
            set
            {
                this.cOUNTRYField = value;
            }
        }

        /// <remarks/>
        public string COMPANY
        {
            get
            {
                return this.cOMPANYField;
            }
            set
            {
                this.cOMPANYField = value;
            }
        }

        /// <remarks/>
        public decimal PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }

        /// <remarks/>
        public ushort YEAR
        {
            get
            {
                return this.yEARField;
            }
            set
            {
                this.yEARField = value;
            }
        }

        /// <remarks/>
        public byte PRODUCER
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


}
