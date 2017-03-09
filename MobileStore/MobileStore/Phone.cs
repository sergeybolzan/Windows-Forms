using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore
{
    [Serializable]
    class Phone
    {
        #region FIELDS
        private string model;
        private string operatingSystem;
        private double processor;
        private double price;
        private string pathToImage;
        private BindingList<string> options;
        #endregion

        #region PROPERTIES
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string OperatingSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }
        public double Processor
        {
            get { return processor; }
            set { processor = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string PathToImage
        {
            get { return pathToImage; }
            set { pathToImage = value; }
        }
        public BindingList<string> Options
        {
            get { return options; }
            set { options = value; }
        }
        #endregion

        #region CTORS
        public Phone()
        {

        }
        public Phone(string model, string operatingSystem, double processor, double price, string pathToImage, BindingList<string> options)
        {
            this.model = model;
            this.operatingSystem = operatingSystem;
            this.processor = processor;
            this.price = price;
            this.pathToImage = pathToImage;
            this.options = options;
        }
        #endregion

        #region METHOD
        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}, Цена - {3}", model, operatingSystem, processor, price);
        }
        #endregion
    }
}
