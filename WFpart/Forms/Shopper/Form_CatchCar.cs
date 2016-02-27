using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.OrderSummeryService;
using WFpart.GetCarService;

namespace WFpart
{
    public partial class Form_CatchCar : Form
    {
        int count;
        int OrderID;
        int Type;
        GetCarClient GetCar_Client;
        List<Car_Get> List_GetCar = new List<Car_Get>();
        public Form_CatchCar(int count, int OrderID, int Type)
        {
            InitializeComponent();
            this.count = count;
            this.OrderID = OrderID;
            this.Type = Type;
            Label LB_CarNumberTemp = new Label();
            LB_CarNumberTemp.Text = "车牌号";
            Label LB_ValidationTemp = new Label();
            LB_ValidationTemp.Text = "驾照号码";
            TextBox TB_CarNumberTemp = new TextBox();
            TextBox TB_ValidationTemp = new TextBox();
            LB_CarNumberTemp.Location = new Point(5, 30);
            LB_ValidationTemp.Location = new Point(5, 30);
            TB_CarNumberTemp.Location = new Point(30, 30);
            TB_ValidationTemp.Location = new Point(30, 30);

            GetCar_Client = (GetCarClient)ClientFactory.GetClient(ClientType.Type.GetCar);
            if (Type == 1)
            {
                            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
                }
            else
            {
                List_GetCar = GetCar_Client.SelectAllCarGets().Where(P => P.GetCar_Order == OrderID).ToList();
                BT_Submit.Text = "退出";
                BT_Submit.Click += new System.EventHandler(BT_Back_Click);
            }
            for (int i = 0; i < count; i++)
            {
                Label LB_CarNumber = new Label();
                LB_CarNumber.Text = LB_CarNumberTemp.Text + (i + 1) + ":";
                LB_CarNumber.Width = 55;
                Label LB_Validation = new Label();
                LB_Validation.Text = LB_ValidationTemp.Text + (i + 1) + ":";
                LB_Validation.Width = 55;
                if (Type == 1)
                {
                    TextBox TB_CarNumber = new TextBox();
                    TextBox TB_Validation = new TextBox();


                    TB_CarNumber.Width = 200;
                    TB_Validation.Width = 200;
                    TB_CarNumber.Location = new Point(65, TB_CarNumberTemp.Location.Y + 30 * i);
                    TB_Validation.Location = new Point(65, TB_ValidationTemp.Location.Y + 30 * i);
                    GB_Car.Controls.Add(TB_CarNumber);
                    GB_Validation.Controls.Add(TB_Validation);
                }
                else
                {
                    Label LB_CarN = new Label();
                    Label LB_Vali = new Label();
                    LB_CarN.Text = List_GetCar[i].GetCar_CarNumber;
                    LB_Vali.Text = List_GetCar[i].GetCar_UserValidation;
                    LB_CarN.Width = 200;
                    LB_Vali.Width = 200;
                    LB_CarN.Location = new Point(65, TB_CarNumberTemp.Location.Y + 30 * i);
                    LB_Vali.Location= new Point(65, TB_ValidationTemp.Location.Y + 30 * i);
                    GB_Car.Controls.Add(LB_CarN);
                    GB_Validation.Controls.Add(LB_Vali);
                }
                LB_CarNumber.Location = new Point(LB_CarNumberTemp.Location.X, LB_CarNumberTemp.Location.Y + 30 * i);
                LB_Validation.Location = new Point(LB_ValidationTemp.Location.X, LB_ValidationTemp.Location.Y + 30 * i);


                GB_Car.Controls.Add(LB_CarNumber);
                GB_Validation.Controls.Add(LB_Validation);

            }
            GB_Car.Height = 50 + 30 * count;
            GB_Validation.Height = 50 + 30 * count;
            this.Height = 130 + 30 * count;
            BT_Submit.Location = new Point(BT_Submit.Location.X, GB_Validation.Height + 20);
        }
        private void BT_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BT_Submit_Click(object sender, EventArgs e)
        {
            List<Car_Get> List_GetCar = new List<Car_Get>();

            for (int i = 0; i < GB_Car.Controls.Count; i++)
            {
                if (GB_Car.Controls[i] is TextBox)
                {
                    List_GetCar.Add(new Car_Get()
                    {
                        GetCar_CarNumber = GB_Car.Controls[i].Text,
                        GetCar_UserValidation = GB_Validation.Controls[i].Text,
                        GetCar_Order = OrderID
                    });
                }
            }
            foreach (Car_Get temp in List_GetCar)
            {
                if (GetCar_Client.AddCarGet(temp) == false)
                {
                    MessageBox.Show("添加过程中出现错误,请联系管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("添加成功!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
