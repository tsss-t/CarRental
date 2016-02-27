using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using WFpart.BrandService;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月20日13:30:26
 * 编写版本：v0.5
 * */
namespace WFpart
{
    public partial class Form_BrandManage : Form
    {
        #region 变量预声明
        bool Mark;
        BrandClient Brand_Client;
        string imgString;
        List<Car_Brand> List_Brand;
        #endregion
        #region 构造方法
        public Form_BrandManage()
        {
            InitializeComponent();
            Brand_Client = (BrandClient)ClientFactory.GetClient(ClientType.Type.Brand);
            BT_UpdateBrand.Visible = false;
            Mark = false;
            Bind_Brand();
        }

        #endregion
        #region 事件
        #region 商标选择框变动事件
        /// <summary>
        /// 商标选择框变动事件
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void LB_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Brand.SelectedIndex < 0||!Mark)
            {
                return;
            }
            String BrandName = LB_Brand.SelectedItem.ToString();
            Car_Brand Temp_Brand = List_Brand.Where(P => P.Brand_Name == BrandName).Single();
            TB_BrandName.Text = Temp_Brand.Brand_Name;
            TB_BrandInfo.Text = Temp_Brand.Brand_Info;
            imgString = null;
            try
            {
                string[] imgArr = Temp_Brand.Brand_IMG.ToString().Split(new char[] { ',' });

                byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });

                Bitmap bmp = new Bitmap(bty.FromBytes(null,null));
                PB_Pic.Image = bmp;
                imgString = Temp_Brand.Brand_IMG;
            }
            catch
            {
                MessageBox.Show("载入图片出现错误，请重新上传图片更新数据库或联系管理员！", "错误！！", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
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
                BT_UpdateBrand.Visible = false;
                BT_AddBrand.Visible = true;
                LB_Brand.ClearSelected();
                TB_BrandInfo.Text = "";
                TB_BrandName.Text = "";
                PB_Pic.Image = null;
                BT_Change.Text = "切换到修改模式";
            }
            else
            {
                Mark = true;
                BT_UpdateBrand.Visible = true;
                BT_AddBrand.Visible = false;
                LB_Brand_SelectedIndexChanged(null, null);
                BT_Change.Text = "切换到添加模式";
            }
        }
        #endregion
        #region 图片拖拽到指定位置时发生的事件
        /// <summary>
        /// 图片拖拽到指定位置时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PL_AddPic_DragDrop(object sender, DragEventArgs e)
        {
            string patch = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            
             //获得2进制图片数据流
            imgString = patch.ImagePatchToBaniryString();

            string[] imgArr = imgString.ToString().Split(new char[] { ',' });

            byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });

            Bitmap bmp = new Bitmap(bty.FromBytes(null,null));
            PB_Pic.Image = bmp;

        }
        private void PL_AddPic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }
        #endregion
        #region 添加商标按钮事件
        /// <summary>
        /// 添加商标按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_AddBrand_Click(object sender, EventArgs e)
        {
            if (TB_BrandName.Text == ""||PB_Pic.Image==null||imgString==null)
            {
                MessageBox.Show("您必须填写好您要添加的商标名和指定商标图片");
                return;
            }

            if (List_Brand.Where(P => P.Brand_Name == TB_BrandName.Text.Trim()).Count() > 0)
            {
                MessageBox.Show("此商标已经存在！请勿重复添加商标！");
            }
            else
            {
                if (Brand_Client.AddBrand(new Car_Brand()
                {
                    Brand_Name = TB_BrandName.Text.Trim(),
                    Brand_Info = TB_BrandInfo.Text.Trim(),
                    Brand_IMG = imgString

                }))
                {
                    MessageBox.Show("创建新的商标成功！！");
                    List_Brand = Brand_Client.SelectAllBrands().ToList();
                    Bind_Brand();
                }
                else
                {
                    MessageBox.Show("创建商标失败，请检查您的输入，如果问题依旧未解决，请联系管理员！");
                }
            }
        }
        #endregion
        #region 更新商标按钮事件
        /// <summary>
        /// 更新商标按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_UpdateBrand_Click(object sender, EventArgs e)
        {
            if (LB_Brand.SelectedIndex >= 0)
            {
                if (Brand_Client.UpdateBrand(new Car_Brand()
                {
                    Brand_ID = List_Brand.Where(P => P.Brand_Name == LB_Brand.SelectedItem.ToString()).Single().Brand_ID,
                    Brand_IMG = imgString,
                    Brand_Info = TB_BrandInfo.Text.Trim(),
                    Brand_Name = TB_BrandName.Text.Trim()
                }))
                {
                    MessageBox.Show("修改商标成功！！");
                }
                List_Brand = Brand_Client.SelectAllBrands().ToList();
                Bind_Brand();
            }
        }
        #endregion
        #endregion
        #region 辅助方法
        #region 绑定品牌框
        /// <summary>
        /// 绑定品牌框
        /// </summary>
        private void Bind_Brand()
        {
            List_Brand = Brand_Client.SelectAllBrands().ToList();
            LB_Brand.DataSource = List_Brand.Select(P => P.Brand_Name).ToList();
        }
        #endregion
        #endregion
    }
}
