using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyTricketInfo.Models
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    [Table("UserInfo")]
    public class UserInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id		 { get; set; }
        public string Name	 { get; set; }
        public string UserName { get; set; }
        public string PassWard { get; set; }
        public string Phone	 { get; set; }
        public string Remark { get; set; }
    }
}