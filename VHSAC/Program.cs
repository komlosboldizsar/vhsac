using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using VHSAC.Logging;
using VHSAC.Model;
using VHSAC.Model.CaptureDevice;
using VHSAC.Model.Router;
using VHSAC.Model.VTR;
using VHSAC.Model.VTRController;

namespace VHSAC
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {

            _myFileLogger = new FileLogger("vhsac");

            loadXML();
            BatchManager.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }

        private static FileLogger _myFileLogger;

        private static List<VTR> _vtrs = new List<VTR>();
        private static Dictionary<string, IRouter> _routers = new Dictionary<string, IRouter>();
        private static Dictionary<string, Controller> _controllers = new Dictionary<string, Controller>();
        private static Dictionary<string, ICaptureDevice> _captureDevices = new Dictionary<string, ICaptureDevice>();

        public static IReadOnlyList<VTR> VTRs
        {
            get { return _vtrs.AsReadOnly(); }
        }

        private static readonly string CONFIG_XML_PATH = @"config.xml";

        private static void loadXML()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(CONFIG_XML_PATH);
            XmlNode rootNode = doc.DocumentElement;

            XmlNode settingsNode = rootNode.SelectSingleNode("settings");
            loadXML_settings(settingsNode);

            XmlNode routersNode = rootNode.SelectSingleNode("routers");
            loadXML_routers(routersNode);

            XmlNode controllersNode = rootNode.SelectSingleNode("controllers");
            loadXML_controllers(controllersNode);

            XmlNode capturedevicesNode = rootNode.SelectSingleNode("capturedevices");
            loadXML_captureDevices(capturedevicesNode);

            XmlNode vtrsNode = rootNode.SelectSingleNode("vtrs");
            loadXML_vtrs(vtrsNode);

        }

        private static void loadXML_settings(XmlNode settingsNode)
        {
            XmlNode filepathNode = settingsNode.SelectSingleNode("savepath");
            Settings.FileSavepath = filepathNode.Value;
        }

        private static void loadXML_routers(XmlNode routersNode)
        {
            foreach(XmlNode node in routersNode.ChildNodes)
            {
                string id = node.Attributes.GetNamedItem("id").Value;
                string name = node.Attributes.GetNamedItem("name").Value;
                if (node.Name == "leitchrouter")
                {
                    string serialport = node.Attributes.GetNamedItem("serialport").Value;
                    IRouter router = new LeitchRouter(name, serialport);
                    _routers.Add(id, router);
                }
            }
        }

        private static void loadXML_controllers(XmlNode controllersNode)
        {
            foreach (XmlNode node in controllersNode.ChildNodes)
            {
                if (node.Name == "controller")
                {
                    string id = node.Attributes.GetNamedItem("id").Value;
                    string name = node.Attributes.GetNamedItem("name").Value;
                    string serialport = node.Attributes.GetNamedItem("serialport").Value;
                    Controller controller = new Controller(name, serialport);
                    _controllers.Add(id, controller);
                }
            }
        }

        private static void loadXML_captureDevices(XmlNode capturedevicesNode)
        {
            foreach (XmlNode node in capturedevicesNode.ChildNodes)
            {
                string id = node.Attributes.GetNamedItem("id").Value;
                string name = node.Attributes.GetNamedItem("name").Value;
                if (node.Name == "windvcapture")
                {
                    ICaptureDevice captureDevice = new WinDVCaptureDevice(/*name*/);
                    _captureDevices.Add(id, captureDevice);
                }
            }
        }

        private static void loadXML_vtrs(XmlNode vtrsNode)
        {
            foreach (XmlNode node in vtrsNode.ChildNodes)
            {

                string name = node.Attributes.GetNamedItem("name").Value;
                string captureDeviceId = node.Attributes.GetNamedItem("capturedevice").Value;
                string controllerId = node.Attributes.GetNamedItem("controller").Value;
                string controllerChannelStr = node.Attributes.GetNamedItem("controllerchannel").Value;

                if (!_captureDevices.ContainsKey(captureDeviceId))
                    throw new Exception(/* TODO */);
                ICaptureDevice captureDevice = _captureDevices[captureDeviceId];

                if (!_controllers.ContainsKey(controllerId))
                    throw new Exception(/* TODO */);
                Controller controller = _controllers[controllerId];

                if (!int.TryParse(controllerChannelStr, out int controllerChannel))
                    throw new Exception(/* TODO */);
                Controller.Adapter controllerAdapter = controller.GetAdapter(controllerChannel);

                List<IRouterCrosspoint> routerCrosspoints = new List<IRouterCrosspoint>();
                foreach (XmlNode childNode in node.ChildNodes)
                {

                    string routerId = childNode.Attributes.GetNamedItem("router").Value;
                    if (!_routers.ContainsKey(routerId))
                        throw new Exception(/* TODO */);
                    IRouter router = _routers[routerId];

                    if (childNode.Name == "leitchcrosspoint")
                    {

                        LeitchRouter leitchRouter = router as LeitchRouter;
                        if(leitchRouter == null)
                            throw new Exception(/* TODO */);

                        string levelStr = childNode.Attributes.GetNamedItem("level").Value;
                        if (!int.TryParse(levelStr, out int level) || (level < 0))
                            throw new Exception(/* TODO */);

                        string destinationStr = childNode.Attributes.GetNamedItem("destination").Value;
                        if (!int.TryParse(destinationStr, out int destination) || (destination < 0))
                            throw new Exception(/* TODO */);

                        string sourceStr = childNode.Attributes.GetNamedItem("source").Value;
                        if (!int.TryParse(sourceStr, out int source) || (source < 0))
                            throw new Exception(/* TODO */);

                        IRouterCrosspoint crosspoint = leitchRouter.GetCrosspoint(level, destination, source);
                        routerCrosspoints.Add(crosspoint);

                    }

                }

                VTR vtr = new VTR(name, routerCrosspoints, captureDevice, controllerAdapter);
                _vtrs.Add(vtr);

            }
        }

    }
}
