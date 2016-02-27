using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.SalaryLogService;
using WFpart.UserManagerService;
using WFpart.WorkRAPService;

namespace WFpart
{
    public partial class Form_SalaryResult : Form
    {
        int ShopID;
        SalaryLogClient SalaryLog_Client;
        UserManagerClient UserManager_Client;
        WorkRAPClient WorkRAP_Client;
        List<User_SalaryLog> List_Log;
        public Form_SalaryResult()
        {
            InitializeComponent();
            ShopID = GlobalParams.ShopID;
            if (ShopID < 0)
            {
                MessageBox.Show("您不属于任何店铺,请联系系统管理员分配您的店铺所属!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            SalaryLog_Client = (SalaryLogClient)ClientFactory.GetClient(ClientType.Type.SalaryLog);
            UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            WorkRAP_Client = (WorkRAPClient)ClientFactory.GetClient(ClientType.Type.WorkRAP);
            List_Log = SalaryLog_Client.SelectAllSalaryLogs().Where(P => P.SalaryLog_Time.Month == DateTime.Now.Month && P.SalaryLog_Time.Year == DateTime.Now.Year).ToList();
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            List_Log = SalaryLog_Client.SelectAllSalaryLogs().Where(P => P.SalaryLog_Time.Month == DateTime.Now.Month && P.SalaryLog_Time.Year == DateTime.Now.Year).ToList();
            if (List_Log.Count() == 0)
            {
                List<Shop_ViewModel> List_User = UserManager_Client.GetAllShops(null, null, ShopID).ToList();
                foreach (Shop_ViewModel Temp in List_User)
                {
                    try
                    {
                        if (WorkRAP_Client.SelectWorkRAP_UID((Guid)Temp.UserId).Where(P=>P.WorkRAP_Time.Month==DateTime.Now.Month&&P.WorkRAP_Time.Year==DateTime.Now.Year).Count() == 0)
                        {

                            WorkRAP_Client.AddWorkRAP(new User_WorkRAP()
                            {
                                WorkRAP_Time = DateTime.Now,
                                WorkRAP_Type = 7,
                                WorkRAP_User = (Guid)Temp.UserId
                            });
                        }
                        SalaryLog_Client.AddSalaryLog(new User_SalaryLog()
                        {
                            SalaryLog_Mark = false,
                            SalaryLog_Time = DateTime.Now,
                            SalaryLog_User = (Guid)Temp.UserId
                        });
                    }
                    catch
                    {
                        MessageBox.Show("系统未知错误,请联系系统管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }
                }
                MessageBox.Show("本月的工资表已经成功生成!现在您可以进入<领工资>选单发放本月工资!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("本月的工资表已经生成!请勿重复生成工资表!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }

        private void BT_Canncel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BT_LastMonth_Click(object sender, EventArgs e)
        {
            DateTime Time;
            if (DateTime.Now.Month == 1)
            {
                Time = new DateTime(DateTime.Now.Year - 1, 12, 28);
               
            }
            else
            {
                Time = new DateTime(DateTime.Now.Year , DateTime.Now.Month-1, 28);
            }
            List_Log = SalaryLog_Client.SelectAllSalaryLogs().Where(P => P.SalaryLog_Time.Month == Time.Month && P.SalaryLog_Time.Year == Time.Year).ToList();
           if (List_Log.Count() == 0)
            {
                List<Shop_ViewModel> List_User = UserManager_Client.GetAllShops(null, null, ShopID).ToList();
                foreach (Shop_ViewModel Temp in List_User)
                {
                    try
                    {
                        if (WorkRAP_Client.SelectWorkRAP_UID((Guid)Temp.UserId).Where(P=>P.WorkRAP_Time.Year==Time.Year&&P.WorkRAP_Time.Month==Time.Month).Count() == 0)
                        {
                            WorkRAP_Client.AddWorkRAP(new User_WorkRAP()
                            {
                                WorkRAP_Time = Time,
                                WorkRAP_Type = 7,
                                WorkRAP_User = (Guid)Temp.UserId
                            });
                        }
                        SalaryLog_Client.AddSalaryLog(new User_SalaryLog()
                        {
                            SalaryLog_Mark = false,
                            SalaryLog_Time = Time,
                            SalaryLog_User = (Guid)Temp.UserId
                        });
                    }
                    catch
                    {
                        MessageBox.Show("系统未知错误,请联系系统管理员!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }
                }
                MessageBox.Show("上月的工资表已经成功生成!现在您可以进入<领工资>选单发放本月工资!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("上月的工资表已经生成!请勿重复生成工资表!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
