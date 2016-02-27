using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.TypeService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月20日15:24:42
 * 编写版本：v0.5
 * */
namespace WFpart
{
    public partial class Form_CarTypeManage : Form
    {
        #region 参数预声明
        bool Mark;
        TypeClient Type_Client;
        List<Car_Type> List_Type;
        #endregion
        #region 构造方法
        public Form_CarTypeManage()
        {
            InitializeComponent();
            Type_Client = (TypeClient)ClientFactory.GetClient(ClientType.Type.Type);
            Bind_Type();
            BT_UpdateType.Visible = false;
            Mark = false;
        }
        #endregion
        #region 辅助方法
        #region 绑定类型事件
        /// <summary>
        /// 绑定类型事件
        /// </summary>
        private void Bind_Type()
        {
            List_Type = Type_Client.SelectAllTypes().ToList();
            LB_Type.DataSource = List_Type.Select(P => P.Type_Name).ToList();
        }
        #endregion
        #endregion
        #region 事件
        #region 状态切换按钮事件
        /// <summary>
        /// 状态切换按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Change_Click(object sender, EventArgs e)
        {
            if (Mark)
            {
                Mark = false;
                BT_UpdateType.Visible = false;
                BT_AddType.Visible = true;
                LB_Type.ClearSelected();
                TB_TypeInfo.Text = "";
                TB_TypeName.Text = "";
                BT_Change.Text = "切换到修改模式";
            }
            else
            {
                Mark = true;
                BT_UpdateType.Visible = true;
                BT_AddType.Visible = false;
                LB_Type_SelectedIndexChanged(null, null);
                BT_Change.Text = "切换到添加模式";
            }
        }

        #endregion
        #region 类型选择框变动事件
        /// <summary>
        /// 类型选择框变动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mark)
            {
                String TypeName = LB_Type.SelectedItem.ToString();
                Car_Type Cartype = List_Type.Where(P => P.Type_Name == TypeName).Single();
                TB_TypeName.Text = Cartype.Type_Name;
                TB_TypeInfo.Text = Cartype.Type_Info;
            }
        }
        #endregion
        #region 添加汽车类型按钮事件
        /// <summary>
        /// 添加汽车类型按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_AddType_Click(object sender, EventArgs e)
        {
            if (TB_TypeName.Text == "")
            {
                MessageBox.Show("请输入类型名", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (List_Type.Where(P => P.Type_Name == TB_TypeName.Text.Trim()).Count() > 0)
            {
                MessageBox.Show("您输入的类型名已经包含在数据库中，请勿重复建立相同类型", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                if (Type_Client.AddType(new Car_Type()
                {
                    Type_Name = TB_TypeName.Text.Trim(),
                    Type_Info = TB_TypeInfo.Text.Trim()
                }))
                {
                    MessageBox.Show("创建新车辆类型成功！");
                    Bind_Type();
                }
                else
                {
                    MessageBox.Show("建立汽车类型失败，请检查拼写，如果问题依旧，请联系管理员！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }
        #endregion
        #region 更新汽车类型按钮事件
        /// <summary>
        /// 更新汽车类型按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_UpdateType_Click(object sender, EventArgs e)
        {
            int TypeID = List_Type.Where(P => P.Type_Name == LB_Type.SelectedItem.ToString()).Single().Type_ID;
            if (Type_Client.UpdateType(new Car_Type()
            {
                Type_ID = TypeID,
                Type_Info = TB_TypeInfo.Text.Trim(),
                Type_Name = TB_TypeName.Text.Trim()
            }))
            {
                MessageBox.Show("修改成功！");
                Bind_Type();
            }
            else
            {
                MessageBox.Show("修改失败，请检查拼写，如果问题依旧，请联系管理员！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
        #endregion
    }
}
