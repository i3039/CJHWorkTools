using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CJH.CJHToolForWin
{
    public partial class frmMidParent : Form
    {
        public frmMidParent()
        {
            InitializeComponent();

            this.Load += frmMidParent_Load;
            this.LocationChanged += frmMidParent_LocationChanged;

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
            tsmActionM.Click += tsmActionM_Click;
            
            //Repair
            tsmRepairBoarding.Click += tsmRepairBoarding_Click;
            tsmToFac.Click += tsmToFac_Click;

            ShowDefaultForm();
        }

        void tsmActionM_Click(object sender, EventArgs e)
        {
            if (!FormIsOpened("frmActionMode"))
            {
                frmActionMode frmAM = new frmActionMode();
                frmAM.MdiParent = this;
                frmAM.WindowState = FormWindowState.Maximized;
                frmAM.Show();
            }
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

        #region 靠边隐藏

        private void frmMidParent_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            Timer checkDockTimer = new Timer();
            checkDockTimer.Tick += new EventHandler(StopRectTimer_Tick);
            checkDockTimer.Interval = 100;
            checkDockTimer.Enabled = true;
        }


        private void StopRectTimer_Tick(object sender, EventArgs e)
        {
            //如果鼠标在窗体上，则根据停靠位置显示整个窗体
            if (this.Bounds.Contains(Cursor.Position))
            {
                switch (this.StopDock)
                {
                    case AnchorStyles.Top:
                        this.Location = new Point(this.Location.X, 0);
                        break;
                    case AnchorStyles.Bottom:
                        this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - this.Height);
                        break;
                    case AnchorStyles.Left:
                        this.Location = new Point(0, this.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, this.Location.Y);
                        break;
                }
            }
            else  //如果鼠标离开窗体，则根据停靠位置隐藏窗体，但须留出部分窗体边缘以便鼠标选中窗体
            {
                switch (this.StopDock)
                {
                    case AnchorStyles.Top:
                        this.Location = new Point(this.Location.X, (this.Height - 3) * (-1));
                        break;
                    case AnchorStyles.Bottom:
                        this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - 5);
                        break;
                    case AnchorStyles.Left:
                        this.Location = new Point((-1) * (this.Width - 3), this.Location.Y);
                        break;
                    case AnchorStyles.Right:
                        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 2, this.Location.Y);
                        break;
                }
            }
        }

        internal AnchorStyles StopDock = AnchorStyles.None;

        /// <summary>
        /// 更改窗体的位置时，根据和各个窗体边缘的距离赋值停靠的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMidParent_LocationChanged(object sender, EventArgs e)
        {
            if (this.Top <= 0)
            {
                this.StopDock = AnchorStyles.Top;
            }
            else if (this.Bottom >= Screen.PrimaryScreen.Bounds.Height)
            {
                this.StopDock = AnchorStyles.Bottom;
            }
            else if (this.Left <= 0)
            {
                this.StopDock = AnchorStyles.Left;
            }
            else if (this.Left >= Screen.PrimaryScreen.Bounds.Width - this.Width)
            {
                this.StopDock = AnchorStyles.Right;
            }
            else
            {
                this.StopDock = AnchorStyles.None;
            }
        }

        #endregion 靠边隐藏

        #endregion 窗体设置
    }
}
