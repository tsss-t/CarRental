using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MVCpart.Models
{
    public class OrderViewModel
    {
        [Required]
        public int VersionID { get; set; }
        [Required]
        [DisplayName("驾车方式")]
        public int RiderType
        {
            get;
            set;
        }
        [Required]
        [DisplayName("提车方式")]
        public bool IsCatch { get; set; }
        [Required]
        [DisplayName("起始时间")]
        public String StartTime { get; set; }
        [Required]
        [DisplayName("退还时间")]
        public String EndTime { get; set; }
        [Required]
        [DisplayName("参加活动")]
        public String ActionEvent { get; set; }
        [DisplayName("备注")]
        public String Info { get; set; }
    }
    public class CarViewModel
    {

    }
}