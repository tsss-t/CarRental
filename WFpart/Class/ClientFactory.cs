using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using WFpart;
using WFpart.AccountService;
using WFpart.ActionService;
using WFpart.BrandService;
using WFpart.CarSummeryService;
using WFpart.CheckoutService;
using WFpart.CityService;
using WFpart.OrderService;
using WFpart.OrderSummeryService;
using WFpart.ProvinceService;
using WFpart.RAPService;
using WFpart.SalaryAppendService;
using WFpart.SalaryInfoSummeryService;
using WFpart.SalaryLogService;
using WFpart.SalaryService;
using WFpart.ShopService;
using WFpart.TypeService;
using WFpart.UserManagerService;
using WFpart.UserSummeryService;
using WFpart.VersionService;
using WFpart.WorkRAPService;
using WFpart.GetCarService;
/*
 * 编写人:杜天行
 * 编写时间:2012年4月18日15:10:56
 * 编写版本:v0.5
 * */
namespace WFpart
{
    /// <summary>
    /// 服务实例发生器
    /// </summary>
    public static class ClientFactory
    {
        static Dictionary<ClientType.Type, Object> Dic = new Dictionary<ClientType.Type, Object>();
        /// <summary>
        /// 添加一个服务
        /// </summary>
        /// <typeparam name="T">泛型化类型</typeparam>
        /// <param name="type">指定服务类型</param>
        /// <param name="Client">服务实例</param>
        public static void AddClient<T>(ClientType.Type type, T Client) where T : class
        {
            if (Dic.Where(P => P.Key == type).Count() == 0)
            {
                Dic.Add(type, Client);
            }
        }
        /// <summary>
        /// 获得客户端已经获得的服务实例
        /// </summary>
        /// <param name="type">服务类型</param>
        /// <returns></returns>
        public static object GetClient(ClientType.Type type)
        {
            //字典中存在——获得实例
            if (Dic.Where(P => P.Key == type).Count() != 0)
            {
                return Dic[type];
            }
            //字典中不存在——生成并返回实例
            else
            {
                return build(type);
            }

        }
        /// <summary>
        /// 客户端服务实例产生器
        /// </summary>
        /// <param name="type">产生的服务类型</param>
        /// <returns></returns>
        private static object build(ClientType.Type type)
        {
            switch (type)
            {
      
                case ClientType.Type.Account:
                    {
                        AccountClient temp = new AccountClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<AccountClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Action:
                    {
                        ActionClient temp = new ActionClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<ActionClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Brand:
                    {
                        BrandClient temp = new BrandClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<BrandClient>(type, temp);
                        return temp;
                    }

                case ClientType.Type.CarSummery:
                    {
                        CarSummeryClient temp = new CarSummeryClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<CarSummeryClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Checkout:
                    {
                        CheckoutClient temp = new CheckoutClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<CheckoutClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.City:
                    {
                        CityClient temp = new CityClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<CityClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Order:
                    {
                        OrderClient temp = new OrderClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<OrderClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.OrderSummery:
                    {
                        OrderSummeryClient temp = new OrderSummeryClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<OrderSummeryClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Province:
                    {
                        ProvinceClient temp = new ProvinceClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<ProvinceClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.RAP:
                    {
                        RAPClient temp = new RAPClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<RAPClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Salary:
                    {
                        SalaryClient temp = new SalaryClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<SalaryClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.SalaryAppend:
                    {
                        SalaryAppendClient temp = new SalaryAppendClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<SalaryAppendClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.SalaryInfoSummery:
                    {
                        SalaryInfoSummeryClient temp = new SalaryInfoSummeryClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<SalaryInfoSummeryClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.SalaryLog:
                    {
                        SalaryLogClient temp = new SalaryLogClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<SalaryLogClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Shop:
                    {
                        ShopClient temp = new ShopClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<ShopClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Type:
                    {
                        TypeClient temp = new TypeClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<TypeClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.Version:
                    {
                        VersionClient temp = new VersionClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<VersionClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.WorkRAP:
                    {
                        WorkRAPClient temp = new WorkRAPClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<WorkRAPClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.UserManager:
                    {
                        UserManagerClient temp = new UserManagerClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<UserManagerClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.UserSummery:
                    {
                        UserSummeryClient temp = new UserSummeryClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<UserSummeryClient>(type, temp);
                        return temp;
                    }
                case ClientType.Type.GetCar:
                    {
                        GetCarClient temp = new GetCarClient();
                        UserNamePasswordClientCredential UNPCC = temp.ClientCredentials.UserName;
                        UNPCC.UserName = GlobalParams.UserName;
                        UNPCC.Password = GlobalParams.Password;
                        AddClient<GetCarClient>(type, temp);
                        return temp;
                    }
            };
            return null;
        }
    }
}
