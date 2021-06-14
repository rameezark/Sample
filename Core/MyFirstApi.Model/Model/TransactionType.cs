using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstApi.Model.Model
{
    [Table("BA_Trans_Type", Schema = "Common")]
    public class TransactionType
    {
        [Key]
        public int Id { get; set; }
        [Column("KEPT_IN_COMPANY_ID")]
        public int KeptInCompanyId { get; set; } 
        [Column("TRANS_TYPE")]
        [StringLength(7)]
        public string TransType { get; set; } 
        [Column("DESCRIPTION")]
        [StringLength(32)]
        public string Description { get; set; } 
        [Column("IS_INTERFACE")]
        [StringLength(1)]
        public string IsInterface { get; set; } = "N"; 
        [Column("SHOW_EMPNO")]
        [StringLength(1)]
        public string ShowEmpno { get; set; } = "N"; 
        [Column("SHOW_VSLCODE")]
        [StringLength(1)]
        public string ShowVslcode { get; set; } = "N";
        [Column("DEFAULT_CURRENCY_ID")]
        public int? DefaultCurrencyId { get; set; } 
        [Column("RATE_CHANGABLE")]
        [StringLength(1)]
        public string RateChangable { get; set; } = "N"; 
        [Column("CURRENCY_CHANGABLE")]
        [StringLength(1)]
        public string CurrencyChangable { get; set; } = "Y"; 
        [Column("ALLOW_DIFF_DATE")]
        [StringLength(1)]
        public string AllowDiffDate { get; set; } = "N"; 
        [Column("TEMPLATE")]
        [StringLength(2)]
        public string Template { get; set; } = "JV"; 
        [Column("ALLOW_CONTROL_ACCOUNT")]
        [StringLength(1)]
        public string AllowControlAccount { get; set; } = "N"; 
        [Column("CUSTOMER_RELATED")]
        [StringLength(1)]
        public string CustomerRelated { get; set; } = "N"; 
        [Column("BANKCASH")]
        [StringLength(1)]
        public string Bankcash { get; set; } = "C";
        [Column("TRANS_PREFIX")]
        [StringLength(5)]
        public string TransPrefix { get; set; }
        [Column("BASE")]
        [StringLength(1)]
        public string Base { get; set; } = "Y"; 
        [Column("REPORTING")]
        [StringLength(1)]
        public string Reporting { get; set; } = "Y"; 
        [Column("ORIGINAL")]
        [StringLength(1)]
        public string Original { get; set; } = "Y"; 
        [Column("REV_TRANS_TYPE_ID")]
        public int? RevTransTypeId { get; set; }  
        [Column("MODIFIED_BY_ID")]
        public int ModifiedById { get; set; }  
        [Column("MODIFIED_ON")]
        public System.DateTime ModifiedOn { get; set; } 
        [Column("INTERCOMPANY_TRANS")]
        [StringLength(1)]
        public string IntercompanyTrans { get; set; } = "N"; 
        [Column("SHOW_OFFSHORE_EMP")]
        [StringLength(1)]
        public string ShowOffshoreEmp { get; set; } = "N"; 
        [Column("ERP_TRANS_TYPE")]
        [StringLength(15)]
        public string ErpTransType { get; set; } 
    }
}
