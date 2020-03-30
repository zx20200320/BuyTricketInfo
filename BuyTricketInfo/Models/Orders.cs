using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyTricketInfo.Models
{
    /// <summary>
    ///订单类
    /// </summary>
    [Table("Orders")]
    public class Orders
    {
        public int Id		 { get; set; }
        public string UserId	 { get; set; }
        public string TricketId { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime DepartTime { get; set; }
    }
}