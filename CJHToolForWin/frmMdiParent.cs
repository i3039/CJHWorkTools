using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CJH.CJHToolForWin
{
    public partial class frmMidParent : Form
    {
        public frmMidParent()
        {
            InitializeComponent();

            #region copy Open String
            copyNewName.Click += copyNewName_Click;
            copyNewTel.Click += copyNewTel_Click;
            copyNewAddress.Click += copyNewAddress_Click;
            #endregion copy Open String

            //Open
            tsmNewOpen.Click += tsmNewOpen_Click;
            tsmOpenSearch.Click += tsmOpenSearch_Click;
            tsmOpenImport.Click += tsmOpenImport_Click;

            //JobCode
            tsmJCodeSearch.Click += tsmJCodeSearch_Click;

            //Move and Replace
            tsmMoveReplace.Click += tsmMoveReplace_Click;
            
            //Repair
            tsmRepairBoarding.Click += tsmRepairBoarding_Click;
            tsmToFac.Click += tsmToFac_Click;

            ShowDefaultForm();
        }

        

        #region copy Open String

        string addrFirst = "";
        int addrNum = 0;
        private void GetNewAddress()
        {
            addrFirst = Common.RandomPhones.GetNumber(1, 9) + "组";
            addrNum = int.Parse(Common.RandomPhones.GetNumber(1, 45));
        }

        void copyNewAddress_Click(object sender, EventArgs e)
        {
            GetNewAddress();
            addrNum++;
            string copyText = addrFirst + "" + addrNum.ToString();
            Clipboard.SetText(copyText);
        }

        void copyNewTel_Click(object sender, EventArgs e)
        {
            string copyText = Common.RandomPhones.GetPhone();
            Clipboard.SetText(copyText);
        }

        void copyNewName_Click(object sender, EventArgs e)
        {
            string copyText = Common.RandomNames.GetDoubleName();
            Clipboard.SetText(copyText);
        }



        #endregion copy Open String

        private void ShowDefaultForm()
        {
            if (!FormIsOpened("frmMoveAndReplace"))
            {
                frmMoveAndReplace frmMR = new frmMoveAndReplace();
                frmMR.MdiParent = this;
                frmMR.WindowState = FormWindowState.Maximized;
                frmMR.Show();
            }
        }

        #region Repair
        void tsmToFac_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void tsmRepairBoarding_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion Repair

        #region Move and Replace
        void tsmMoveReplace_Click(object sender, EventArgs e)
        {
            ShowDefaultForm();
            //if (!FormIsOpened("frmMoveAndReplace"))
            //{
            //    frmMoveAndReplace frmMR = new frmMoveAndReplace();
            //    frmMR.MdiParent = this;
            //    frmMR.Show();
            //    //frmHHTCodeManage hhtcode = new frmHHTCodeManage();
            //    //hhtcode.MdiParent = this;
            //    //hhtcode.WindowState = FormWindowState.Maximized;
            //    //hhtcode.Show();
            //} 
        }

        #endregion Move and Replace

        #region JobCode
        void tsmJCodeSearch_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion JobCode

        #region Open
        void tsmOpenImport_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void tsmOpenSearch_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void tsmNewOpen_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion Open

        #region 窗体设置

        /// <summary>
        /// 窗体是否已激活
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private bool FormIsOpened(string formName)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name.Equals(formName))
                {
                    item.Visible = true;
                    item.WindowState = FormWindowState.Maximized;
                    //if (!formName.Equals("frmNewOpenCard"))
                    //{
                    //    item.WindowState = FormWindowState.Maximized;
                    //    //ShowFormSize(item);
                    //}
                    item.Activate();
                    return true;
                }
            }

            return false;
        }

        #endregion 窗体设置
    }
}
