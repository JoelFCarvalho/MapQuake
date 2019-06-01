using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapQuake
{
    public interface IRunsMVC
    {
        string mensagemMVC();
    }

    public class Controller : IRunsMVC
    {
        static Model model;
        static View view;
        static Controller controller;

        public String mensagemMVC()
        {
            return ("Controller");
        }

        [STAThread]
        static void Main()
        {
            model = new Model();
            view = new View();
            controller = new Controller();

            //Subscrição de eventos
            view.EvSair += CtrMensagemSair;
            view.EvSair += CtrSair;
            view.EvExportar += view.ExportaMapa;
            view.EvGerarMapa += CtrObtemDados;
            //Subscrição de evento de erro
            model.EvErroXML += new Delegado(view.MensagemErro);
            
            //Inicia execução do programa
            view.Arranca();
        }

        //Métodos que executam as acções dos eventos subscritos
        static void CtrMensagemSair(object sender, EventArgs e)
        {
            view.MensagemSair(model.mensagemMVC() + view.mensagemMVC() + controller.mensagemMVC());
        }

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
