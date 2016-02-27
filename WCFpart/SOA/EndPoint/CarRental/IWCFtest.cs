using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
/*
 * 编写人：杜天行
 * 编写时间：2012年4月9日11:06:47
 * 版本：v0.5
 * */
namespace WCFpart.SOA.EndPoint
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IWCFtest”。
    /// <summary>
    /// 活动服务终结点
    /// </summary>
    [ServiceContract]
    public interface IWCFtest
    {
        #region 增
        [OperationContract]
        bool AddAction(Car_Action Action);
        #endregion
        #region 删
        [OperationContract]
        bool DeleteAction(Car_Action Action);
        #endregion
        #region 改
        [OperationContract]
        bool UpdateAction(Car_Action NewAction);
        #endregion
        #region 查
        [OperationContract]
        Car_Action SelectAction_ID(int ActionID);
        [OperationContract]
        List<Car_Action> SelectAllActions();
        [OperationContract]
        List<Car_Action> SelectActionDIY_Func(Func<Car_Action, bool> where);
        [OperationContract]
        List<Car_Action> SelectActionDIY_Field(Func<Car_Action, bool> where, Func<Car_Action, Car_Action> select);
        #endregion
    }
}
