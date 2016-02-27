using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WCFpart
{
    [ServiceContract]
    public interface Brand_DAO
    {
        [OperationContract]
        List<Car_Brand> get_all_Brands();
        [OperationContract]
        Car_Brand get_brand(int brand_ID);
        [OperationContract]
        List<Car_Brand> get_brands(Func<Car_Brand, bool> select_func);
        [OperationContract]
        bool save_brand(Car_Brand brand);
        [OperationContract]
        bool update_brand(Car_Brand brand);
    }
}
