using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
using WFpart.TypeService;
using WFpart.ActionService;
using WFpart.VersionService;
using WFpart.OrderService;
using WFpart.OrderSummeryService;
/*
 * 编写人:杜天行
 * 编写时间:2012年4月21日18:37:48
 * 编写版本:v0.5
 * */
namespace WFpart
{
    public partial class Form_OrderManage : Form
    {
        #region 1.参数预声明
        int ShopID;
        Guid SelectUID;
        UserManagerClient UserManager_Client;
        VersionClient Version_Client;
        TypeClient Type_Client;
        ActionClient Action_Client;
        OrderClient Order_Client;
        OrderSummeryClient OrderSummery_Client;
        List<WFpart.VersionService.Car_Version> List_Version;
        List<WFpart.UserManagerService.aspnet_UsersEX> List_UserEX;
        List<WFpart.UserManagerService.User_ViewModel> List_User;
        List<Car_Type> List_Type;
        List<Car_Action> List_Action;
        #endregion
        #region 2.构造方法
        public Form_OrderManage()
        {
            InitializeComponent();
            UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            Type_Client = (TypeClient)ClientFactory.GetClient(ClientType.Type.Type);
            Action_Client = (ActionClient)ClientFactory.GetClient(ClientType.Type.Action);
            Version_Client = (VersionClient)ClientFactory.GetClient(ClientType.Type.Version);
            Order_Client = (OrderClient)ClientFactory.GetClient(ClientType.Type.Order);
            OrderSummery_Client = (OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            ShopID = GlobalParams.ShopID;
            if (ShopID < 0)
            {
                MessageBox.Show("您不属于任何店铺,请联系系统管理员分配您的店铺所属!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                List_Version = Version_Client.SelectAllVersions().Where(P => P.Version_Shop == ShopID).ToList();
            }
            List_Action = Action_Client.SelectAllActions().ToList();
            List_Type = Type_Client.SelectAllTypes().ToList();
            List_UserEX = UserManager_Client.SelectUserEXInfo_All().ToList();
            List_User = UserManager_Client.SelectUserInfo_All().ToList();
            PL_NewUser.Visible = false;
            PL_UserResult.Visible = false;
            Bind_Action();
            Bind_Type();
            Bind_Version();
        }
        #endregion
        #region 3.辅助方法
        #region 3.1不能输入字母
        /// <summary>
        /// 不能输入字母
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            int kc = e.KeyChar;
            TextBox txtMoney = (TextBox)sender;
            if ((kc < 48 || kc > 57) && kc != 8)
            {
                e.Handled = true;
            }
            if (kc == 46)                       //小数点
            {
                if (txtMoney.Text.Length <= 0)
                    e.Handled = true;           //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(txtMoney.Text, out oldf);
                    b2 = float.TryParse(txtMoney.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        #endregion
        #region 3.2车的类型绑定方法
        private void Bind_Type()
        {
            List<string> List_temp = new List<string>();
            List_temp.Add("<—请选择汽车类型—>");
            List_temp.AddRange(List_Type.Select(P => P.Type_Name).ToList());
            CB_Type.DataSource = List_temp;

        }
        #endregion
        #region 3.3参与活动绑定方法
        private void Bind_Action()
        {
            CB_Action.DataSource = List_Action.Select(P => P.Action_Name).ToList();
        }
        #endregion
        #region 3.4车辆型号绑定方法
        private void Bind_Version()
        {
            LB_Version.DataSource = List_Version.Select(P => P.Version_Name).ToList();
        }
        #endregion
        #endregion
        #region 4.事件
        #region 4.1用户选择块
        #region 4.1.1查找用户按钮事件
        /// <summary>
        /// 查找用户按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Search_Click(object sender, EventArgs e)
        {
            List<WFpart.UserManagerService.aspnet_UsersEX> List_UserEX_Temp = List_UserEX;
            List<WFpart.UserManagerService.User_ViewModel> List_User_Temp = List_User;
            List<string> List_UserName = new List<string>();
            if (TB_SearchUserName.Text.Trim() != "")
            {
                List_User_Temp = List_User_Temp.Where(P => P.UserName.Contains(TB_SearchUserName.Text.Trim())).ToList();
            }
            if (TB_SearchRealName.Text.Trim() != "")
            {
                List_UserEX_Temp = List_UserEX_Temp.Where(P => P.User_RealName.Contains(TB_SearchRealName.Text.Trim())).ToList();
            }
            if (TB_SearchValidation.Text.Trim() != "")
            {
                List_UserEX_Temp = List_UserEX_Temp.Where(P => P.User_Validation.Contains(TB_SearchValidation.Text.Trim())).ToList();
            }
            foreach (WFpart.UserManagerService.aspnet_UsersEX UserEX_Temp in List_UserEX_Temp)
            {
                foreach (WFpart.UserManagerService.User_ViewModel User_Temp in List_User_Temp)
                {
                    if (UserEX_Temp.User_ID == User_Temp.UserID)
                    {
                        List_UserName.Add(User_Temp.UserName);
                    }
                }
            }
            LB_User.DataSource = List_UserName;
        }
        #endregion
        #region 4.1.2重置按钮
        private void BT_Reset_Click(object sender, EventArgs e)
        {
            TB_SearchRealName.Text = "";
            TB_SearchUserName.Text = "";
            TB_SearchValidation.Text = "";
        }
        #endregion
        #region 4.1.3提交新账户注册
        private void BT_Sub_Click(object sender, EventArgs e)
        {
            if (TB_RealName.Text.Trim() == null | TB_Phone.Text.Trim() == null || TB_Validation.Text.Trim() == null)
            {
                MessageBox.Show("请完善至少前三项资料!");
                return;
            }
            else
            {
                if (List_UserEX.Where(P => P.User_Validation == TB_Validation.Text.Trim()).Count() > 0)
                {
                    MessageBox.Show("您的身份证已经注册过,请选择老账户进行订车服务!");
                    return;
                }

                if (UserManager_Client.UserReg(null, new UserManagerService.aspnet_UsersEX()
                {
                    User_RealName = TB_RealName.Text.Trim(),
                    User_Validation = TB_Validation.Text.Trim(),
                    User_Adress = TB_Adress.Text.Trim(),
                    User_Phone = TB_Phone.Text.Trim(),
                    User_Info = TB_Info.Text.Trim()
                }))
                {
                    MessageBox.Show("账号注册成功!");
                    SelectUID = UserManager_Client.SelectUserEXInfo_All().Where(P => P.User_Validation == TB_Validation.Text.Trim()).Single().User_ID;
                    List_User = UserManager_Client.SelectUserInfo_All().ToList();
                    List_UserEX = UserManager_Client.SelectUserEXInfo_All().ToList();
                    WFpart.UserManagerService.User_ViewModel _TempUser = List_User.Where(P => P.UserID == SelectUID).Single();
                    WFpart.UserManagerService.aspnet_UsersEX _TempUserEX = List_UserEX.Where(P => P.User_ID == SelectUID).Single();
                    Label_UserName.Text = _TempUserEX.User_RealName;
                    Label_Adress.Text = _TempUserEX.User_Adress;
                    Label_Info.Text = _TempUserEX.User_Info;
                    Label_Phone.Text = _TempUserEX.User_Phone;
                    Label_Validation.Text = _TempUserEX.User_Validation;
                    PL_NewUser.Visible = false;
                    PL_UserResult.Visible = true;
                    RB_NewUser.Visible = false;
                    RB_OldUser.Visible = false;
                }
                else
                {
                    MessageBox.Show("账号注册失败!请检查拼写,如问题依旧,请联系管理员!", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }
        #endregion
        #region 4.1.4交换用户方式
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (RB_NewUser.Checked)
            {
                PL_NewUser.Visible = true;
                PL_OldUser.Visible = false;
            }
            else
            {
                PL_OldUser.Visible = true;
                PL_NewUser.Visible = false;
            }
        }
        #endregion
        #region 4.1.5旧用户的提交
        private void BT_SeachSub_Click(object sender, EventArgs e)
        {
            if (LB_User.SelectedIndex < 0)
            {
                return;
            }
            SelectUID = List_User.Where(P => P.UserName == LB_User.SelectedItem.ToString().Trim()).Single().UserID;
            foreach (string rolename in UserManager_Client.RoleSelect_UserName(LB_User.SelectedItem.ToString()))
            {
                if (rolename.Contains("管理员") || rolename.Contains("员工"))
                {
                    MessageBox.Show("您选择的用户具有多重系统身份，该员工属于公司内部员工，该服务不向公司内部员工开放！");
                    return;
                }
            }

            WFpart.UserManagerService.User_ViewModel _TempUser = List_User.Where(P => P.UserID == SelectUID).Single();
            WFpart.UserManagerService.aspnet_UsersEX _TempUserEX = List_UserEX.Where(P => P.User_ID == SelectUID).Single();
            Label_User.Text = LB_User.SelectedItem.ToString();
            Label_UserName.Text = _TempUserEX.User_RealName;
            Label_Adress.Text = _TempUserEX.User_Adress;
            Label_Info.Text = _TempUserEX.User_Info;
            Label_Phone.Text = _TempUserEX.User_Phone;
            Label_Validation.Text = _TempUserEX.User_Validation;
            PL_OldUser.Visible = false;
            PL_UserResult.Visible = true;
            RB_NewUser.Visible = false;
            RB_OldUser.Visible = false;
        }
        #endregion


        #endregion
        #region 4.2车辆选择块
        #region 4.2.1类型选择框变动事件
        private void CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Type.SelectedIndex == 0)
            {
                LB_Version.DataSource = List_Version.Select(P => P.Version_Name).ToList();
            }
            else
            {
                int typeID = List_Type.Where(T => T.Type_Name == CB_Type.SelectedItem.ToString()).Single().Type_ID;
                if (List_Version.Where(P => P.Version_Type == typeID).Select(K => K.Version_Name).Count() > 0)
                {
                    LB_Version.DataSource = List_Version.Where(P => P.Version_Type == typeID).Select(K => K.Version_Name).ToList();
                }
                else
                {
                    LB_Version.DataSource = null;
                }
            }

        }
        #endregion
        #region  4.2.2提交订单
        private void BT_AddOrder_Click(object sender, EventArgs e)
        {
            if (LB_Version.SelectedIndex < 0)
            {
                MessageBox.Show("请选择您要预定的车型!");
                return;
            }
            int VersionID = List_Version.Where(P => P.Version_Name == LB_Version.SelectedItem.ToString()).Single().Version_ID;
            int Versiontotal = List_Version.Where(P => P.Version_Name == LB_Version.SelectedItem.ToString()).Single().Version_Count;
            string[] starttime = TM_Start.Value.ToShortDateString().Split('/');
            string[] endtime = TM_Back.Value.ToShortDateString().Split('/');
            int Car_Count = OrderSummery_Client.SelectRentaledCarCount_TimeAndVersion(
                ShopID, VersionID,
                Convert.ToInt32(starttime[0]),
                Convert.ToInt32(starttime[1]),
                Convert.ToInt32(starttime[2]),
                Convert.ToInt32(endtime[0]),
                Convert.ToInt32(endtime[1]),
                Convert.ToInt32(endtime[2])
                );
            int nokosite = Versiontotal - Car_Count;
            if (nokosite < Convert.ToInt32(TB_Count.Text))
            {
                MessageBox.Show(String.Format("该车型目前只剩下{0}辆,您预定的数量超过库存数量!", nokosite));
                return;
            }
            else
            {
                DialogResult res=
                MessageBox.Show("您是否确定要将这条订单添加到数据库?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Cancel)
                {
                    return; 
                }
                bool iscatch;
                int RentalType;
                int ActionID = List_Action.Where(P => P.Action_Name == CB_Action.SelectedItem.ToString()).Single().Action_ID;
                if (RB_Self.Checked)
                {
                    iscatch = false;
                }
                else
                {
                    iscatch = true;
                }
                if (RB_SelfGet.Checked)
                {
                    RentalType = 1;
                }
                else
                {
                    RentalType = 2;
                }
                OrderService.Car_Order Temp=new OrderService.Car_Order()
                {
                    Order_Action = ActionID,
                    Order_Count = Convert.ToInt32(TB_Count.Text),
                    Order_End_Time = new DateTime(Convert.ToInt32(endtime[0]), Convert.ToInt32(endtime[1]), Convert.ToInt32(endtime[2])),
                    Order_Start_Time = new DateTime(Convert.ToInt32(starttime[0]), Convert.ToInt32(starttime[1]), Convert.ToInt32(starttime[2])),
                    Order_IsCatch = iscatch,
                    Order_Message = TB_Message.Text,
                    Order_RentalType = RentalType,
                    Order_Shop = ShopID,
                    Order_User = List_User.Where(P => P.UserName == Label_User.Text).Single().UserID,
                    Order_Version = VersionID,
                    Order_Time=DateTime.Now
                };
                if (Order_Client.AddOrder(Temp))
                {
                    MessageBox.Show("提交订单成功!");
                    List_Version = Version_Client.SelectAllVersions().Where(P=>P.Version_Shop==ShopID).ToList();
                }
                else
                {
                    MessageBox.Show("提交订单失败!请检查拼写,如错误依旧,请联系管理员!","错误!",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
            }

        }
        #endregion
        #region 4.2.3查看车型具体情况
        private void BT_SeachVersion_Click(object sender, EventArgs e)
        {
            int VersionID=List_Version.Where(P=>P.Version_Name==LB_Version.SelectedItem.ToString()).Single().Version_ID;
            string[] starttime = TM_Start.Value.ToShortDateString().Split('/');
            string[] endtime = TM_Back.Value.ToShortDateString().Split('/');
            Form_VersionInfo form = new Form_VersionInfo(ShopID, VersionID, starttime, endtime);
            form.Owner = this;
            form.ShowDialog();
        }
        #endregion
        #endregion

        #endregion

    }
}
