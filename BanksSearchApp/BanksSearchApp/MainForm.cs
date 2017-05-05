using GMap.NET;
using GMap.NET.WindowsForms;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                marker.BranchBank = branchBank;
                marker.DisplayedCurrencyType = CurrencyTypes.UsdSell;
                marker.ToolTip = new MyGMapToolTip(marker);
                marker.ToolTipMode = MarkerTooltipMode.Never;
                marker.ToolTipText = " ";
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
                if (tscbSelectCurrency.SelectedIndex == 0) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.DisplayedCurrencyType = CurrencyTypes.UsdSell;
                if (tscbSelectCurrency.SelectedIndex == 1) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.DisplayedCurrencyType = CurrencyTypes.EurSell;
                if (tscbSelectCurrency.SelectedIndex == 2) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.DisplayedCurrencyType = CurrencyTypes.RurSell;
            }

            if (tscbSelectAction.SelectedIndex == 1)
            {
                if (tscbSelectCurrency.SelectedIndex == 0) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.DisplayedCurrencyType = CurrencyTypes.UsdBuy;
                if (tscbSelectCurrency.SelectedIndex == 1) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.DisplayedCurrencyType = CurrencyTypes.EurBuy;
                if (tscbSelectCurrency.SelectedIndex == 2) foreach (MyGMapMarker marker in markersOverlay.Markers) marker.DisplayedCurrencyType = CurrencyTypes.RurBuy;
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
}
