using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Security.Permissions;

namespace WCFpart
{
    //[PrincipalPermission(SecurityAction.Demand, Role = "super user")] 
    public class Brand_Manager : Brand_DAO
    {
        DB_Helper<Car_Brand> DB_Brand = new DB_Helper<Car_Brand>();

        public List<Car_Brand> get_all_Brands()
        {
            return DB_Brand.getTable().ToList();
        }
        public Car_Brand get_brand(int brand_ID)
        {
            return DB_Brand.Select(P => P.Brand_ID == brand_ID).Single();
        }
        public List<Car_Brand> get_brands(Func<Car_Brand, bool> select_func)
        {
            return DB_Brand.Select(select_func).ToList();
        }
        public bool save_brand(Car_Brand brand)
        {
            return DB_Brand.Insert(brand);
        }
        public bool update_brand(Car_Brand brand)
        {
            Car_Brand old_Brand=DB_Brand.Select(P=>P.Brand_ID==brand.Brand_ID).Single();
            return DB_Brand.Update(old_Brand,brand);
        }

    }
}
