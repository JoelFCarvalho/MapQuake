using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapQuake
{
    public partial class View : Form, IRunsMVC
    {
        public event EventHandler EvGerarMapa = null;
        public event EventHandler EvExportar = null;
        public event EventHandler EvSair = null;

        public String mensagemMVC()
        {
            return ("View");
        }

        public View()
        {
            InitializeComponent();

            //Formato da data nas caixas de escolha
            boxDataMin.CustomFormat = "yyyy-MM-dd";
            boxDataMax.CustomFormat = "yyyy-MM-dd";

            //Inicialização SharpMap
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("Mundo");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile("..\\..\\Shapes\\TM_WORLD_BORDERS-0.3.shp", true);
            mapBox1.Map.Layers.Add(vlay);
            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
            mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }

        public void Arranca()
        {
            ShowDialog();
        }

        //Actualiza o mapa, adicionando um layer com os novos epicentros recolhidos do feed
        public void GeraEpicentrosMapa(List<Coordenada> epicentros)
        {
            SharpMap.Layers.VectorLayer vlay2 = new SharpMap.Layers.VectorLayer("Epicentros");
            Collection<GeoAPI.Geometries.IGeometry> geomColl = new Collection<GeoAPI.Geometries.IGeometry>();
            GeoAPI.GeometryServiceProvider.Instance = new NetTopologySuite.NtsGeometryServices();
            GeoAPI.Geometries.IGeometryFactory gf = GeoAPI.GeometryServiceProvider.Instance.CreateGeometryFactory();
            for(int i=0; i < epicentros.Count; i++)
            {
                double lat = Convert.ToDouble(epicentros.ElementAt(i).Latitude, CultureInfo.InvariantCulture);
                double lon = Convert.ToDouble(epicentros.ElementAt(i).Longitude, CultureInfo.InvariantCulture);
                geomColl.Add(gf.CreatePoint(new GeoAPI.Geometries.Coordinate(lon, lat)));
            }
            vlay2.DataSource = new SharpMap.Data.Providers.GeometryProvider(geomColl);
            mapBox1.Map.Layers.Add(vlay2);
            mapBox1.Refresh();
        }

        //Exporta o mapa para ficheiro png
        public void ExportaMapa(object sender, EventArgs e)
        {
            Image imgMapa = mapBox1.Map.GetMap();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                imgMapa.Save(sfd.FileName, format);
        }

        public void MensagemSair(string mensagem)
        {
            MessageBox.Show("Obrigado por utilizar!\nEste software foi elaborado pela metodologia \n\n" + mensagem, "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensagemErro()
        {
            MessageBox.Show("O servidor retornou uma resposta vazia para uma procura \n" +
                "pelos critérios que seleccionou.\n\n" +
                "Por favor, tente com outros critérios.", "Aviso",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Métodos inspectores dos parâmetros do utilizador
        public string paramDataMin()
        {
            return boxDataMin.Text;
        }
        public string paramDataMax()
        {
            return boxDataMax.Text;
        }
        public string paramLat()
        {
            return boxLat.Text;
        }
        public string paramLon()
        {
            return boxLon.Text;
        }
        public string paramRaio()
        {
            return boxRaio.Text;
        }
        public string paramMagMin()
        {
            return boxMagMin.Text;
        }
        public string paramMagMax()
        {
            return boxMagMax.Text;
        }

        //Eventos dos botões
        private void btnGerarMapa_Click(object sender, EventArgs e)
        {
            EvGerarMapa?.Invoke(sender, e);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            EvExportar?.Invoke(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            EvSair?.Invoke(sender, e);
        }
    }
}
