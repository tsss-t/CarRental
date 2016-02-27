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
    public class UserLoginViewModel
    {
        [Required]
        [DisplayName("用户名")]
        public String UserName { get; set; }
        [Required]
        [DisplayName("密码")]
        public String Password { get; set; }

    }
    [PropertiesMustMatch("UserPassword", "UserConfirmPassword", ErrorMessage = "密码和确认密码不匹配。")]
    public class UserViewModel
    {
        [Required(ErrorMessage="请输入登陆名")]   
        [StringLength(20,MinimumLength=7,ErrorMessage="用户名必须在长度7-20之间")]
        [DisplayName("用户名")]
        public String UserName { get; set; }

        [Required(ErrorMessage="请输入密码")]   
        [StringLength(20,MinimumLength=7,ErrorMessage="密码必须在长度7-20之间")]
        [DisplayName("密码")]
        public String UserPassword { get; set; }

        [Required(ErrorMessage="请再次输入密码")]   
        [StringLength(20,MinimumLength=7,ErrorMessage="密码必须在长度7-20之间")]
        [DisplayName("再次输入密码")]
        public String UserConfirmPassword { get; set; }

         [Required(ErrorMessage="请输入您的电子邮箱地址")]   
        [StringLength(255,ErrorMessage="您输入的字符串过长")]
        [DisplayName("电子邮箱")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4})$",ErrorMessage="请输入正确的Email")]
        public String Email { get; set; }

        [Required(ErrorMessage="请输入密码提示问题")]
        [StringLength(255,ErrorMessage="您输入的字符串过长")]
        [DisplayName("密码提示问题")]
        public String Answer{ get; set; }

        [Required(ErrorMessage="请输入密码提示答案")]
        [StringLength(255,ErrorMessage="您输入的字符串过长")]
        [DisplayName("密码提示答案")]
        public String Question{ get; set; }

        [Required(ErrorMessage="请输入真实姓名")]
        [StringLength(10,ErrorMessage="您输入的字符串过长")]
        [DisplayName("真实姓名")]
        public String User_RealName{ get; set; }

        [Required(ErrorMessage="请输入身份证号码")]
        [StringLength(18,MinimumLength=15,ErrorMessage="您输入的身份证号码有误")]
        [DisplayName("身份证号码")]
        public String User_Validation{ get; set; }

        [Required(ErrorMessage="请输入联系电话")]
        [StringLength(30,ErrorMessage="您输入的字符串过长")]
        [DisplayName("联系电话")]
        public String User_Phone{ get; set; }

        [DisplayName("家庭住址")]
        [StringLength(255,ErrorMessage="您输入的字符串过长")]
        public String User_Adress{ get; set; }

        [DisplayName("备注")]
        [StringLength(255,ErrorMessage="您输入的字符串过长")]
        public String User_Info{ get; set; }

    }
      [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class PropertiesMustMatchAttribute : ValidationAttribute
    {
        private const string _defaultErrorMessage = "'{0}' 和 '{1}' 不匹配。";
        private readonly object _typeId = new object();

        public PropertiesMustMatchAttribute(string originalProperty, string confirmProperty)
            : base(_defaultErrorMessage)
        {
            OriginalProperty = originalProperty;
            ConfirmProperty = confirmProperty;
        }

        public string ConfirmProperty { get; private set; }
        public string OriginalProperty { get; private set; }

        public override object TypeId
        {
            get
            {
                return _typeId;
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentUICulture, ErrorMessageString,
                OriginalProperty, ConfirmProperty);
        }

        public override bool IsValid(object value)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value);
            object originalValue = properties.Find(OriginalProperty, true /* ignoreCase */).GetValue(value);
            object confirmValue = properties.Find(ConfirmProperty, true /* ignoreCase */).GetValue(value);
            return Object.Equals(originalValue, confirmValue);
        }
    }
}