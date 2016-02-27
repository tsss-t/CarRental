using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFpart.UserManagerService;
using WFpart.AccountService;
using System.Windows.Forms.DataVisualization.Charting;
//using WFpart.ProvinceService;
//using WFpart.CityService;
//using WFpart.ShopService;


namespace WFpart
{
    public partial class Form_Money : Form
    {
        #region 参数预声明
        int ShopID;
        int CityID;
        int ProvinceID;
        int year;
        int month;
        int day;
        UserManagerClient UserManager_Client;
        AccountClient Account_Client;
        List<Shop_ViewModel> List_ShopInfo;
        List<Car_Account> List_Account;
        //ProvinceClient Province_Client;
        //CityClient City_Client;
        //ShopClient Shop_Client;
        //List<Car_Province> List_Province;
        //List<WFpart.CityService.Car_City> List_City;
        //List<WFpart.ShopService.Car_Shop> List_Shop;
        #endregion
        #region 构造方法
        public Form_Money()
        {
            InitializeComponent();
            ShopID = 0;
            CityID = 0;
            ProvinceID = 0;
            UserManager_Client = (UserManagerClient)ClientFactory.GetClient(ClientType.Type.UserManager);
            Account_Client = (AccountClient)ClientFactory.GetClient(ClientType.Type.Account);

            List_ShopInfo = UserManager_Client.GetAllShops(null, null, null).ToList();
            List_Account = Account_Client.SelectAllAccounts().ToList();
            //Province_Client = (ProvinceClient)ClientFactory.GetClient(ClientType.Type.Province);
            //City_Client = (CityClient)ClientFactory.GetClient(ClientType.Type.City);
            //Shop_Client = (ShopClient)ClientFactory.GetClient(ClientType.Type.Shop);
            Bind_Province();
            Bind_Year();
        }
        #endregion
        #region 省市3级联动
        private void Bind_Province()
        {
            List<String> List_PravinceName = new List<string>();
            List_PravinceName.Add("<——全部——>");
            List_PravinceName.AddRange(List_ShopInfo.Select(K => K.Province_Name).Distinct().ToList());
            CB_Province.DataSource = List_PravinceName;
        }
        private void Bind_City()
        {
            List<String> List_CityName = new List<string>();
            List_CityName.Add("<——全部——>");
            if (CB_Province.SelectedIndex > 0)
            {
                List_CityName.AddRange(List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString()).Select(K => K.City_Name).Distinct().ToList());
                ProvinceID = List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString()).First().Province_ID;
            }
            else
            {
                ProvinceID = 0;
            }
            CB_City.DataSource = List_CityName;
        }
        private void Bind_Shop()
        {
            List<String> List_ShopName = new List<string>();
            List_ShopName.Add("<——全部——>");
            if (CB_City.SelectedIndex > 0)
            {
                List_ShopName.AddRange(List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString() && P.City_Name == CB_City.SelectedItem.ToString()).Select(K => K.Shop_Name).Distinct().ToList());
                CityID = List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString() && P.City_Name == CB_City.SelectedItem.ToString()).First().City_ID;
            }
            else
            {
                CityID = 0;
            }
            CB_Shop.DataSource = List_ShopName;
        }
        private void CB_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_City();
        }
        private void CB_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Shop();
        }
        private void CB_Shop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Shop.SelectedIndex > 0)
            {
                ShopID = List_ShopInfo.Where(P => P.Province_Name == CB_Province.SelectedItem.ToString() && P.City_Name == CB_City.SelectedItem.ToString() && P.Shop_Name == CB_Shop.SelectedItem.ToString()).First().Shop_ID;
            }
            else
            {
                ShopID = 0;
            }
            Bind_Pic();
        }
        #endregion
        #region 年月日3级联动
        private void Bind_Year()
        {
            List<String> List_Year = new List<string>();
            List_Year.Add("<——全部——>");

            for (int i = 2012; i <= DateTime.Now.Year; i++)
            {
                List_Year.Add(i.ToString());
            }
            CB_Year.DataSource = List_Year;
        }
        private void Bind_Month()
        {
            List<String> List_Month = new List<string>();
            List_Month.Add("<——全部——>");
            if (CB_Year.SelectedIndex > 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    List_Month.Add(i.ToString());
                }


                year = Convert.ToInt32(CB_Year.SelectedItem.ToString());
            }
            else
            {
                year = 0;
            }
            CB_Month.DataSource = List_Month;
        }
        private void Bind_Day()
        {
            List<string> List_Day = new List<string>();
            List_Day.Add("<——全部——>");
            if (CB_Month.SelectedIndex > 0)
            {
                int day = DateTime.DaysInMonth(
                    Convert.ToInt32(CB_Year.SelectedItem.ToString()),
                    Convert.ToInt32(CB_Month.SelectedItem.ToString()));
                for (int i = 1; i <= day; i++)
                {
                    List_Day.Add(i.ToString());
                }

                month = Convert.ToInt32(CB_Month.SelectedItem.ToString());
            }
            else
            {
                month = 0;
            }
            CB_Day.DataSource = List_Day;
        }
        private void CB_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Month();
        }


        private void CB_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Day();
        }

        private void CB_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Day.SelectedIndex > 0)
            {
                day = Convert.ToInt32(CB_Day.SelectedItem.ToString());
            }
            else
            {
                day = 0;
            }
            Bind_Pic();
        }
        #endregion
        private void Bind_Pic()
        {
            var X = List_Account.Select(P => P.Account_Time);
            var Y = List_Account.Select(P => P.Account_Price);
            List<Car_Account> List_AccTemp = List_Account;
            List<SelectResult> Temp_result = new List<SelectResult>();
            #region 地点处理
            if (CB_Province.SelectedIndex > 0)
            {
                if (CB_City.SelectedIndex > 0)
                {
                    if (CB_Shop.SelectedIndex > 0)
                    {
                        List_AccTemp = List_AccTemp.Where(P => P.Account_Shop == ShopID).ToList();
                    }
                    else
                    {
                        
                    }
                }
                else
                {

                }
            }
            #endregion
            #region 时间处理
            if (CB_Year.SelectedIndex > 0)
            {
                List_AccTemp = List_AccTemp.Where(P => P.Account_Time.Year == Convert.ToInt32(CB_Year.SelectedItem.ToString())).ToList();
                if (CB_Month.SelectedIndex > 0)
                {
                    List_AccTemp = List_AccTemp.Where(P => P.Account_Time.Month == Convert.ToInt32(CB_Month.SelectedItem.ToString())).ToList();
                    if (CB_Day.SelectedIndex > 0)
                    {
                        int day = DateTime.DaysInMonth(
                        Convert.ToInt32(CB_Year.SelectedItem.ToString()),
                        Convert.ToInt32(CB_Month.SelectedItem.ToString()));
                        List_AccTemp = List_AccTemp.Where(P => P.Account_Time.Day == Convert.ToInt32(CB_Day.SelectedItem.ToString())).ToList();
                        for (int i = 0; i < 24; i++)
                        {
                            SelectResult k = (from P in List_AccTemp
                                              where (P.Account_Time.Hour == i)
                                              group P by P.Account_Time.Hour into K
                                              select new SelectResult
                                              {
                                                  Time = i,
                                                  Price = K.Sum(P => P.Account_Price)
                                              }).FirstOrDefault();
                            Temp_result.Add(k ?? new SelectResult() { Price = 0, Time = i });
                        }
                    }
                    else
                    {
                        int day = DateTime.DaysInMonth(
                        Convert.ToInt32(CB_Year.SelectedItem.ToString()),
                        Convert.ToInt32(CB_Month.SelectedItem.ToString()));
                        for (int i = 1; i <= day; i++)
                        {
                            SelectResult k = (from P in List_AccTemp
                                              where (P.Account_Time.Day == i)
                                              group P by P.Account_Time.Day into K
                                              select new SelectResult
                                              {
                                                  Time = i,
                                                  Price = K.Sum(P => P.Account_Price)
                                              }).FirstOrDefault();
                            Temp_result.Add(k ?? new SelectResult() { Price = 0, Time = i });
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        SelectResult k = (from P in List_AccTemp
                                          where (P.Account_Time.Month == i)
                                          group P by P.Account_Time.Month into K
                                          select new SelectResult
                                          {
                                              Time = i,
                                              Price = K.Sum(P => P.Account_Price)
                                          }).FirstOrDefault();
                        Temp_result.Add(k ?? new SelectResult() { Price = 0, Time = i });
                    }
                }
            }
            else
            {
                for (int i = DateTime.Now.Year-5; i <= DateTime.Now.Year; i++)
                {
                    SelectResult k = (from P in List_AccTemp
                                      where (P.Account_Time.Year == i)
                                      group P by P.Account_Time.Year into K
                                      select new SelectResult
                                      {
                                          Time = i,
                                          Price = K.Sum(P => P.Account_Price)
                                      }).FirstOrDefault();
                    Temp_result.Add(k ?? new SelectResult() { Price = 0, Time = i });
                }
            }
            #endregion


            Pic.Series["交易额"].Points.DataBind(Temp_result, "Time", "Price", "AxisLabel=Time,Label=Price");
            Pic.Series["交易额"].ChartType = SeriesChartType.Column;
            Pic.Series["交易额"].IsValueShownAsLabel = true;
            //Pic.Series["S1"].Points.DataBindXY(X,Y);

            //foreach (DataPoint point in Pic.Series["S1"].Points)
            //{
            //    point["Exploded"] = "false";
            //    if(point.AxisLabel=
            //}

            //Pic.DataSource = Temp_result;
            Pic.DataBind();

        }
    }
    class SelectResult
    {
        public int Time { get; set; }
        public decimal Price { get; set; }

    }

}
