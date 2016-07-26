using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
//using Excel;

namespace CJH.Common
{
    public class ExcelHelper
    {
        //Excel.Application appli = new Excel.Application();

        ///// <summary>
        ///// 生成开户数据DataTable
        ///// </summary>
        ///// <param name="range"></param>
        ///// <param name="jcode"></param>
        ///// <returns></returns>
        //private System.Data.DataTable GetSaveData(Excel.Range range, string jcode)
        //{
        //    System.Data.DataTable dt = new System.Data.DataTable("ImportData");
        //    dt.Columns.Add("Job_Code");
        //    dt.Columns.Add("HHT_ID");
        //    dt.Columns.Add("Customer");
        //    dt.Columns.Add("State");
        //    dt.Columns.Add("SCID");
        //    dt.Columns.Add("CAID");
        //    dt.Columns.Add("Board");
        //    dt.Columns.Add("Address");

        //    int rowCount = range.Rows.Count;
        //    for (int i = 1; i <= rowCount; i++)
        //    {
        //        string state = ((Excel.Range)range.get_Item(i, 4)).Text;
        //        string scid = StringHelper.AddZeroString(((Excel.Range)range.get_Item(i, 5)).Text, 12);
        //        string hhtid = ((Excel.Range)range.get_Item(i, 1)).Text;
        //        System.Data.DataRow newDR = dt.NewRow();
        //        if (!state.Equals("销户"))
        //        {
        //            newDR["Job_Code"] = jcode;
        //            newDR["HHT_ID"] = hhtid;
        //            newDR["Customer"] = ((Excel.Range)range.get_Item(i, 2)).Text;
        //            newDR["State"] = state;
        //            newDR["SCID"] = scid;
        //            newDR["CAID"] = StringHelper.AddZeroString(((Excel.Range)range.get_Item(i, 6)).Text, 11);
        //            newDR["Board"] = ((Excel.Range)range.get_Item(i, 7)).Text;
        //            newDR["Address"] = ((Excel.Range)range.get_Item(i, 8)).Text;
        //        }
        //        else
        //        {
        //            newDR["Job_Code"] = jcode;
        //            newDR["HHT_ID"] = hhtid;
        //            newDR["State"] = state;
        //        }
                
        //        dt.Rows.Add(newDR);
        //    }

        //    return dt;
        //}

        ///// <summary>
        ///// 导入开户数据
        ///// </summary>
        ///// <param name="path"></param>
        ///// <returns></returns>
        //public System.Data.DataSet GetImportData(string path)
        //{
        //    System.Data.DataSet ds = new DataSet();
        //    System.Data.DataTable strDt = new System.Data.DataTable("MsgString");
        //    strDt.Columns.Add("Job_Code");
        //    strDt.Columns.Add("This_Count");
        //    strDt.Columns.Add("Total_Count");

        //    System.Data.DataRow strDR = strDt.NewRow();

        //    Excel._Workbook wk = (Excel._Workbook)appli.Workbooks.Open(path);

        //    Excel._Worksheet sheet1 = wk.Worksheets.get_Item(1);
        //    string jcode = sheet1.Name;
        //    strDR["Job_Code"] = jcode;    //获取工号

        //    Excel.Range range1 = sheet1.UsedRange;
        //    strDR["This_Count"] = range1.Rows.Count;      //本次导入数量
        //    System.Data.DataTable newDt = GetSaveData(range1, jcode);
        //    ds.Tables.Add(newDt);

        //    //Excel.Worksheet sheet4 = wk.Worksheets.get_Item(4);
        //    //Excel.Range range4 = sheet4.UsedRange;
        //    //System.Data.DataTable countyDt = GetImportDataToCounty(range4, jcode);
        //    //ds.Tables.Add(countyDt);
        //    //strDR["Total_Count"] = ((Excel.Range)range4.get_Item(1, 4)).Text;      //获取总数量

        //    //Excel.Worksheet sheet5 = wk.Worksheets.get_Item(5);
        //    //Excel.Range range5 = sheet5.UsedRange;
        //    //System.Data.DataTable clearDT = GetClearAddress(range5);
        //    //ds.Tables.Add(clearDT);

        //    strDt.Rows.Add(strDR);
        //    ds.Tables.Add(strDt);

        //    appli.Workbooks.Close();

        //    return ds;
        //}

        ///// <summary>
        ///// 导入工号数据
        ///// </summary>
        ///// <param name="path"></param>
        ///// <returns></returns>
        //public System.Data.DataSet GetImportJobCode(string path)
        //{
        //    System.Data.DataSet ds = new DataSet();
        //    System.Data.DataTable strDt = new System.Data.DataTable("MsgString");
        //    strDt.Columns.Add("Job_Code");
        //    strDt.Columns.Add("This_Count");
        //    strDt.Columns.Add("Total_Count");

        //    System.Data.DataRow strDR = strDt.NewRow();

        //    Excel._Workbook wk = (Excel._Workbook)appli.Workbooks.Open(path);

        //    Excel._Worksheet sheet1 = wk.Worksheets.get_Item(1);
        //    string jcode = sheet1.Name;
        //    strDR["Job_Code"] = jcode;    //获取工号

        //    Excel.Range range1 = sheet1.UsedRange;
        //    strDR["This_Count"] = range1.Rows.Count;      //本次导入数量
        //    System.Data.DataTable newDt = GetSaveData(range1, jcode);
        //    ds.Tables.Add(newDt);

        //    //Excel.Worksheet sheet4 = wk.Worksheets.get_Item(4);
        //    //Excel.Range range4 = sheet4.UsedRange;
        //    //System.Data.DataTable countyDt = GetImportDataToCounty(range4, jcode);
        //    //ds.Tables.Add(countyDt);
        //    //strDR["Total_Count"] = ((Excel.Range)range4.get_Item(1, 4)).Text;      //获取总数量

        //    //Excel.Worksheet sheet5 = wk.Worksheets.get_Item(5);
        //    //Excel.Range range5 = sheet5.UsedRange;
        //    //System.Data.DataTable clearDT = GetClearAddress(range5);
        //    //ds.Tables.Add(clearDT);

        //    strDt.Rows.Add(strDR);
        //    ds.Tables.Add(strDt);

        //    appli.Workbooks.Close();

        //    return ds;
        //}
    }
}
