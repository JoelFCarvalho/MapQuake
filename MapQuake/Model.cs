using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MapQuake
{
    public delegate void Delegado();

    public class Model : IRunsMVC
    {
        public event Delegado EvErroXML = null;

        String requestURL = null;

        public String mensagemMVC()
        {
            return ("Model");
        }

        //Obtem o feed de XML dados os parâmetros do utilizador e extrai as coordenadas dos eventos,
        //devolvendo-os numa lista de coordenadas
        public List<Coordenada> ObtemDados(String strDataMin, String strDataMax, String strLat, String strLon, String strRaio, String strMagMin, String strMagMax)
        {
            requestURL = "http://www.seismicportal.eu/fdsnws/event/1/query?limit=1000&";
            requestURL += String.IsNullOrEmpty(strDataMin) ? "" : "start=" + strDataMin + "&";
            requestURL += String.IsNullOrEmpty(strDataMax) ? "" : "end=" + strDataMax + "&";
            requestURL += String.IsNullOrEmpty(strLat) ? "" : "lat=" + strLat + "&";
            requestURL += String.IsNullOrEmpty(strLon) ? "" : "lon=" + strLon + "&";
            requestURL += String.IsNullOrEmpty(strRaio) ? "" : "maxradius=" + strRaio + "&";
            requestURL += String.IsNullOrEmpty(strMagMin) ? "" : "minmag=" + strMagMin + "&";
            requestURL += String.IsNullOrEmpty(strMagMax) ? "" : "maxmag=" + strMagMax + "&";
            requestURL += "format=xml";

            List<Coordenada> coords_epi = new List<Coordenada>();

            //Obter e processar dados XML
            XDocument xd = null;
            XNamespace xns = "http://quakeml.org/xmlns/bed/1.2";
            try
            {
                xd = XDocument.Load(requestURL);
            }
            catch(System.Net.WebException e)
            {
                //Apenas para debug, é apresentado o erro na consola
                System.Diagnostics.Debug.Write(e);
                //É utilizada a metodologia de assinatura dos Eventos e Delegados no tratamento da excepção
                EvErroXML();
            }
            if(!(xd == null))
            {
                var events = xd.Root.Descendants(xns + "eventParameters").Elements(xns + "event");
                foreach (var ev in events)
                {
                    var origin = ev.Descendants(xns + "origin");
                    String longitude = origin.Descendants(xns + "longitude").Descendants(xns + "value").Single().Value;
                    String latitude = origin.Descendants(xns + "latitude").Descendants(xns + "value").Single().Value;
                    coords_epi.Add(new Coordenada { Latitude = latitude, Longitude = longitude });
                }
            }
            return coords_epi;
        }
    }

    //classe representativa das coordenadas, facilita o manuseamento de um par latitude / longitude
    public class Coordenada
    {
        public String Latitude {get; set;}
        public String Longitude {get; set;}

        public override String ToString()
        {
            return Latitude + " ; " + Longitude;
        }
    }
}
