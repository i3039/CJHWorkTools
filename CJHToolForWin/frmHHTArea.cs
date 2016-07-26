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
    public partial class frmHHTArea : Form
    {
        WS_Area.CJHWServiceBase wsArea = new WS_Area.CJHWServiceBase();

        List<Model.HHT_Area> areas = new List<Model.HHT_Area>();

        public frmHHTArea()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length != 9 && txtCode.Text.Length != 12)
            {
                MessageBox.Show("地区编码长度为9或12.");
                return;
            }

            areas.Clear();
            areas = Common.JsonHelper.ParseFormJson<List<Model.HHT_Area>>(wsArea.GetHHTAreaList(txtCode.Text));

            if (!areas.Exists(x => x.Code == txtCode.Text))
            {
                Model.HHT_Area hhtArea = new Model.HHT_Area();
                hhtArea.Area_Level = (txtCode.Text.Length == 9) ? 4 : 5;
                hhtArea.AreaName = txtHHTAreaName.Text;
                hhtArea.Code = txtCode.Text;

                //throw new NotImplementedException();
                string addString = wsArea.SaveHHTArea(Common.JsonHelper.GetJosn<Model.HHT_Area>(hhtArea));

                if (addString.Equals("OK"))
                {
                    areas.Add(hhtArea);
                }
            }

            ListShow(areas);
        }

        void ListShow(List<Model.HHT_Area> hhtAreas)
        {
            //hhtAreas.Sort();
            dgvList.DataSource = hhtAreas;
            dgvList.AutoGenerateColumns = false;

            dgvList.Columns["Code"].HeaderText = "地区编码";
            dgvList.Columns["Code"].Width = 90;
            dgvList.Columns["AreaName"].HeaderText = "地区名称";
            dgvList.Columns["AreaName"].Width = 180;

            dgvList.Columns["Area_Level"].Visible = false;
        }
    }
}
