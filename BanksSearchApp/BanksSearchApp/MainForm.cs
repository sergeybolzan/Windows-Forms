using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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
            gMapControl.Zoom = 16;
            //Устанавливаем центр приближения/удаления курсор мыши.
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            gMapControl.IgnoreMarkerOnMouseWheel = true;

            // НАВИГАЦИЯ ПО КАРТЕ 
            //CanDragMap - Если параметр установлен в True, пользователь может перетаскивать карту  помощью правой кнопки мыши. 
            gMapControl.CanDragMap = true;

            //Указываем что перетаскивание карты осуществляется с использованием левой клавишей мыши. По умолчанию - правая.
            gMapControl.DragButton = MouseButtons.Left;

            //Указываем элементу управления, что необходимо при открытии карты перейти по координатам 
            gMapControl.Position = new GMap.NET.PointLatLng(53.902800, 27.561759);


            //ОТОБРАЖЕНИЕ МАРКЕРОВ НА КАРТЕ 
            //MarkersEnabled - Если параметр установлен в True, любые маркеры, заданные вручную будет показаны.
            gMapControl.MarkersEnabled = true;

            //Создаем новый список маркеров, с указанием компонента в котором они будут использоваться и названием списка.
            GMapOverlay markersOverlay = new GMapOverlay("marker");
            //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат.
            GMap.NET.WindowsForms.Markers.GMarkerGoogle markerG = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(53.902542, 27.561781), GMarkerGoogleType.green);
            markerG.Size = new System.Drawing.Size(3, 3);
            markerG.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
            //Текст отображаемый при наведении на маркер.
            markerG.ToolTipText = "Объект №1";
            markerG.ToolTipMode = MarkerTooltipMode.Always;





            //Инициализация нового КРАСНОГО маркера, с указанием его координат.
            GMap.NET.WindowsForms.Markers.GMarkerGoogle markerR = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(53.902752, 27.561294), GMarkerGoogleType.red);
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
            //gMapControl.MouseClick += gMapControl1_MouseClick;

        }



        //void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    double X = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
        //    double Y = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
        //    GMapOverlay markersOverlay = new GMapOverlay(gMapControl, "NewMarkers");
        //    GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen markerG = new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new GMap.NET.PointLatLng(Y, X));
        //    markerG.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerG);
        //    markerG.ToolTipText = "Новый объект";
        //    markersOverlay.Markers.Add(markerG);
        //    gMapControl.Overlays.Add(markersOverlay);
        //}

    }

    public class GmapMarkerWithLabel : GMapMarker, ISerializable
    {
        private Font font;
        private GMarkerGoogle innerMarker;

        public string Caption;

        public GmapMarkerWithLabel(PointLatLng p, string caption, GMarkerGoogleType type)
            : base(p)
        {
            font = new Font("Arial", 14);
            innerMarker = new GMarkerGoogle(p, type);

            Caption = caption;
        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);
            g.DrawString(Caption, font, Brushes.Black, new PointF(LocalPosition.X - Size.Width / 2, LocalPosition.Y - Size.Height));
        }

        public override void Dispose()
        {
            if (innerMarker != null)
            {
                innerMarker.Dispose();
                innerMarker = null;
            }

            base.Dispose();
        }

        #region ISerializable Members

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        protected GmapMarkerWithLabel(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }

    public class GMapMarkerRect : GMarkerGoogle
    {
        //public Pen Pen;

        public GMapMarkerRect(PointLatLng p, GMarkerGoogleType type)
            : base(p, type)
        {
            //Pen = new Pen(Brushes.Red, 5);

            // do not forget set Size of the marker
            // if so, you shall have no event on it ;}
            //Size = new Size(55, 55);
        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);
            //g.DrawRectangle(Pen, new System.Drawing.Rectangle(LocalPosition.X - Size.Width / 2, LocalPosition.Y - Size.Height / 2, Size.Width, Size.Height));
            var rect = new RectangleF(LocalPosition.X - Size.Width / 2 - 1, LocalPosition.Y - Size.Height / 2, 57, 17);
            g.FillRectangle(Brushes.LightGreen, rect);
            g.DrawString("2.885", new Font("Arial", 14), Brushes.Black, new PointF(LocalPosition.X - Size.Width / 2, LocalPosition.Y - Size.Height / 2 - 2));

        }
    }
}

