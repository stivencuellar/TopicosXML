using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace TopicosXML
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDecoratorDoc = null;
        XmlDocument xmlFuenteDoc = null;
        XmlDocument xmlResultadoDoc = null;
        string xmlDecorator = "";
        string xmlFuente = "";
        private static string RootNodeName = "cora:set";
        XmlNodeList rootNodeDecorador = null;

        public Form1()
        {
            InitializeComponent();
            xmlDecoratorDoc = new XmlDocument();
            xmlFuenteDoc = new XmlDocument();
            xmlResultadoDoc = new XmlDocument();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargarDecorador_Click(object sender, EventArgs e)
        {
            cargarDecorador();
        }

        private void btnCargarFuente_Click(object sender, EventArgs e)
        {
            cargarFuente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
           // leerDocorador();
            validadorAccion();
        }

        private void validadorAccion()
        {
            XPathDocument document = new XPathDocument(xmlDecorator);
            XPathNavigator navigator = document.CreateNavigator();
            XmlNamespaceManager manager = new XmlNamespaceManager(navigator.NameTable);
            manager.AddNamespace("cora", "http://www.xmlstairways.com/cora");

            String xPathInsert = "cora:set/cora:decorator/cora:insert";
            XPathExpression queryInsert = navigator.Compile(xPathInsert);
            queryInsert.SetContext(manager);
            XPathNodeIterator nodesInsert = navigator.Select(queryInsert);
            XmlNode nodeDecorInsert = xmlDecoratorDoc.SelectSingleNode("/cora:set/cora:decorator/cora:insert", manager);

            String xPathAppend = "cora:set/cora:decorator/cora:append";
            XPathExpression queryAppend = navigator.Compile(xPathAppend);
            queryAppend.SetContext(manager);
            XPathNodeIterator nodesAppend = navigator.Select(queryAppend);
            XmlNode node = xmlFuenteDoc.SelectSingleNode("/page");
            XmlNode nodeDecorAppend = xmlDecoratorDoc.SelectSingleNode("/cora:set/cora:decorator/cora:append",manager);
            //string mamu = xmlFuenteDoc
            //MessageBox.Show(mamu);

            String xPathReplace = "cora:set/cora:decorator/cora:replace";
            XPathExpression queryReplace = navigator.Compile(xPathReplace);
            queryReplace.SetContext(manager);
            XPathNodeIterator nodesReplace = navigator.Select(queryReplace);
            XmlNode nodeR = xmlFuenteDoc.SelectSingleNode("/page/content");
            XmlNode nodeDecorReplace = xmlDecoratorDoc.SelectSingleNode("/cora:set/cora:decorator/cora:replace", manager);

            rtxtResultado.Clear();
            //rtxtFuente.Clear();

            if (nodesInsert.MoveNext())
            {
                //Consulta el nombre del nodo y el contenido
                string elem = nodeDecorInsert.FirstChild.LocalName;
                string ContElem = nodeDecorInsert.InnerText;

                //Creación del elemento para insertar!
                XmlElement newElement = xmlFuenteDoc.CreateElement(elem);
                newElement.InnerText = ContElem;
                //node.

                //Guardo el resultado y lo muestro!
                string resul = @"C:\Users\Manuela\Downloads\cora\tests\01 - append\newDoc.xml";
                xmlFuenteDoc.Save(resul);
                xmlResultadoDoc.Load(resul);
                rtxtResultado.LoadFile(resul, RichTextBoxStreamType.PlainText);
            }
            if (nodesAppend.MoveNext())
            {
                //Consulta el nombre del nodo y el contenido
                string elem = nodeDecorAppend.FirstChild.LocalName;
                string ContElem = nodeDecorAppend.InnerText;

                //Creación del elemento para agregar!
                XmlElement newElement = xmlFuenteDoc.CreateElement(elem);
                newElement.InnerText = ContElem;
                node.AppendChild(newElement);

                //Guardo el resultado y lo muestro!
                string resul = @"C:\Users\Manuela\Downloads\cora\tests\01 - append\newDoc.xml";
                xmlFuenteDoc.Save(resul);
                xmlResultadoDoc.Load(resul);
                rtxtResultado.LoadFile(resul, RichTextBoxStreamType.PlainText);
            } 
            if (nodesReplace.MoveNext())
            {
                //Consulta el nombre del nodo y el contenido
                string elem = nodeDecorReplace.FirstChild.LocalName;
                string ContElem = nodeDecorReplace.InnerText;

                XmlNode viejoNodo = xmlFuenteDoc.SelectSingleNode("/page");

                XmlElement newElement = xmlFuenteDoc.CreateElement(elem);
                newElement.InnerText = ContElem;

                XmlDocumentFragment xmlDocFragment = xmlFuenteDoc.CreateDocumentFragment();
                xmlDocFragment.InnerXml = "<" + elem + ">" + ContElem + "</" + elem + ">";

                viejoNodo.ReplaceChild(xmlDocFragment, viejoNodo.LastChild);

                //Guardo el resultado y lo muestro!
                string resul = @"C:\Users\Manuela\Downloads\cora\tests\03 - replace\newDoc.xml";
                xmlFuenteDoc.Save(resul);
                xmlResultadoDoc.Load(resul);
                rtxtResultado.LoadFile(resul, RichTextBoxStreamType.PlainText);
            }

            /*
            XmlNamespaceManager manager = new XmlNamespaceManager(xmlDecoratorDoc.NameTable);
            manager.AddNamespace("cora", "http://www.xmlstairways.com/cora");
            //String xPath = "cora:set/cora:decorator";
            rtxtFuente.Clear();
            XPathDocument xpDoc = new XPathDocument(xmlDecorator);
            XPathNavigator xpNav = xpDoc.CreateNavigator();
            XPathExpression xpExpression = xpNav.Compile(xPath);
            //xmlDecoratorDoc.Load(xmlDecorator);
            rtxtResultado.Text = xmlDecoratorDoc.SelectSingleNode(xpExpression.Expression, manager).InnerText;
            //XmlNodeList myNodeList = xmlDecoratorDoc.SelectNodes(xPath, manager);
            XPathNodeIterator xpIter = xpNav.Select(xpExpression);
             * 
            while (nodesInsert.MoveNext())
            {
                rtxtFuente.AppendText(nodesInsert.Current.LocalName);
                if (nodesInsert.Current.HasChildren)
                {
                    rtxtResultado.AppendText("Si tengo hijos :)");
                }
            }*/

        }

        public void cargarDecorador()
        {
            ofdXMLSelector.Title = "Buscar Archivo XML DECORATOR";
            ofdXMLSelector.Filter = "Archivos XML | decorator.xml";
            if (ofdXMLSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xmlDecorator = ofdXMLSelector.FileName;
                xmlDecoratorDoc.Load(xmlDecorator);
                rtxtDecorador.LoadFile(xmlDecorator, RichTextBoxStreamType.PlainText);
                rootNodeDecorador = xmlDecoratorDoc.GetElementsByTagName(RootNodeName);
            }
        }

        public void cargarFuente() 
        {
            ofdXMLSelector.Title = "Buscar Archivo XML SOURCE";
            ofdXMLSelector.Filter = "Archivos XML | source.xml";
            if (ofdXMLSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xmlFuente = ofdXMLSelector.FileName;
                xmlFuenteDoc.Load(xmlFuente);
                rtxtFuente.LoadFile(xmlFuente, RichTextBoxStreamType.PlainText);
            } 
        }

        public void leerDocorador()
        {

        }
    }
}
