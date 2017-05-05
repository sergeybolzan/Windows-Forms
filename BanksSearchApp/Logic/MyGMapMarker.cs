using BanksSearchApp;
using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MyGMapMarker : GMapMarker, ISerializable
    {
        private Bitmap Bitmap;
        public string Caption { get; set; }
        public BranchBank BranchBank { get; set; }
        private CurrencyTypes displayedCurrencyType;
        public CurrencyTypes DisplayedCurrencyType
        {
            get { return displayedCurrencyType; }
            set
            {
                displayedCurrencyType = value;
                if (displayedCurrencyType == CurrencyTypes.UsdSell)
                {
                    Caption = BranchBank.Bank.UsdSell.ToString();
                }
                if (displayedCurrencyType == CurrencyTypes.UsdBuy)
                {
                    Caption = BranchBank.Bank.UsdBuy.ToString();
                }
                if (displayedCurrencyType == CurrencyTypes.EurSell)
                {
                    Caption = BranchBank.Bank.EurSell.ToString();
                }
                if (displayedCurrencyType == CurrencyTypes.EurBuy)
                {
                    Caption = BranchBank.Bank.EurBuy.ToString();
                }
                if (displayedCurrencyType == CurrencyTypes.RurSell)
                {
                    Caption = BranchBank.Bank.RurSell.ToString();
                }
                if (displayedCurrencyType == CurrencyTypes.RurBuy)
                {
                    Caption = BranchBank.Bank.RurBuy.ToString();
                }
            }
        }

        public MyGMapMarker(PointLatLng p, string caption)
            : base(p)
        {
            this.Bitmap = Properties.Resources.label;
            this.Caption = caption;
            Size = new System.Drawing.Size(Bitmap.Width, Bitmap.Height);
            Offset = new Point(-Size.Width / 2 - 5, -Size.Height);
        }

        public override void OnRender(Graphics g)
        {
            g.DrawImage(Bitmap, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawString(Caption, new Font("Arial", 13), Brushes.Black, new PointF(LocalPosition.X + 10, LocalPosition.Y + 4));
        }

        public override void Dispose()
        {
            if (Bitmap != null)
            {
                Bitmap.Dispose();
                Bitmap = null;
            }
            base.Dispose();
        }

        #region ISerializable Members
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        protected MyGMapMarker(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endregion

    }
}
