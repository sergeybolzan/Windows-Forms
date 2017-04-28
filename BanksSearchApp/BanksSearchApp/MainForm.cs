using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
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
            gMapControl = new GMapControl();
            gMapControl.Dock = DockStyle.Fill;
            this.Controls.Add(gMapControl);

            gMapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            gMapControl.MaxZoom = 18;
            gMapControl.MinZoom = 2;
            gMapControl.Zoom = 17;
            gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            gMapControl.IgnoreMarkerOnMouseWheel = true;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.Position = new PointLatLng(53.902800, 27.561759);
            gMapControl.MarkersEnabled = true;

            GMapOverlay markersOverlay = new GMapOverlay("marker");
            gMapControl.Overlays.Add(markersOverlay);



            GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(53.902542, 27.561781), GMarkerGoogleType.green);
            markerG.ToolTip = new GMapRoundedToolTip(markerG);
            markerG.ToolTipText = "Объект №1";
            markerG.ToolTipMode = MarkerTooltipMode.Always;
            markersOverlay.Markers.Add(markerG);

            GMarkerGoogle markerR = new GMarkerGoogle(new PointLatLng(53.90227, 27.560604), GMarkerGoogleType.red);
            markerR.ToolTip = new GMapBaloonToolTip(markerR);
            markerR.ToolTipText = "Объект №2";
            markersOverlay.Markers.Add(markerR);

            GMarkerGoogle imageMarker = new GMarkerGoogle(new PointLatLng(53.902752, 27.561294), Properties.Resources.label);
            markersOverlay.Markers.Add(imageMarker);

            MyGMapMarkerImage imageMarker2 = new MyGMapMarkerImage(new PointLatLng(53.90227, 27.560604));
            markersOverlay.Markers.Add(imageMarker2);
            imageMarker2.ToolTip = new GMapToolTip(imageMarker2);
            markerG.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            imageMarker2.ToolTipText = "asdasdadadada";
            //imageMarker2.ToolTipPosition = imageMarker2.


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

    public class MyGMapMarkerImage : GMapMarker, ISerializable
    {
        Bitmap Bitmap;
        public MyGMapMarkerImage(PointLatLng p)
            : base(p)
        {
            this.Bitmap = Properties.Resources.label;
            Size = new System.Drawing.Size(Bitmap.Width, Bitmap.Height);
            Offset = new Point(-Size.Width / 2, -Size.Height);
        }

        public override void OnRender(Graphics g)
        {
            g.DrawImage(Bitmap, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
            g.DrawString("2.885", new Font("Arial", 13), Brushes.Black, new PointF(LocalPosition.X + 10, LocalPosition.Y + 4));
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

        protected MyGMapMarkerImage(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endregion
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
}

