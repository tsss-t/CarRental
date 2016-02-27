using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.SalaryService;
using WFpart.SalaryAppendService;
using WFpart.SalaryInfoSummeryService;

namespace WFpart
{
    public partial class Form_SalaryInfo : Form
    {
        int Row_count;
        SalaryInfoSummeryClient SalaryInfoSummery_Client;
        List<SalaryInfo_ViewModel> List_SalaryInfo;
        List<RAP_ViewModel> List_RAP;
        List<SalaryAppend_ViewModel> List_Append;
        public Form_SalaryInfo(Guid UID,String RealName,decimal BaseSalary,decimal TotalSalary)
        {
            InitializeComponent();
            this.printDocument1.OriginAtMargins = true;//启用页边距
            this.pageSetupDialog1.EnableMetric = true; //以毫米为单位


            SalaryInfoSummery_Client = (SalaryInfoSummeryClient)ClientFactory.GetClient(ClientType.Type.SalaryInfoSummery);

            List_RAP = SalaryInfoSummery_Client.SelectRAP_UID(UID).ToList();
            List_Append = SalaryInfoSummery_Client.SelectSalaryAppend_UID(UID).ToList();
            Row_count = 3 + List_RAP.Count() + List_Append.Count();
            PL_Salary.RowCount = Row_count;
            PL_Salary.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            for (int h = 0; h < PL_Salary.RowStyles.Count; h++)
            {
                PL_Salary.RowStyles[h].SizeType = SizeType.Absolute;
                PL_Salary.RowStyles[h].Height = 20;
            }
            for (int i = 0; i < Row_count; i++)
            {

                Label LB1 = new Label();
                Label LB2 = new Label();
                LB1.Font = label1.Font;
                LB2.Font = label1.Font;
                if (i > 1&&i<=List_RAP.Count()+1)
                {
                    LB1.Text = List_RAP[i - 2].RAP_Name;
                    LB2.Text = List_RAP[i - 2].RAP_Price.ToString();
                }
                else if (i > 1 + List_RAP.Count()&&i<=List_Append.Count()+List_RAP.Count()+1)
                {
                    LB1.Text = List_Append[i - 2 - List_RAP.Count].SalaryAppend_Info;
                    LB2.Text = List_Append[i - 2 - List_RAP.Count].SalaryAppend_Price.ToString();
                }
                else if(i==0)
                {
                    LB1.Text = "员工姓名";
                    LB2.Text = RealName;
                }
                else if (i == 1)
                {
                    LB1.Text = "基本工资";
                    LB2.Text = BaseSalary.ToString();
                }
                else
                {
                    LB1.Text = "合计";
                    LB2.Text = TotalSalary.ToString();
                }

                PL_Salary.Controls.Add(LB1, 0, i );
                PL_Salary.Controls.Add(LB2, 1, i);

            }
            this.Height = 20 * (Row_count+3)+30;
        }

        private void BT_SetPrint_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog(); 
        }

        private void BT_ViewPrint_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog(); 
        }

        private void BT_Print_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //打印内容 为 局部的 this.groupBox1
            Bitmap _NewBitmap = new Bitmap(PL_Salary.Width, PL_Salary.Height);
            PL_Salary.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            e.Graphics.DrawImage(_NewBitmap, 0, 0, _NewBitmap.Width, _NewBitmap.Height); 
        }

    }
}
