using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanksSearchApp
{
    public partial class MainForm : Form
    {
        private GMapControl gMapControl;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMap();
        }

        private void LoadMap()
        {
            // Создание элемента, отображающего карту !
            gMapControl = new GMapControl();
            // Растягивание элемента на все окно!
            gMapControl.Dock = DockStyle.Fill;
            // Добавление элемента 
            this.Controls.Add(gMapControl);

            // ОБЩИЕ НАСТРОЙКИ КАРТЫ 
            //Указываем, что будем использовать карты OpenStreetMap.
            gMapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            // Указываем источник данных карты (выбран: интренети или локальный кэш)
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            // МАСШТАБИРОВАНИЕ
            //Указываем значение максимального приближения.
            gMapControl.MaxZoom = 18;
            //Указываем значение минимального приближения.
            gMapControl.MinZoom = 2;
            //Указываем, что при загрузке карты будет использоваться 16ти кратной приближение.
            gMapControl.Zoom = 17;
            //Устанавливаем центр приближения/удаления курсор мыши.
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            // НАВИГАЦИЯ ПО КАРТЕ 
            //CanDragMap - Если параметр установлен в True, пользователь может перетаскивать карту  помощью правой кнопки мыши. 
            gMapControl.CanDragMap = true;

            //Указываем что перетаскивание карты осуществляется с использованием левой клавишей мыши. По умолчанию - правая.
            gMapControl.DragButton = MouseButtons.Left;

            //Указываем элементу управления, что необходимо при открытии карты перейти по координатам 
            gMapControl.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);


            // ОТОБРАЖЕНИЕ МАРКЕРОВ НА КАРТЕ 
            //MarkersEnabled - Если параметр установлен в True, любые маркеры, заданные вручную будет показаны.
            gMapControl.MarkersEnabled = true;

            //Создаем новый список маркеров, с указанием компонента в котором они будут использоваться и названием списка.
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl, "marker");
            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат.
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG = new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(53.902542, 27.561781));
            markerG.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
            //Текст отображаемый при наведении на маркер.
            markerG.ToolTipText = "Объект №1";

            //Инициализация нового КРАСНОГО маркера, с указанием его координат.
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markerR = new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(new GMap.NET.PointLatLng(53.902752, 27.561294));
            markerR.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapBaloonToolTip(markerR);
            //Текст отображаемый при наведении на маркер.
            markerR.ToolTipText = "Объект №2";

            //Добавляем маркеры в список маркеров.
            //Зеленый маркер
            markersOverlay.Markers.Add(markerG);
            //Красный маркет
            markersOverlay.Markers.Add(markerR);
            //Добавляем в компонент, список маркеров.
            gMapControl.Overlays.Add(markersOverlay);

            // СОБЫТИЯ ПО КАРТЕ !
            gMapControl.MouseClick += gMapControl1_MouseClick;

        }



        void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            double X = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl, "NewMarkers");
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG = new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(Y, X));
            markerG.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
            markerG.ToolTipText = "Новый объект";
            markersOverlay.Markers.Add(markerG);
            gMapControl.Overlays.Add(markersOverlay);
        }

    }
}
