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
            btnSearch.Click += btnSearch_Click;
            dgvList.CellContentClick += dgvList_CellContentClick;

            txtCode.KeyPress += txtCode_KeyPress;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            //areas.Clear();
            areas = Common.JsonHelper.ParseFormJson<List<Model.HHT_Area>>(wsArea.GetHHTAreaListByName(txtHHTAreaName.Text));
            TextClear();
            ListShow();
        }

        void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtCode.Text.Length != 9 && txtCode.Text.Length != 12)
                {
                    return;
                }

                areas = Common.JsonHelper.ParseFormJson<List<Model.HHT_Area>>(wsArea.GetHHTAreaList(txtCode.Text));

                if (areas.Exists(x => x.Code == txtCode.Text))
                {
                    //MessageBox.Show(string.Format("{0} 已存在。", txtCode.Text));
                    TextClear();
                    lblRemark.Text = wsArea.GetTheAreaName(txtCode.Text.Substring(0, 6));
                    ListShow();
                }
            }
            catch { }
            
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length != 9 && txtCode.Text.Length != 12)
            {
                MessageBox.Show("地区编码长度为9或12.");
                return;
            }
            if (txtHHTAreaName.Text.Trim().Equals(""))
            {
                MessageBox.Show("地区名称不可为空.");
                return;
            }

            //areas.Clear();
            areas = Common.JsonHelper.ParseFormJson<List<Model.HHT_Area>>(wsArea.GetHHTAreaList(txtCode.Text));

            Model.HHT_Area hhtArea = new Model.HHT_Area();
            if (!areas.Exists(x => x.Code == txtCode.Text))
            {
                hhtArea.Area_Level = (txtCode.Text.Length == 9) ? 4 : 5;
                hhtArea.AreaName = txtHHTAreaName.Text;
                hhtArea.Code = txtCode.Text;

                string addString = wsArea.SaveHHTArea(Common.JsonHelper.GetJosn<Model.HHT_Area>(hhtArea));

                if (addString.Equals("OK"))
                {
                    areas.Add(hhtArea);
                }
            }
            string remark = string.Format("说明:{0}", wsArea.GetAreaName(txtCode.Text.Substring(0, 6)).ToString());
            string areaName = txtHHTAreaName.Text;
            TextClear();
            lblAreaName.Text = areaName;
            lblRemark.Text = remark;

            ListShow();
        }

        private void TextClear()
        {
            txtCode.Text = "";
            txtHHTAreaName.Text = "";
            lblAreaName.Text = "";
            lblRemark.Text = "";
        }

        void ListShow()
        {
            dgvList.DataSource = areas;
            dgvList.AutoGenerateColumns = false;

            dgvList.Columns["Code"].HeaderText = "地区编码";
            dgvList.Columns["Code"].Width = 86;
            //dgvList.Columns["Code"].DisplayIndex = 2;
            dgvList.Columns["AreaName"].HeaderText = "地区名称";
            dgvList.Columns["AreaName"].Width = 140;
            //dgvList.Columns["AreaName"].DisplayIndex = 3;

            dgvList.Columns["Area_Level"].Visible = false;

            bool isExist = false;
            foreach (DataGridViewColumn item in dgvList.Columns)
            {
                if (item.Name.Equals("BtnDelete"))
                {
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                DataGridViewButtonColumn colBtnDelete = new DataGridViewButtonColumn();
                colBtnDelete.HeaderText = "";
                colBtnDelete.Name = "BtnDelete";
                colBtnDelete.UseColumnTextForButtonValue = true;
                colBtnDelete.Text = "删除";
                colBtnDelete.Width = 40;
                //colBtnDelete.DisplayIndex = 1;
                this.dgvList.Columns.Add(colBtnDelete);
            }
        }

        void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string code = dgvList.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            int row = dgvList.Rows[e.RowIndex].Index;
            if (dgvList.Columns[e.ColumnIndex].Name == "BtnDelete")
            {
                DialogResult drBtn = MessageBox.Show("确定要删除吗？", "系统提示", MessageBoxButtons.YesNo);
                if (drBtn == DialogResult.Yes)
                {
                    string delStr = wsArea.DelHHTArea(code);
                    if (delStr.Equals("OK"))
                    {
                        areas.Clear();
                        areas = Common.JsonHelper.ParseFormJson<List<Model.HHT_Area>>(wsArea.GetHHTAreaList(code));
                        ListShow();
                    }
                    else
                    {
                        MessageBox.Show(delStr);
                    }
                }
            }
        }

    }
}
