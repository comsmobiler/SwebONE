using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmoONE.DTOs
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  消费明细类型模板的数据传输对象,用于返回查询结果
    // ******************************************************************
    /// <summary>
    /// 消费明细类型模板的数据传输对象,用于返回查询结果
    /// </summary>
    public class RB_RType_TemplateDto
    {
        /// <summary>
        /// 报销类型模板ID
        /// </summary>
        public string RB_RTT_TemplateID { get; set; }

        /// <summary>
        /// 报销类型ID
        /// </summary>
        public string RB_RTT_TypeID { get; set; }


        /// <summary>
        /// 报销类型名称
        /// </summary>
        public string RB_TypeName { get; set; }

        /// <summary>
        /// 消费金额
        /// </summary>
        public decimal RB_RTT_Amount { get; set; }

        /// <summary>
        /// 消费备注
        /// </summary>
        public string RB_RTT_Note { get; set; }

    }
}
