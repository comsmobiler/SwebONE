using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SmoONE.Domain
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  联系人,用DataAnnotations定义映射到数据库.继承IAggregateRoot，不想使用InputDto的话,可以根据IAggregateRoot类型进行DataAnnotations验证,也方便以后扩展.有部分配置在LeaveConfiguration中
    // ******************************************************************

    /// <summary>
    /// 联系人
    /// </summary>
    [Table("Contact")]
    public class Contact: IAggregateRoot
    {
        /// <summary>
        /// 联系人ID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("联系人ID")]
        public int C_ID { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("联系人")]
        public string C_USER { get; set; }


        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("创建日期")]
        [Column(TypeName = "datetime")]
        public DateTime C_CreateDate { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string C_CreateUser { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        [Column(TypeName = "datetime")]
        [DisplayName("更新日期")]
        public DateTime C_UpdateDate { get; set; }

        /// <summary>
        /// 更新者ID
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新者")]
        public string C_UpdateUser { get; set; }
    }
}
