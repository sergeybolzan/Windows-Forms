using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanksSearchApp
{
    public partial class MainForm : Form
    {
        private Point mouseLocation;
        private MyGMapMarker clickedMarker;
        private GMapOverlay markersOverlay;
        private GMapControl gMapControl;
        public MainForm()
        {
            InitializeComponent();
            GetDataFromXML.UpdateBanksInfo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMap();
            tscbSelectAction.Text = "Продать";
            tscbSelectCurrency.Text = "1 Доллар США";
            gMapControl.OnMarkerClick += gMapControl_OnMarkerClick;
            gMapControl.MouseClick += gMapControl_MouseClick;
            gMapControl.MouseDown += gMapControl_MouseDown;
        }

        private void LoadMap()
        {
            markersOverlay = new GMapOverlay();
            gMapControl = new GMapControl();
            gMapControl.Dock = DockStyle.Fill;
            this.Controls.Add(gMapControl);

            gMapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            gMapControl.MaxZoom = 18;
            gMapControl.MinZoom = 2;
            gMapControl.Zoom = 12;
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            gMapControl.IgnoreMarkerOnMouseWheel = true;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.Position = new PointLatLng(53.902800, 27.561759);
            gMapControl.ShowCenter = false;
            gMapControl.MarkersEnabled = true;

            gMapControl.Overlays.Add(markersOverlay);
            #region oldmarkers
            //MyGMapMarkerImage imageMarker1 = new MyGMapMarkerImage(new PointLatLng(53.902752, 27.561294), "1.835");
            //imageMarker1.ToolTip = new MyGMapToolTip(imageMarker1);
            //imageMarker1.ToolTipMode = MarkerTooltipMode.Never;
            //imageMarker1.ToolTipText = "qweqweqweqweqweqweqweqweqeqweqweqweqweqwe";
            //markersOverlay.Markers.Add(imageMarker1);

            //MyGMapMarkerImage imageMarker2 = new MyGMapMarkerImage(new PointLatLng(53.90227, 27.560604), "2.235");
            //imageMarker2.ToolTip = new MyGMapToolTip(imageMarker2);
            //imageMarker2.ToolTipMode = MarkerTooltipMode.Never;
            //imageMarker2.ToolTipText = "123456789123456789123456789123456789123456789";
            //markersOverlay.Markers.Add(imageMarker2);
            #endregion

            var branchsBanks = GetDataFromDB.GetBranchsBanksInfo();
            foreach (var branchBank in branchsBanks)
            {
                MyGMapMarker marker = new MyGMapMarker(new PointLatLng(branchBank.Latitude, branchBank.Longitude), "");
                marker.MyCurrency = new Currency(branchBank.Bank.UsdSell, branchBank.Bank.UsdBuy, branchBank.Bank.EurSell, branchBank.Bank.EurBuy, branchBank.Bank.RurSell, branchBank.Bank.RurBuy);
                marker.MyCurrencyTypes = CurrencyTypes.UsdSell;
                marker.ToolTip = new MyGMapToolTip(marker);
                marker.ToolTipMode = MarkerTooltipMode.Never;
                marker.ToolTipText = branchBank.Bank.Name + "\nАдрес: " + branchBank.Address + "\nКурс обновлен " + branchBank.Bank.DateTime.ToString();
                markersOverlay.Markers.Add(marker);
            }

        }
        #region Обработчики нажатия мышкой по карте и маркерам
        //Отслеживаем именно нажатие кнопки мыши (не отжатие), чтобы обработчик gMapControl_MouseClick не выполнялся, когда перетаскиваем карту 
        void gMapControl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
        }

        //Убираем tooltip с маркера при нажатии на карту или на другой маркер
        void gMapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouseLocation == e.Location)
            {
                if (clickedMarker != null)
                {
                    clickedMarker.ToolTipMode = MarkerTooltipMode.Never;
                }
                clickedMarker = null;
            }
        }

        //При нажатии на маркер показываем его tooltip
        void gMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (clickedMarker == null)
            {
                item.ToolTipMode = MarkerTooltipMode.Always;
                clickedMarker = (MyGMapMarker)item;
            }
        }
        #endregion


        private void tsbtnShow_Click(object sender, EventArgs e)
        {
            foreach (MyGMapMarker marker in markersOverlay.Markers) marker.IsVisible = true;
            if (tscbSelectAction.SelectedIndex == 0)
            {
                if (tscbSelectCurrency.SelectedIndex == 0) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.MyCurrencyTypes = CurrencyTypes.UsdSell;
                if (tscbSelectCurrency.SelectedIndex == 1) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.MyCurrencyTypes = CurrencyTypes.EurSell;
                if (tscbSelectCurrency.SelectedIndex == 2) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.MyCurrencyTypes = CurrencyTypes.RurSell;
            }

            if (tscbSelectAction.SelectedIndex == 1)
            {
                if (tscbSelectCurrency.SelectedIndex == 0) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.MyCurrencyTypes = CurrencyTypes.UsdBuy;
                if (tscbSelectCurrency.SelectedIndex == 1) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.MyCurrencyTypes = CurrencyTypes.EurBuy;
                if (tscbSelectCurrency.SelectedIndex == 2) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.MyCurrencyTypes = CurrencyTypes.RurBuy;
            }
            gMapControl.Refresh();
        }

        private void tsbtnShowMin_Click(object sender, EventArgs e)
        {
            decimal minRate = Decimal.MaxValue;
            decimal markerRate;
            foreach (MyGMapMarker marker in markersOverlay.Markers)
            {
                markerRate = Convert.ToDecimal(marker.Caption);
                if (minRate > markerRate) minRate = markerRate;
            }
            foreach (MyGMapMarker marker in markersOverlay.Markers)
            {
                marker.IsVisible = true;
                if (minRate != Convert.ToDecimal(marker.Caption)) marker.IsVisible = false;
            }
        }

        private void tsbtnShowMax_Click(object sender, EventArgs e)
        {
            decimal maxRate = 0;
            decimal markerRate;
            foreach (MyGMapMarker marker in markersOverlay.Markers)
            {
                markerRate = Convert.ToDecimal(marker.Caption);
                if (maxRate < markerRate) maxRate = markerRate;
            }
            foreach (MyGMapMarker marker in markersOverlay.Markers)
            {
                marker.IsVisible = true;
                if (maxRate != Convert.ToDecimal(marker.Caption)) marker.IsVisible = false;
            }
        }
    }

    public class MyGMapMarker : GMapMarker, ISerializable
    {
        private Bitmap Bitmap;
        public string Caption { get; set; }
        public Currency MyCurrency { get; set; }
        private CurrencyTypes myCurrencyTypes;
        public CurrencyTypes MyCurrencyTypes
        {
            get { return myCurrencyTypes; }
            set 
            { 
                myCurrencyTypes = value;
                if (myCurrencyTypes == CurrencyTypes.UsdSell)
                {
                    Caption = MyCurrency.UsdSell.ToString();
                }
                if (myCurrencyTypes == CurrencyTypes.UsdBuy)
                {
                    Caption = MyCurrency.UsdBuy.ToString();
                }
                if (myCurrencyTypes == CurrencyTypes.EurSell)
                {
                    Caption = MyCurrency.EurSell.ToString();
                }
                if (myCurrencyTypes == CurrencyTypes.EurBuy)
                {
                    Caption = MyCurrency.EurBuy.ToString();
                }
                if (myCurrencyTypes == CurrencyTypes.RurSell)
                {
                    Caption = MyCurrency.RurSell.ToString();
                }
                if (myCurrencyTypes == CurrencyTypes.RurBuy)
                {
                    Caption = MyCurrency.RurBuy.ToString();
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
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Marker.ToolTipPosition.X, Marker.ToolTipPosition.Y, 240, 160);
            rect.Offset(Marker.Offset.X - 86, Marker.Offset.Y - 171);
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
            g.DrawString(Marker.ToolTipText, Font, Foreground, rect, Format);
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
