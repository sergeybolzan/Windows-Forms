using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
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
            gMapControl.ShowCenter = false;
            gMapControl.MarkersEnabled = true;

            GMapOverlay markersOverlay = new GMapOverlay();
            gMapControl.Overlays.Add(markersOverlay);



            GMarkerGoogle markerG = new GMarkerGoogle(new PointLatLng(53.902542, 27.561781), GMarkerGoogleType.green);
            markerG.ToolTip = new GMapRoundedToolTip(markerG);
            markerG.ToolTipText = "Объект №1";
            markersOverlay.Markers.Add(markerG);

            GMarkerGoogle markerR = new GMarkerGoogle(new PointLatLng(53.902752, 27.561294), GMarkerGoogleType.red);
            markerR.ToolTip = new GMapBaloonToolTip(markerR);
            markerR.ToolTipText = "Объект №2";
            markersOverlay.Markers.Add(markerR);

            MyGMapMarkerImage imageMarker2 = new MyGMapMarkerImage(new PointLatLng(53.90227, 27.560604), "2.235");
            imageMarker2.ToolTip = new MyGMapToolTip(imageMarker2);
            imageMarker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            imageMarker2.ToolTipText = "123456789123456789123456789123456789123456789";
            markersOverlay.Markers.Add(imageMarker2);


            //gMapControl.MouseClick += gMapControl1_MouseClick;
        }
        //void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    double X = gMapControl.FromLocalToLatLng(e.X, e.Y).Lng;
        //    double Y = gMapControl.FromLocalToLatLng(e.X, e.Y).Lat;
        //    GMapOverlay markersOverlay = new GMapOverlay();
        //    MyGMapMarkerImage markerG = new MyGMapMarkerImage(new GMap.NET.PointLatLng(Y, X), "3.345");
        //    markerG.ToolTip = new MyGMapToolTip(markerG);
        //    markerG.ToolTipText = "Новый объект";
        //    gMapControl.Overlays.Add(markersOverlay);
        //    markersOverlay.Markers.Add(markerG);
        //}
    }

    public class MyGMapMarkerImage : GMapMarker, ISerializable
    {
        Bitmap Bitmap;
        public string Caption;
        public MyGMapMarkerImage(PointLatLng p, string caption)
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

        protected MyGMapMarkerImage(SerializationInfo info, StreamingContext context)
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
