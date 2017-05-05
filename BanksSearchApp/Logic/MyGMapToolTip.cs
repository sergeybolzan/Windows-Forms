using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Класс подсказки в виде прямоугольника с текстовым отображением информации о банке.
    /// </summary>
    public class MyGMapToolTip : GMapToolTip, ISerializable
    {
        public MyGMapToolTip(GMapMarker marker)
            : base(marker)
        {
            Stroke = new Pen(Brushes.LightGray);
            Fill = Brushes.White;
        }

        public override void OnRender(Graphics g)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Marker.ToolTipPosition.X, Marker.ToolTipPosition.Y, 320, 160);
            rect.Offset(Marker.Offset.X - 125, Marker.Offset.Y - 171);
            using (GraphicsPath objGP = new GraphicsPath())
            {
                objGP.AddLine(rect.X + rect.Width / 2 + 10, rect.Y + rect.Height, rect.X + rect.Width / 2, rect.Y + rect.Height + 10);
                objGP.AddLine(rect.X + rect.Width / 2, rect.Y + rect.Height + 10, rect.X + rect.Width / 2 - 10, rect.Y + rect.Height);
                objGP.AddLine(rect.X + rect.Width / 2 - 10, rect.Y + rect.Height, rect.X, rect.Y + rect.Height);
                objGP.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y);
                objGP.AddLine(rect.X, rect.Y, rect.X + rect.Width, rect.Y);
                objGP.AddLine(rect.X + rect.Width, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
                objGP.CloseFigure();

                g.FillPath(Fill, objGP);
                g.DrawPath(Stroke, objGP);
            }
            MyGMapMarker myMarker = (MyGMapMarker)Marker;
            g.DrawString(myMarker.BranchBank.Bank.Name, new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold, GraphicsUnit.Pixel), new SolidBrush(Color.Black), rect.X + 5, rect.Y + 5);
            g.DrawString(myMarker.BranchBank.Address, new Font(FontFamily.GenericSansSerif, 13, GraphicsUnit.Pixel), new SolidBrush(Color.Black), rect.X + 7, rect.Y + 40);

            string dateTimeText = null;
            if (myMarker.BranchBank.Bank.DateTime.Date == DateTime.Now.Date) dateTimeText = "Курс обновлен сегодня в " + myMarker.BranchBank.Bank.DateTime.TimeOfDay;
            else dateTimeText = "Курс обновлен " + myMarker.BranchBank.Bank.DateTime;
            g.DrawString(dateTimeText, new Font(FontFamily.GenericSansSerif, 13, GraphicsUnit.Pixel), new SolidBrush(Color.Black), rect.X + 7, rect.Y + 70);

            string currencyText = String.Format("1 Доллар США: покупка - {0}, продажа - {1}\n1 Евро: покупка - {2}, продажа - {3}\n100 Рос. рублей: покупка - {4}, продажа - {5}", myMarker.BranchBank.Bank.UsdSell, myMarker.BranchBank.Bank.UsdBuy, myMarker.BranchBank.Bank.EurSell, myMarker.BranchBank.Bank.EurBuy, myMarker.BranchBank.Bank.RurSell, myMarker.BranchBank.Bank.RurBuy);
            g.DrawString(currencyText, new Font(FontFamily.GenericSansSerif, 13, GraphicsUnit.Pixel), new SolidBrush(Color.Black), rect.X + 7, rect.Y + 105);
        }

        #region ISerializable Members
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
        protected MyGMapToolTip(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endregion

    }
}
