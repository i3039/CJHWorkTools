using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CJH.CJHWooks
{
    public partial class frmBaseSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSearch.Click += btnSearch_Click;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("code", txtCode.Text.Trim());
            XmlDocument xd = WebServiceCaller.QuerySoapWebService("http://localhost:6311/CJHWServiceBase.asmx", "GetAreaName", ht);
            showResult.InnerText = xd.OuterXml;
        }
        //调用示例：
        //Hashtable ht = new Hashtable();  //Hashtable 为webservice所需要的参数集
        //ht.Add("str", "test");
        //ht.Add("b", "true");
        //XmlDocument xx = WebSvcCaller.QuerySoapWebService("http://localhost:81/service.asmx", "HelloWorld", ht);
        //MessageBox.Show(xx.OuterXml);
        //http://localhost:6311/CJHWServiceBase.asmx?op=GetAreaName
    }
}