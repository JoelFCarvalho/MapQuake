using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapQuake
{
    public class Controller
    {
        static Model model;
        static View view;

        [STAThread]
        static void Main()
        {
            model = new Model();
            view = new View();

            //Subscrição de eventos
            view.EvSair += CtrSair;
            view.EvExportar += view.ExportaMapa;
            view.EvGerarMapa += CtrObtemDados;
            //Subscrição de evento de erro
            model.EvErroXML += view.MensagemErro;
            
            //Inicia execução do programa
            view.Arranca();
        }

        //Métodos que executam as acções dos eventos subscritos
        static void CtrSair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static void CtrObtemDados(object sender, EventArgs e)
        {
            List<Coordenada> epicentros = null;
            epicentros = model.ObtemDados(view.paramDataMin(), view.paramDataMax(), view.paramLat(), view.paramLon(), view.paramRaio(), view.paramMagMin(), view.paramMagMax());
            view.GeraEpicentrosMapa(epicentros);
        }
    }
}
