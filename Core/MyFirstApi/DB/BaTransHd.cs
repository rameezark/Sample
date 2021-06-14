using System;
using System.Collections.Generic;

namespace MyFirstApi.DB
{
    public partial class BaTransHd
    {
        public BaTransHd()
        {
            InverseParent = new HashSet<BaTransHd>();
        }

        public int Id { get; set; }
        public int KeptInCompanyId { get; set; }
        public int TransTypeId { get; set; }
        public string TransactionNo { get; set; }
        public int? ParentId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public string PostingType { get; set; }
        public int? ApprovedById { get; set; }
        public int? InterTransReferId { get; set; }
        public string DraftNo { get; set; }
        public string Reverse { get; set; }
        public DateTime? ReverseDate { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? TransCurrencyId { get; set; }
        public string TransactionSource { get; set; }
        public string TransactionNarration { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int? InterReversalId { get; set; }
        public string CentralPurchase { get; set; }
        public int? V5Id { get; set; }
        public string TransferType { get; set; }
        public int? SoTransactionId { get; set; }
        public string Reconciled { get; set; }
        public int? RecurrTransactionId { get; set; }
        public string RecurringType { get; set; }
        public int? IntercompanyEntityid { get; set; }
        public DateTime? OrgTransDate { get; set; }
        public string IsBankCharge { get; set; }

        public virtual BaTransHd Parent { get; set; }
        public virtual ICollection<BaTransHd> InverseParent { get; set; }
    }
}
