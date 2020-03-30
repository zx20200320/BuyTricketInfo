using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuyTricketInfo.Models
{
    [Table("Tickets")]
    public class Tickets
    {
        [Display(Name ="编号")]
        public int Id { get; set; }
        [Display(Name = "出发站")]
        /// <summary>
        /// 出发站
        /// </summary>
        public string DepartureStation { get; set; }
        [Display(Name = "到达站")]
        /// <summary>
        /// 到达站
        /// </summary>
        public string ArrivalStation { get; set; }
        [Display(Name = "车次")]
        /// <summary>
        /// 车次
        /// </summary>
        public string TrainNumber { get; set; }
        [Display(Name = "开点")]
        /// <summary>
        /// 开点
        /// </summary>
        public DateTime OpenPoint { get; set; }
        [Display(Name = "座位号")]
        /// <summary>
        /// 座位号
        /// </summary>
        public string SeatNo { get; set; }
        [Display(Name = "座次")]
        /// <summary>
        /// 座次
        /// </summary>
        public string SeatLevel { get; set; }
        [Display(Name = "票价")]
        /// <summary>
        /// 票价
        /// </summary>
        public float TicketPrice { get; set; }
        [Display(Name = "是否售出")]
        /// <summary>
        /// 是否售出
        /// </summary>
        public bool IsSaleOut { get; set; }
    }
}