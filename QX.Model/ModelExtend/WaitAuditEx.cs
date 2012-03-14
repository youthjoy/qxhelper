using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Model
{
    /// <summary>
    /// 待审单据类型
    /// </summary>
    public class WaitAuditEx
    {
        /// <summary>
        /// 公司编码
        /// </summary>
        public string CompanyCode{get;set;}
        /// <summary>
        /// 公司名称
        /// </summary>
        public string Company{get;set;}
        /// <summary>
        /// 单据类型
        /// </summary>
        public string RType{get;set;}
        /// <summary>
        /// 单据类型名称
        /// </summary>
        public string RTypeName { get; set; }
        /// <summary>
        /// 单据编码
        /// </summary>
        public string RCode{get;set;}
        /// <summary>
        /// 单据名称
        /// </summary>
        public string RTitle{get;set;}
        /// <summary>
        /// 单据日期
        /// </summary>
        public string RDate { get; set; }
        /// <summary>
        /// 物料总金额
        /// </summary>
        public string RSum{get;set;}
    }
}
