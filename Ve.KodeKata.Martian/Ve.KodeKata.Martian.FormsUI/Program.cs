using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ve.KodeKata.Martian.ExplorerManager;
using Ve.KodeKata.Martian.Model;


namespace Ve.KodeKata.Martian.FormsUI
{
    static class Program
    {

        private static Container container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegisterInstances();
            Application.Run(container.GetInstance<FrmMarsOne>());
        }


        public static void RegisterInstances()
        {
            container = new SimpleInjector.Container();

            container.Register<IExplorerManager, ExplorerManager.ExplorerManager>();
            container.Register<IPlanet, Planet>();
            container.Register<IExplorer, MarsOne>();
            container.Register<FrmMarsOne>();
        }
    }
}
