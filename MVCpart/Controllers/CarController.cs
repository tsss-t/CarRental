using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using MVCpart.CarSummeryService;
using System.ServiceModel.Security;
using MVCpart.ProvinceService;
using MVCpart.Models;
using MVCpart.ActionService;
using System.IO;
/*
 * 编写人:杜天行
 * 编写时间:2012年5月6日10:47:56
 * 编写版本:V1.0
 * -2.0
 * 实现省市店三级查找
 * 
 * -1.0
 * 实现汽车浏览控制类
 * */

namespace MVCpart.Controllers
{
    public class CarController : Controller
    {
        #region 城市选择页面
        [HttpGet]
        public ActionResult SelectArea(int? ID)
        {
            ProvinceClient Province_Clinet = (ProvinceClient)ClientFactory.GetClient(ClientType.Type.Province);
            List<Car_Province> List_Province = Province_Clinet.SelectAllProvinces().ToList();
            Province_Clinet.Close();
            return View(List_Province);
        }
        public ActionResult SelectCity(int? ID)
        {
            ID = ID ?? 0;
            CityService.CityClient City_Client = (CityService.CityClient)ClientFactory.GetClient(ClientType.Type.City);
            List<CityService.Car_City> List_City = City_Client.SelectAllCitys().ToList();
            City_Client.Close();
            if (ID != 0)
            {
                ViewData["City"] = List_City.Where(P => P.City_Province == ID).ToList();
            }
            return View("SelectCity", List_City.Where(P => P.City_Province == ID).ToList());
        }
        #endregion
        #region Select页面
        //
        // GET: /Car/
        /// <summary>
        /// 浏览汽车信息视图
        /// </summary>
        /// <param name="ID">城市编号</param>
        /// <returns></returns>
        public ActionResult Select(int? ID)
        {
            ID = ID ?? 0;
            this.HttpContext.Session["CityID"] = ID;
            //设置车辆浏览模型
            CarSummeryClient CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
            List<Car_ViewModel> List_Car = CarSummery_Client.SelectAllCar().ToList();
            if (ID != 0)
            {
                List_Car = List_Car.Where(P => P.City_ID == ID).ToList();
            }
            CarSummery_Client.Close();
            ViewData["Count"] = List_Car.Count();
            this.HttpContext.Session["Model"] = List_Car;

            //设置店铺
            ShopService.ShopClient Shop_Client = (ShopService.ShopClient)ClientFactory.GetClient(ClientType.Type.Shop);
            List<ShopService.Car_Shop> List_Shop = Shop_Client.SelectAllShops().Where(P => P.Shop_City == ID).ToList();
            Shop_Client.Close();
            List_Shop.Insert(0, new ShopService.Car_Shop() { Shop_ID = 0, Shop_Name = "全部" });
            ViewData["ListShop"] = List_Shop;
            this.HttpContext.Session["ShopSelect"] = 0;

            //设置车辆类型
            TypeService.TypeClient Type_Client = (TypeService.TypeClient)ClientFactory.GetClient(ClientType.Type.Type);
            List<TypeService.Car_Type> List_Type = Type_Client.SelectAllTypes().ToList();
            Type_Client.Close();
            List_Type.Insert(0, new TypeService.Car_Type() { Type_ID = 0, Type_Name = "全部" });
            ViewData["ListType"] = List_Type;
            this.HttpContext.Session["TypeSelect"] = 0;

            //设置租赁价格
            this.HttpContext.Session["MinPrice"] = 0;
            this.HttpContext.Session["MaxPrice"] = 100000;


            //设置品牌系列
            BrandService.BrandClient Brand_Client = (BrandService.BrandClient)ClientFactory.GetClient(ClientType.Type.Brand);
            List<BrandService.Car_Brand> List_Brand = Brand_Client.SelectAllBrands().ToList();
            Brand_Client.Close();
            List_Brand.Insert(0, new BrandService.Car_Brand() { Brand_ID = 0, Brand_Name = "全部" });
            ViewData["ListBrand"] = List_Brand;
            this.HttpContext.Session["BrandSelect"] = 0;

            return View(List_Car);
        }
        [HttpPost]
        public ActionResult Select(FormCollection formCollection)
        {
            return View();
        }
        public ActionResult SelectShop(int? ID)
        {
            ID = ID ?? 0;
            this.HttpContext.Session["ShopSelect"] = ID;
            int TypeID = Convert.ToInt32(this.HttpContext.Session["TypeSelect"]);
            int BrandID = Convert.ToInt32(this.HttpContext.Session["BrandSelect"]);
            int ShopID = Convert.ToInt32(this.HttpContext.Session["ShopSelect"]);
            decimal MinPrice = Convert.ToInt32(this.HttpContext.Session["MinPrice"]);
            decimal MaxPrice = Convert.ToInt32(this.HttpContext.Session["MaxPrice"]);

            List<CarSummeryService.Car_ViewModel> List_Car = (List<CarSummeryService.Car_ViewModel>)this.HttpContext.Session["Model"];
            List<CarSummeryService.Car_ViewModel> List_Temp = List_Car;
            if (TypeID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Type_ID == TypeID).ToList();
            }
            if (BrandID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Brand_ID == BrandID).ToList();
            }
            if (ShopID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Shop_ID == ShopID).ToList();
            }
            List_Temp = List_Temp.Where(P => P.Version_Price_Normal_Rental <= MaxPrice &&
                    P.Version_Price_Normal_Rental >= MinPrice).ToList();

            ViewData["Count"] = List_Temp.Count();
            return View("SelectCar", List_Temp.Take(10));
        }
        public ActionResult SelectType(int? ID)
        {
            ID = ID ?? 0;
            this.HttpContext.Session["TypeSelect"] = ID;
            int TypeID = Convert.ToInt32(this.HttpContext.Session["TypeSelect"]);
            int BrandID = Convert.ToInt32(this.HttpContext.Session["BrandSelect"]);
            int ShopID = Convert.ToInt32(this.HttpContext.Session["ShopSelect"]);
            decimal MinPrice = Convert.ToInt32(this.HttpContext.Session["MinPrice"]);
            decimal MaxPrice = Convert.ToInt32(this.HttpContext.Session["MaxPrice"]);
            List<CarSummeryService.Car_ViewModel> List_Car = (List<CarSummeryService.Car_ViewModel>)this.HttpContext.Session["Model"];
            List<CarSummeryService.Car_ViewModel> List_Temp = List_Car;
            if (TypeID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Type_ID == TypeID).ToList();

            }
            if (BrandID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Brand_ID == BrandID).ToList();
            }
            if (ShopID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Shop_ID == ShopID).ToList();
            }
            List_Temp = List_Temp.Where(P => P.Version_Price_Normal_Rental <= MaxPrice &&
                    P.Version_Price_Normal_Rental >= MinPrice).ToList();
            ViewData["Count"] = List_Temp.Count();
            return View("SelectCar", List_Temp.Take(10));
        }
        public ActionResult SelectBrand(int? ID)
        {
            ID = ID ?? 0;
            this.HttpContext.Session["BrandSelect"] = ID;
            int TypeID = Convert.ToInt32(this.HttpContext.Session["TypeSelect"]);
            int BrandID = Convert.ToInt32(this.HttpContext.Session["BrandSelect"]);
            int ShopID = Convert.ToInt32(this.HttpContext.Session["ShopSelect"]);
            decimal MinPrice = Convert.ToInt32(this.HttpContext.Session["MinPrice"]);
            decimal MaxPrice = Convert.ToInt32(this.HttpContext.Session["MaxPrice"]);
            List<CarSummeryService.Car_ViewModel> List_Car = (List<CarSummeryService.Car_ViewModel>)this.HttpContext.Session["Model"];
            List<CarSummeryService.Car_ViewModel> List_Temp = List_Car;
            if (TypeID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Type_ID == TypeID).ToList();
            }
            if (BrandID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Brand_ID == BrandID).ToList();
            }
            if (ShopID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Shop_ID == ShopID).ToList();
            }
            List_Temp = List_Temp.Where(P => P.Version_Price_Normal_Rental <= MaxPrice &&
                    P.Version_Price_Normal_Rental >= MinPrice).ToList();
            ViewData["Count"] = List_Temp.Count();
            return View("SelectCar", List_Temp.Take(10));
        }
        public ActionResult SelectPrice(int? ID)
        {
            ID = ID ?? 0;
            switch (ID)
            {
                case 0:
                    {
                        this.HttpContext.Session["MinPrice"] = 0;
                        this.HttpContext.Session["MaxPrice"] = 100000;
                        break;
                    }
                case 1:
                    {
                        this.HttpContext.Session["MinPrice"] = 0;
                        this.HttpContext.Session["MaxPrice"] = 199;
                        break;
                    }
                case 2:
                    {
                        this.HttpContext.Session["MinPrice"] = 200;
                        this.HttpContext.Session["MaxPrice"] = 499;
                        break;
                    }
                case 3:
                    {
                        this.HttpContext.Session["MinPrice"] = 500;
                        this.HttpContext.Session["MaxPrice"] = 999;
                        break;
                    }
                case 4:
                    {
                        this.HttpContext.Session["MinPrice"] = 1000;
                        this.HttpContext.Session["MaxPrice"] = 100000;
                        break;
                    }
            }
            int TypeID = Convert.ToInt32(this.HttpContext.Session["TypeSelect"]);
            int BrandID = Convert.ToInt32(this.HttpContext.Session["BrandSelect"]);
            int ShopID = Convert.ToInt32(this.HttpContext.Session["ShopSelect"]);
            decimal MinPrice = Convert.ToInt32(this.HttpContext.Session["MinPrice"]);
            decimal MaxPrice = Convert.ToInt32(this.HttpContext.Session["MaxPrice"]);
            List<CarSummeryService.Car_ViewModel> List_Car = (List<CarSummeryService.Car_ViewModel>)this.HttpContext.Session["Model"];
            List<CarSummeryService.Car_ViewModel> List_Temp = List_Car;
            if (TypeID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Type_ID == TypeID).ToList();
            }
            if (BrandID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Brand_ID == BrandID).ToList();
            }
            if (ShopID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Shop_ID == ShopID).ToList();
            }
            List_Temp = List_Temp.Where(P => P.Version_Price_Normal_Rental <= MaxPrice &&
                    P.Version_Price_Normal_Rental >= MinPrice).ToList();
            ViewData["Count"] = List_Temp.Count();
            return View("SelectCar", List_Temp.Take(10));
        }
        public ActionResult SelectPage(int? ID)
        {
            ID = ID ?? 1;
            int TypeID = Convert.ToInt32(this.HttpContext.Session["TypeSelect"]);
            int BrandID = Convert.ToInt32(this.HttpContext.Session["BrandSelect"]);
            int ShopID = Convert.ToInt32(this.HttpContext.Session["ShopSelect"]);
            decimal MinPrice = Convert.ToInt32(this.HttpContext.Session["MinPrice"]);
            decimal MaxPrice = Convert.ToInt32(this.HttpContext.Session["MaxPrice"]);
            List<CarSummeryService.Car_ViewModel> List_Car = (List<CarSummeryService.Car_ViewModel>)this.HttpContext.Session["Model"];
            List<CarSummeryService.Car_ViewModel> List_Temp = List_Car;
            if (TypeID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Type_ID == TypeID).ToList();
            }
            if (BrandID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Brand_ID == BrandID).ToList();
            }
            if (ShopID != 0)
            {
                List_Temp = List_Temp.Where(P => P.Shop_ID == ShopID).ToList();
            }
            List_Temp = List_Temp.Where(P => P.Version_Price_Normal_Rental <= MaxPrice &&
                    P.Version_Price_Normal_Rental >= MinPrice).ToList();
            ViewData["Count"] = List_Temp.Count();
            return View("SelectCar", List_Temp.Skip(10 * (int)(ID - 1)).Take(10 * (int)ID));
        }
        #endregion
        [HttpGet]
        public ActionResult SelectInfo(int CityID,int ShopID,int VersionID)
        {
            Car_ViewModel CarInfo;
            ViewData["CityID"] = CityID;
            ViewData["ShopID"] = ShopID;
            ViewData["VersionID"] = VersionID;
            CarSummeryClient CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
            CarInfo = CarSummery_Client.SelectAllCar().Where(P => P.Version_ID == VersionID).FirstOrDefault();
            CarSummery_Client.Close();
            if (Session["UserName"] == null)
            {
                Session["BackUrl"] = Request.Url.AbsoluteUri;
            }
            return View(CarInfo);
        }
        [HttpPut]
        public ActionResult OrderGet(OrderViewModel CarModel,String ShopID,String RentalNumber,String Code)
        {
            if (Session["UserName"] != null)
            {
                if (Code.ToLower() == Session["Code"].ToString().ToLower())
                {
                    try
                    {
                        OrderService.Car_Order order = new OrderService.Car_Order
                        {
                            Order_Action = Convert.ToInt32(CarModel.ActionEvent),
                            Order_Count = Convert.ToInt32( RentalNumber),
                            Order_IsCatch = CarModel.IsCatch,
                            Order_Message = CarModel.Info,
                            Order_Start_Time = Convert.ToDateTime(CarModel.StartTime),
                            Order_End_Time = Convert.ToDateTime(CarModel.EndTime),
                            Order_Version = CarModel.VersionID,
                            Order_RentalType = CarModel.RiderType,
                            Order_User = Guid.Parse(Session["UserID"].ToString()),
                            Order_Shop=Convert.ToInt32(ShopID),
                            Order_Time=DateTime.Now,
                            Order_DepositPay=false

                        };
                        OrderService.OrderClient Order_Client = (OrderService.OrderClient)ClientFactory.GetClient(ClientType.Type.Order);
                        if (Order_Client.AddOrder(order))
                        {
                            return View("OrderSuccess");
                        }
                        else
                        {
                            return View("OrderFaile");
                        }
                    }
                    catch
                    {
                        return View("OrderFaile");
                    }
                }
            }
            return View("OrderFaile");
        }
        [HttpPost]
        public ActionResult OrderGet(int CityID, int ShopID, int? VersionID)
        {
            ViewData["CityID"] = CityID;
            ViewData["ShopID"] = ShopID;
            VersionID = VersionID ?? 1;

            //判断是否登录
            if (Session["UserName"] == null)
            {
                return View("OrderPart",new OrderViewModel());
            }
            else
            {
                //当之前没有选择店铺时,现在列出店铺列表提供选择
                CarSummeryClient CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
                List<Car_ViewModel> List_Car = CarSummery_Client.SelectAllCar().ToList();
                List_Car = List_Car.Where(P => P.City_ID == CityID && P.Version_ID == VersionID).ToList();
                CarSummery_Client.Close();
                if (ShopID == 0)
                {
                    List<SelectListItem> ShopList = new List<SelectListItem>();
                    foreach (Car_ViewModel temp in List_Car)
                    {
                        SelectListItem SL = new SelectListItem();
                        SL.Text = temp.Shop_Name;
                        SL.Value = temp.Shop_ID.ToString();
                        if (!ShopList.Contains(SL))
                        {
                            ShopList.Add(SL);
                        }
                    }
                    ViewData["ShopList"] = ShopList;
                }
                //添加活动事件选项表
                ActionClient Action_Client = (ActionClient)ClientFactory.GetClient(ClientType.Type.Action);
                List<Car_Action> ActionList = Action_Client.SelectAllActions().ToList();
                Action_Client.Close();
                List<SelectListItem> ListAction = new List<SelectListItem>();
                foreach (Car_Action Temp in ActionList)
                {
                    SelectListItem sl = new SelectListItem();
                    sl.Text = Temp.Action_Name;
                    sl.Value = Temp.Action_ID.ToString();
                    ListAction.Add(sl);
                }
                ViewData["ActionList"] = ListAction;

                return View("OrderPart", new OrderViewModel()
                {
                    VersionID = (int)VersionID,
                    StartTime = DateTime.Now.Date.ToString(),
                    EndTime = DateTime.Now.Date.ToString()
                });
            }

        }
        [HttpPost]
        public String  RentalNumberGet(int ShopID,int VersionID,String StartTime,String EndTime)
        {
            String[] starttime = StartTime.Split('/');
            String[] endtime = EndTime.Split('/');

            //得到所选择的车的所有存在数量
            CarSummeryClient CarSummery_Client = (CarSummeryClient)ClientFactory.GetClient(ClientType.Type.CarSummery);
            List<Car_ViewModel> List_Car = CarSummery_Client.SelectAllCar().ToList();
            List_Car = List_Car.Where(P => P.Shop_ID == ShopID && P.Version_ID == VersionID).ToList();
            int Car_Total=List_Car.FirstOrDefault().Version_Count;
            CarSummery_Client.Close();

            //得到所选择的车的已预订数量
            List<SelectListItem> CarCountList = new List<SelectListItem>();
            OrderSummeryService.OrderSummeryClient OrderSummery_Client = (OrderSummeryService.OrderSummeryClient)ClientFactory.GetClient(ClientType.Type.OrderSummery);
            int Car_Count = OrderSummery_Client.SelectRentaledCarCount_TimeAndVersion(
            ShopID, (int)VersionID,
            Convert.ToInt32(starttime[0]),
            Convert.ToInt32(starttime[1]),
            Convert.ToInt32(starttime[2]),
            Convert.ToInt32(endtime[0]),
            Convert.ToInt32(endtime[1]),
            Convert.ToInt32(endtime[2])
            );
            StringWriter SW = new StringWriter();
            HtmlTextWriter writer = new HtmlTextWriter(SW);

            writer.AddAttribute("name", "RentalNumber");
            writer.AddAttribute("class", "TextBox");
            writer.AddAttribute("Stype", "height:20px;");
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            for (int i = 1; i <= Car_Total - Car_Count; i++)
            {
                writer.AddAttribute("label", i.ToString());
                writer.AddAttribute("value", i.ToString());
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(i.ToString());
                writer.RenderEndTag();
            }

            writer.RenderEndTag();
            return SW.ToString();
        }

    }
}
