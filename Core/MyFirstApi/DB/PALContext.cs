using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyFirstApi.DB
{
    public partial class PALContext : DbContext
    {
        public PALContext()
        {
        }

        public PALContext(DbContextOptions<PALContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaTransHd> BaTransHd { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.201.1.87,1433;initial catalog=PAL;Integrated Security=true;MultipleActiveResultSets=True;Min Pool Size=25;Max Pool Size=2000; Connection Timeout=60;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "MARIAPPS\\abdul.rameez");

            modelBuilder.Entity<BaTransHd>(entity =>
            {
                entity.ToTable("BA_Trans_HD", "Acct");

                entity.HasIndex(e => e.ApprovedOn)
                    .HasName("IX_BA_TRANS_HD_APPROVED_ON");

                entity.HasIndex(e => e.CreatedById)
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K8");

                entity.HasIndex(e => e.Id)
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K1");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_BA_TRANS_HD_PARENT_ID");

                entity.HasIndex(e => e.PostingType)
                    .HasName("IX_BA_TRANS_HD_POSTING_TYPE");

                entity.HasIndex(e => new { e.ApprovedOn, e.Id })
                    .HasName("idx_ba_trans_hd_nc_id");

                entity.HasIndex(e => new { e.Id, e.TransCurrencyId })
                    .HasName("_dta_stat_1203535371_1_16");

                entity.HasIndex(e => new { e.Id, e.TransactionDate })
                    .HasName("IX_BA_Trans_HD_TRANSACTION_DATE");

                entity.HasIndex(e => new { e.TransCurrencyId, e.TransactionDate })
                    .HasName("_dta_stat_1203535371_16_6");

                entity.HasIndex(e => new { e.TransTypeId, e.CreatedById })
                    .HasName("_dta_stat_1203535371_3_8");

                entity.HasIndex(e => new { e.TransactionNo, e.KeptInCompanyId })
                    .HasName("UQ_BA_TRANS_HD_TRANSACTION_NO_KEPT_IN_COMPANY_ID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Id, e.CreatedById, e.KeptInCompanyId })
                    .HasName("_dta_stat_1203535371_1_8_2");

                entity.HasIndex(e => new { e.TransCurrencyId, e.TransactionDate, e.Id })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K16_K6_K1");

                entity.HasIndex(e => new { e.TransactionDate, e.Id, e.PostingType })
                    .HasName("idx_acct_ba_trans_dt_nc_posting_type_1");

                entity.HasIndex(e => new { e.CreatedById, e.KeptInCompanyId, e.PostingType, e.Id })
                    .HasName("_dta_stat_1203535371_8_2_9_1");

                entity.HasIndex(e => new { e.KeptInCompanyId, e.TransTypeId, e.CreatedById, e.PostingType })
                    .HasName("IX_BA_TRANS_HD_KEPT_IN_COMPANY_ID_TRANS_TYPE_ID_CREATED_BY_ID_POSTING_TYPE");

                entity.HasIndex(e => new { e.TransTypeId, e.Id, e.KeptInCompanyId, e.CreatedById })
                    .HasName("_dta_stat_1203535371_3_1_2_8");

                entity.HasIndex(e => new { e.TransactionDate, e.Id, e.CreatedById, e.KeptInCompanyId })
                    .HasName("_dta_stat_1203535371_6_1_8_2");

                entity.HasIndex(e => new { e.Id, e.TransTypeId, e.KeptInCompanyId, e.PostingType, e.TransactionDate })
                    .HasName("IX_TRANS_HD_TRANS_TYPE");

                entity.HasIndex(e => new { e.Id, e.TransTypeId, e.TransactionNo, e.PostingType, e.TransactionDate })
                    .HasName("IX_BA_Trans_HD_POSTING_TYPE_TRANSACTION_DATE");

                entity.HasIndex(e => new { e.Id, e.TransactionDate, e.KeptInCompanyId, e.TransTypeId, e.CreatedById })
                    .HasName("_dta_stat_1203535371_1_6_2_3_8");

                entity.HasIndex(e => new { e.KeptInCompanyId, e.CreatedById, e.PostingType, e.TransactionDate, e.TransTypeId })
                    .HasName("_dta_stat_1203535371_2_8_9_6_3");

                entity.HasIndex(e => new { e.TransactionDate, e.CreatedById, e.KeptInCompanyId, e.PostingType, e.Id })
                    .HasName("_dta_stat_1203535371_6_8_2_9_1");

                entity.HasIndex(e => new { e.TransTypeId, e.Id, e.TransCurrencyId, e.KeptInCompanyId, e.CreatedById, e.PostingType })
                    .HasName("_dta_stat_1203535371_3_1_16_2_8_9");

                entity.HasIndex(e => new { e.TransactionDate, e.Id, e.TransCurrencyId, e.KeptInCompanyId, e.TransTypeId, e.CreatedById })
                    .HasName("_dta_stat_1203535371_6_1_16_2_3_8");

                entity.HasIndex(e => new { e.KeptInCompanyId, e.TransTypeId, e.CreatedById, e.PostingType, e.Id, e.TransactionDate, e.TransCurrencyId })
                    .HasName("_dta_stat_1203535371_2_3_8_9_1_6_16");

                entity.HasIndex(e => new { e.TransTypeId, e.TransactionNo, e.ParentId, e.TransCurrencyId, e.TransactionNarration, e.TransactionDate, e.CreatedById, e.KeptInCompanyId, e.PostingType, e.Id })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K6_K8_K2_K9_K1_3_4_5_16_18");

                entity.HasIndex(e => new { e.TransTypeId, e.TransactionNo, e.ParentId, e.TransCurrencyId, e.TransactionNarration, e.TransactionDate, e.Id, e.CreatedById, e.KeptInCompanyId, e.PostingType })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K6_K1_K8_K2_K9_3_4_5_16_18");

                entity.HasIndex(e => new { e.TransactionNo, e.ParentId, e.TransactionNarration, e.KeptInCompanyId, e.CreatedById, e.PostingType, e.TransactionDate, e.TransTypeId, e.Id, e.TransCurrencyId })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K2_K8_K9_K6_K3_K1_K16_4_5_18");

                entity.HasIndex(e => new { e.TransactionNo, e.ParentId, e.TransactionNarration, e.TransCurrencyId, e.TransactionDate, e.Id, e.KeptInCompanyId, e.TransTypeId, e.CreatedById, e.PostingType })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K16_K6_K1_K2_K3_K8_K9_4_5_18");

                entity.HasIndex(e => new { e.TransactionNo, e.ParentId, e.TransactionNarration, e.TransTypeId, e.CreatedById, e.KeptInCompanyId, e.PostingType, e.Id, e.TransactionDate, e.TransCurrencyId })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K3_K8_K2_K9_K1_K6_K16_4_5_18");

                entity.HasIndex(e => new { e.TransactionNo, e.ParentId, e.TransactionNarration, e.TransactionDate, e.Id, e.TransCurrencyId, e.KeptInCompanyId, e.TransTypeId, e.CreatedById, e.PostingType })
                    .HasName("_dta_index_BA_Trans_HD_5_1203535371__K6_K1_K16_K2_K3_K8_K9_4_5_18");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApprovedById).HasColumnName("APPROVED_BY_ID");

                entity.Property(e => e.ApprovedOn).HasColumnName("APPROVED_ON");

                entity.Property(e => e.CentralPurchase)
                    .IsRequired()
                    .HasColumnName("CENTRAL_PURCHASE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CreatedById).HasColumnName("CREATED_BY_ID");

                entity.Property(e => e.CreatedOn).HasColumnName("CREATED_ON");

                entity.Property(e => e.DraftNo)
                    .IsRequired()
                    .HasColumnName("DRAFT_NO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InterReversalId).HasColumnName("INTER_REVERSAL_ID");

                entity.Property(e => e.InterTransReferId).HasColumnName("INTER_TRANS_REFER_ID");

                entity.Property(e => e.IntercompanyEntityid).HasColumnName("INTERCOMPANY_ENTITYID");

                entity.Property(e => e.IsBankCharge)
                    .HasColumnName("IS_BANK_CHARGE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KeptInCompanyId).HasColumnName("KEPT_IN_COMPANY_ID");

                entity.Property(e => e.ModifiedById).HasColumnName("MODIFIED_BY_ID");

                entity.Property(e => e.ModifiedOn).HasColumnName("MODIFIED_ON");

                entity.Property(e => e.OrgTransDate)
                    .HasColumnName("ORG_TRANS_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");

                entity.Property(e => e.PostingType)
                    .IsRequired()
                    .HasColumnName("POSTING_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.Reconciled)
                    .HasColumnName("RECONCILED")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RecurrTransactionId).HasColumnName("RECURR_TRANSACTION_ID");

                entity.Property(e => e.RecurringType)
                    .HasColumnName("RECURRING_TYPE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Reverse)
                    .IsRequired()
                    .HasColumnName("REVERSE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ReverseDate)
                    .HasColumnName("REVERSE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SoTransactionId).HasColumnName("SO_TRANSACTION_ID");

                entity.Property(e => e.TransCurrencyId).HasColumnName("TRANS_CURRENCY_ID");

                entity.Property(e => e.TransTypeId).HasColumnName("TRANS_TYPE_ID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("TRANSACTION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.TransactionNarration)
                    .HasColumnName("TRANSACTION_NARRATION")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionNo)
                    .IsRequired()
                    .HasColumnName("TRANSACTION_NO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSource)
                    .HasColumnName("TRANSACTION_SOURCE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferType)
                    .HasColumnName("TRANSFER_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.V5Id).HasColumnName("V5_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ACCT_BA_TRANS_HD_PARENT_ID_ACCT_BA_TRANS_HD_ID");
            });

            modelBuilder.HasSequence("ApplicableBusinessCentres_ID_SEQ", "Acct");

            modelBuilder.HasSequence("AR_APPROVAL_LIST_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence<int>("ARAPAGEING_GRP_COMPANIES_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Abs_Accounts_Map_SEQ", "Acct").StartsAt(110421);

            modelBuilder.HasSequence("BA_Abs_Imports_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Abs_Inv_DT_SEQ", "Acct").StartsAt(160002);

            modelBuilder.HasSequence("BA_Abs_Inv_Hd_SEQ", "Acct").StartsAt(115002);

            modelBuilder.HasSequence("BA_Abs_Orders_SEQ", "Acct").StartsAt(2700002);

            modelBuilder.HasSequence("BA_Abs_Vendor_Map_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Abs_Vessel_Map_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("ba_ageing_analysis_setup_seq", "Acct").HasMax(999999999999999999);

            modelBuilder.HasSequence("BA_Allotment_Mapping_SEQ", "Acct").StartsAt(105003);

            modelBuilder.HasSequence("BA_Analysis_Type_SEQ", "Acct").StartsAt(142841);

            modelBuilder.HasSequence("BA_Appl_Subaccount_SEQ", "Acct").StartsAt(302129);

            modelBuilder.HasSequence("BA_Applicable_Analysis_SEQ", "Acct").StartsAt(302546);

            modelBuilder.HasSequence("BA_APPROVAL_LIST_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_AP_MAPPING_ANALYSIS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_AP_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_APPROVAL_LIST_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_AR_AUTO_BILLING_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_DM_INVOICE_CLIENT_MAP_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_INTERCOMPANY_MAPPING_ANALYSIS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_INTERCOMPANY_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_INVOICE_CSC_COMPANY_MAP_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_AR_INVOICE_DT_CREDIT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_AR_INVOICE_DT_CSC_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_AR_INVOICE_DT_ECONNECT_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("ba_ar_invoice_dt_seq", "Acct").StartsAt(279298);

            modelBuilder.HasSequence("ba_ar_invoice_dt_sub_seq", "Acct").StartsAt(279298);

            modelBuilder.HasSequence("ba_ar_invoice_hd_seq", "Acct").StartsAt(166678);

            modelBuilder.HasSequence("BA_AR_Recvpay_SEQ", "Acct").StartsAt(160674);

            modelBuilder.HasSequence<int>("BA_ARINVOICE_SHORE_EMP_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Attachments_SEQ", "Acct").StartsAt(110003);

            modelBuilder.HasSequence<int>("BA_AUTO_BILLING_NEGATIVE_LIST_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BA_WESTERNUNION_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Bank_Accounts_SEQ", "Acct").StartsAt(105006);

            modelBuilder.HasSequence("BA_BANK_CHARGES_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_DEAL_NUMBER_REGISTER_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_CAMT_DT_STMT_BAL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_CAMT_DT_STMT_NTRY_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_CAMT_DT_STMT_NTRY_TXDTLS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_CAMT_DT_STMT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_CAMT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_DT_TRANS_DATA_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BANK_RECONCILE_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BERENBERG_CORPORATE_INTR_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BERENBERG_CORPORATE_SEPA_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BILLING_TYPE_MAST_SEQ", "Acct");

            modelBuilder.HasSequence("BA_BSM_BS_ENTITY_MAPPING_seq", "Acct");

            modelBuilder.HasSequence("BA_BSM_BS_TRANSFER_LOG_seq", "Acct");

            modelBuilder.HasSequence("BA_Budget_Alloc_SEQ", "Acct").StartsAt(958293);

            modelBuilder.HasSequence("BA_Budget_Analysis_Alloc_SEQ", "Acct").StartsAt(700976);

            modelBuilder.HasSequence("BA_Budget_Analysis_DT_SEQ", "Acct").StartsAt(157196);

            modelBuilder.HasSequence("BA_Budget_DT_SEQ", "Acct").StartsAt(474224);

            modelBuilder.HasSequence("BA_Budget_Hd_SEQ", "Acct").StartsAt(110139);

            modelBuilder.HasSequence("BA_CHART_DT_SEQ", "Acct").StartsAt(4868968);

            modelBuilder.HasSequence("BA_CHART_HD_ANALYSIS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Chart_Hd_SEQ", "Acct").StartsAt(114976);

            modelBuilder.HasSequence("BA_CHARTER_ACCOUNTS_ANALYSIS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_CHARTER_ACCOUNTS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_CHARTERER_ACCOUNT_DESCRIPTION_SEQ", "Acct");

            modelBuilder.HasSequence("BA_CHARTERER_ACCOUNT_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Company_Departments_Disb_SEQ", "Acct").StartsAt(105003);

            modelBuilder.HasSequence("BA_CONS_CHART_DT_SEQ", "Acct").StartsAt(317093);

            modelBuilder.HasSequence("BA_Cons_Chart_Hd_SEQ", "Acct").StartsAt(105004);

            modelBuilder.HasSequence("BA_Cost_Alloc_Draft_SEQ", "Acct").StartsAt(1282728);

            modelBuilder.HasSequence("ba_cost_alloc_SEQ", "Acct").StartsAt(1283156);

            modelBuilder.HasSequence("BA_COUNTRY_MAST_SEQ", "Acct").StartsAt(101003);

            modelBuilder.HasSequence("BA_CTM_REQUEST_REGISTER_SEQ", "Acct");

            modelBuilder.HasSequence("BA_CUSTOMERS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_DATA_TRANSFER_ACCOUNT_MAPPING_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_DATA_TRANSFER_ACCOUNT_MAPPING_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_DBS_FORMAT_TYPE_SEQ", "Acct").StartsAt(115002);

            modelBuilder.HasSequence("BA_DEUTCH_BANK_SEQ", "Acct").StartsAt(105003);

            modelBuilder.HasSequence("BA_DEUTSCHE_BANK_INTERFACE_LOG_SEQ", "Acct");

            modelBuilder.HasSequence("BA_DISB_ACCRUAL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_DISB_ADVANCE_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Disb_Advance_SEQ", "Acct").StartsAt(105011);

            modelBuilder.HasSequence("BA_DISB_APPROVAL_TEMPLATE_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Disb_Credits_SEQ", "Acct").StartsAt(126656);

            modelBuilder.HasSequence("BA_DISB_CTM_REQUEST_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Disb_DT_SEQ", "Acct").StartsAt(129410);

            modelBuilder.HasSequence("BA_Disb_Exp_SEQ", "Acct").StartsAt(284272);

            modelBuilder.HasSequence("BA_Disb_Hd_SEQ", "Acct").StartsAt(128701);

            modelBuilder.HasSequence("BA_Disb_Status_SEQ", "Acct").StartsAt(129229);

            modelBuilder.HasSequence("BA_EBANK_DTAZ_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EBANK_DTAZV_RECQ_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EBANK_DTAZV_RECT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EBANK_DTAZV_RECZ_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EMAIL_NOTIFICATION_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Entity_Locking_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_ENTITY_SUBCOMPANY_SEQ", "Acct").StartsAt(105007);

            modelBuilder.HasSequence("BA_ETN_LOCATION_ARRANGER_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_ETN_LOCATION_CITY_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_ETN_LOCATION_PCC_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EURASIA_CLIENT_DETAIL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EURASIA_INTERFACE_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EURASIA_INTERFACE_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_EXCHANGE_RATE_BANKDEFRANCE_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Exchange_Rate_SEQ", "Acct").StartsAt(125624);

            modelBuilder.HasSequence("BA_EXPENSE_MASTER_SEQ", "Acct").StartsAt(110096);

            modelBuilder.HasSequence("BA_ExRate_Download_Log_SEQ", "Acct").StartsAt(1001);

            modelBuilder.HasSequence("BA_Financial_Year_SEQ", "Acct").StartsAt(114473);

            modelBuilder.HasSequence("BA_Forcast_Alloc_SEQ", "Acct").StartsAt(105000);

            modelBuilder.HasSequence("BA_Forecast_DT_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Forecast_Hd_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_GROUP_SUBACCOUNT_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_HANS_ENTITYMAPPING_SEQ", "Acct").StartsAt(1000);

            modelBuilder.HasSequence("BA_HOLD_RELEASE_DTL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_HOLIDAY_CALENDAR_SEQ", "Acct");

            modelBuilder.HasSequence("BA_HSBC_PAYMENT_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_HSBC_PAYMENT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_HSBC_PAYMENT_PARAMETERS_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_I2P_USER_ACCESS_TOKEN_SEQ", "Acct");

            modelBuilder.HasSequence("ba_Import_Disbursement_temp_SEQ", "Acct");

            modelBuilder.HasSequence("ba_Import_Transaction_temp_SEQ", "Acct").StartsAt(105006);

            modelBuilder.HasSequence("BA_IMPORT_TRANSFER_ACC_SUBACC_DT_SEQ", "Acct").StartsAt(10);

            modelBuilder.HasSequence("BA_IMPORT_TRANSFER_ACC_SUBACC_SEQ", "Acct").StartsAt(10);

            modelBuilder.HasSequence("BA_IMPORT_WORLDLINK_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_IMPORT_WORLDLINK_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INSURANCE_MAPPING_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Intercompany_Mapping_SEQ", "Acct").StartsAt(3001);

            modelBuilder.HasSequence("BA_INTERFACING_WITH_HYPERION_LOG_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INTERFACING_WITH_HYPERION_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INVOICE_ADVANCE_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INVOICE_ADVANCE_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INVOICE_APPROVAL_RIGHTS_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INVOICE_APPROVAL_RIGHTS_DT_USERS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_INVOICE_APPROVAL_RIGHTS_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Invoice_HD_I2P_TEMP_TBL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Invoice_Mapping_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_ISS_VESSEL_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_LAST_NUMBER_USED_I2P_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Locked_Accounts_GLOBAL_APPL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Locked_Accounts_GLOBAL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Locked_Accounts_SEQ", "Acct").StartsAt(122058);

            modelBuilder.HasSequence("BA_LUBE_TRANSACTION_LOG_SEQ", "Acct");

            modelBuilder.HasSequence("BA_MITSUI_ACCOUNT_MAPPING_SEQ", "Acct").StartsAt(110421);

            modelBuilder.HasSequence("ba_multicash_seq", "Acct").StartsAt(152874);

            modelBuilder.HasSequence("BA_Opening_Balance_Anl_SEQ", "Acct").StartsAt(507171);

            modelBuilder.HasSequence("BA_Opening_Balance_DT_SEQ", "Acct").StartsAt(726850);

            modelBuilder.HasSequence("BA_Opening_Balance_Hd_SEQ", "Acct").StartsAt(518214);

            modelBuilder.HasSequence("BA_Operation_Cost_SEQ", "Acct").StartsAt(105009);

            modelBuilder.HasSequence<int>("BA_OPEX_AR_MAPPING_ACCOUNTS_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_OPEX_AR_MAPPING_ANALYSIS_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_OPEX_AR_MAPPING_LOG_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_OPEX_AR_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_PAID_BY_OWNER_MAIL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_ACTIVE_RECORDS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_APPROVAL_LIST_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_BERENBERG_BANK_PAYMENT_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_BERENBERG_BANK_PAYMENT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_CITI_BANK_PAYMENT_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_CITI_BANK_PAYMENT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_CITY_BANK_PAYMENT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_HSBC_BANK_PAYMENT_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_HSBC_BANK_PAYMENT_DT_SUB_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_HSBC_BANK_PAYMENT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_SEPA_BANK_PAYMENT_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_SEPA_BANK_PAYMENT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_SMBC_BANK_PAYMENT_DT_ASIA_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_SMBC_BANK_PAYMENT_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_BATCH_SMBC_BANK_PAYMENT_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_PURPOSE_MAST_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_PURPOSE_MAST_MAPPING2_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PAYMENT_TYPE_CHARGE_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_PO_ACCRUAL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_PUBLISH_ENTITY_SEQ", "Acct").StartsAt(1000);

            modelBuilder.HasSequence("BA_RBS_EXPORT_SEQ", "Acct").StartsAt(105013);

            modelBuilder.HasSequence("BA_Reason_Tax_Exemption_SEQ", "Acct").StartsAt(105004);

            modelBuilder.HasSequence("BA_RECCR_BILLING_INV_GEN_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_RECCR_BILLING_INV_GEN_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Recurring_DT_SEQ", "Acct").StartsAt(105004);

            modelBuilder.HasSequence("BA_Recurring_Logs_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Recurring_Trans_SEQ", "Acct").StartsAt(105003);

            modelBuilder.HasSequence("BA_Report_Parameter_SEQ", "Acct").StartsAt(105354);

            modelBuilder.HasSequence("BA_SAMPLE_TBL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SEACHEF_CMP_MAPPING_ANALYSIS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SEACHEF_CMP_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SEACHEF_COMPONENTS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SEACHEF_INV_GEN_DT_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SEACHEF_INV_GEN_HD_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_SEACHEF_RECURRING_LOGS_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_SEACHEF_RECURRING_TRANS_DT_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_SEACHEF_RECURRING_TRANS_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SEPA_SEQ", "Acct").StartsAt(110003);

            modelBuilder.HasSequence("BA_SharePoint_Attachment_I2P_TEMP_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SharePoint_Attachment_I2P_TEMP_TBL_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SharePoint_Attachment_seq", "Acct");

            modelBuilder.HasSequence("BA_SOA_INTERFACE_DT_SEQ", "Acct")
                .StartsAt(680100)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("BA_SOA_INTERFACE_HD_SEQ", "Acct")
                .StartsAt(10000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("BA_SOA_MAPPING_SEQ", "Acct").StartsAt(144234);

            modelBuilder.HasSequence("BA_SPLIT_INVOICE_HD_SEQ", "Acct");

            modelBuilder.HasSequence("BA_STANDARD_CHARTERD_FORMAT_TYPE_SEQ", "Acct").StartsAt(115002);

            modelBuilder.HasSequence("BA_STOCK_EXPENSE_ACCOUNT_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_SUPERINTENDENT_ATTENDANCE_DAYS_SEQ", "Acct").StartsAt(1000);

            modelBuilder.HasSequence("BA_SUPERITENDENT_ATTENDANCE_DAYS_SEQ", "Acct").StartsAt(1000);

            modelBuilder.HasSequence("BA_Technical_Forecast_DT_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Technical_Forecast_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Template_Analysis_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_Template_DT_SEQ", "Acct").StartsAt(140498);

            modelBuilder.HasSequence("BA_Template_Hd_SEQ", "Acct").StartsAt(105004);

            modelBuilder.HasSequence("BA_TERM_PAYMENT_APPL_COMP_SEQ", "Acct");

            modelBuilder.HasSequence("BA_TERMS_OF_PAYMENT_SEQ", "Acct");

            modelBuilder.HasSequence("ba_trans_dt_draft_seq", "Acct").StartsAt(14024730);

            modelBuilder.HasSequence("BA_TRANS_DT_DRAFT_SHORE_EMP_SEQ", "Acct");

            modelBuilder.HasSequence("BA_TRANS_DT_RECONCILE_SEQ", "Acct");

            modelBuilder.HasSequence("ba_trans_dt_seq", "Acct").StartsAt(14047207);

            modelBuilder.HasSequence("BA_TRANS_DT_SHORE_EMP_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_TRANS_EXCHANGE_USER_ACCESS_TOKEN_PAL_API_SEQ", "Acct");

            modelBuilder.HasSequence<int>("BA_TRANS_EXCHANGE_USER_ACCESS_TOKEN_RECEIVE_API_SEQ", "Acct");

            modelBuilder.HasSequence("ba_trans_hd_seq", "Acct").StartsAt(860967);

            modelBuilder.HasSequence("BA_TRANS_PAYMENT_BANK_CHARGE_MAPPING_SEQ", "Acct");

            modelBuilder.HasSequence("BA_TRAVEL_INTERFACE_DT_SEQ", "Acct").StartsAt(135002);

            modelBuilder.HasSequence("BA_TRAVEL_INTERFACE_HD_SEQ", "Acct").StartsAt(110002);

            modelBuilder.HasSequence("BA_VALID_ACCOUNTS_SEQ", "Acct").StartsAt(5060000);

            modelBuilder.HasSequence("BA_Valid_Analysis_SEQ", "Acct").StartsAt(13125102);

            modelBuilder.HasSequence("BA_VALID_GROUP_SUBACCOUNTS_SEQ", "Acct");

            modelBuilder.HasSequence("BA_Valid_Subaccounts_SEQ", "Acct").StartsAt(4195343);

            modelBuilder.HasSequence("BA_WAGE_MAPPING_SEQ", "Acct").StartsAt(165045);

            modelBuilder.HasSequence("BA_WILHELMSEN_USER_MAPPING_SEQ", "Acct").StartsAt(105002);

            modelBuilder.HasSequence("BA_WSP_IMPORT_TRANSACTION_TEMP_SEQ", "Acct");

            modelBuilder.HasSequence("EntityEmailDetails_ID_SEQ", "Acct");

            modelBuilder.HasSequence("ER_GRB_STORAGE_LOCATION_SEQ", "Acct").StartsAt(279298);

            modelBuilder.HasSequence("ExpenditureTypeApplicableCompanies_ID_SEQ", "Acct");

            modelBuilder.HasSequence("ExpenditureTypeMaster_ID_SEQ", "Acct");

            modelBuilder.HasSequence("I2PINVOICE_MAPPINGISSUES_SEQ", "Acct");

            modelBuilder.HasSequence("PAYMENT_BATCH_CITY_BANK_SEQ", "Acct");

            modelBuilder.HasSequence("SP_Analysis_Codes_seq", "Acct").StartsAt(1700484);

            modelBuilder.HasSequence("SP_I2PINVOICE_BANKDETAILS_SEQ", "Acct");

            modelBuilder.HasSequence("UP_BA_BANK_DEAL_NUMBER_REGISTER_SEQ", "Acct");

            modelBuilder.HasSequence("VendorExpenseDetails_ID_SEQ", "Acct");

            modelBuilder.HasSequence("WorldLinkAccountMapping_ID_SEQ", "Acct").StartsAt(1000);

            modelBuilder.HasSequence("WorldLinkEntityMapping_SEQ", "Acct");

            modelBuilder.HasSequence("WorldLinkInterfaceDt_SEQ", "Acct");

            modelBuilder.HasSequence("WorldLinkInterfaceHd_SEQ", "Acct");

            modelBuilder.HasSequence("WorldLinkMapping_ID_SEQ", "Acct").StartsAt(1000);

            modelBuilder.HasSequence("AD_APPLICATION_CATEGORY_SEQ", "Admin");

            modelBuilder.HasSequence("AD_APPLICATION_KEY_PAGES_SEQ", "Admin");

            modelBuilder.HasSequence<int>("Ad_Application_Pages_Meta_SEQ", "Admin")
                .StartsAt(247900198)
                .HasMin(247900000);

            modelBuilder.HasSequence("Ad_Application_Pages_seq", "Admin")
                .StartsAt(1002271)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("Ad_Application_Roles_SEQ", "Admin").StartsAt(105880);

            modelBuilder.HasSequence("Ad_Applications_SEQ", "Admin").StartsAt(156055);

            modelBuilder.HasSequence("AD_APPLICATIONS_VERSION_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Company_Applications_SEQ", "Admin").StartsAt(105646);

            modelBuilder.HasSequence("Ad_Company_Types_SEQ", "Admin").StartsAt(105529);

            modelBuilder.HasSequence("AD_CUSTOM_ATTRIBUTE_SEQ", "Admin");

            modelBuilder.HasSequence("AD_CWA_AUDIT_SEQ", "Admin");

            modelBuilder.HasSequence<int>("AD_CWA_MENU_DT_SEQ", "Admin");

            modelBuilder.HasSequence<int>("AD_CWA_MENU_HD_SEQ", "Admin");

            modelBuilder.HasSequence("AD_CWA_MENU_TEMPLATE_DT_SEQ", "Admin");

            modelBuilder.HasSequence("AD_CWA_MENU_TEMPLATE_HD_SEQ", "Admin");

            modelBuilder.HasSequence("AD_CWA_MENU_TEMPLATE_TILES_SEQ", "Admin");

            modelBuilder.HasSequence("AD_CWA_OBJECTS_SEQ", "Admin").StartsAt(113020);

            modelBuilder.HasSequence("AD_CWA_USER_MENU_ACCESS_DT_SEQ", "Admin").StartsAt(1000);

            modelBuilder.HasSequence("AD_CWA_USER_MENU_ACCESS_HD_SEQ", "Admin").StartsAt(1000);

            modelBuilder.HasSequence("AD_CWA_USER_TILE_ACCESS_SEQ", "Admin").StartsAt(1000);

            modelBuilder.HasSequence("AD_DA_APPLICATION_RELEASE_NOTES_READ_SEQ", "Admin").HasMin(1);

            modelBuilder.HasSequence("AD_DA_APPLICATION_RELEASE_NOTES_SEQ", "Admin").HasMax(999999999999999);

            modelBuilder.HasSequence("AD_DA_PINNED_APPLICATIONS_SEQ", "Admin").HasMax(999999999999999);

            modelBuilder.HasSequence("AD_DA_VIDEO_READ_SEQ", "Admin").HasMax(99999999999999999);

            modelBuilder.HasSequence("AD_DESIG_DESIGNATIONS_GROUP_SEQ", "Admin").HasMax(999999999999999999);

            modelBuilder.HasSequence<int>("AD_DESIG_GROUP_RULES_SEQ", "Admin");

            modelBuilder.HasSequence<int>("AD_DESIG_USER_RULES_SEQ", "Admin");

            modelBuilder.HasSequence<int>("AD_DESIGNATION_RULE_MAST_SEQ", "Admin");

            modelBuilder.HasSequence<int>("AD_DESIGNATION_RULES_SEQ", "Admin");

            modelBuilder.HasSequence("AD_DESIGNATIONS_GROUP_SEQ", "Admin").HasMax(999999999999999999);

            modelBuilder.HasSequence("AD_DESIGNATIONS_SEQ", "Admin")
                .StartsAt(4300)
                .HasMax(999999999999999);

            modelBuilder.HasSequence("Ad_Favourites_SEQ", "Admin").StartsAt(109250);

            modelBuilder.HasSequence("Ad_Global_Admins_SEQ", "Admin").StartsAt(105602);

            modelBuilder.HasSequence("AD_INFO_GUIDE_APPLICABLE_PAGES_SEQ", "Admin");

            modelBuilder.HasSequence("AD_INFO_GUIDE_SEQ", "Admin");

            modelBuilder.HasSequence("AD_LIVEFLEET_TILE_ROLES_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Local_Admins_SEQ", "Admin").StartsAt(105612);

            modelBuilder.HasSequence("AD_OWNER_MENU_ACCESS_DT_SEQ", "Admin")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("AD_OWNER_MENU_ACCESS_HD_SEQ", "Admin")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("AD_OWNER_OBJECT_ACCESS_SEQ", "Admin");

            modelBuilder.HasSequence("AD_OWNER_TILE_ACCESS_SEQ", "Admin").HasMax(9999999999999999);

            modelBuilder.HasSequence("AD_OWNER_TILES_SEQ", "Admin").StartsAt(1000);

            modelBuilder.HasSequence("Ad_Page_Objects_SEQ", "Admin").StartsAt(112980);

            modelBuilder.HasSequence("Ad_Pal_Applications_SEQ", "Admin").StartsAt(105000);

            modelBuilder.HasSequence("AD_PASSWORD_POLICY_SEQ", "Admin");

            modelBuilder.HasSequence("AD_REPORT_MASTER_SEQ", "Admin").StartsAt(1476);

            modelBuilder.HasSequence("Ad_Role_Access_Rights_AUDIT_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Role_Access_Rights_SEQ", "Admin").StartsAt(346203);

            modelBuilder.HasSequence("AD_ROLE_OBJECT_RIGHTS_AUDIT_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Role_Object_Rights_SEQ", "Admin").StartsAt(105739);

            modelBuilder.HasSequence("AD_ROLE_RANK_MAPPING_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Roles_SEQ", "Admin").StartsAt(105620);

            modelBuilder.HasSequence("Ad_Roles_Tree_Node_SEQ", "Admin");

            modelBuilder.HasSequence("AD_TILE_APPLICABLE_SIZE_SEQ", "Admin");

            modelBuilder.HasSequence("AD_TILE_ROLES_AUDIT_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Tile_Roles_SEQ", "Admin").StartsAt(105568);

            modelBuilder.HasSequence("AD_TILE_SIZE_MAST_SEQ", "Admin");

            modelBuilder.HasSequence("AD_TILE_STRATEGIC_OBJECTIVE_DT_SEQ", "Admin");

            modelBuilder.HasSequence("AD_TILE_STRATEGIC_OBJECTIVE_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_Tiles_SEQ", "Admin").StartsAt(100531);

            modelBuilder.HasSequence("AD_USER_ACTIVITY_CWA_SEQ", "Admin");

            modelBuilder.HasSequence("AD_USER_ACTIVITY_seq", "Admin").StartsAt(1000000);

            modelBuilder.HasSequence("AD_USER_CUSTOM_ATTRIBUTE_SEQ", "Admin");

            modelBuilder.HasSequence("AD_USER_DESIGNATION_SEQ", "Admin").HasMax(999999999999999);

            modelBuilder.HasSequence("Ad_User_Entities_SEQ", "Admin").StartsAt(105712);

            modelBuilder.HasSequence("AD_USER_MENU_ACCESS_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_User_Objects_AUDIT_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_User_Objects_DT_SEQ", "Admin").StartsAt(105000);

            modelBuilder.HasSequence("Ad_User_Objects_Hd_SEQ", "Admin").StartsAt(105000);

            modelBuilder.HasSequence("Ad_User_Objects_SEQ", "Admin").StartsAt(127237);

            modelBuilder.HasSequence("AD_USER_PASSWORD_EXPIRY_SEQ", "Admin");

            modelBuilder.HasSequence("AD_USER_RIGHTS_audit_SEQ", "Admin").HasMax(999999999999999999);

            modelBuilder.HasSequence("ad_user_rights_comments_audit_seq", "Admin");

            modelBuilder.HasSequence("AD_USER_RIGHTS_CUSTOMIZE_ATTRIBUTES_AUDIT_SEQ", "Admin");

            modelBuilder.HasSequence("AD_USER_RIGHTS_CUSTOMIZE_ATTRIBUTES_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_User_Rights_DT_SEQ", "Admin").StartsAt(144914);

            modelBuilder.HasSequence("AD_USER_RIGHTS_HD_ROLE_DT_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_User_Rights_HD_SEQ", "Admin").StartsAt(284252);

            modelBuilder.HasSequence("AD_USER_TILE_COMPANY_MAPPING_SEQ", "Admin");

            modelBuilder.HasSequence("AD_USER_TILES_SEQ", "Admin");

            modelBuilder.HasSequence("Ad_User_Vessels_SEQ", "Admin").StartsAt(113980);

            modelBuilder.HasSequence("AD_VESSEL_GROUP_SEQ", "Admin");

            modelBuilder.HasSequence("AD_VESSEL_ROLE_SEQ", "Admin").HasMax(9999999999999999);

            modelBuilder.HasSequence("AD_VESSEL_VESSEL_GROUP_MAPPING_SEQ", "Admin");

            modelBuilder.HasSequence("AD_VESSELS_RIGHTS_AUDIT_LOG_SEQ", "Admin");

            modelBuilder.HasSequence("AD_VESSELS_VERSION_SEQ", "Admin");

            modelBuilder.HasSequence("ADV4_DOMAINS_SEQ", "Admin");

            modelBuilder.HasSequence("CM_Subcompany_Access_Rights_SEQ", "Admin").StartsAt(500000);

            modelBuilder.HasSequence("IN", "Admin");

            modelBuilder.HasSequence("AuditLogDT_SEQ", "Audit").StartsAt(500000);

            modelBuilder.HasSequence("AuditLogHD_SEQ", "Audit").StartsAt(500000);

            modelBuilder.HasSequence("AuditLogSettingsDT_SEQ", "Audit").StartsAt(941);

            modelBuilder.HasSequence("AuditLogSettingsHD_SEQ", "Audit").StartsAt(3299);

            modelBuilder.HasSequence("BB_ADD_AMOUNT_MAP_SEQ", "B2B")
                .StartsAt(100)
                .HasMin(100)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<int>("BB_ADMIN_STRUCTURE_SEQ", "B2B")
                .StartsAt(140)
                .HasMin(100);

            modelBuilder.HasSequence<int>("BB_COMPANY_EDI_CODE_SEQ", "B2B");

            modelBuilder.HasSequence("BB_CONFIG_DATA_SEQ", "B2B")
                .StartsAt(100)
                .HasMin(100);

            modelBuilder.HasSequence("BB_EMAIL_TEMPLATE_SEQ", "B2B").StartsAt(3175002);

            modelBuilder.HasSequence("BB_ENIP_COMPANIES_SEQ", "B2B").StartsAt(8835);

            modelBuilder.HasSequence("BB_ENIP_VESSELS_SEQ", "B2B").StartsAt(587122);

            modelBuilder.HasSequence("BB_PAL_ENIP_DOC_MAP_SEQ", "B2B")
                .StartsAt(1000)
                .HasMin(100)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<int>("BB_QUEUE_SEQ", "B2B")
                .StartsAt(3001)
                .HasMin(1000);

            modelBuilder.HasSequence("BB_QUEUE_STATUS_GENERATED_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence("BB_QUEUE_STATUS_QUEUED_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence("BB_QUEUE_STATUS_RECEIVED_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence("BB_QUEUE_STATUS_SENT_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence("BB_QUEUE_STATUS_UPDATED_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence<int>("BB_SDC_VENDOR_MAP_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence<int>("BB_UOM_MF_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence("BB_VENDOR_VESSEL_ENIP_SEQ", "B2B");

            modelBuilder.HasSequence("SP_VDN_CONSIGNMENT_DT_SEQ", "B2B").HasMin(1);

            modelBuilder.HasSequence("SP_VDN_HD_SEQ", "B2B")
                .StartsAt(100)
                .HasMin(100);

            modelBuilder.HasSequence("SP_VDN_ITEM_DT_SEQ", "B2B")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("BSFP_DELIVERABLE_TYPE_COMPANY_MAPPING_SEQ", "BSFP");

            modelBuilder.HasSequence("BSFP_DELIVERABLE_TYPE_REPONSIBILITY_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_ADDITIONAL_INFO_DATA_VALUES_SEQ", "BSFP").StartsAt(1315714);

            modelBuilder.HasSequence("FP_ADDITIONAL_INFO_DATA_VALUES_SEQ_TEST", "BSFP");

            modelBuilder.HasSequence("FP_COMMENT_READ_SEQ", "BSFP").StartsAt(41);

            modelBuilder.HasSequence("FP_COMMENTS_SEQ", "BSFP").StartsAt(141131);

            modelBuilder.HasSequence("FP_DATA_VALUES_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_BUDGET_DATA_VALUES_APPL_CMP_AUDIT_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_BUDGET_DATA_VALUES_APPL_CMP_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_BUDGET_DATA_VALUES_AUDIT_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_BUDGET_DATA_VALUES_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_BUDGET_VERSION_AUDIT_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_ESTIMATE_EXTRA_POLITE_SETTINGS_AUDIT_SEQ", "BSFP");

            modelBuilder.HasSequence("FP_FIXED_ESTIMATE_EXTRA_POLITE_SETTINGS_SEQ", "BSFP");

            modelBuilder.HasSequence("LUCANET_REFRESH_LOG_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_ACCOUNTS_ANALYSIS_DT_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_ACCOUNTS_SEQ", "BSFP").StartsAt(301391);

            modelBuilder.HasSequence("MDM_ACTIVITY_STATUS_SEQ", "BSFP").StartsAt(155);

            modelBuilder.HasSequence("MDM_AUDITOR_SEQ", "BSFP").StartsAt(345);

            modelBuilder.HasSequence("MDM_BENCHMARK_INSURANCE_DET_DT_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_BENCHMARK_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_CIRCLE_SEQ", "BSFP").StartsAt(162);

            modelBuilder.HasSequence("MDM_CLASSIFICATION_SOCIETY_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_CMP_VESSEL_TYPE_SEQ", "BSFP").StartsAt(262);

            modelBuilder.HasSequence("MDM_COMPANIES_SEQ", "BSFP").StartsAt(535653);

            modelBuilder.HasSequence("MDM_COMPANY_ACTIVITY_STATUS_DT_SEQ", "BSFP").StartsAt(236497);

            modelBuilder.HasSequence("MDM_COMPANY_OP_MANAGER_DT_SEQ", "BSFP").StartsAt(234643);

            modelBuilder.HasSequence("MDM_COMPANY_RES_MANAGER_DT_SEQ", "BSFP").StartsAt(235260);

            modelBuilder.HasSequence("MDM_COMPANY_SEGMENT_DT_SEQ", "BSFP").StartsAt(235193);

            modelBuilder.HasSequence("MDM_COMPANY_SHARE_DT_SEQ", "BSFP").StartsAt(235517);

            modelBuilder.HasSequence("MDM_COMPANY_TYPE_SEQ", "BSFP").StartsAt(346);

            modelBuilder.HasSequence("MDM_COMPANY_VESSEL_DT_SEQ", "BSFP").StartsAt(235530);

            modelBuilder.HasSequence("MDM_CONSOLIDATION_ENTITY_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_CONSOLIDATION_STRUCTURE_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_CONSOLIDATION_TYPE_SEQ", "BSFP").StartsAt(301);

            modelBuilder.HasSequence("MDM_COST_CENTER_SEQ", "BSFP").StartsAt(214267);

            modelBuilder.HasSequence("MDM_D3_DEPARTMENT_SEQ", "BSFP").StartsAt(79);

            modelBuilder.HasSequence("MDM_DATA_TYPE_SEQ", "BSFP").StartsAt(321);

            modelBuilder.HasSequence("MDM_DATASOURCE_MAPPING_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_DELIVERABLE_REPONSIBILITY_SEQ", "BSFP").StartsAt(327528);

            modelBuilder.HasSequence("MDM_DELIVERABLE_SEQ", "BSFP").StartsAt(234967);

            modelBuilder.HasSequence("MDM_DELIVERABLE_TYPE_SEQ", "BSFP").StartsAt(214234);

            modelBuilder.HasSequence("MDM_DELVERABLE_TYPE_CATEGORY_DT_SEQ", "BSFP").StartsAt(181);

            modelBuilder.HasSequence("MDM_DELVERABLE_TYPE_CATEGORY_SEQ", "BSFP").StartsAt(9);

            modelBuilder.HasSequence("MDM_EMPLOYEE_POA_DT_SEQ", "BSFP").StartsAt(238068);

            modelBuilder.HasSequence("MDM_EMPLOYEE_SEQ", "BSFP").StartsAt(238116);

            modelBuilder.HasSequence("MDM_ENTITY_ADJUSTMENT_SEQ", "BSFP").StartsAt(234614);

            modelBuilder.HasSequence("MDM_FP_ROLE_USER_MAPPING_SEQ", "BSFP").StartsAt(15912);

            modelBuilder.HasSequence("MDM_FP_ROLES_SEQ", "BSFP").StartsAt(191);

            modelBuilder.HasSequence("MDM_LAST_INTERFACE_RUN_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_LEGAL_TYPE_SEQ", "BSFP").StartsAt(159);

            modelBuilder.HasSequence("MDM_PERSON_SEQ", "BSFP").StartsAt(235476);

            modelBuilder.HasSequence("MDM_PERSONS_TITLE_SEQ", "BSFP").StartsAt(77);

            modelBuilder.HasSequence("MDM_POWER_OF_ATTORNEY_SEQ", "BSFP").StartsAt(272);

            modelBuilder.HasSequence("MDM_PROCESS_TYPE_SEQ", "BSFP").StartsAt(14);

            modelBuilder.HasSequence("MDM_REPORTING_TYPE_SEQ", "BSFP").StartsAt(312);

            modelBuilder.HasSequence("MDM_RESPONSIBILITY_SEQ", "BSFP").StartsAt(266);

            modelBuilder.HasSequence("MDM_RHYTHM_SEQ", "BSFP").StartsAt(5);

            modelBuilder.HasSequence("MDM_SEGMENTS_SEQ", "BSFP").StartsAt(1796);

            modelBuilder.HasSequence("MDM_SHARE_TYPE_SEQ", "BSFP").StartsAt(82);

            modelBuilder.HasSequence("MDM_SISTER_VESSEL_TEMPLATE_SEQ", "BSFP").StartsAt(234490);

            modelBuilder.HasSequence("MDM_STG_PAL_UPDATES_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_SUB_GROUP_SEQ", "BSFP").StartsAt(350);

            modelBuilder.HasSequence("MDM_TRADING_AREA_SEQ", "BSFP").StartsAt(149);

            modelBuilder.HasSequence("MDM_VESSEL_BENCHMARK_DT_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_VESSEL_COMPANY_SEQ", "BSFP");

            modelBuilder.HasSequence("MDM_VESSEL_DIRECTOR_SEQ", "BSFP").StartsAt(1362);

            modelBuilder.HasSequence("MDM_VESSEL_OPERATIONAL_MANAGER_SEQ", "BSFP").StartsAt(112);

            modelBuilder.HasSequence("MDM_VESSEL_REGISTER_DETAILS_SEQ", "BSFP").StartsAt(214672);

            modelBuilder.HasSequence("CH_ADDRESS_COMMISSION_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_AGENTS_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_APPROVAL_HIERARCHY_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_APPROVAL_HIERARCHY_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_APPROVAL_RIGHTS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_DEMURRAGE_BROKER_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_DEMURRAGE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_EMP_REDELIVERY_NOTICES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_EMPLOYMENT_BROKERS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_EMPLOYMENT_LUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_EMPLOYMENT_OPTIONS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_ESTIMATION_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_OTHER_EXPENSES_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_OTHER_EXPENSES_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_PORT_SCHEDULE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_VOYAGE_PORT_EXPENSES_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_VOYAGE_PORT_EXPENSES_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_VOYAGE_RESULTS_BROKERS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_VOYAGE_RESULTS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ARCHIVE_VR_POOL_ADJUSTMENT_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_ATTACHMENTS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_AUDIT_PAYMENT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_ADDITIONAL_INFO_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_BALLAST_DAYS_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_BUNKERS_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_DT_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_HD_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_REDELIVERY_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_TC_AVG_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence<int>("CH_BALTIC_INDEX_TYPE_SEQ", "CHARTER")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence("CH_BANK_PAYMENTS_SEQ", "CHARTER")
                .StartsAt(9143)
                .HasMin(1);

            modelBuilder.HasSequence("CH_BROKER_COMMISSION_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_BROKER_COMMISSION_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_BUDGET_ACCOUNT_DT_SEQ", "CHARTER");

            modelBuilder.HasSequence<int>("CH_BUNKER_DELIVERY_CHARGES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_BUNKERS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_CARGO_ENQUIRY_CARGOS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_CARGO_ENQUIRY_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_CARGO_ENQUIRY_PORTS_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_CHARTER_HIRE_SEQ", "CHARTER")
                .StartsAt(9143)
                .HasMin(1);

            modelBuilder.HasSequence("CH_CHARTERERS_EXPENSES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_CHECKLIST_ATTACHMENTS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_COMBINED_BANK_PAYMENT_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_DEMURRAGE_BROKER_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_DEMURRAGE_BROKER_TYP", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_DEMURRAGE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EGCS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EMP_RECEIVABLE_BANK_DETAILS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EMP_REDELIVERY_NOTICES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EMPLOYMENT_BROKERS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EMPLOYMENT_CHECKLIST_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_EMPLOYMENT_EGCS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EMPLOYMENT_LUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_EMPLOYMENT_OPTIONS_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_EMPLOYMENT_OPTIONS_SORTORDER_SEQ", "CHARTER").HasMin(0);

            modelBuilder.HasSequence("CH_EMPLOYMENT_PORTS_SEQ", "CHARTER").StartsAt(0);

            modelBuilder.HasSequence("CH_EMPLOYMENT_SUBLUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ENQUIRY_DURATION_RATES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_BUNKER_CONSUMPTION_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_CARGOS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_CURRENT_FUEL_PRICE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_DURATION_RATES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_LOAD_TERMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_LUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_PORTS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_ESTIMATION_START_ROB_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_GENERAL_SETTINGS_SEQ", "CHARTER")
                .StartsAt(10)
                .HasMin(1);

            modelBuilder.HasSequence("CH_HIRE_GROUP_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_HIRE_GROUP_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_HIRE_STMT_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_LAYTIME_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_LAYTIME_PORTS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_LOAD_TERMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_LUMPSUM_TYPE_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_LUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_MAP_CHARTERING_ENTITY_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OFFHIRE_BROKERS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OFFHIRE_BUNKERS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OFFHIRE_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OFFHIRE_LUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_OFFHIRE_NAME_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_OFFHIRE_RULES_DT_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_OFFHIRE_RULES_HD_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_OFFHIRE_SUBLUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OTHER_EXPENSES_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OTHER_EXPENSES_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OTHER_EXPENSES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_OWNERS_EXPENSES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_POOL_INCOME_EXPENS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_PORT_SCHEDULE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_PORT_TIMESHEET_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_REDELIVERY_RANGE_SEQ", "CHARTER").HasMax(999999999999999);

            modelBuilder.HasSequence("CH_SUBLUMPSUMS_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_USER_COMPANY_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence<int>("CH_VESSEL_OBLIGATIONS_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_VOYAGE_BUNKER_EXPENSE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_VOYAGE_DEMURRAGE_PORT_EXPENSE_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_VOYAGE_PORT_EXPENSES_DT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_VOYAGE_PORT_EXPENSES_HD_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_VOYAGE_PORT_EXPENSES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_VOYAGE_RESULTS_ATTACHMENT_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_VOYAGE_RESULTS_BROKERS_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_VOYAGE_RESULTS_SEQ", "CHARTER");

            modelBuilder.HasSequence("CH_VR_CALC_BUNK_EXPENSES_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("CH_VR_POOL_ADJUSTMENT_SEQ", "CHARTER").StartsAt(211);

            modelBuilder.HasSequence("VO_ARCHIVE_VESSEL_EMPLOYMENT_SEQ", "CHARTER").HasMin(1);

            modelBuilder.HasSequence("[LP_RA_Task_WF_Templates_SEQ", "Common");

            modelBuilder.HasSequence("AD_REPORT_MASTER_SEQ", "Common").StartsAt(150);

            modelBuilder.HasSequence("AspNetUsers_SEQ", "Common");

            modelBuilder.HasSequence("AutoUpdateApplication_HD_SEQ", "Common");

            modelBuilder.HasSequence("AutoUpdater_Settings_SEQ", "Common");

            modelBuilder.HasSequence("AutoUpdaterLog_SEQ", "Common");

            modelBuilder.HasSequence("AutoUpdateVesselDT_SEQ", "Common");

            modelBuilder.HasSequence("BA_Account_Cat_SEQ", "Common").StartsAt(502051);

            modelBuilder.HasSequence("BA_Account_Mast_SEQ", "Common").StartsAt(114509);

            modelBuilder.HasSequence("BA_Allocation_Type_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("BA_Analysis_Code_Cat_SEQ", "Common").StartsAt(105023);

            modelBuilder.HasSequence("BA_Analysis_Mast_SEQ", "Common").StartsAt(502019);

            modelBuilder.HasSequence("BA_APPLICABLE_ENTITY_GRP_MAST_SEQ", "Common");

            modelBuilder.HasSequence("BA_Bank_Appl_Cmp_SEQ", "Common").StartsAt(502394);

            modelBuilder.HasSequence("BA_Bank_Branch_Appl_Cmp_SEQ", "Common").StartsAt(514177);

            modelBuilder.HasSequence("BA_Bank_Branch_Appl_Roles_SEQ", "Common").StartsAt(105002);

            modelBuilder.HasSequence("BA_Bank_Branches_MF_SEQ", "Common").StartsAt(570042);

            modelBuilder.HasSequence("BA_Bank_MF_SEQ", "Common").StartsAt(516753);

            modelBuilder.HasSequence("BA_DBS_PRODUCT_TYPE_SEQ", "Common").StartsAt(115002);

            modelBuilder.HasSequence("BA_DIVE_MARINE_SERVICES_SEQ", "Common");

            modelBuilder.HasSequence("BA_Entity_Grp_Mast_SEQ", "Common").StartsAt(502085);

            modelBuilder.HasSequence("BA_ENTITY_MAST_AR_NO_SEQ", "Common");

            modelBuilder.HasSequence("BA_Entity_Mast_Bank_Details_SEQ", "Common");

            modelBuilder.HasSequence("BA_Entity_Mast_SEQ", "Common").StartsAt(502036);

            modelBuilder.HasSequence("BA_Entity_Type_Mast_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("BA_Format_Master_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("BA_HOLD_RELEASE_REASON_SEQ", "Common");

            modelBuilder.HasSequence("BA_LETTER_HEAD_MASTER_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("BA_Local_Name_SEQ", "Common").StartsAt(105027);

            modelBuilder.HasSequence("BA_LOCAL_VENDOR_ACCOUNTS_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("BA_NEGATIVE_LIST_SEQ", "Common").StartsAt(115000);

            modelBuilder.HasSequence("BA_OASYS_COMPANY_MAPPING_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("BA_Parameters_SEQ", "Common").StartsAt(3415511);

            modelBuilder.HasSequence("BA_PARTNER_TYPE_SEQ", "Common");

            modelBuilder.HasSequence("BA_PAYMENT_PURPOSE_MAST_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("BA_PAYMENT_PURPOSE_MAST_SEQ", "Common");

            modelBuilder.HasSequence("BA_Quote_to_Job_Conversion_SEQ", "Common");

            modelBuilder.HasSequence("BA_RBS_EXPORT_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("BA_Report_Mapping_Code_Mast_SEQ", "Common");

            modelBuilder.HasSequence("BA_SERVICE_DEFINITIONS_APPL_OWNER_seq", "Common");

            modelBuilder.HasSequence("BA_Service_Definitions_SEQ", "Common").StartsAt(105002);

            modelBuilder.HasSequence("BA_Standard_Chart_Mast_SEQ", "Common").StartsAt(10);

            modelBuilder.HasSequence("BA_STD_CHART_MAST_SEQ", "Common");

            modelBuilder.HasSequence("BA_Subaccount_Cat_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("BA_Subaccount_Mast_SEQ", "Common").StartsAt(500012);

            modelBuilder.HasSequence("BA_SUPERINTENDENT_ATTENDANCE_DAYS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("BA_TERM_PAYMENT_APPL_COMP_SEQ", "Common");

            modelBuilder.HasSequence("BA_TERMS_OF_PAYMENT_SEQ", "Common");

            modelBuilder.HasSequence("BA_Trans_Type_SEQ", "Common").StartsAt(502039);

            modelBuilder.HasSequence("BA_TYPE_COST_INCOME_SEQ", "Common");

            modelBuilder.HasSequence("BA_Vat_Category_SEQ", "Common").StartsAt(105015);

            modelBuilder.HasSequence("BA_Vat_Key_SEQ", "Common").StartsAt(105028);

            modelBuilder.HasSequence("BA_VESSEL_SUBACCOUNT_MAP_SEQ", "Common");

            modelBuilder.HasSequence("BA_WESER_ACCOUNTS_MAP_SEQ", "Common");

            modelBuilder.HasSequence("BREADTH_MF_SEQ", "Common");

            modelBuilder.HasSequence("BSFP_PROJECT_SEQ", "Common");

            modelBuilder.HasSequence("CH_ADMIN_STRUCTURE_seq", "Common")
                .StartsAt(15)
                .HasMax(999999999999999);

            modelBuilder.HasSequence("CH_COMPANY_FEES_seq", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("CH_COMPANY_MASK_seq", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("CH_POOL_ADJUSTMENT_SEQ", "Common");

            modelBuilder.HasSequence("CH_POOL_ASSIGNMENTS_seq", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("CH_TRADE_AREAS_seq", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("CM_Activity_Group_MF_SEQ", "Common").StartsAt(121814);

            modelBuilder.HasSequence("CM_Activity_MF_SEQ", "Common").StartsAt(502018);

            modelBuilder.HasSequence<int>("CM_ADMIN_ACCEPTANCE_FLAG_DOCUMENTS_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("CM_Admin_Structure_SEQ", "Common").StartsAt(700273);

            modelBuilder.HasSequence("CM_AGREEMENT_NAMES_SEQ", "Common").StartsAt(3125421);

            modelBuilder.HasSequence("CM_App_Format_Occasions_SEQ", "Common").StartsAt(105018);

            modelBuilder.HasSequence<int>("CM_APPRAISAL_APPROVER_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("CM_Appraisal_Attribs_NB_DT_SEQ", "Common");

            modelBuilder.HasSequence("CM_Appraisal_Attribs_SEQ", "Common").StartsAt(105007);

            modelBuilder.HasSequence("CM_APPRAISAL_CRITERIA_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("CM_Appraisal_Formats_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Appraisal_Occasions_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence<int>("CM_APPRAISAL_PENDING_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("CM_Appraisal_Tab_Grids_SEQ", "Common")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Appraisal_Tabes_SEQ", "Common")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_AppraisalRankMapping_SEQ", "Common").HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Appraisee_Applicable_Tabes_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("CM_Appraisee_Appraiser_Mapping_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("CM_Appraisee_Format_Mapping_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("CM_Appraiser_Applicable_Tabes_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("CM_APPROVAL_CYCLE_SEQ", "Common");

            modelBuilder.HasSequence("CM_ASSESSMENT_ALERT_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("CM_Attrib_Details_SEQ", "Common").StartsAt(101000);

            modelBuilder.HasSequence("CM_Attrib_For_Appraisal_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Attrib_Values_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_BI_Rank_Group_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Bmi_Definitions_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Briefing_Topics_MF_SEQ", "Common").StartsAt(502027);

            modelBuilder.HasSequence("CM_CLIENT_APPROVAL_SETUP_DT_SEQ", "Common");

            modelBuilder.HasSequence("CM_CLIENT_APPROVAL_SETUP_HD_SEQ", "Common");

            modelBuilder.HasSequence("CM_Comp_Document_SEQ", "Common").StartsAt(105010);

            modelBuilder.HasSequence("CM_COMP_LETTER_FILESTREAM_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_COMPANY_ALLOCATION_SEQ", "Common");

            modelBuilder.HasSequence("CM_Company_Fields_SEQ", "Common").StartsAt(502025);

            modelBuilder.HasSequence("CM_Company_Sub_Company_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_COMPETENCY_MF_NEW_SEQ", "Common");

            modelBuilder.HasSequence("CM_COMPETENCY_MF_SEQ", "Common")
                .StartsAt(12730)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("CM_COMPETENCY_REQ_NEW_SEQ", "Common");

            modelBuilder.HasSequence("CM_COMPETENCY_REQ_SEQ", "Common")
                .StartsAt(4060)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CM_COMPETENCY_TRAINING_NEW_SEQ", "Common");

            modelBuilder.HasSequence("CM_COMPETENCY_TRAINING_SEQ", "Common").StartsAt(5000);

            modelBuilder.HasSequence("CM_COMPLETED_LETTERS_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence<int>("CM_CONDITION_TYPE_MASTER_APPLICABLE_TO_SEQ", "Common")
                .HasMin(-922337203)
                .HasMax(922337203);

            modelBuilder.HasSequence("CM_CONDITION_TYPE_MASTER_SEQ", "Common").StartsAt(110421);

            modelBuilder.HasSequence("CM_Contract_Format_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_CONTRACT_REASON_MF_SEQ", "Common");

            modelBuilder.HasSequence("CM_Country_Groups_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_COURSE_COMPETENCY_MATRIX_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("CM_COURSE_COMPETENCY_MATRIX_VESSEL_RANK_SEQ", "Common");

            modelBuilder.HasSequence("CM_CREWING_DEBUG_INFO_FROM_VESSEL_SEQ", "Common");

            modelBuilder.HasSequence("CM_Doc_Category_Doc_Types_SEQ", "Common").StartsAt(502013);

            modelBuilder.HasSequence("CM_Doc_Req_Nationality_SEQ", "Common");

            modelBuilder.HasSequence("CM_Doc_Req_Type_SEQ", "Common").StartsAt(267775);

            modelBuilder.HasSequence("CM_Doc_Req_Vsl_SEQ", "Common").StartsAt(419264);

            modelBuilder.HasSequence("CM_Docs_Issue_Authority_SEQ", "Common").StartsAt(112182);

            modelBuilder.HasSequence("CM_Document_MF_NB_DT_SEQ", "Common");

            modelBuilder.HasSequence("CM_Document_MF_SEQ", "Common").StartsAt(570315);

            modelBuilder.HasSequence("CM_Document_Set_Det_SEQ", "Common").StartsAt(500033);

            modelBuilder.HasSequence("CM_Document_Set_MF_SEQ", "Common").StartsAt(500033);

            modelBuilder.HasSequence("CM_Document_Types_SEQ", "Common").StartsAt(500048);

            modelBuilder.HasSequence("CM_DYNAMIC_PROCEDURE_TEMPLATE_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("CM_DYNAMIC_PROCEDURE_TYPE_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("CM_EMAIL_DATA_MAPPING_SEQ", "Common")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Emp_Current_Profile_SEQ", "Common").StartsAt(2020036);

            modelBuilder.HasSequence("CM_EMP_SIGNATURE_FILESTREAM_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_EXTEND_REDUCE_REASON_MF_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_FIELD_TYPES_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_FIELDS_MASTER_SEQ", "Common")
                .StartsAt(1150)
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_GENERAL_REGISTER_APP_PAGES_SEQ", "Common");

            modelBuilder.HasSequence("CM_HOTEL_MANAGEMENT_DT_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("CM_HOTEL_MANAGEMENT_HD_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("CM_Inactive_Reasons_SEQ", "Common").StartsAt(500005);

            modelBuilder.HasSequence("CM_Incident_Type_MF_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("CM_Institution_MF_SEQ", "Common").StartsAt(120712);

            modelBuilder.HasSequence("CM_Lang_Eval_Grade_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Last_Number_Used_SEQ", "Common").StartsAt(400000);

            modelBuilder.HasSequence("CM_LETTER_FIELDS_SEQ", "Common")
                .StartsAt(4853)
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_LETTER_FORMAT_NAMES_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_LETTER_SIGNATURE_SEQ", "Common");

            modelBuilder.HasSequence("CM_LETTER_TEMPLATE_HD_SEQ", "Common")
                .StartsAt(11)
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence<int>("CM_LETTER_TEMPLATE_HISTORY_SEQ", "Common").HasMax(2147483600);

            modelBuilder.HasSequence("CM_NATIONALITY_REPORTING_GRP_SEQ", "Common");

            modelBuilder.HasSequence("CM_NEWS_AND_ANNOUNCEMENT_APPLICABLE_IDS_SEQ", "Common");

            modelBuilder.HasSequence("CM_NEWS_AND_ANNOUNCEMENT_APPLICABLE_TO_SEQ", "Common");

            modelBuilder.HasSequence("CM_News_And_Announcement_SEQ", "Common");

            modelBuilder.HasSequence("CM_NEWS_FILESTREAM_SEQ", "Common");

            modelBuilder.HasSequence("CM_Ntbr_Reasons_SEQ", "Common").StartsAt(200000);

            modelBuilder.HasSequence("CM_OCIMF_Paired_RankGroup_SEQ", "Common");

            modelBuilder.HasSequence<int>("CM_OCIMF_PAIRED_RGP_CHANGE_GAP_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("CM_OCIMF_SIRE_RESPONSE_LOG_SEQ", "Common");

            modelBuilder.HasSequence("CM_Other_Comp_Vessels_SEQ", "Common").StartsAt(982062);

            modelBuilder.HasSequence<int>("CM_OTHER_COMPANY_VESSEL_REGISTER_DT_SEQ", "Common");

            modelBuilder.HasSequence<int>("CM_OTHER_COMPANY_VESSEL_REGISTER_HD_SEQ", "Common");

            modelBuilder.HasSequence<int>("CM_OTHER_COMPANY_VESSEL_SPECIAL_FEATURES_SEQ", "Common");

            modelBuilder.HasSequence("CM_Parameters_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Personnel_MF_NB_DT_SEQ", "Common");

            modelBuilder.HasSequence("CM_Personnel_MF_Portal_Stg_SEQ", "Common");

            modelBuilder.HasSequence("CM_Personnel_MF_SEQ", "Common").StartsAt(2022042);

            modelBuilder.HasSequence("CM_PLANNER_SETTING_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_POB_TRAVEL_MODE_SEQ", "Common");

            modelBuilder.HasSequence<int>("CM_PROCESS_BUSINESS_FLOW_ACTIONS_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("CM_PROCESS_BUSINESS_FLOW_NOTIFICATIONS_SEQ", "Common");

            modelBuilder.HasSequence<int>("CM_PROCESS_BUSINESS_FLOW_OPTIONAL_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("CM_PROCESS_BUSINESS_FLOW_SEQ", "Common");

            modelBuilder.HasSequence<int>("CM_PROCESS_CONDITION_MAPPING_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("CM_PROCESS_CONDITION_MASTER_SEQ", "Common");

            modelBuilder.HasSequence("CM_PROCESS_MASTER_FUNTION_ROLE_MAPPING_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("CM_PROCESS_MASTER_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_PROCESS_MASTER_STATUS_MAPPING_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("CM_Process_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_PROCESS_STATUS_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("CM_PROCESS_TEMPLATE_COMPANY_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_PROCESS_TEMPLATE_DT_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_PROCESS_TEMPLATE_HD_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_PROCESS_TEMPLATE_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("CM_PROJECT_COMPANY_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("CM_Rank_Group_MF_SEQ", "Common").StartsAt(105011);

            modelBuilder.HasSequence("CM_Rank_MF_SEQ", "Common").StartsAt(105016);

            modelBuilder.HasSequence("CM_Signoff_Reason_MF_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("CM_Signon_Reason_MF_SEQ", "Common").StartsAt(105012);

            modelBuilder.HasSequence("CM_SOA_COMP_DET_SEQ", "Common").StartsAt(149975);

            modelBuilder.HasSequence("CM_Soa_Comp_Master_SEQ", "Common").StartsAt(105016);

            modelBuilder.HasSequence("CM_TEMP_HISTORY_FILESTREAM_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_Training_Batches_SEQ", "Common").StartsAt(110015);

            modelBuilder.HasSequence<int>("CM_VESSEL_SPECIAL_FEATURE_MF_SEQ", "Common");

            modelBuilder.HasSequence("CM_VESSEL_SUBTYPE_TANKER_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("CM_Work_Gear_Definitions_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CM_Work_Group_MF_SEQ", "Common").StartsAt(105004);

            modelBuilder.HasSequence("Co_ADDRESS_SEQ", "Common").StartsAt(402004);

            modelBuilder.HasSequence("CO_Admin_Structure_NB_DT_SEQ", "Common");

            modelBuilder.HasSequence("Co_Admin_Structure_SEQ", "Common").StartsAt(302329);

            modelBuilder.HasSequence("Co_Airports_SEQ", "Common").StartsAt(402004);

            modelBuilder.HasSequence("CO_ALERT_FORWARDED_USERS_seq", "Common");

            modelBuilder.HasSequence("CO_ALERT_MESSAGES_SEQ", "Common");

            modelBuilder.HasSequence("CO_ALERTS_SEQ", "Common");

            modelBuilder.HasSequence("CO_ALL_ATTACHMENTS_CONFIG_SEQ", "Common")
                .StartsAt(105)
                .HasMin(105);

            modelBuilder.HasSequence("Co_Application_Pages_SEQ", "Common").StartsAt(101000);

            modelBuilder.HasSequence("Co_Citizenships_SEQ", "Common").StartsAt(154886);

            modelBuilder.HasSequence("CO_COLOR_CODE_SETTINGS_SEQ", "Common").StartsAt(44);

            modelBuilder.HasSequence("CO_Companies_EConnect_Staging_SEQ", "Common").StartsAt(4324399);

            modelBuilder.HasSequence<int>("CO_COMPANIES_ENTITIES_LOGO_MASTER_SEQ", "Common");

            modelBuilder.HasSequence<int>("CO_COMPANIES_ENTITY_LOCATION_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("co_COMPANIES_SEQ", "Common")
                .StartsAt(536498)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("Co_Company_Applications_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Co_Company_Colours_SEQ", "Common");

            modelBuilder.HasSequence("CO_Company_Company_Types_NB_DT_SEQ", "Common");

            modelBuilder.HasSequence("Co_Company_Company_Types_SEQ", "Common");

            modelBuilder.HasSequence("Co_Company_Contacts_SEQ", "Common").StartsAt(122352);

            modelBuilder.HasSequence("Co_Company_Departments_SEQ", "Common").StartsAt(502363);

            modelBuilder.HasSequence("CO_COMPANY_FLAG_ICONS_SEQ", "Common");

            modelBuilder.HasSequence("Co_Company_Hierarchy_SEQ", "Common").StartsAt(150000);

            modelBuilder.HasSequence("Co_Company_Name_Changes_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Co_Company_Sub_Company_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Co_Company_Type_Group_Comp_Types_SEQ", "Common").StartsAt(502231);

            modelBuilder.HasSequence("CO_COMPANYTYPE_APPLICATION_MAPPING_SEQ", "Common").StartsAt(2);

            modelBuilder.HasSequence("Co_Confirmed_Vessel_Stakeholders_SEQ", "Common");

            modelBuilder.HasSequence("CO_CONTACT_DETAILS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("CO_CONTACT_FIELDS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("CO_CONTACT_GROUP_MAPPING_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("CO_CONTACT_GROUP_SEQ", "Common").StartsAt(1010);

            modelBuilder.HasSequence("CO_CONTACT_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("Co_Countries_SEQ", "Common").StartsAt(155011);

            modelBuilder.HasSequence("CO_COUNTRY_FLAG_ICONS_SEQ", "Common");

            modelBuilder.HasSequence("Co_Country_Regions_SEQ", "Common").StartsAt(400000);

            modelBuilder.HasSequence("Co_Currencies_SEQ", "Common").StartsAt(154767);

            modelBuilder.HasSequence("Co_Department_Positions_SEQ", "Common").StartsAt(400000);

            modelBuilder.HasSequence("Co_Departments_SEQ", "Common").StartsAt(400000);

            modelBuilder.HasSequence("CO_ECONNECT_VENDOR_CODE_SEQ", "Common")
                .StartsAt(1111111)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CO_EXCLUDED_FILETYPES_SEQ", "Common");

            modelBuilder.HasSequence("CO_FEATURE_USER_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("CO_FEEDBACK_ANSWERS_SEQ", "Common");

            modelBuilder.HasSequence("CO_FEEDBACK_QUESTIONS_SEQ", "Common");

            modelBuilder.HasSequence("CO_FLAG_ICONS_SEQ", "Common");

            modelBuilder.HasSequence("CO_FLAGS_FLAG_ICONS_SEQ", "Common");

            modelBuilder.HasSequence("Co_Flags_SEQ", "Common").StartsAt(154953);

            modelBuilder.HasSequence("CO_FORMS_CHECKLIST_MAPPING_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CO_INTERFACE_CONNECTION_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("CO_INTERFACE_DT_SEQ", "Common");

            modelBuilder.HasSequence("CO_INTERFACE_HD_SEQ", "Common");

            modelBuilder.HasSequence("CO_INTERFACE_JOB_SEQ", "Common");

            modelBuilder.HasSequence("CO_INTERFACE_LOG_SEQ", "Common");

            modelBuilder.HasSequence("CO_INTERFACE_PROTOCOLS_SEQ", "Common");

            modelBuilder.HasSequence("CO_INTERFACE_USER_SEQ", "Common");

            modelBuilder.HasSequence("CO_LAST_COMPANY_SELECTED_SEQ", "Common");

            modelBuilder.HasSequence("Co_Last_Number_Used_SEQ", "Common").StartsAt(200037);

            modelBuilder.HasSequence<int>("CO_LOGO_MASTER_SEQ", "Common");

            modelBuilder.HasSequence("Co_Messages_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CO_MODULE_INTEGRATION_SEQ", "Common");

            modelBuilder.HasSequence("CO_MY_VESSELS_SEQ", "Common");

            modelBuilder.HasSequence("Co_Nationalities_SEQ", "Common").StartsAt(154637);

            modelBuilder.HasSequence("Co_Nationality_Flag_SEQ", "Common").StartsAt(105009);

            modelBuilder.HasSequence("CO_NATIONALITY_FLAGS_SEQ", "Common").StartsAt(100000);

            modelBuilder.HasSequence("CO_NOTICES_SEQ", "Common").StartsAt(531692);

            modelBuilder.HasSequence("CO_Notification_Attachments_SEQ", "Common").StartsAt(101000);

            modelBuilder.HasSequence("CO_NOTIFICATIONS_FORWARDED_USERS_seq", "Common");

            modelBuilder.HasSequence("CO_Notifications_SEQ", "Common").StartsAt(101012);

            modelBuilder.HasSequence("CO_OFF_APPLICATION_STATUS_HISTORY_seq", "Common")
                .StartsAt(112545)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CO_OFF_APPLICATION_STATUS_seq", "Common")
                .StartsAt(145256)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CO_PAGE_FILTERS_SEQ", "Common").HasMax(9999999999999999);

            modelBuilder.HasSequence("Co_Parameters_SEQ", "Common").StartsAt(31200375);

            modelBuilder.HasSequence("CO_Parameters_Sub_SEQ", "Common").StartsAt(100001);

            modelBuilder.HasSequence("Co_Ports_SEQ", "Common").StartsAt(121113);

            modelBuilder.HasSequence("Co_Positions_SEQ", "Common").StartsAt(502010);

            modelBuilder.HasSequence("Co_Regions_SEQ", "Common").StartsAt(154741);

            modelBuilder.HasSequence("CO_REPORT_PARAMETER_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("Co_Roles_SEQ", "Common").StartsAt(154990);

            modelBuilder.HasSequence<int>("CO_SAVE_COMPANIES_LOGO_MASTER_SEQ", "Common");

            modelBuilder.HasSequence<int>("CO_SAVE_ENTITIES_LOGO_MASTER_SEQ", "Common");

            modelBuilder.HasSequence("Co_Schemas_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CO_SDC_PMSO_Contacts_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("co_sister_vessel_ref_seq", "Common");

            modelBuilder.HasSequence("CO_SISTER_VESSELS_seq", "Common");

            modelBuilder.HasSequence("Co_States_SEQ", "Common").StartsAt(155009);

            modelBuilder.HasSequence("CO_SUPER_USER_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("Co_Tables_SEQ", "Common").StartsAt(3120042);

            modelBuilder.HasSequence("CO_TWOFACTOR_LOCKED_HISTORY_SEQ", "Common");

            modelBuilder.HasSequence("Co_Uom_Conversions_SEQ", "Common").StartsAt(502124);

            modelBuilder.HasSequence("CO_UOM_MF_SEQ", "Common").StartsAt(900076);

            modelBuilder.HasSequence("CO_USER_ALERTS_seq", "Common");

            modelBuilder.HasSequence("CO_User_Departments_SEQ", "Common").StartsAt(3979);

            modelBuilder.HasSequence("CO_USER_LOCKED_HISTORY_SEQ", "Common");

            modelBuilder.HasSequence("CO_USER_LOGIN_HISTORY_SEQ", "Common").StartsAt(106875);

            modelBuilder.HasSequence("CO_USER_MULTIFACTOR_AUTH_HISTORY_SEQ", "Common");

            modelBuilder.HasSequence("CO_USER_MULTIFACTOR_LOGIN_SEQ", "Common");

            modelBuilder.HasSequence("CO_USER_NOTIFICATIONS_seq", "Common");

            modelBuilder.HasSequence("CO_USERS_AUDIT_SEQ", "Common");

            modelBuilder.HasSequence("Co_Users_SEQ", "Common").StartsAt(110922);

            modelBuilder.HasSequence("CO_USERS_SUPER_DT_SEQ", "Common");

            modelBuilder.HasSequence("CO_USERS_SUPER_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("Co_Vessel_Additional_Info_SEQ", "Common").StartsAt(500000);

            modelBuilder.HasSequence<int>("CO_Vessel_Allocation_BCKUP_SEQ", "Common");

            modelBuilder.HasSequence("CO_Vessel_Allocation_DT_SEQ", "Common").StartsAt(9500);

            modelBuilder.HasSequence("CO_Vessel_Allocation_HD_SEQ", "Common").HasMax(999999999999999999);

            modelBuilder.HasSequence("Co_Vessel_Communications_SEQ", "Common").StartsAt(110060);

            modelBuilder.HasSequence("Co_Vessel_Companies_SEQ", "Common").StartsAt(114125);

            modelBuilder.HasSequence("CO_VESSEL_CONFIRMED_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Co_Vessel_Departments_SEQ", "Common").StartsAt(154855);

            modelBuilder.HasSequence<int>("CO_VESSEL_DESIGNATION_BACKUP_USERS_SEQ", "Common");

            modelBuilder.HasSequence<int>("CO_VESSEL_DESIGNATION_USER_HISTORY_SEQ", "Common");

            modelBuilder.HasSequence<int>("CO_VESSEL_DESIGNATION_USERS_SEQ", "Common");

            modelBuilder.HasSequence<int>("CO_VESSEL_DESIGNATIONS_MF_SEQ", "Common");

            modelBuilder.HasSequence("Co_Vessel_Features_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Co_Vessel_Fleet_Types_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CO_VESSEL_GROUP_DT_SEQ", "Common")
                .StartsAt(1000)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CO_Vessel_Group_dt_Sesq", "Common")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CO_VESSEL_GROUP_HD_SEQ", "Common")
                .StartsAt(1000)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CO_Vessel_Group_Hd_Sesq", "Common")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CO_Vessel_Images_seq", "Common").HasMax(9999999999999999);

            modelBuilder.HasSequence("CO_VESSEL_MGMNT_TYPE_DESIGNATIONS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence<int>("CO_VESSEL_MGMT_TYPE_DESIGNATIONS_SEQ", "Common");

            modelBuilder.HasSequence("CO_VESSEL_PAGE_SETTINGS_SEQ", "Common").StartsAt(101000);

            modelBuilder.HasSequence("CO_Vessel_Particulars_repl_seq", "Common")
                .StartsAt(2576)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("Co_Vessel_Particulars_SEQ", "Common").StartsAt(864544);

            modelBuilder.HasSequence("Co_Vessel_Register_Master_Definition_SEQ", "Common");

            modelBuilder.HasSequence("Co_Vessel_Register_Master_Dt_Deleted_SEQ", "Common");

            modelBuilder.HasSequence("Co_Vessel_Register_Master_Dt_SEQ", "Common");

            modelBuilder.HasSequence("Co_Vessel_Register_Master_SEQ", "Common");

            modelBuilder.HasSequence("Co_Vessel_Register_Reasons_SEQ", "Common").StartsAt(105001);

            modelBuilder.HasSequence("CO_Vessel_Register_seq", "Common")
                .StartsAt(302408)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("Co_Vessel_Size_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Co_Vessel_Stakeholders_SEQ", "Common").HasMax(99999999999999999);

            modelBuilder.HasSequence("Co_Vessel_Type_Subtypes_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CO_VESSEL_USERS_TEMPLATE_DT_SEQ", "Common");

            modelBuilder.HasSequence("CO_Vessel_Work_Group_SEQ", "Common");

            modelBuilder.HasSequence("Co_Vsl_Rgs_Srvc_Life_Cycle_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("CO_Work_Group_MF_SEQ", "Common").StartsAt(11111);

            modelBuilder.HasSequence("CONTRACT_ITEM_RANGE_SEQ", "Common");

            modelBuilder.HasSequence("CONTRACT_ITEM_RANGE_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("CONTRACT_ITEM_TIME_SEQ", "Common");

            modelBuilder.HasSequence("DA_CASH_POSITION_SEQ", "Common").StartsAt(79407);

            modelBuilder.HasSequence("DA_CRW_EXCLUDE_PAYROLL_VESSELS_SEQ", "Common");

            modelBuilder.HasSequence<int>("DA_DASHBOARD_SDC_SEQ", "Common");

            modelBuilder.HasSequence("Da_Md_vessel_Months_Target_Seq", "Common");

            modelBuilder.HasSequence("DA_Mycurrencies_SEQ", "Common").StartsAt(110053);

            modelBuilder.HasSequence("DA_Myentities_SEQ", "Common").StartsAt(110000);

            modelBuilder.HasSequence("DA_Myvessels_SEQ", "Common").StartsAt(110011);

            modelBuilder.HasSequence("DA_Tile_Currencies_SEQ", "Common").StartsAt(110000);

            modelBuilder.HasSequence<int>("DA_TRIP_PLAN_EDITABLE_USERS_SEQ", "Common");

            modelBuilder.HasSequence("DA_TRIP_PLAN_SEQ", "Common");

            modelBuilder.HasSequence("DA_USER_DASHBOARD_DOCK_TILES_SEQ", "Common");

            modelBuilder.HasSequence("DA_USER_DASHBOARD_DOCKS_SEQ", "Common");

            modelBuilder.HasSequence("DA_USER_DASHBOARDS_SEQ", "Common");

            modelBuilder.HasSequence("DA_USER_TILE_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("DA_User_Tiles_SEQ", "Common").StartsAt(110015);

            modelBuilder.HasSequence("DIAMETER_MF_SEQ", "Common");

            modelBuilder.HasSequence<int>("EL_ADMIN_STRUCTURE_SEQ_SEQ", "Common").StartsAt(2040);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENT_MAPPING_SEQ", "Common").StartsAt(370);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENT_VESSEL_SUBTYPES_SEQ", "Common").StartsAt(721);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENTS_DATA_SEQ", "Common");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENTS_SEQ", "Common").StartsAt(384);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_GROUPS_SEQ", "Common").StartsAt(54);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_REGISTRY_MAPPING_SEQ", "Common").StartsAt(8);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_SUB_GROUPS_SEQ", "Common").StartsAt(152);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_TEMPLATES_SEQ", "Common").StartsAt(15);

            modelBuilder.HasSequence<int>("EL_LOG_BOOKS_SEQ", "Common").StartsAt(16);

            modelBuilder.HasSequence<int>("EL_PARAMETERS_SEQ", "Common").StartsAt(583);

            modelBuilder.HasSequence<int>("EL_Uom_MF_SEQ", "Common").StartsAt(2046);

            modelBuilder.HasSequence("EQUIPMENT_VESSEL_GROUP_MAPPING_SEQ", "Common").StartsAt(329);

            modelBuilder.HasSequence("IC_Admin_Structure_seq", "Common").StartsAt(2254);

            modelBuilder.HasSequence("IC_Claim_SubType_Exp_SubTypes_seq", "Common").StartsAt(2001);

            modelBuilder.HasSequence("IC_Claim_Subtypes_seq", "Common").StartsAt(2001);

            modelBuilder.HasSequence("IC_Claims_Of_Companies_SEQ", "Common").HasMax(99999999999999999);

            modelBuilder.HasSequence("IC_CrewMed_Subtypes_seq", "Common").StartsAt(2001);

            modelBuilder.HasSequence("IC_Expenditure_Type_Subtypes_seq", "Common").StartsAt(2001);

            modelBuilder.HasSequence("IC_Parameters_seq", "Common").StartsAt(2066);

            modelBuilder.HasSequence("IC_ParametersTest_SEQ", "Common");

            modelBuilder.HasSequence("IC_POLICY_HOLDER_COMPANIES_SEQ", "Common").HasMax(99999999999999999);

            modelBuilder.HasSequence("IC_REVIEW_PERIOD_SETTINGS_SEQ", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("IP_IP_TAG_PRIORITY_SEQ", "Common");

            modelBuilder.HasSequence("IP_IP_TAG_TYPE_SEQ", "Common");

            modelBuilder.HasSequence("IP_TAG_PRIORITY_SEQ", "Common");

            modelBuilder.HasSequence("IP_TAG_REGIONS_SEQ", "Common");

            modelBuilder.HasSequence("IP_TAG_TYPE_SEQ", "Common").StartsAt(10003);

            modelBuilder.HasSequence("ITEM_COMBINATION_MF_SEQ", "Common");

            modelBuilder.HasSequence("ITEM_COMBINATION_VALUE_SEQ", "Common");

            modelBuilder.HasSequence("LETTER_FIELDS_SEQ", "Common")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("LOA_Combination_MF_SEQ", "Common");

            modelBuilder.HasSequence("LOA_Combination_Value_SEQ", "Common");

            modelBuilder.HasSequence("LOA_GRP_SEQ", "Common");

            modelBuilder.HasSequence("LOA_ITEM_VALUE_SEQ", "Common");

            modelBuilder.HasSequence("LOA_MF_SEQ", "Common");

            modelBuilder.HasSequence("LP_ABSMARCAT_CAUSELIST_SEQ", "Common").StartsAt(112242);

            modelBuilder.HasSequence("LP_ABSMARKAT_CAUSES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_ACCEPTABILITY_SCALE_SEQ", "Common");

            modelBuilder.HasSequence("LP_ACCIDENT_SBUCATEGORY_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("LP_ACCIDENT_SUBTYPES_SEQ", "Common").StartsAt(3125925);

            modelBuilder.HasSequence("LP_ACTION_FORMATS_SEQ", "Common").StartsAt(112084);

            modelBuilder.HasSequence("LP_ADMIN_STRUCTURE_SEQ", "Common").StartsAt(112661);

            modelBuilder.HasSequence("LP_ALLISION_SUBCATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("LP_APPLICATION_FUNCTIONAL_ROLES_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_GUIDANCE_NOTE_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_PERIOD_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_SECTION_CONCERNS_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_SECTION_CORRECTIVE_ACTIONS_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_SECTIONS_ELEMENTS_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_SECTIONS_SEQ", "Common");

            modelBuilder.HasSequence("LP_BBS_WORKFLOW_TEMPLATE_SEQ", "Common");

            modelBuilder.HasSequence("LP_CLIENT_PARAMETERS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_COLLISION_SUBCATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("LP_COMPANY_UNIT_TYPE_COMPANY_UNITS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_DNV_MSCAT_CAUSES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_DNV_MSCAT_SEQ", "Common").StartsAt(15);

            modelBuilder.HasSequence("LP_DNV_MSCAT_SUBCAUSES_SEQ", "Common").StartsAt(3130002);

            modelBuilder.HasSequence("LP_DR_DRILL_CATEGORY_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_DR_DRILL_COMPANY_UNITS_SEQ", "Common").StartsAt(273);

            modelBuilder.HasSequence("LP_DR_DRILL_GROUPS_SEQ", "Common").StartsAt(75);

            modelBuilder.HasSequence("LP_DR_DRILL_GUIDANCE_NOTE_SEQ", "Common");

            modelBuilder.HasSequence("LP_DR_DRILL_PERIOD_SEQ", "Common").StartsAt(386);

            modelBuilder.HasSequence("LP_DR_DRILL_SUB_GROUPS_SEQ", "Common").StartsAt(45);

            modelBuilder.HasSequence("LP_DR_DRILL_VESSEL_SUBTYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_DR_DRILLS_SEQ", "Common").StartsAt(182);

            modelBuilder.HasSequence("LP_DR_GROUP_COMPANY_UNITS_SEQ", "Common").StartsAt(41);

            modelBuilder.HasSequence("LP_DR_GROUP_VESSEL_SUBTYPES_SEQ", "Common").StartsAt(10170);

            modelBuilder.HasSequence("LP_DR_Group_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_DR_SUBGROUP_COMPANY_UNITS_SEQ", "Common").StartsAt(59);

            modelBuilder.HasSequence("LP_DR_SUBGROUP_VESSEL_SUBTYPES_SEQ", "Common").StartsAt(2949);

            modelBuilder.HasSequence("LP_EVENT_TYPES_FINDING_CATEGORY_SEQ", "Common");

            modelBuilder.HasSequence("LP_EVENT_TYPES_FINDING_HEADER_SEQ", "Common");

            modelBuilder.HasSequence("LP_EVENT_TYPES_REFERENCE_TYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_EVENT_TYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_Event_Types_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_Facilitation_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_FINDING_HEADER_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_FINDING_LEVEL1_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_FINDING_LEVEL2_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence<int>("LP_FUNCTIONAL_ROLE_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("LP_GAS_LISTS_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_GROUNDING_SUBCATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_ACTION_LIST_SEQ", "Common").StartsAt(282);

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_CAUSE_TYPE_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_COMMENT_TYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_COMPANY_UNITS_SEQ", "Common");

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_OTHER_SETTINGS_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_SEVERITIES_SEQ", "Common").StartsAt(42);

            modelBuilder.HasSequence("LP_Incident_Subtype_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPE_WF_TEMPLATES_SEQ", "Common").StartsAt(58);

            modelBuilder.HasSequence("LP_INCIDENT_SUBTYPES_SEQ", "Common").StartsAt(36);

            modelBuilder.HasSequence("LP_INCIDENT_TYPES_SEQ", "Common").StartsAt(24);

            modelBuilder.HasSequence("LP_KPI_HEADER_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_LEVEL_LABELS_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_LEVEL1_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_LEVEL2_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_LEVEL3_CORPORATE_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_LEVEL3_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_MC_AUTHORITY_LEVEL_ROLES_SEQ", "Common").StartsAt(866);

            modelBuilder.HasSequence("LP_MC_AUTHORITY_LEVELS_SEQ", "Common").StartsAt(4);

            modelBuilder.HasSequence("LP_MC_AUTHORITY_SECTIONS_SEQ", "Common").StartsAt(288);

            modelBuilder.HasSequence("LP_MC_CHANGE_TYPE_AUTH_LEVELS_SEQ", "Common").StartsAt(16);

            modelBuilder.HasSequence("LP_MC_CHANGE_TYPE_SEQ", "Common").StartsAt(10);

            modelBuilder.HasSequence("LP_MC_Change_Type_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_MC_REQUIRED_INFORMATION_SEQ", "Common");

            modelBuilder.HasSequence("LP_MC_SECTION_QUESTIONS_SEQ", "Common").StartsAt(69);

            modelBuilder.HasSequence("LP_MC_SECTIONS_SEQ", "Common").StartsAt(45);

            modelBuilder.HasSequence("LP_MOU_COUNTRIES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_MOU_Deficiency_Groups_SEQ", "Common").StartsAt(31);

            modelBuilder.HasSequence("LP_MOU_DEFICIENCY_LIST_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_MOU_DEFICIENCY_SUBGROUPS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_MOU_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("LP_MSCAT_Causes_seq", "Common").StartsAt(132);

            modelBuilder.HasSequence("LP_NEAR_MISS_SUBCATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("LP_PARAMETERS_SEQ", "Common").StartsAt(1103);

            modelBuilder.HasSequence("LP_PERSONAL_RESPONSIBILITY_SEQ", "Common");

            modelBuilder.HasSequence("LP_POLLUTION_SUBCATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("LP_Polution_SubCategories_Quantity_SEQ", "Common");

            modelBuilder.HasSequence("LP_POST_INCIDENT_QUESTIONS_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_CATEGORY_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_PR_COMPANY_UNITS_SEQ", "Common").StartsAt(20);

            modelBuilder.HasSequence("LP_PR_GROUP_COMPANY_UNITS_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_PR_GROUP_QUESTION_SETS_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_GROUP_TAB_FORMATS_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_GROUP_VESSEL_SUBTYPES_SEQ", "Common").StartsAt(955);

            modelBuilder.HasSequence("LP_PR_Group_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_GROUPS_SEQ", "Common").StartsAt(11);

            modelBuilder.HasSequence("LP_PR_GUIDANCE_NOTE_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_PERIOD_SEQ", "Common").StartsAt(24);

            modelBuilder.HasSequence("LP_PR_REVIEW_SEQ", "Common").StartsAt(21);

            modelBuilder.HasSequence("LP_PR_SIRE_RA_AREA_DETAILS_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_SUB_GROUPS_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_PR_SUBGROUP_COMPANY_UNITS_SEQ", "Common").StartsAt(2);

            modelBuilder.HasSequence("LP_PR_SUBGROUP_VESSEL_SUBTYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_PR_VESSEL_SUBTYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_CATEGORY_MATRIX_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_CATEGORY_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_COLOUR_CODE_SEQ", "Common").StartsAt(48);

            modelBuilder.HasSequence("LP_RA_MATRIX_DEFINITION_SEQ", "Common").StartsAt(31);

            modelBuilder.HasSequence("LP_RA_MATRIX_REFERENCE_TYPE_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_RA_MATRIX_RISK_INDEX_SEQ", "Common").StartsAt(15);

            modelBuilder.HasSequence("LP_RA_MATRIX_SEQ", "Common").StartsAt(4);

            modelBuilder.HasSequence("LP_RA_RISK_LEVEL_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_TASK_COMPANY_UNITS_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_TASK_GROUPS_SEQ", "Common").StartsAt(10823);

            modelBuilder.HasSequence("LP_RA_TASK_LOCATIONS_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_TASK_SUB_GROUPS_SEQ", "Common").StartsAt(28);

            modelBuilder.HasSequence("LP_RA_TASK_VESSEL_SUBTYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_Task_WF_Templates_SEQ", "Common");

            modelBuilder.HasSequence("LP_RA_TASK_WP_TEMPLATES_SEQ", "Common").StartsAt(25);

            modelBuilder.HasSequence("LP_RA_TASKS_SEQ", "Common");

            modelBuilder.HasSequence("LP_REFERENCE_TYPES_SEQ", "Common").StartsAt(50);

            modelBuilder.HasSequence("LP_REFERENCE_TYPES_SETTINGS_SEQ", "Common").StartsAt(3175705);

            modelBuilder.HasSequence("LP_REPORT_COMPANY_SPECIFIC_UNITS_SEQ", "Common").StartsAt(3081);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_ACTION_LIST_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_AREA_ANALYSIS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_AREA_INSPECTION_SEQ", "Common").StartsAt(2);

            modelBuilder.HasSequence("LP_Report_SubType_Cause_Type_SEQ", "Common").StartsAt(3125421);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_COMMENT_TYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_COMPANY_SPECIFIC_UNITS_SEQ", "Common").StartsAt(2000);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_COMPANY_UNITS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_FINDING_LIST_SEQ", "Common");

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_OTHER_SETTINGS_SEQ", "Common").StartsAt(4);

            modelBuilder.HasSequence<int>("LP_REPORT_SUBTYPE_REPORT_FREQUENCY_SEQ", "Common");

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_RESULTS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_SEVERITIES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_SUBCATEGORIES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_SUBCATEGORY_LIST_seq", "Common").StartsAt(11191);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_VESSEL_SUBTYPES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_Report_SubType_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_REPORT_SUBTYPE_WF_TEMPLATES_SEQ", "Common").StartsAt(50);

            modelBuilder.HasSequence("LP_REPORT_SUBTYPES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_REPORT_TYPES_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_RISK_SCORE_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("LP_ROOT_CAUSE_HEADER_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_ROOT_CAUSE_LEVEL1_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_ROOT_CAUSE_LEVEL2_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_ROOT_CAUSE_LEVEL3_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_SBM_MINUTES_SECTION_SEQ", "Common").StartsAt(930);

            modelBuilder.HasSequence("LP_SBM_MINUTES_SECTION_VESSEL_SUBTYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_SBM_PERIOD_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_SBM_Sub_Types_SEQ", "Common").StartsAt(60);

            modelBuilder.HasSequence("LP_SBM_Subtypes_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LP_SBM_TYPES_OF_MEETINGS_SEQ", "Common").StartsAt(32);

            modelBuilder.HasSequence("LP_SWF_Functional_Roles_SEQ", "Common");

            modelBuilder.HasSequence("LP_SWF_Next_Actions_For_MWF_SEQ", "Common");

            modelBuilder.HasSequence("LP_SYSTEM_WORK_FLOW_SEQ", "Common");

            modelBuilder.HasSequence("LP_VESSEL_AGE_FACTOR_SEQ", "Common");

            modelBuilder.HasSequence("LP_VESSEL_ALLOCATION_APPLICATIONS_SEQ", "Common").StartsAt(3172196);

            modelBuilder.HasSequence("LP_VESSEL_ALLOCATIONS_WF_TEMPLATES_SEQ", "Common");

            modelBuilder.HasSequence("LP_VESSEL_SCORE_LIST_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_Allocation_Entity_Applications_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_ALLOCATION_ENTITY_ROLES_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_ALLOCATION_ENTITY_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_Allocation_Entity_Templates_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_Allocation_Entity_Users_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_ATTACHMENTS_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_TEMPLATE_ACTIONS_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_TEMPLATE_COMPANIES_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_Template_Control_Roles_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_TEMPLATE_CONTROLS_SEQ", "Common").StartsAt(3);

            modelBuilder.HasSequence("LP_WF_TEMPLATE_VESSEL_TYPES_SEQ", "Common");

            modelBuilder.HasSequence("LP_WF_TEMPLATES_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_WORK_FLOW_GROUPS_SEQ", "Common");

            modelBuilder.HasSequence("LP_Work_Flow_Log_Details_SEQ", "Common");

            modelBuilder.HasSequence("LP_WORK_FLOW_LOGS_SEQ", "Common");

            modelBuilder.HasSequence("LP_WORK_FLOW_TEMPLATES_SEQ", "Common").StartsAt(50);

            modelBuilder.HasSequence("LP_WP_FORMAT_GUIDANCE_NOTE_SEQ", "Common");

            modelBuilder.HasSequence("LP_WP_FORMATS_SEQ", "Common");

            modelBuilder.HasSequence("LP_WP_GAS_LIST_SEQ", "Common").StartsAt(6);

            modelBuilder.HasSequence("LP_WP_SECTION_AUTHORITIES_SEQ", "Common").StartsAt(38);

            modelBuilder.HasSequence("LP_WP_SECTION_GUIDANCE_NOTE_SEQ", "Common").StartsAt(21);

            modelBuilder.HasSequence("LP_WP_TEMPLATE_ACTIVITY_LIST_SEQ", "Common").StartsAt(15);

            modelBuilder.HasSequence("LP_WP_TEMPLATE_GAS_LIST_SEQ", "Common").StartsAt(36);

            modelBuilder.HasSequence("LP_WP_TEMPLATE_GUIDANCE_NOTE_SEQ", "Common").StartsAt(29);

            modelBuilder.HasSequence("LP_WP_TEMPLATE_SECTION_QUESTIONS_SEQ", "Common").StartsAt(430);

            modelBuilder.HasSequence("LP_WP_TEMPLATE_SECTIONS_SEQ", "Common").StartsAt(189);

            modelBuilder.HasSequence("LP_WP_TEMPLATE_SEQ", "Common").StartsAt(29);

            modelBuilder.HasSequence("LP_WP_Template_WF_Template_SEQ", "Common");

            modelBuilder.HasSequence("LPI_DOWNLOAD_UTIL_TABLES_SEQ", "Common").StartsAt(540);

            modelBuilder.HasSequence("LPI_REPORT_SUBTYPE_IRT_SEQ", "Common");

            modelBuilder.HasSequence("LPI_TERMS_AND_CONDITIONS_SEQ", "Common");

            modelBuilder.HasSequence("LPMDM_Attachments_SEQ", "Common");

            modelBuilder.HasSequence("LPQ_QUESTION_ANSWER_TYPE_ANSWERS_SEQ", "Common");

            modelBuilder.HasSequence("LPQ_QUESTION_SET_REPORT_SUBTYPES_SEQ", "Common");

            modelBuilder.HasSequence("MDCFKTable_SEQ", "Common");

            modelBuilder.HasSequence("MDCRegister_SEQ", "Common");

            modelBuilder.HasSequence("MDCTable_SEQ", "Common");

            modelBuilder.HasSequence("MFA_EXCLUDED_USERS_SEQ", "Common");

            modelBuilder.HasSequence<int>("PJ_DOCKS_MF_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence("PJ_JOB_SPECS_MF_SEQ", "Common")
                .StartsAt(496)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOBS_MF_SEQ", "Common")
                .StartsAt(1021)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_SECTIONS_MF_SEQ", "Common")
                .StartsAt(88)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_STANDARD_QUOTES_MF_SEQ", "Common")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_SUPPLY_ITEMS_MF_SEQ", "Common")
                .StartsAt(69)
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_SURVEY_TYPE_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("PJ_UOM_MF_SEQ", "Common").StartsAt(143);

            modelBuilder.HasSequence<int>("PJ_YARDS_MF_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence("PM_ADMIN_STRUCTURE_SEQ", "Common").StartsAt(400050);

            modelBuilder.HasSequence("PM_Alarm_MF_SEQ", "Common").StartsAt(501999);

            modelBuilder.HasSequence("PM_APPROVAL_LIST_SEQ", "Common").StartsAt(10000);

            modelBuilder.HasSequence("PM_Assembly_Equipments_LIB_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_Assembly_MF_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_ATTACHMENT_CONFIG_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("PM_Builders_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("PM_CONDITIONS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_Equip_Parameter_Mapping_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("PM_Equipment_Extn_SEQ", "Common").StartsAt(502001);

            modelBuilder.HasSequence("PM_EQUIPMENT_LIB_SEQ", "Common").HasMax(999999999999999999);

            modelBuilder.HasSequence("PM_Equipment_MF_SEQ", "Common").StartsAt(502043);

            modelBuilder.HasSequence("PM_Equipment_Parameter_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("PM_Equipment_Type_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("PM_Event_Categories_SEQ", "Common").StartsAt(502015);

            modelBuilder.HasSequence("PM_Events_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("PM_Frequency_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("PM_JOB_DESCRIPTION_LIB_SEQ", "Common").StartsAt(1002);

            modelBuilder.HasSequence("PM_JOB_LIB_SEQ", "Common").HasMax(99999999999999999);

            modelBuilder.HasSequence("PM_Job_MF_Procedure_SEQ", "Common").StartsAt(502163);

            modelBuilder.HasSequence("PM_Job_MF_SEQ", "Common").StartsAt(200000);

            modelBuilder.HasSequence("PM_JOB_PLAN_HISTORY_SEQ", "Common");

            modelBuilder.HasSequence("PM_JOB_PROC_LIB_SEQ", "Common")
                .StartsAt(99990000631866)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PM_JOB_SPARE_LIB_SEQ", "Common").HasMax(99999999999999999);

            modelBuilder.HasSequence("PM_Job_To_Vsl_Category_SEQ", "Common").StartsAt(502011);

            modelBuilder.HasSequence("PM_JOBPLAN_RA_LIB_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_Makers_SEQ", "Common").StartsAt(527880);

            modelBuilder.HasSequence("PM_MANUALS_LIB_DETAILS_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("PM_MANUALS_LIB_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("PM_MODELS_SEQ", "Common").StartsAt(114540);

            modelBuilder.HasSequence("PM_Project_Index_SEQ", "Common").StartsAt(502028);

            modelBuilder.HasSequence("PM_Project_SEQ", "Common").StartsAt(112222);

            modelBuilder.HasSequence("PM_SAFETY_SUBGROUP_LIST_SEQ", "Common").StartsAt(10000);

            modelBuilder.HasSequence("PM_SPARE_LIB_LOAD_SEQ", "Common").HasMax(999999999999999999);

            modelBuilder.HasSequence("PM_SPARE_MAPPING_SEQ", "Common")
                .StartsAt(1000)
                .HasMin(1000);

            modelBuilder.HasSequence("PM_SPARE_PARTS_CODE_SEQ", "Common").StartsAt(3517051);

            modelBuilder.HasSequence("PM_Status_List_SEQ", "Common").StartsAt(502041);

            modelBuilder.HasSequence("PM_Storage_Location_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("PM_Survey_Reference_SEQ", "Common").StartsAt(105001);

            modelBuilder.HasSequence("PM_TF_JOB_LIB_FORMS_MAPPING_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_USER_RANKS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_VESSEL_ASSEMBLY_COMPLETION_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PM_VESSEL_DEPT_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("PR_Accident_Insurance_SEQ", "Common").StartsAt(105007);

            modelBuilder.HasSequence<int>("PR_BPS_MONTHLY_INP_TEMPLATE_SEQ", "Common");

            modelBuilder.HasSequence("PR_CASH_ADVANCE_COMPONENT_MAPPING_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PR_CASH_ADVANCE_RANK_CATEGORY_MAPPING_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("PR_Cmpnt_Not_Appl_Companies_SEQ", "Common").StartsAt(105001);

            modelBuilder.HasSequence("PR_Component_Categories_SEQ", "Common").StartsAt(502013);

            modelBuilder.HasSequence("PR_Component_NB_DT_SEQ", "Common");

            modelBuilder.HasSequence("PR_Component_SEQ", "Common").StartsAt(502002);

            modelBuilder.HasSequence("PR_Contract_Group_SEQ", "Common").StartsAt(105003);

            modelBuilder.HasSequence("PR_COST_CODE_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("PR_COST_CODE_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("PR_LAST_NUMBER_USED_SEQ", "Common").StartsAt(400002);

            modelBuilder.HasSequence("PR_LEAVE_RULE_DETAILS_SEQ", "Common");

            modelBuilder.HasSequence("PR_Monthly_Inp_Template_NEW_SEQ", "Common").StartsAt(503073);

            modelBuilder.HasSequence("PR_Monthly_Inp_Template_SEQ", "Common").StartsAt(509642);

            modelBuilder.HasSequence("PR_PAYSCALE_COMPONENT_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("PR_Payscale_Hd_SEQ", "Common").StartsAt(112774);

            modelBuilder.HasSequence("PR_Payscale_MF_SEQ", "Common").StartsAt(110966);

            modelBuilder.HasSequence("PR_Payslip_Group_SEQ", "Common").StartsAt(502134);

            modelBuilder.HasSequence("PR_SOCIAL_BENEFIT_SEQ", "Common");

            modelBuilder.HasSequence("PR_VESSEL_ADDITIONAL_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("RA_Category_Matrix_SEQ", "Common");

            modelBuilder.HasSequence("RA_Task_Company_Units_SEQ", "Common").StartsAt(95);

            modelBuilder.HasSequence("RA_TASK_GROUP_SEQ", "Common").StartsAt(10823);

            modelBuilder.HasSequence("RA_TASK_GROUPS_VESSEL_SUBTYP_SEQ", "Common").StartsAt(92);

            modelBuilder.HasSequence("RA_TASK_SUB_GROUPS_VESSEL_SUBTYP_SEQ", "Common").StartsAt(92);

            modelBuilder.HasSequence("RA_TASKS_SEQ", "Common").StartsAt(269);

            modelBuilder.HasSequence("RA_TASKS_SUB_GROUP_SEQ", "Common").StartsAt(28);

            modelBuilder.HasSequence("rep_code_seq_upd", "Common").StartsAt(350);

            modelBuilder.HasSequence("REP_CRW_PLAN_VESSEL_SETTING_SEQ", "Common").StartsAt(1414000000);

            modelBuilder.HasSequence("REP_CRW_TOUR_VESSEL_SETTING_SEQ", "Common").StartsAt(1414000000);

            modelBuilder.HasSequence("REP_ENABLED_VESSELS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("REP_EXTR_PC_EXCLUDE_SEQ", "Common");

            modelBuilder.HasSequence("REP_Import_Temp_Table_SEQ", "Common");

            modelBuilder.HasSequence("REP_PAYSCALE_AUTO_EXPORT_SETTINGS_SEQ", "Common");

            modelBuilder.HasSequence("REP_Queue_Log_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("REP_SKIPPED_RECORDS_SEQ", "Common");

            modelBuilder.HasSequence("REP_Vessel_CDT_Settings_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("REP_VESSEL_DEFAULT_DATA_REPLICATE_LOG_SEQ", "Common");

            modelBuilder.HasSequence("REP_VESSEL_SETTINGS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("Rm_Admin_Structure_SEQ", "Common").StartsAt(500000);

            modelBuilder.HasSequence("Rm_Lookup_Team_Office_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Rm_Lookup_Team_Vessel_SEQ", "Common").StartsAt(502062);

            modelBuilder.HasSequence("Rm_Matrix_Category_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Rm_Matrix_Definition_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Rm_Matrix_Groupcategory_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Rm_Matrix_Groupdefinition_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Rm_Parameters_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("Rm_Subgroup_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SC_Admin_Structure_SEQ", "Common").StartsAt(600000);

            modelBuilder.HasSequence("SC_Nutrition_MF_SEQ", "Common").StartsAt(502154);

            modelBuilder.HasSequence("SC_Stock_Spoilage_Reason_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SC_Victualling_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_Admin_Structure_SEQ", "Common").StartsAt(200648);

            modelBuilder.HasSequence("SP_Approval_Cycle_DT_SEQ", "Common").StartsAt(105001);

            modelBuilder.HasSequence("SP_Approval_Cycle_Hd_SEQ", "Common").StartsAt(110421);

            modelBuilder.HasSequence("SP_APPROVAL_DETAILS_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("SP_Approval_Exempted_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_Approval_List_Hist_SEQ", "Common");

            modelBuilder.HasSequence("SP_Approval_List_SEQ", "Common").StartsAt(2111457);

            modelBuilder.HasSequence("SP_Approval_Rights_DT_SEQ", "Common").StartsAt(105004);

            modelBuilder.HasSequence("SP_Approval_Rights_Hd_SEQ", "Common").StartsAt(105011);

            modelBuilder.HasSequence("SP_APPROVAL_RIGHTS_LIMIT_SEQ", "Common").StartsAt(2001);

            modelBuilder.HasSequence("SP_ATTACHMENT_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("SP_Company_Tradenet_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_CONTRACT_ITEM_LEVEL_ATTRIBUTE_DT_SEQ", "Common");

            modelBuilder.HasSequence("SP_Contract_Vessels_SEQ", "Common");

            modelBuilder.HasSequence("SP_Contracted_Companies_seq", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_CRITICAL_SPARES_INVENTORY_DT_SEQ", "Common");

            modelBuilder.HasSequence("SP_CRITICAL_SPARES_INVENTORY_HD_SEQ", "Common");

            modelBuilder.HasSequence("SP_DOCUMENT_PREFIXES_sEQ", "Common");

            modelBuilder.HasSequence("SP_ExVessel_Allocation_DT_SEQ", "Common");

            modelBuilder.HasSequence("SP_ExVessel_Allocation_HD_SEQ", "Common");

            modelBuilder.HasSequence<int>("SP_FLAG_COMBINATION_MF_Combination_SEQ", "Common");

            modelBuilder.HasSequence<int>("SP_FLAG_COMBINATION_MF_SEQ", "Common");

            modelBuilder.HasSequence("SP_FLAG_COMBINATION_MF_TEST_Combination_SEQ", "Common");

            modelBuilder.HasSequence("SP_FLAG_COMBINATION_MF_TEST_SEQ", "Common");

            modelBuilder.HasSequence<int>("SP_FLAG_MF_SEQ", "Common");

            modelBuilder.HasSequence<int>("SP_FLAG_MF_TEST_SEQ", "Common");

            modelBuilder.HasSequence("SP_FUNCTIONAL_ROLE_INFO_SEQ", "Common");

            modelBuilder.HasSequence("SP_Functional_Role_SEQ", "Common").StartsAt(105004);

            modelBuilder.HasSequence("SP_I2P_APPROVAL_RIGHTS_DT_SEQ", "Common");

            modelBuilder.HasSequence("SP_I2P_APPROVAL_RIGHTS_HD_SEQ", "Common");

            modelBuilder.HasSequence("SP_I2P_EXCLUDED_CATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("SP_ITEM_CATEGORY_EQUIP_MAPPING_SEQ", "Common").HasMax(999999999999999999);

            modelBuilder.HasSequence("SP_Item_FLAG_COMBINATION_MAPPING_HISTORY_SEQ", "Common");

            modelBuilder.HasSequence("SP_Item_FLAG_COMBINATION_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("SP_Item_FLAG_MF_SEQ", "Common");

            modelBuilder.HasSequence("SP_ITEM_LOCATIONS_SEQ", "Common").StartsAt(222769);

            modelBuilder.HasSequence("SP_ITEM_MF_ATTRIBUTES_SEQ", "Common").StartsAt(13350008324090);

            modelBuilder.HasSequence("SP_ITEM_MF_SEQ", "Common").StartsAt(8214483);

            modelBuilder.HasSequence("SP_Item_Section_SEQ", "Common").StartsAt(1859);

            modelBuilder.HasSequence("SP_Item_Template_DT_SEQ", "Common").StartsAt(113640);

            modelBuilder.HasSequence("SP_Item_Template_Hd_SEQ", "Common").StartsAt(105134);

            modelBuilder.HasSequence("SP_Item_Unit_Conversion_SEQ", "Common").StartsAt(502029);

            modelBuilder.HasSequence("SP_Item_Value_seq", "Common").StartsAt(9999000183732);

            modelBuilder.HasSequence("SP_ItemCategoryAttributeMapping_SEQ", "Common");

            modelBuilder.HasSequence("SP_Packing_UOM_Mapping_SEQ", "Common");

            modelBuilder.HasSequence("SP_Payment_Contract_DT_SEQ", "Common").StartsAt(300000);

            modelBuilder.HasSequence("sp_payment_contract_hd_seq", "Common").StartsAt(115000);

            modelBuilder.HasSequence("SP_Po_Status_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_ProductAttributeDT_SEQ", "Common");

            modelBuilder.HasSequence("SP_ProductAttributeHD_SEQ", "Common");

            modelBuilder.HasSequence("SP_ProductAttributeValueHD_SEQ", "Common");

            modelBuilder.HasSequence("SP_SPARES_MAPPING_LIB_SEQ", "Common").StartsAt(10000);

            modelBuilder.HasSequence("SP_SPARES_MAPPING_SEQ", "Common").StartsAt(10000);

            modelBuilder.HasSequence<int>("SP_SUPPLY_CONTARCT_REGIONS_SEQ", "Common");

            modelBuilder.HasSequence("SP_Supply_Contract_DT_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence<int>("SP_Supply_Contract_HD_History_SEQ", "Common");

            modelBuilder.HasSequence("SP_Supply_Contract_Hd_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_Supply_Contract_Ports_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence<int>("SP_SUPPLY_CONTRACT_REGIONS_SEQ", "Common");

            modelBuilder.HasSequence("SP_SUPPLY_CONTRACT_UOM_DT_SEQ", "Common");

            modelBuilder.HasSequence("SP_SUPPLY_CONTRACT_VESSEL_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("SP_Supply_Contract_Zones_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_TERMS_AND_CONDITIONS_SEQ", "Common").StartsAt(500);

            modelBuilder.HasSequence("SP_Transaction_Type_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_TYPE_IN_VESSELS_SEQ", "Common");

            modelBuilder.HasSequence("SP_USER_VESSEL_HISTORY_seq", "Common");

            modelBuilder.HasSequence("SP_VENDOR_ACCOUNT_DETAILS_SEQ", "Common");

            modelBuilder.HasSequence("SP_VENDOR_ACCREDITATION_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("SP_VENDOR_ADDITIONAL_DETAILS_SEQ", "Common").StartsAt(2001);

            modelBuilder.HasSequence("SP_Vendor_Approval_SEQ", "Common").StartsAt(110293);

            modelBuilder.HasSequence("SP_Vendor_Categories_SEQ", "Common").StartsAt(110212);

            modelBuilder.HasSequence("SP_Vendor_Comments_Action_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_Vendor_Comments_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("sp_vendor_Companies_SEQ", "Common").StartsAt(115001);

            modelBuilder.HasSequence("SP_VENDOR_CONTACT_ADDITIONAL_SEQ", "Common");

            modelBuilder.HasSequence("SP_Vendor_Contacts_SEQ", "Common").StartsAt(120386);

            modelBuilder.HasSequence("SP_Vendor_Data_Transfer_SEQ", "Common").StartsAt(125757);

            modelBuilder.HasSequence("SP_Vendor_Eval_Criteria_CATEGORY_DT_SEQ", "Common").StartsAt(5020);

            modelBuilder.HasSequence("SP_Vendor_Eval_Criteria_SEQ", "Common").StartsAt(502023);

            modelBuilder.HasSequence("SP_Vendor_Eval_Ratings_MF_SEQ", "Common").StartsAt(400000);

            modelBuilder.HasSequence("SP_Vendor_History_SEQ", "Common").StartsAt(105002);

            modelBuilder.HasSequence("SP_VENDOR_ITEM_CATEGORIES_SEQ", "Common");

            modelBuilder.HasSequence("SP_VENDOR_ITEM_SECTIONS_SEQ", "Common");

            modelBuilder.HasSequence("sp_vendor_items_seq", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_Vendor_Makers_Seq", "Common").StartsAt(2220000);

            modelBuilder.HasSequence("sp_vendor_port_seq", "Common").StartsAt(115000);

            modelBuilder.HasSequence("SP_VENDOR_QUALIFY_SEQ", "Common").StartsAt(218530);

            modelBuilder.HasSequence("SP_Vendor_Vendor_Types_SEQ", "Common").StartsAt(131193);

            modelBuilder.HasSequence("sp_vendor_vessels_seq", "Common").StartsAt(273270);

            modelBuilder.HasSequence("SP_VESSEL_ALLOCATION_DT_HIST_SEQ", "Common").StartsAt(22322750);

            modelBuilder.HasSequence("SP_Vessel_Allocation_DT_SEQ", "Common").StartsAt(840087);

            modelBuilder.HasSequence("SP_Vessel_Allocation_HD_HIST_SEQ", "Common");

            modelBuilder.HasSequence("SP_Vessel_Allocation_Hd_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("SP_VESSEL_SETTINGS_SEQ", "Common").StartsAt(1001);

            modelBuilder.HasSequence("SP_VESSELS_AND_SPARES_SEQ", "Common");

            modelBuilder.HasSequence("SUPPLY_CONTRACT_VENDOR_MAPPING_SEQ", "Common");

            modelBuilder.HasSequence("TEMPORARY_SEQ", "Common")
                .HasMin(0)
                .HasMax(100)
                .IsCyclic();

            modelBuilder.HasSequence("TRN_Admin_Structure_SEQ", "Common");

            modelBuilder.HasSequence("TRN_Parameters_SEQ", "Common");

            modelBuilder.HasSequence("TS_Account_Mapping_MF_SEQ", "Common").HasMax(999999999999999999);

            modelBuilder.HasSequence("TS_ADDITIONAL_SERVICES_SEQ", "Common").StartsAt(10124440);

            modelBuilder.HasSequence("TS_Travel_Bill_To_SEQ", "Common").HasMax(999999999999999999);

            modelBuilder.HasSequence("Ts_Travel_Desk_DT_seq", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("Ts_Travel_Desk_HD_seq", "Common").HasMax(999999999999999);

            modelBuilder.HasSequence("TS_Travel_Reason_MF_SEQ", "Common").StartsAt(105008);

            modelBuilder.HasSequence("TS_Trip_Category_MF_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence<int>("UP_CM_ADMINACCEPTANCE_MF_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("VesselBeneficialOwnerHistoryFT_SEQ", "Common");

            modelBuilder.HasSequence("VesselCompanyHistoryFT_SEQ", "Common");

            modelBuilder.HasSequence("VesselDataFT_SEQ", "Common");

            modelBuilder.HasSequence("VesselFlagHistoryFT_SEQ", "Common");

            modelBuilder.HasSequence("VesselNameHistoryFT_SEQ", "Common");

            modelBuilder.HasSequence("VesselSpecialFeaturesFT_SEQ", "Common");

            modelBuilder.HasSequence<decimal>("VO_ADMIN_STRUCTURE_SEQ", "Common")
                .StartsAt(2500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_AlertRoles_SEQ", "Common")
                .StartsAt(500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Cargo_Aux_Names_SEQ", "Common")
                .StartsAt(2000)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Cargo_Details_SEQ", "Common").StartsAt(2000);

            modelBuilder.HasSequence<decimal>("VO_Cargo_VesselType_Mapping_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_COMMENTS_DT_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_COMMENTS_HD_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_COMMODITIES_SEQ", "Common")
                .StartsAt(16)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_DELAY_GROUPS_SEQ", "Common")
                .StartsAt(2000)
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence<decimal>("VO_DELAY_REASONS_SEQ", "Common")
                .StartsAt(1000)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_EQ_MASTERS_SEQ", "Common")
                .StartsAt(74)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_EQ_TYPES_SEQ", "Common")
                .StartsAt(69)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_EQUIP_TYPE_ATTRIB_MAPPING_SEQ", "Common")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_Equipment_MeasurePoints_SEQ", "Common")
                .StartsAt(864)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_EUMRV_VSL_TYPE_MAPPING_SEQ", "Common").StartsAt(110);

            modelBuilder.HasSequence("VO_INCIDENTS_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence<decimal>("VO_ITEM_CATEGORIES_SEQ", "Common")
                .StartsAt(500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_ITEM_MF_SEQ", "Common")
                .StartsAt(500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Item_Operations_SEQ", "Common")
                .StartsAt(500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_MEASURE_POINTS_SEQ", "Common")
                .StartsAt(11880)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_OPR_Office_DT_SEQ", "Common")
                .StartsAt(1120)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_OPR_Office_HD_SEQ", "Common")
                .StartsAt(1100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PAGE_COMMENT_REFERENCE_SEQ", "Common")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_Performance_Codes_SEQ", "Common")
                .StartsAt(500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_Port_Terminal_Berth_SEQ", "Common")
                .StartsAt(107)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SDR_CATALOGUE_CATEGORY_SEQ", "Common").StartsAt(100);

            modelBuilder.HasSequence("VO_SDR_ITEM_CATALOGUE_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence<decimal>("VO_Terminal_Facilities_SEQ", "Common")
                .StartsAt(765)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_Terminals_SEQ", "Common")
                .StartsAt(202)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_VESSEL_GROUP_SEQ", "Common")
                .StartsAt(96)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_VESSEL_VESSEL_GROUP_SEQ", "Common")
                .StartsAt(275)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VesselType_Commodities_Mapping_SEQ", "Common")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Voyage_Events_SEQ", "Common").StartsAt(1500);

            modelBuilder.HasSequence<int>("WM_CONTRIBUTION_SLAB_SEQ", "Common").HasMin(-2147483647);

            modelBuilder.HasSequence("WM_Pagibig_Slab_SEQ", "Common").StartsAt(105001);

            modelBuilder.HasSequence("WM_PHIL_HLTH_INS_SLAB_APPL_COMPONENTS_SEQ", "Common").HasMin(1);

            modelBuilder.HasSequence("WM_Phil_Hlth_Ins_Slab_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("WM_Rank_Not_Applicable_SEQ", "Common").StartsAt(502016);

            modelBuilder.HasSequence("WM_Sss_Slab_SEQ", "Common").StartsAt(105000);

            modelBuilder.HasSequence("WR_IMO_RULES_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("WR_IMO_STD_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("WR_Rule_Line_SEQ", "Common").StartsAt(1000);

            modelBuilder.HasSequence("WR_RULE_RANK_MAPPING_SEQ", "Common").HasMax(9999999999999999);

            modelBuilder.HasSequence("BS_BONDED_STOCK_SEQ", "Crew");

            modelBuilder.HasSequence("BS_PURCHASE_ORDER_DT_SEQ", "Crew");

            modelBuilder.HasSequence("BS_PURCHASE_ORDER_HD_SEQ", "Crew");

            modelBuilder.HasSequence("BS_SALES_ORDER_DETAILS_SEQ", "Crew");

            modelBuilder.HasSequence("CBA_CERTIFICATE_ML_SEQ", "Crew").StartsAt(3517018);

            modelBuilder.HasSequence("CM_Academic_Qualification_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Academic_Qualification_SEQ", "Crew").StartsAt(329880);

            modelBuilder.HasSequence("CM_ACTIVITY_DETAILS_FUTURE_SEQ", "Crew").StartsAt(2000000);

            modelBuilder.HasSequence("CM_Activity_Details_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Activity_Details_SEQ", "Crew").StartsAt(1564643);

            modelBuilder.HasSequence("CM_ADDENDUM_CONTRACT_LETTER_SEQ", "Crew").StartsAt(105002);

            modelBuilder.HasSequence("CM_ADDENDUM_CONTRACT_LETTER_SERIAL_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Allotment_Settings_SEQ", "Crew");

            modelBuilder.HasSequence("CM_APPRAISAL_APPROVER_COMMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Appraisal_Commun_SEQ", "Crew").StartsAt(105002);

            modelBuilder.HasSequence("CM_Appraisal_Details_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Appraisal_Details_SEQ", "Crew").StartsAt(12953490);

            modelBuilder.HasSequence("CM_APPRAISAL_EMAIL_ALERTS_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_Appraisal_Goals_Details_SEQ", "Crew").StartsAt(518214);

            modelBuilder.HasSequence("CM_Appraisal_Goals_SEQ", "Crew").StartsAt(105007);

            modelBuilder.HasSequence("CM_Appraisal_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_APPRAISAL_REMINDER_SETTINGS_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_APPRAISAL_REMINDER_SETTINGS_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Appraisal_SEQ", "Crew").StartsAt(1086335);

            modelBuilder.HasSequence("CM_Attachments_SEQ", "Crew").StartsAt(4000000);

            modelBuilder.HasSequence("CM_AWARD_LIST_RANK_GROUP_MAPPING_SEQ", "Crew").StartsAt(700033);

            modelBuilder.HasSequence("CM_AWARD_LIST_TILE_MF_SEQ", "Crew").StartsAt(700038);

            modelBuilder.HasSequence("CM_BACKGROUND_DET_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_BACKGROUND_RECORD_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Bank_Accounts_SEQ", "Crew").StartsAt(258884);

            modelBuilder.HasSequence("CM_BERTHMASTER_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Black_List_SEQ", "Crew").StartsAt(105001);

            modelBuilder.HasSequence("CM_Bmi_Chart_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_BMI_HISTORY_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Bmi_History_SEQ", "Crew").StartsAt(300004);

            modelBuilder.HasSequence("CM_Breif_Debrief_SEQ", "Crew").StartsAt(126000);

            modelBuilder.HasSequence("CM_Brief_Debrief_SEQ", "Crew").StartsAt(125052);

            modelBuilder.HasSequence("CM_BS_ITEM_PRICING_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Cash_Advance_SEQ", "Crew").StartsAt(400035);

            modelBuilder.HasSequence("CM_CBA_MF_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_Check_List_Items_SEQ", "Crew").StartsAt(105004);

            modelBuilder.HasSequence("CM_Checklist_Item_MF_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_CHECKLIST_REPORT_DT_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_CHECKLIST_REPORT_HD_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_Checklist_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_CHECKLIST_TEMPLATE_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_CMS_EVALUATING_RANK_GROUP_MAPPING_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CMS_EVALUATING_RANK_GROUP_MAPPING_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Comp_Reports_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_COMPANY_ALLOCATION_DT_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_COMPANY_ALLOCATION_HD_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("cm_company_chg_approve_seq", "Crew").StartsAt(8070130);

            modelBuilder.HasSequence("CM_Company_Contracts_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_COMPANY_NATIONALITY_DT_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_COMPANY_NATIONALITY_HD_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_COMPETENCY_ACTIVITY_LOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_COMPETENCY_EMP_ASSESSMENT_NEW_SEQ", "Crew");

            modelBuilder.HasSequence("CM_COMPETENCY_EMP_ASSESSMENT_SEQ", "Crew").StartsAt(300000);

            modelBuilder.HasSequence("CM_COMPETENCY_SEND_STATUS_NEW_SEQ", "Crew");

            modelBuilder.HasSequence("CM_COMPETENCY_SEND_STATUS_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_CONTEXT_MENU_PAGES_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Contract_Ins_DT_SEQ", "Crew").StartsAt(272366);

            modelBuilder.HasSequence("CM_Contract_Letter_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Contract_Letter_SEQ", "Crew").StartsAt(123439);

            modelBuilder.HasSequence("CM_Correspondance_SEQ", "Crew").StartsAt(325224);

            modelBuilder.HasSequence("CM_Correspondence_Attachments_SEQ", "Crew").StartsAt(10201944);

            modelBuilder.HasSequence("CM_Correspondence_Filestream_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Course_Attachments_SEQ", "Crew").StartsAt(5000000);

            modelBuilder.HasSequence("CM_COURSE_RANK_GROUP_MAPPING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence<int>("CM_COURSES_ARCHIVE_AUTO_DEL_AUDITLOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Courses_SEQ", "Crew").StartsAt(4551326);

            modelBuilder.HasSequence("CM_CREW_DP_HOURS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Crew_Process_SEQ", "Crew").StartsAt(389988);

            modelBuilder.HasSequence("CM_CREW_REQUEST_EXTENSION_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence<int>("CM_CREW_TAKEOVER_FLT_TBL_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_CREW_YARDDELIVERY_FLT_TBL_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CREWCHANGE_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CREWCHANGE_DETAILS_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CREWCHANGE_DETAILS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CREWCHANGE_PORT_AGENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CREWCHANGE_REF_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CREWCHANGE_SEQ", "Crew").StartsAt(10000);

            modelBuilder.HasSequence("CM_CREWPORTAL_MAILING_LIST_NAM_SEQ", "Crew");

            modelBuilder.HasSequence("CM_CSC_EXA_MAPPING_SEQ", "Crew").StartsAt(115050);

            modelBuilder.HasSequence("CM_CV_STATUS_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("CM_DA_FLAT_TABLE_CADET_INTAKE_SEQ", "Crew").StartsAt(11021);

            modelBuilder.HasSequence("CM_DA_REPORTING_RANKS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Doa_Details_SEQ", "Crew").StartsAt(389963);

            modelBuilder.HasSequence("CM_Doc_Issue_Authority_Types_SEQ", "Crew").StartsAt(112990);

            modelBuilder.HasSequence("CM_Doctor_Visit_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Documents_SEQ", "Crew").StartsAt(4549324);

            modelBuilder.HasSequence("CM_Drug_Test_Details_SEQ", "Crew").StartsAt(320463);

            modelBuilder.HasSequence<int>("CM_DRY_DOCK_FLT_TBL_SEQ", "Crew");

            modelBuilder.HasSequence("CM_DYNAMIC_EVALUATION_DESIGN_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_DYNAMIC_EVALUATION_DESIGN_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EIGHTYEIGHT_REGISTER_SEQ", "Crew")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("cm_electrical_exp_Seq", "Crew").StartsAt(105002);

            modelBuilder.HasSequence("CM_EMAIL_REPLYTO_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EMAIL_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EMAIL_STORE_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_EMP_CLIENT_APPROVAL_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EMP_CLIENT_APPROVAL_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EMP_CLIENT_APPROVAL_MF_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Emp_Company_Change_Open_Pool_History_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Emp_Company_SEQ", "Crew").StartsAt(11588750);

            modelBuilder.HasSequence("CM_EMP_LEAVE_REQUEST_FT_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_EMP_LEAVE_REQUEST_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EMP_PLAN_EXPERIENCE_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_EMP_QUARANTINE_LOG_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_EMP_SENIORITY_EXPERIENCE_SEQ", "Crew");

            modelBuilder.HasSequence("CM_EMP_TEMPERATURE_LOG_DT_ATTACHMENTS_SEQ", "Crew")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_EMP_TEMPERATURE_LOG_DT_FILESTREAM_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence<int>("CM_EMP_TEMPERATURE_LOG_DT_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_EMP_TEMPERATURE_LOG_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Emp_Work_Gear_Issue_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Emp_Work_Gear_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Employee_Signature_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Exp_Matrix_Def_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Exp_Matrix_MF_SEQ", "Crew").StartsAt(105008);

            modelBuilder.HasSequence("CM_EXPENSE_DETAILS_SEQ", "Crew").StartsAt(405787);

            modelBuilder.HasSequence("CM_EXT_Attachments_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_EXT_DOCUMENTS_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_EXT_Filestream_SEQ", "Crew").StartsAt(70100);

            modelBuilder.HasSequence<int>("CM_EXT_PROVIDER_LOGIN_CREDENTIALS_SEQ", "Crew").HasMin(1);

            modelBuilder.HasSequence<int>("CM_EXT_PROVIDER_LOOKUP_SEQ", "Crew")
                .StartsAt(10)
                .HasMin(1);

            modelBuilder.HasSequence("CM_EXTEND_REDUCE_ATTACHMENTS_SEQ", "Crew")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_Extend_Reduce_SEQ", "Crew").StartsAt(500002);

            modelBuilder.HasSequence("CM_Extra_Crew_Request_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_Filestream_SEQ", "Crew").StartsAt(2981643);

            modelBuilder.HasSequence("CM_GET_OCIMF_VAL_SEQ", "Crew").HasMax(999999999999999999);

            modelBuilder.HasSequence("CM_GET_OCIMF_XML_SEQ", "Crew").HasMax(999999999999999999);

            modelBuilder.HasSequence("CM_HOTEL_BOOKING_DT_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_HOTEL_BOOKING_HD_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_HOTEL_BOOKING_HISTORY_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Ill_Injury_Log_SEQ", "Crew").StartsAt(111761);

            modelBuilder.HasSequence("CM_ILLNESS_INJURY_ACTIONS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Inactive_Details_SEQ", "Crew").StartsAt(387817);

            modelBuilder.HasSequence("CM_Inactive_Request_Details_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_INCIDENT_EXPOSURE_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Incident_Seafarers_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Incidents_SEQ", "Crew").StartsAt(101000);

            modelBuilder.HasSequence("CM_INSTITUTION_COURSES_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Insurance_Details_SEQ", "Crew").StartsAt(131309);

            modelBuilder.HasSequence("CM_Insurance_Premiums_SEQ", "Crew").StartsAt(105004);

            modelBuilder.HasSequence("cm_insurance_SEQ", "Crew").StartsAt(110658);

            modelBuilder.HasSequence("CM_INT_ASSESSMENT_ENG_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_INT_ASSESSMENT_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Interview_Details_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Languages_Known_SEQ", "Crew").StartsAt(250134);

            modelBuilder.HasSequence("CM_LICENSE_ATTACHMENTS_SEQ", "Crew").StartsAt(6000000);

            modelBuilder.HasSequence<int>("CM_LICENSES_ARCHIVE_AUTO_DEL_AUDITLOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Licenses_seq", "Crew").StartsAt(4563783);

            modelBuilder.HasSequence("CM_LOCAL_NAMES_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence<int>("CM_LPSQ_INSPECTIONS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MAIL_PACKETS_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MAIL_PACKETS_DISPATCH_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MAIL_PACKETS_DISPATCH_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MAIL_PACKETS_FILESTREAM_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MAIL_PACKETS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MANNING_SCALE_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MANNING_SCALE_FILESTREAM_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Matrix_Applicable_VesselSubTypes_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Matrix_Applicable_VesselTypes_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_Matrix_Criteria_MF_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_MEASUREMENTS_SEQ", "Crew").StartsAt(3017);

            modelBuilder.HasSequence("CM_Medical_Details_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Medical_Details_SEQ", "Crew").StartsAt(287034);

            modelBuilder.HasSequence<int>("CM_MEDICAL_DOCS_ARCHIVE_AUTO_DEL_AUDITLOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_MEDICAL_DOCS_ATTACHMENTS_SEQ", "Crew").StartsAt(7000000);

            modelBuilder.HasSequence("CM_Medical_Docs_SEQ", "Crew").StartsAt(4463902);

            modelBuilder.HasSequence("CM_MEDICAL_TEST_DETAILS_ATTACHMENTS_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Medical_Test_DT_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_MEDICAL_TEST_FILESTREAM_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Medical_Test_HD_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Monthly_Credit_Settings_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Monthly_Insurance_SEQ", "Crew").StartsAt(411736);

            modelBuilder.HasSequence("CM_MTC_MAPPING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_MUSTER_ALLOCATION_SEQ", "Crew");

            modelBuilder.HasSequence("CM_NAT_CSC_SEQ", "Crew").StartsAt(105006);

            modelBuilder.HasSequence("CM_NEWS_AND_ANNOUNCEMENT_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_NEWS_AND_ANNOUNCEMENT_FILESTREAM_SEQ", "Crew");

            modelBuilder.HasSequence("CM_NIUM_BANK_DETAILS_LOG_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_NTBR_INACTIVE_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_OCIMF_VESSEL_GUI_SEQ", "Crew");

            modelBuilder.HasSequence("CM_ORACLE_FUSION_DAT_DATA_SEQ", "Crew");

            modelBuilder.HasSequence("CM_ORACLE_FUSION_DAT_MATRIX_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Other_Comp_Exp_Vessel_Correction_Replication_SEQ", "Crew").StartsAt(982062);

            modelBuilder.HasSequence("CM_Other_Comp_Exp_Vessel_Correction_SEQ", "Crew").StartsAt(982062);

            modelBuilder.HasSequence("CM_Other_Company_Exp_SEQ", "Crew").StartsAt(847421);

            modelBuilder.HasSequence<int>("CM_OTHER_DOCS_ARCHIVE_AUTO_DEL_AUDITLOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_OTHER_DOCS_ATTACHMENTS_SEQ", "Crew").StartsAt(8000000);

            modelBuilder.HasSequence("CM_Other_Docs_SEQ", "Crew").StartsAt(4551323);

            modelBuilder.HasSequence("CM_P_I_EXPENSES_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_PAL_CREWPORTAL_MAPPING_NAM_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PAL_EXTERNAL_EXPERIENCE_MAPPING_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PAL_EXTERNAL_SEAFARER_LOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PAL_EXTERNAL_SEAFARER_MAPPING_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PENDING_TASK_NOTIFICATIONS_SEQ", "Crew").HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_Personnel_Add_Info_SEQ", "Crew").StartsAt(1665953);

            modelBuilder.HasSequence("CM_Pi_Claim_Details_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_Plan_Approval_seq", "Crew").StartsAt(127212);

            modelBuilder.HasSequence("CM_Plan_Details_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PLAN_DETAILS_SEQ", "Crew").StartsAt(127152);

            modelBuilder.HasSequence("CM_Plan_Rights_SEQ", "Crew").StartsAt(3252209);

            modelBuilder.HasSequence("CM_POB_MUSTER_STATION_SEQ", "Crew");

            modelBuilder.HasSequence("CM_POB_PLAN_DETAILS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_POB_ROOMHD_MUSTER_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PORTAL_Docs_Attachments_STG_SEQ", "Crew").StartsAt(115188);

            modelBuilder.HasSequence("CM_PORTAL_DOCUMENT_STG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PORTAL_PAYSLIP_REMARKS_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PORTAL_PAYSLIP_REMARKS_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PROMOTION_GUIDELINE_ATTRIBS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_PROPOSED_ADD_WAGES_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_RANK_GROUP_MIS_MF_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_RANK_GROUPS_MIS_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_RECEIVED_PORTAL_APPLICANT_STATUS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_References_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_References_SEQ", "Crew").StartsAt(367920);

            modelBuilder.HasSequence("CM_Remarks_SEQ", "Crew").StartsAt(1191893);

            modelBuilder.HasSequence("CM_Report_Formats_SEQ", "Crew")
                .StartsAt(31200132)
                .HasMin(31200132);

            modelBuilder.HasSequence("CM_REPORT_LOGOS_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_REPORT_LOGOS_FILESTREAM_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Report_Parameter_SEQ", "Crew").StartsAt(105221);

            modelBuilder.HasSequence("CM_ROOM_ALLOCATION_SEQ", "Crew")
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("CM_ROOM_TYPE_SEQ", "Crew");

            modelBuilder.HasSequence("CM_ROOMHD_BERTHMASTER_SEQ", "Crew");

            modelBuilder.HasSequence("CM_ROOMHD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_SCALE_CONTRACTED_SCHEDULER_SEQ", "Crew").StartsAt(100);

            modelBuilder.HasSequence("CM_Scale_Contracted_SEQ", "Crew").StartsAt(255197);

            modelBuilder.HasSequence("CM_Scale_CSC_SEQ", "Crew").StartsAt(265371);

            modelBuilder.HasSequence("CM_Scale_Owner_SEQ", "Crew").StartsAt(151254);

            modelBuilder.HasSequence("CM_SCALE_POB_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Scale_Safe_SEQ", "Crew").StartsAt(126646);

            modelBuilder.HasSequence("CM_SCHEDULERS_SEQ", "Crew").StartsAt(100);

            modelBuilder.HasSequence("CM_SEAFARER_PROFILE_QUICK_LINKS_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_SELECTION_CRITERIA_AVAILABLE_FIELDS_SEQ", "Crew").HasMin(1);

            modelBuilder.HasSequence("CM_SHORE_EXP_NB_DT_SEQ", "Crew");

            modelBuilder.HasSequence("CM_SHORE_EXP_SEQ", "Crew").StartsAt(105004);

            modelBuilder.HasSequence("CM_SOA_COMPANY_COMPONENT_MAPPING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_SOA_COMPONENT_CATEGORY_SEQ", "Crew").StartsAt(3125421);

            modelBuilder.HasSequence<int>("CM_SOA_EXPENSE_DETAILS_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_SOA_EXPENSE_DETAILS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_SPECIAL_TRG_DETAILS_seq", "Crew")
                .StartsAt(128)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("CM_TCM_TRAINING_EFFECTIVENESS_DT_SEQ", "Crew").StartsAt(258884);

            modelBuilder.HasSequence("CM_TEMPERATURE_APPLICABLE_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_TEMPERATURE_COMPANY_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence<int>("CM_TEMPERATURE_SETTINGS_DT_SEQ", "Crew");

            modelBuilder.HasSequence<int>("CM_TEMPERATURE_SETTINGS_HD_SEQ", "Crew");

            modelBuilder.HasSequence("CM_TEMPERATURE_TEMPLATE_MAPPING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_TOUR_APPROVAL_DETAILS_SEQ", "Crew").StartsAt(100);

            modelBuilder.HasSequence("CM_Tour_Details_SEQ", "Crew").StartsAt(621281);

            modelBuilder.HasSequence("CM_TOUR_ORACLE_FUSION_DAT_FILE_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Tour_Request_Details_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_TRAINING_EFFECTIVENESS_SEQ", "Crew").StartsAt(258884);

            modelBuilder.HasSequence("CM_Training_Req_SEQ", "Crew").StartsAt(257377);

            modelBuilder.HasSequence("CM_Training_Reservation_SEQ", "Crew").StartsAt(281255);

            modelBuilder.HasSequence("CM_TRAINING_SCHEDULE_SEQ", "Crew");

            modelBuilder.HasSequence("CM_Transfer_Promo_Det_SEQ", "Crew").StartsAt(105003);

            modelBuilder.HasSequence<int>("CM_TRAVEL_DOCS_ARCHIVE_AUTO_DEL_AUDITLOG_SEQ", "Crew");

            modelBuilder.HasSequence("CM_TRAVEL_DOCS_ATTACHMENTS_SEQ", "Crew").StartsAt(10100003);

            modelBuilder.HasSequence("CM_Travel_Docs_SEQ", "Crew").StartsAt(10100026);

            modelBuilder.HasSequence("CM_VACCINATION_MAPPING_MF_SEQ", "Crew");

            modelBuilder.HasSequence("CM_VACCINATION_MAPPING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_VESSEL_CBA_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_VESSEL_DECK_MASTER_SEQ", "Crew");

            modelBuilder.HasSequence("CM_VESSEL_MATRIX_SEQ", "Crew");

            modelBuilder.HasSequence("CM_VESSEL_PI_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_VESSEL_RANK_CSC_SEQ", "Crew").StartsAt(105004);

            modelBuilder.HasSequence("CM_Vessel_Sub_Company_SEQ", "Crew").StartsAt(140396);

            modelBuilder.HasSequence("CM_VESSEL_TRADE_AREA_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CM_Vessel_Wage_Parameters_SEQ", "Crew").StartsAt(147016);

            modelBuilder.HasSequence("CM_Vessel_Work_Group_SEQ", "Crew").StartsAt(105000);

            modelBuilder.HasSequence("CM_VISA_REQUEST_ATTACHMENTS_SEQ", "Crew");

            modelBuilder.HasSequence("CM_VISA_REQUEST_DT_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("CM_VISA_REQUEST_SEQ", "Crew")
                .HasMin(0)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence<int>("COMMON.CM_EXTEND_REDUCE_REASON_MF", "Crew");

            modelBuilder.HasSequence<int>("COMMON.CM_EXTEND_REDUCE_REASON_MF_SEQ", "Crew");

            modelBuilder.HasSequence("contractletter_wage_component_SEQ", "Crew").StartsAt(3120024);

            modelBuilder.HasSequence<int>("CREW.CM_INCIDENT_EXPOSURE_SEQ", "Crew");

            modelBuilder.HasSequence("CUSTOM_REPORT_PAGE_MAPPING_SEQ", "Crew").StartsAt(500048);

            modelBuilder.HasSequence("DOCUMENT_REQIREMENT_SET_SEQ", "Crew")
                .StartsAt(1001)
                .HasMin(-2147483647)
                .HasMax(2147483640);

            modelBuilder.HasSequence("ersm_crew_change_seq", "Crew").StartsAt(600000);

            modelBuilder.HasSequence("ERSM_VESSEL_DETAILS_SEQ", "Crew").StartsAt(10000);

            modelBuilder.HasSequence("ERSM_VESSEL_REGISTER_AUDIT_SEQ", "Crew").StartsAt(300000);

            modelBuilder.HasSequence("Q88_LookUp_SEQ", "Crew")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("Q88_Register_SEQ", "Crew")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("REP_VSL_EXTRACTION_COUNT_LIST_SEQ", "Crew")
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence<int>("RPT_SIGN_ON_OFF_LETTER_SEQ", "Crew").StartsAt(11111);

            modelBuilder.HasSequence("SF_NEWS_AND_ANNOUNCEMENT_COMMENT_DETAILS_SEQ", "Crew");

            modelBuilder.HasSequence("SF_NEWS_AND_ANNOUNCEMENT_EMPLOYEE_REACTION_DETAILS_SEQ", "Crew");

            modelBuilder.HasSequence("TS_Additional_Amount_Details_SEQ", "Crew").StartsAt(1001);

            modelBuilder.HasSequence("TS_Reply_Templates_SEQ", "Crew").HasMax(999999999999999999);

            modelBuilder.HasSequence("TS_TO_Agents_DT_SEQ", "Crew").StartsAt(10100000);

            modelBuilder.HasSequence("TS_TO_Communication_DT_seq", "Crew").StartsAt(10100000);

            modelBuilder.HasSequence("TS_TO_Passenger_Doc_DT_SEQ", "Crew").StartsAt(13115000);

            modelBuilder.HasSequence("TS_TO_Passenger_DT_SEQ", "Crew").StartsAt(10100000);

            modelBuilder.HasSequence<int>("TS_TRAVEL_AGENT_ACCOUNT_SETTINGS_SEQ", "Crew");

            modelBuilder.HasSequence("TS_TRAVEL_ORDER_COLOUR_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("TS_Travel_Order_HD_SEQ", "Crew").StartsAt(10100000);

            modelBuilder.HasSequence("TS_Travel_Request_Add_Services_SEQ", "Crew").StartsAt(10124440);

            modelBuilder.HasSequence("TS_TRAVEL_ROUTE_SEQ", "Crew")
                .StartsAt(10124440)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("UP_CM_SCHEDULER_RUNNER_SEQ", "Crew").StartsAt(100);

            modelBuilder.HasSequence("WR_ADVANCE_RETARD_SETTING_SEQ", "Crew").HasMax(9999999999999999);

            modelBuilder.HasSequence("WR_CREW_SETTING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_CREW_SETTINGS_SEQ", "Crew").StartsAt(100);

            modelBuilder.HasSequence("WR_CREWSCHEDULE_GENERAL_COMMENTS_SEQ", "Crew").HasMax(9999999999999999);

            modelBuilder.HasSequence("WR_CrewSchedule_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_CrewSchedule_TASK_SEQ", "Crew");

            modelBuilder.HasSequence("WR_DefaultSchedule_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_HOLIDAY_DT_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_HOLIDAY_HD_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_IMO_VESSEL_RULES_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_NCTABLE_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_NONCONFOMITY_EXCLUDED_RANKS_SEQ", "Crew").HasMax(9999999999999999);

            modelBuilder.HasSequence("WR_OT_SETTING_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_OT_SETTINGS_SEQ", "Crew").StartsAt(100);

            modelBuilder.HasSequence("WR_Task_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_TaskDefinition_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("WR_TIME_SLOT_SEQ", "Crew").HasMax(9999999999999999);

            modelBuilder.HasSequence("WR_VESSEL_RULE_RECALCULATION_HISTORY_SEQ", "Crew");

            modelBuilder.HasSequence("WR_VESSEL_SCHEDULE_SEQ", "Crew").StartsAt(1000);

            modelBuilder.HasSequence("CRM_ATTACHMENTS_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_CATEGORY_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_CONTACT_REGISTER_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_CUSTOM_CATEGORY_TYPE_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_CUSTOM_TAG_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_CUSTOMER_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_INDUSTRY_CATEGORY_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_MAIL_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_NUMBER_SEQ", "CRM").StartsAt(4000);

            modelBuilder.HasSequence("CRM_LEAD_PRODUCT_MAPPING_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_RATING_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_SOURCE_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_STATUS_HISTORY_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_STATUS_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_LEAD_USER_VOTE_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_PRODUCT_CATEGORY_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_PRODUCT_STATUS_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_PRODUCTS_REGISTER_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_RATING_PARAMETERS_SEQ", "CRM");

            modelBuilder.HasSequence("CRM_TEAMS_SEQ", "CRM");

            modelBuilder.HasSequence("CW_ALERT_USER_READ_SEQ", "CWA");

            modelBuilder.HasSequence("CW_ARRIVAL_REPORT_SEQ", "CWA").StartsAt(1000);

            modelBuilder.HasSequence("CW_CREW_REVIEWED_SEQ", "CWA");

            modelBuilder.HasSequence("CW_CREWLIST_DT_SEQ", "CWA");

            modelBuilder.HasSequence<int>("CW_CREWLIST_ERRORLOG_SEQ", "CWA");

            modelBuilder.HasSequence("CW_CREWLIST_HD_SEQ", "CWA");

            modelBuilder.HasSequence("CW_CWA_FEEDBACK_SEQ", "CWA").HasMax(9999999999999999);

            modelBuilder.HasSequence("CW_CWA_OFFICERS_SEQ", "CWA").HasMax(9999999999999999);

            modelBuilder.HasSequence("CW_DEPARTMENT_COMPANY_CUSTOMIZATION_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENT_COMPANY_DESIGNATIONS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENT_COMPANY_USERS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENT_DESIGNATION_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENT_MENU_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENT_TILE_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTMENTUSERS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_DEPARTURE_REPORT_SEQ", "CWA").StartsAt(1000);

            modelBuilder.HasSequence("CW_DYN_Noon_Report_Template_DT_SEQ", "CWA").StartsAt(640);

            modelBuilder.HasSequence("CW_EXCEPTIONS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_HELP_FILES_SEQ", "CWA");

            modelBuilder.HasSequence("CW_MENU_BOOKMARK_SEQ", "CWA");

            modelBuilder.HasSequence<int>("CW_MOL_VARIANCE_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_NOON_REPORT_ERRLOG_SEQ", "CWA").StartsAt(1000);

            modelBuilder.HasSequence("CW_Noon_Report_seq", "CWA")
                .StartsAt(38900)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("CW_OIL_APPROVAL_STATUS_seq", "CWA")
                .StartsAt(22000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CW_OPEX_TILE_CONFIG_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_OPEX_TILE_CONFIG_HD_SEQ", "CWA");

            modelBuilder.HasSequence("CW_OWNER_MEDICAL_DOC_TYPE_SEQ", "CWA");

            modelBuilder.HasSequence("CW_OWNER_MENU_ACCESS_SEQ", "CWA").StartsAt(110421);

            modelBuilder.HasSequence("CW_OWNER_OBJECT_ACCESS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_OWNER_VESSEL_INFO_SEQ", "CWA");

            modelBuilder.HasSequence("CW_OWNER_VESSELS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_QUERIES_ATTACHMENT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_QUERIES_DEPARTMENT_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_QUERIES_USER_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_QUERY_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_QUERY_HD_SEQ", "CWA");

            modelBuilder.HasSequence("CW_RELEASE_NOTES_APPLICABLE_OWNERS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_RELEASE_NOTES_READ_SEQ", "CWA");

            modelBuilder.HasSequence("CW_RELEASE_NOTES_SEQ", "CWA");

            modelBuilder.HasSequence("CW_REPORT_DT_DRILL_INVOICES_SEQ", "CWA");

            modelBuilder.HasSequence("CW_REPORT_DT_DRILL_ORDERS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_REPORT_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_REPORT_HD_SEQ", "CWA");

            modelBuilder.HasSequence("CW_REPORT_NAME_SEQ", "CWA").StartsAt(1000);

            modelBuilder.HasSequence("CW_REPORT_PARAMETER_INSTANCE_ID_SEQ", "CWA").StartsAt(1000);

            modelBuilder.HasSequence("CW_REPORT_PARAMETER_seq", "CWA")
                .StartsAt(3000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CW_REPORT_TYPE_CATEGORY_SEQ", "CWA").StartsAt(3125139);

            modelBuilder.HasSequence("CW_REPORT_TYPE_OWNERS_seq", "CWA").HasMax(99999999999999999);

            modelBuilder.HasSequence("CW_Report_Type_seq", "CWA")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("CW_Scanned_Docs_Filestream_seq", "CWA")
                .StartsAt(99992161)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("CW_Scanned_Docs_seq", "CWA")
                .StartsAt(99992158)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("CW_TILE_COMPANY_MAPPING_SEQ", "CWA");

            modelBuilder.HasSequence("CW_TILE_MASTER_SEQ", "CWA");

            modelBuilder.HasSequence("CW_TILE_SECTION_MASTER_SEQ", "CWA");

            modelBuilder.HasSequence("CW_TRS_INSPECTION_REPORT_COMMENTS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_TRS_INSPECTION_REPORT_FILES_OBJECT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_TRS_INSPECTION_REPORT_FILES_SEQ", "CWA");

            modelBuilder.HasSequence("CW_UNIT_PRICE_VENDORID_INS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_ACTIVITY_TYPE_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_DASHBOARDS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_RESTRICTION_HD_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_RESTRICTION_MENU_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_RESTRICTION_TILE_DT_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_TILE_CUSTOM_CONFIG_SEQ", "CWA");

            modelBuilder.HasSequence("CW_USER_TILE_SETTINGS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_VESSEL_INFO_MASTER_SEQ", "CWA");

            modelBuilder.HasSequence("CW_VESSEL_POSITIONS_SEQ", "CWA");

            modelBuilder.HasSequence("CW_VESSEL_VALIDITY_CONFIG_SEQ", "CWA");

            modelBuilder.HasSequence("CWA_BANK_DOCUMENTS_SEQ", "CWA");

            modelBuilder.HasSequence("COMMON.SP_ADD_AMOUNT_DET_SEQ", "dbo").StartsAt(271704);

            modelBuilder.HasSequence("I2P_CURRENCYMASTER_SEQ", "dbo");

            modelBuilder.HasSequence("UPDCDTVERSION_SEQ", "dbo");

            modelBuilder.HasSequence("DM_DIVING_REPORT_DETAILS_SEQ", "DM");

            modelBuilder.HasSequence("DM_DIVING_REPORT_IMAGES_SEQ", "DM");

            modelBuilder.HasSequence("DM_DIVING_REPORT_PAGE_DT_SEQ", "DM");

            modelBuilder.HasSequence("DM_DIVING_REPORT_PAGE_HD_SEQ", "DM");

            modelBuilder.HasSequence("DM_LOCATION_DETAIL_SEQ", "DM");

            modelBuilder.HasSequence("Pre_Dive_Check_List_Dt_SEQ", "DM");

            modelBuilder.HasSequence("Pre_Dive_Check_List_Hd_SEQ", "DM");

            modelBuilder.HasSequence("Pre_Dive_Plan_Dt_SEQ", "DM");

            modelBuilder.HasSequence("Pre_Dive_Plan_Hd_SEQ", "DM");

            modelBuilder.HasSequence("Report_Item_Seq", "DM");

            modelBuilder.HasSequence("Report_Master_SEQ", "DM");

            modelBuilder.HasSequence("Report_Parameter_SEQ", "DM");

            modelBuilder.HasSequence("Tool_Box_Meeting_Dt_Seq", "DM");

            modelBuilder.HasSequence("Tool_Box_Meeting_Hd_Seq", "DM");

            modelBuilder.HasSequence("Tool_Box_Meeting_Team_List_Seq", "DM");

            modelBuilder.HasSequence("User_Settings_Seq", "DM");

            modelBuilder.HasSequence("Users_Seq", "DM");

            modelBuilder.HasSequence("Uw_Cctv_Equipment_Check_List_Dt_SEQ", "DM");

            modelBuilder.HasSequence("Uw_Cctv_Equipment_Check_List_Hd_SEQ", "DM");

            modelBuilder.HasSequence("DOCK_SCHEME_SEQ", "DryDock");

            modelBuilder.HasSequence("Investment_Project_History_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("Investment_Project_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_Attachments_Filestream_Vessel_seq", "DryDock").StartsAt(5001);

            modelBuilder.HasSequence("PJ_ATTACHMENTS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_ATTACHMENTS_VESSEL_SEQ", "DryDock").StartsAt(2001);

            modelBuilder.HasSequence("PJ_BUDGET_APPLICABLE_OWNER_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_BUDGET_GROUP_MF_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_CHECK_LIST_EVENTS_SUBTYPE_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_CHECK_LIST_EVENTS_TYPE_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_COMMENTS_DT_SEQ", "DryDock");

            modelBuilder.HasSequence<int>("PJ_COMMENTS_HD_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_Cost_Category_MF_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_CREW_JOB_DT_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_CREW_JOB_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_CRITERIA_MF_SEQ", "DryDock").StartsAt(1059);

            modelBuilder.HasSequence("PJ_Dock_Schedule_Archieve_SEQ", "DryDock")
                .StartsAt(9999)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_Dock_Schedule_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_EQUIPMENT_SECTION_CONFIG_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_EVENTS_CHECK_LIST_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence<int>("PJ_EVENTS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence("PJ_GROUP_MASTER_SEQ", "DryDock").StartsAt(1000);

            modelBuilder.HasSequence("PJ_INSPECTION_REPORT_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_CATEGORY_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_JOB_COMPLETION_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_Job_Cost_Estimate_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_Job_Item_Owner_Cost_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_QUOTES_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_ITEM_QUOTES_TENDER_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_ITEM_QUOTES_VESSEL_SEQ", "DryDock")
                .StartsAt(1400)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_ITEM_QUOTES_YARDS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SAFETY_DESCRIPTION_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SAFETY_DESCRIPTION_TENDER_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SAFETY_DESCRIPTION_VESSEL_SEQ", "DryDock")
                .StartsAt(4000)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SAFETY_INSTRUCTIONS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SAFETY_INSTRUCTIONS_TENDER_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SAFETY_INSTRUCTIONS_VESSEL_SEQ", "DryDock")
                .StartsAt(3100)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SPECS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SPECS_TENDER_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEM_SPECS_VESSEL_SEQ", "DryDock").StartsAt(1700);

            modelBuilder.HasSequence("PJ_JOB_ITEM_VENDORS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEMS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEMS_TAG_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEMS_TENDER_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_ITEMS_VESSEL_SEQ", "DryDock")
                .StartsAt(1001)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_OWNER_STD_SUPPLIES_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_Job_Owner_Supplies_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_Job_Owner_Supplies_Tender_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_Job_Owner_Supplies_Vessel_SEQ", "DryDock")
                .StartsAt(5100)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_Job_Quotes_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_REPORT_DT_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_REPORT_HD_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_JOB_SAFETY_DESCRIPTION_SEQ", "DryDock")
                .StartsAt(63)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_SAFETY_INSTRUCTIONS_SEQ", "DryDock")
                .StartsAt(640)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_TAG_MF_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_Job_Tasks_SEQ", "DryDock")
                .StartsAt(165)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_JOB_YARD_STD_SUPPLIES_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("PJ_Job_Yard_Supplies_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_Job_Yard_Supplies_Tender_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_Job_YARD_Supplies_Vessel_SEQ", "DryDock")
                .StartsAt(6101)
                .HasMin(1);

            modelBuilder.HasSequence("PJ_LAPTOP_REGISTRATION_SEQ", "DryDock")
                .StartsAt(999901)
                .HasMin(1)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PJ_Linked_Requisitions_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999);

            modelBuilder.HasSequence<int>("PJ_Lock_Project_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence("PJ_MACHINE_DETAILS_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_MARINE_PAINT_DT_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_MARINE_PAINT_HD_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_NEW_UNPLANNED_JOBS_SEQ", "DryDock").HasMin(1);

            modelBuilder.HasSequence("PJ_PAINT_COMPARISON_DETAILS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_PAINT_OPTION_DT_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_PAINT_OPTION_HD_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_PAINT_SYSTEM_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_PRICING_COMPLETED_YARDS_PRICE_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_PROJECT_BUDGET_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_PROJECT_CONTACT_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_PROJECT_EVENTS_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_PROJECT_EXCHANGE_RATE_SETTINGS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_PROJECT_PLAN_HISTORY_SEQ", "DryDock")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_Project_Sections_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_Project_Sections_Vessel_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_PROJECT_STATUS_SEQ", "DryDock").StartsAt(103);

            modelBuilder.HasSequence("PJ_PROSPECTIVE_VENDORS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_PROSPECTIVE_YARDS_SEQ", "DryDock")
                .StartsAt(5201)
                .HasMin(1)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PJ_RECOVERABLE_COST_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PJ_REPAIR_JOBS_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_REPAIR_JOBS_VESSEL_SEQ", "DryDock").StartsAt(1900);

            modelBuilder.HasSequence("PJ_REPAIR_SPECS_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_REPAIR_SPECS_VESSEL_SEQ", "DryDock").StartsAt(3390);

            modelBuilder.HasSequence("PJ_REPAIR_STANDARD_QUOTES_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_REPAIR_STANDARD_QUOTES_VESSEL_SEQ", "DryDock").StartsAt(8100);

            modelBuilder.HasSequence("PJ_Report_Parameter_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_SAFETY_SEQ", "DryDock").StartsAt(269);

            modelBuilder.HasSequence("PJ_SCORE_TYPE_GROUP_MF_TYP", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_SCORE_TYPE_GROUP_SEQ", "DryDock")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_SCORE_TYPE_MF_SEQ", "DryDock")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_SCORE_TYPE_SEQ", "DryDock")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_SECTION_QUOTE_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_STANDARD_QUOTES_VESSEL_SUBTYPES_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_SUB_GROUP_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_SUB_PROJECT_SEQ", "DryDock").StartsAt(1000);

            modelBuilder.HasSequence<int>("PJ_TENDER_INVITATION_HISTORY_SEQ", "DryDock")
                .HasMin(-92233720)
                .HasMax(92233720);

            modelBuilder.HasSequence<int>("PJ_TENDER_INVITATION_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_TERMS_AND_CONDITIONS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PJ_USER_REGISTRATION_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_User_Vessel_Group_DT_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_User_Vessel_Group_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_Vessel_Additional_AREA_SEQ", "DryDock").StartsAt(12200);

            modelBuilder.HasSequence("PJ_VESSEL_DATA_SETUP_HD_SEQ", "DryDock")
                .StartsAt(5201)
                .HasMin(1)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PJ_VESSEL_DETAILS_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("PJ_Vessel_Group_DT_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_Vessel_Group_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_VESSEL_PARTICULAR_LABEL_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_VESSEL_PARTICULARS__EQUIPMENTS_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_VESSEL_PARTICULARS_EQUIPMENTS_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_VESSEL_PARTICULARS_SEQ", "DryDock");

            modelBuilder.HasSequence<int>("PJ_VESSEL_SUB_PROJECTS_SEQ", "DryDock")
                .StartsAt(2084)
                .HasMin(1)
                .HasMax(999999999);

            modelBuilder.HasSequence("PJ_VESSEL_TYPE_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_WORK_DESCRIPTION_TEMPLATE_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_WORK_DESCRIPTION_TEMPLATE_VESSEL_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_YARD_EVALUATION_CRITERIA_SEQ", "DryDock").StartsAt(1000);

            modelBuilder.HasSequence("PJ_YARD_EVALUATION_DT_SEQ", "DryDock").StartsAt(1000);

            modelBuilder.HasSequence("PJ_YARD_EVALUATION_HD_SEQ", "DryDock").StartsAt(1000);

            modelBuilder.HasSequence("PJ_YARD_QUESTIONNAIRE_SEQ", "DryDock").StartsAt(100);

            modelBuilder.HasSequence("PJ_YARD_QUOTE_DICOUNT_SEQ", "DryDock")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PJ_YARD_SERVICE_DETAILS_SEQ", "DryDock");

            modelBuilder.HasSequence("PJ_YARD_SERVICE_PO_SEQ", "DryDock");

            modelBuilder.HasSequence<int>("PJ_YARD_USER_MAPPING_SEQ", "DryDock");

            modelBuilder.HasSequence<int>("EL_ADMIN_STRUCTURE_SEQ", "ELOG").StartsAt(2061);

            modelBuilder.HasSequence("EL_DECK_LOG_DETAILS_SEQ", "ELOG");

            modelBuilder.HasSequence("EL_DECK_LOG_FINAL_APPROVAL_SEQ", "ELOG").StartsAt(5);

            modelBuilder.HasSequence("EL_DECK_LOG_SEQ", "ELOG").StartsAt(1611000000002);

            modelBuilder.HasSequence("EL_ELOG_ATTACHMENTS_FILESTREAM_SEQ", "ELOG");

            modelBuilder.HasSequence("EL_ELOG_ATTACHMENTS_SEQ", "ELOG");

            modelBuilder.HasSequence("EL_ENGINE_LOG_DETAILS_SEQ", "ELOG");

            modelBuilder.HasSequence("EL_ENGINE_LOG_FINAL_APPROVAL_SEQ", "ELOG");

            modelBuilder.HasSequence("EL_ENGINE_LOG_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_EVENTS_REFERENCES_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LEARNTEST_SEQ", "ELOG").StartsAt(583);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_APPROVAL_RIGHTS_HISTORY_SEQ", "ELOG").StartsAt(13);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_APPROVAL_RIGHTS_SEQ", "ELOG").StartsAt(32);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_ATTRIBUTE_MAPPING_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_DEFENITION_SEQ", "ELOG").StartsAt(4900);

            modelBuilder.HasSequence("EL_LOG_BOOK_DEFINITION_EXTN_SEQ", "ELOG").StartsAt(51);

            modelBuilder.HasSequence("EL_LOG_BOOK_DEFINITION_UOM_SEQ", "ELOG").StartsAt(3608);

            modelBuilder.HasSequence("EL_LOG_BOOK_DOCUMENTS_SEQ", "ELOG").StartsAt(7);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENT_GROUPS_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENT_MAPPING_SEQ", "ELOG").StartsAt(370);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENT_SUB_GROUPS_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENT_VESSEL_SUBTYPES_SEQ", "ELOG").StartsAt(721);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENTS_DATA_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_EVENTS_SEQ", "ELOG").StartsAt(661);

            modelBuilder.HasSequence("EL_LOG_BOOK_EVENTS_SPECIAL_ZONE_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_GROUPS_DROPDOWN_MAPPING_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_GROUPS_SEQ", "ELOG").StartsAt(67);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_REGISTRY_MAPPING_SEQ", "ELOG").StartsAt(21);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_SUB_GROUPS_SEQ", "ELOG").StartsAt(163);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_TEMPLATES_SEQ", "ELOG").StartsAt(15);

            modelBuilder.HasSequence<int>("EL_LOG_BOOK_VESSEL_TEMPLATE_SEQ", "ELOG");

            modelBuilder.HasSequence<int>("EL_LOG_BOOKS_SEQ", "ELOG").StartsAt(16);

            modelBuilder.HasSequence<int>("EL_PARAMETERS_SEQ", "ELOG").StartsAt(583);

            modelBuilder.HasSequence<int>("EL_SPECIAL_ZONES_SEQ", "ELOG").StartsAt(199);

            modelBuilder.HasSequence<int>("EL_Uom_MF_SEQ", "ELOG").StartsAt(2046);

            modelBuilder.HasSequence<int>("EL_UOM_SEQ", "ELOG").StartsAt(583);

            modelBuilder.HasSequence<int>("EL_VESSEL_ADDITIONAL_PARAMS_SEQ", "ELOG").StartsAt(557);

            modelBuilder.HasSequence<int>("EL_VESSEL_ATTRIBUTES_SEQ", "ELOG").StartsAt(661);

            modelBuilder.HasSequence<int>("EL_VESSEL_LOG_BOOK_TEMPLATES_SEQ", "ELOG").StartsAt(156);

            modelBuilder.HasSequence("EL_VESSEL_UOM_SEQ", "ELOG").StartsAt(41);

            modelBuilder.HasSequence<int>("ER_SPECIAL_ZONES_SEQ", "ELOG").StartsAt(198);

            modelBuilder.HasSequence<int>("ER_ACT_VAR_VALIDATION_SEQ", "ERBOOKS").StartsAt(974);

            modelBuilder.HasSequence<int>("ER_ACTIVITY_GROUPS_SEQ", "ERBOOKS").StartsAt(136);

            modelBuilder.HasSequence<int>("ER_ACTIVITY_LINES_SEQ", "ERBOOKS").StartsAt(3004);

            modelBuilder.HasSequence("ER_ACTIVITY_RECORDBOOK_DATA_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ACTIVITY_RECORDBOOKS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_ADMIN_STRUCTURE_SEQ", "ERBOOKS").StartsAt(101);

            modelBuilder.HasSequence<int>("ER_BALLAST_RECORD_STAGING_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_BILGE_SLUDGE_GENERATED_STAGING_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_BOOKS_TEMPLATES_SEQ", "ERBOOKS").StartsAt(66);

            modelBuilder.HasSequence<int>("ER_DAILY_ROB_CONFIG_SEQ", "ERBOOKS").StartsAt(7);

            modelBuilder.HasSequence<int>("ER_EQUIPMENTS_SETTINGS_SEQ", "ERBOOKS").StartsAt(111);

            modelBuilder.HasSequence("ER_ERBOOKS_ATTACHMENTS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_FLAG_CERTIFICATE_SEQ", "ERBOOKS").StartsAt(5);

            modelBuilder.HasSequence("ER_GARBAGE_DISPOSED_STAGING_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_GARBAGE_GENERATED_STAGING_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_GARBAGE_TYPE_CONFIG_SEQ", "ERBOOKS").StartsAt(694);

            modelBuilder.HasSequence<int>("ER_GRB_GARBAGE_TYPE_SEQ", "ERBOOKS").StartsAt(14);

            modelBuilder.HasSequence("ER_GRB_STORAGE_LOC_PARTS_SEQ", "ERBOOKS").StartsAt(105114);

            modelBuilder.HasSequence("ER_GRB_STORAGE_LOCATION_SEQ", "ERBOOKS").StartsAt(279623);

            modelBuilder.HasSequence<int>("ER_GRB_ZONE_PARAMETERS_SEQ", "ERBOOKS").StartsAt(9);

            modelBuilder.HasSequence<int>("ER_LOGBOOK_DOCUMENTS_SEQ", "ERBOOKS").StartsAt(12);

            modelBuilder.HasSequence<int>("ER_LOGBOOKS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_MASTER_SIGN_ACTIVITY_RECORDBOOK_DATA_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_MASTER_SIGNATURES_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_MASTER_TEMPLATE_ACTIVITY_ID_MAPPING_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_MASTER_TEMPLATE_VERSION_AUDIT_LOGS_SEQ", "ERBOOKS").StartsAt(1506);

            modelBuilder.HasSequence<int>("ER_MASTER_TEMPLATE_VERSION_SEQ", "ERBOOKS").StartsAt(1506);

            modelBuilder.HasSequence("ER_ORB_ACTIVITY_RECORDBOOK_FILES_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_ACTIVITY_RECORDBOOK_LINE_DATA_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_ACTIVITY_RECORDBOOK_VARIABLE_VALUES_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_ORB_ACTIVITY_VARIABLES_SEQ", "ERBOOKS").StartsAt(8485);

            modelBuilder.HasSequence("ER_ORB_AUDIT_LOGS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_FULL_INVENTORY_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_LOGS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_PSC_INSPECTION_FILES_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_PSC_INSPECTIONS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_ORB_SYNTAX_ROLE_CONFIG_SEQ", "ERBOOKS").StartsAt(114636);

            modelBuilder.HasSequence<int>("ER_ORB_SYNTAX_SEQ", "ERBOOKS").StartsAt(1388);

            modelBuilder.HasSequence<int>("ER_ORB_SYNTAX_TANK_TYPE_CONFIG_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_ORB_TANK_PIPELINE_DESIGNER_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_ORB_TANK_PIPELINES_SEQ", "ERBOOKS").StartsAt(235);

            modelBuilder.HasSequence("ER_PARAMETERS_SEQ", "ERBOOKS").StartsAt(105002);

            modelBuilder.HasSequence<int>("ER_PDF_BACKUP_LOCATION_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_PORTS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_RUNNING_HOUR_STAGING_SEQ", "ERBOOKS");

            modelBuilder.HasSequence("ER_SETUP_TANK_PARTS_SEQ", "ERBOOKS").StartsAt(1387);

            modelBuilder.HasSequence<int>("ER_SETUP_TANKS_SEQ", "ERBOOKS").StartsAt(116251);

            modelBuilder.HasSequence("ER_SIGNATURE_FLOW_CONFIG_SEQ", "ERBOOKS").StartsAt(110139);

            modelBuilder.HasSequence<int>("ER_SIGNATURE_FLOW_SEQ", "ERBOOKS").StartsAt(9);

            modelBuilder.HasSequence("ER_SPECIAL_ZONES_DETAILS_SEQ", "ERBOOKS").StartsAt(27);

            modelBuilder.HasSequence<int>("ER_SPECIAL_ZONES_SEQ", "ERBOOKS").StartsAt(198);

            modelBuilder.HasSequence<int>("ER_STORAGE_LOC_GARBAGE_CONFIG_SEQ", "ERBOOKS").StartsAt(244);

            modelBuilder.HasSequence<int>("ER_TANK_CATEGORIES_SEQ", "ERBOOKS").StartsAt(27);

            modelBuilder.HasSequence<int>("ER_TANK_COLOR_CODE_SEQ", "ERBOOKS").StartsAt(12);

            modelBuilder.HasSequence<int>("ER_TANK_TYPES_SEQ", "ERBOOKS").StartsAt(22);

            modelBuilder.HasSequence<int>("ER_TIMEZONE_SETTINGS_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_VARIABLES_SEQ", "ERBOOKS").StartsAt(695);

            modelBuilder.HasSequence("ER_VESSEL_ER_BOOK_TEMPLATES_SEQ", "ERBOOKS").StartsAt(279424);

            modelBuilder.HasSequence<int>("ER_VESSEL_LOGBOOK_DOC_CONFIG_SEQ", "ERBOOKS");

            modelBuilder.HasSequence<int>("ER_VESSEL_ORB_PART_CONFIG_SEQ", "ERBOOKS").StartsAt(193);

            modelBuilder.HasSequence<int>("ER_VESSEL_ORB_SYNTAX_CONFIG_SEQ", "ERBOOKS").StartsAt(823);

            modelBuilder.HasSequence<int>("ER_VESSSEL_EQUIPMENT_CONFIG_SEQ", "ERBOOKS").StartsAt(209);

            modelBuilder.HasSequence<int>("FR_ACTIVITY_SEQ", "FORMS").StartsAt(150001);

            modelBuilder.HasSequence("FR_ATTACHMENTS_SEQ", "FORMS")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence<int>("FR_EMAIL_CONFIG_SEQ", "FORMS").StartsAt(140001);

            modelBuilder.HasSequence<int>("FR_FORM_TYPE_SEQ", "FORMS");

            modelBuilder.HasSequence<int>("FR_MAPPING_SEQ", "FORMS").StartsAt(130001);

            modelBuilder.HasSequence<int>("FR_OVERVIEW_ATTACHMENTS_HISTORY_SEQ", "FORMS").StartsAt(170001);

            modelBuilder.HasSequence<int>("FR_OVERVIEW_HISTORY_SEQ", "FORMS").StartsAt(150001);

            modelBuilder.HasSequence<int>("FR_SEL_TAGS_SEQ", "FORMS").StartsAt(250001);

            modelBuilder.HasSequence<int>("FR_TAG_ATTACHMENTS_REF_SEQ", "FORMS").StartsAt(160001);

            modelBuilder.HasSequence<int>("FR_TAGS_MODULE_SEQ", "FORMS").StartsAt(140001);

            modelBuilder.HasSequence<int>("FR_TAGS_PORT_SEQ", "FORMS").StartsAt(150001);

            modelBuilder.HasSequence<int>("FR_TAGS_ROLE_SEQ", "FORMS").StartsAt(160001);

            modelBuilder.HasSequence<int>("FR_TAGS_SEQ", "FORMS").StartsAt(130001);

            modelBuilder.HasSequence<int>("FR_TAGS_VESSEL_SEQ", "FORMS").StartsAt(170001);

            modelBuilder.HasSequence<int>("FR_TAGS_VESSEL_TYPE_SEQ", "FORMS").StartsAt(180001);

            modelBuilder.HasSequence<int>("FR_TRIGGER_TAG_SEQ", "FORMS").StartsAt(150001);

            modelBuilder.HasSequence("FP_ACCOUNT_ANALYSIS_MAPPINGS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_ACCOUNT_GROUPS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_ACCOUNT_MAPPINGS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_Accounts_Map_SEQ", "FP");

            modelBuilder.HasSequence("FP_APPLICABLE_ENTITY_SEQ", "FP");

            modelBuilder.HasSequence("FP_ATTACHMENTS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_BCG_FLEET_SEQ", "FP").StartsAt(652);

            modelBuilder.HasSequence("FP_BS_OWNERS_SEQ", "FP");

            modelBuilder.HasSequence("FP_BS_OWNERS_SUBACC_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ACCOUNTS_COMMENT_READ_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ACCOUNTS_COMMENTS_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ACCOUNTS_COMMENTS_HD_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ACCOUNTS_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ACCOUNTS_HD_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ANALYSIS_MAPPING_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_ENTITY_SEQ", "FP");

            modelBuilder.HasSequence("FP_CAPITAL_INTRATE_MAPPING_SEQ", "FP");

            modelBuilder.HasSequence("FP_CHART_HD_ANALYSIS_SEQ", "FP");

            modelBuilder.HasSequence("FP_CHARTER_RATE_DT_ACTUAL_SEQ", "FP");

            modelBuilder.HasSequence("FP_CHARTER_RATE_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_CHARTER_RATE_HD_SEQ", "FP");

            modelBuilder.HasSequence("FP_COMMENT_READ_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_COMMENTS_ATTACHMENT_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_COMMENTS_DT_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_COMMENTS_HD_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_COMPANY_ROLE_USERS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence<int>("FP_CWA_ADJUSTMENTS_SEQ", "FP")
                .StartsAt(1000)
                .HasMin(-10000000)
                .HasMax(100000000);

            modelBuilder.HasSequence("FP_CWA_ADMIN_TOOL_FILTER_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DEFAULT_PARAMETERS_SEQ", "FP");

            modelBuilder.HasSequence("FP_DELIVERABLE_APPROVAL_HISTORY_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence<int>("FP_DELIVERABLE_BUDGET_DT_SEQ", "FP");

            modelBuilder.HasSequence<int>("FP_DELIVERABLE_FORECAST_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_DELIVERABLE_TYPE_APPL_COMPANY_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DELIVERABLE_TYPE_MONTHS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DELIVERABLE_USERS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DELIVERABLE_VARIANCE_DT_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DELIVERABLE_VESSEL_DT_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DELIVERABLES_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_DELIVERABLES_TYPE_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_EFFECTIVE_DAILY_RATE_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_EFFECTIVE_DAILY_RATE_HD_SEQ", "FP");

            modelBuilder.HasSequence("FP_ER_Imports_seq", "FP");

            modelBuilder.HasSequence("FP_ER_TRANSACTIONS_seq", "FP");

            modelBuilder.HasSequence("FP_ER_TRANSACTIONS_TEMP_seq", "FP");

            modelBuilder.HasSequence("FP_FORECAST_DT_SEQ", "FP").StartsAt(100);

            modelBuilder.HasSequence("FP_FORECAST_HD_SEQ", "FP").StartsAt(100);

            modelBuilder.HasSequence("FP_FUND_POSITION_REPORT_DT_SEQ", "FP").StartsAt(0);

            modelBuilder.HasSequence<int>("FP_GENERATE_DELIVERABLE_AFTER_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_GLOBAL_ENTITY_LOCKING_LOG_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_GLOBAL_ENTITY_LOCKING_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("fp_group_allocation_key_adjustments_SEQ", "FP");

            modelBuilder.HasSequence("FP_GROUP_COMPANIES_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_GROUPALLOCATION_SEQ", "FP");

            modelBuilder.HasSequence("FP_IFRS_REPORTS_DT_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_IFRS_REPORTS_HD_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_INTER_COMPANY_MAPPING_SEQ", "FP").StartsAt(334);

            modelBuilder.HasSequence("FP_LABUAN_REPORT_MAPPING_SEQ", "FP").StartsAt(69);

            modelBuilder.HasSequence("FP_MASTER_CHARTS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_MASTER_TEMPLATE_DT_SEQ", "FP").StartsAt(19798);

            modelBuilder.HasSequence("FP_MASTER_TEMPLATE_DT_SEQ_TEST", "FP").StartsAt(19798);

            modelBuilder.HasSequence("FP_OWNER_ATTACHMENTTYPES_HISTORY_SEQ", "FP");

            modelBuilder.HasSequence("FP_OWNER_ATTACHMENTTYPES_SEQ", "FP");

            modelBuilder.HasSequence("FP_PARAMETERISED_REPORT_FILTER_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_PARAMETERISED_REPORT_FILTER_HD_SEQ", "FP");

            modelBuilder.HasSequence("FP_PL_ADJUSTMENTS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_PL_FORECASTS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REPORT_NEGATIVE_LIST_SEQ", "FP").HasMax(9999999999999999);

            modelBuilder.HasSequence("FP_REPORT_PARAMETER_INSTANCE_ID_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REPORT_PARAMETER_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REPORT_TYPE_APPL_OWNERS_SEQ", "FP").HasMin(1);

            modelBuilder.HasSequence("FP_REPORT_TYPE_MONTHS_SEQ", "FP").HasMin(1);

            modelBuilder.HasSequence("FP_REPORT_TYPE_OWNER_USERS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REPORT_TYPE_SEQ", "FP");

            modelBuilder.HasSequence("FP_REPORTS_DT_CASH_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence<int>("FP_REPORTS_DT_HIGHLIGHT_SEQ", "FP").HasMin(-2147483647);

            modelBuilder.HasSequence("FP_REPORTS_DT_LEDGER_SEQ", "FP");

            modelBuilder.HasSequence("FP_REPORTS_DT_SIX_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REPORTS_DT_THREE_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REPORTS_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_REVALUATION_REPORT_DT_FLAGS_SEQ", "FP");

            modelBuilder.HasSequence("FP_REVALUATION_REPORT_DT_SEQ", "FP");

            modelBuilder.HasSequence("FP_REVALUATION_REPORT_EXCHRATES_SEQ", "FP");

            modelBuilder.HasSequence("FP_REVALUATION_REPORT_HD_SEQ", "FP");

            modelBuilder.HasSequence("FP_ROLES_SEQ", "FP").StartsAt(1000);

            modelBuilder.HasSequence("FP_SUB_STATEMENTS_SEQ", "FP");

            modelBuilder.HasSequence("FP_SWA_ALERT_USERS_SEQ", "FP");

            modelBuilder.HasSequence("FP_SWA_OWNER_REPORT_TYPES_SEQ", "FP");

            modelBuilder.HasSequence("FP_SWA_OWNER_SCANDOCS_MAPPING_SEQ", "FP");

            modelBuilder.HasSequence("FP_SWA_REPORT_TYPES_SEQ", "FP");

            modelBuilder.HasSequence("FP_VARIANCE_NEGATIVE_SEQ", "FP");

            modelBuilder.HasSequence("FP_VESSEL_ENTITY_EXCEPTION_SEQ", "FP");

            modelBuilder.HasSequence("EMPLOYEE_TEST_EMP_ID", "guest")
                .HasMin(1)
                .HasMax(999);

            modelBuilder.HasSequence("std_id_seq", "guest")
                .HasMin(1)
                .HasMax(999);

            modelBuilder.HasSequence("student_id_seq", "guest")
                .HasMin(1)
                .HasMax(999);

            modelBuilder.HasSequence<int>("IP_ACTIVITY_SEQ", "INFOPAL").StartsAt(150001);

            modelBuilder.HasSequence("IP_ATTACHMENTS_FILESTREAM_SEQ", "INFOPAL")
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("IP_ATTACHMENTS_SEQ", "INFOPAL")
                .StartsAt(999900001001)
                .HasMin(1)
                .HasMax(99999999999999999);

            modelBuilder.HasSequence("IP_AUDIT_INSPECTION_ALERT_DATA_SEQ", "INFOPAL").StartsAt(20000);

            modelBuilder.HasSequence("IP_DETENTION_DETAILS_ALERT_DATA_SEQ", "INFOPAL").StartsAt(30000);

            modelBuilder.HasSequence<int>("IP_EMAIL_CONFIG_SEQ", "INFOPAL").StartsAt(140001);

            modelBuilder.HasSequence("IP_FACILITATION_DEMAND_ALERT_SEQ", "INFOPAL").StartsAt(10000);

            modelBuilder.HasSequence<int>("IP_FORM_TYPE_SEQ", "INFOPAL");

            modelBuilder.HasSequence("IP_IP_TAG_PRIORITY_SEQ", "INFOPAL");

            modelBuilder.HasSequence("IP_IP_TAG_TYPE_SEQ", "INFOPAL");

            modelBuilder.HasSequence<int>("IP_MAPPING_SEQ", "INFOPAL").StartsAt(130001);

            modelBuilder.HasSequence<int>("IP_OVERVIEW_HISTORY_SEQ", "INFOPAL").StartsAt(150001);

            modelBuilder.HasSequence<int>("IP_SEL_TAGS_SEQ", "INFOPAL").StartsAt(250001);

            modelBuilder.HasSequence<int>("IP_SYSTEM_ALERTS_SEQ", "INFOPAL").StartsAt(160001);

            modelBuilder.HasSequence<int>("IP_TAG_ATTACHMENTS_REF_SEQ", "INFOPAL").StartsAt(160001);

            modelBuilder.HasSequence("IP_TAG_REGIONS_SEQ", "INFOPAL");

            modelBuilder.HasSequence<int>("IP_TAGS_COUNTRY_SEQ", "INFOPAL").StartsAt(160001);

            modelBuilder.HasSequence<int>("IP_TAGS_PORT_SEQ", "INFOPAL").StartsAt(150001);

            modelBuilder.HasSequence<int>("IP_TAGS_ROLE_SEQ", "INFOPAL").StartsAt(160001);

            modelBuilder.HasSequence<int>("IP_TAGS_SEQ", "INFOPAL").StartsAt(130001);

            modelBuilder.HasSequence<int>("IP_TAGS_VESSEL_SEQ", "INFOPAL").StartsAt(170001);

            modelBuilder.HasSequence<int>("IP_TAGS_VESSEL_TYPE_SEQ", "INFOPAL").StartsAt(180001);

            modelBuilder.HasSequence<int>("IP_TRIGGER_TAG_SEQ", "INFOPAL").StartsAt(150001);

            modelBuilder.HasSequence("IC_Accounts_Transact_seq", "Insurance");

            modelBuilder.HasSequence("IC_Attachments_Filestream_Seq", "Insurance");

            modelBuilder.HasSequence("IC_Attachments_Seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Not_Accepted_Items_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Postings_History_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Postings_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Process_Status_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Setting_Deductibles_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Setting_Premiums_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Settings_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Statement_Items_seq", "Insurance");

            modelBuilder.HasSequence("IC_Claim_Type_Based_Users_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Club_Quarterly_Reports_seq", "Insurance");

            modelBuilder.HasSequence("IC_COMMENT_READ_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_COMMENTS_DT_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_COMMENTS_HD_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_COMMENTS_USERS_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Crew_Medical_Advice_seq", "Insurance");

            modelBuilder.HasSequence("IC_Datasource_Companies_seq", "Insurance");

            modelBuilder.HasSequence("IC_Deductible_Claim_Subtypes_SEQ", "Insurance").HasMax(99999999999999999);

            modelBuilder.HasSequence("IC_Deductible_CS_history_SEQ", "Insurance").HasMax(99999999999999999);

            modelBuilder.HasSequence("IC_Incident_No_seq", "Insurance")
                .StartsAt(99)
                .HasMax(9999999999999999);

            modelBuilder.HasSequence("IC_Insurance_Claim_Crew_seq", "Insurance");

            modelBuilder.HasSequence("IC_Insurance_Claim_Remarks_Seq", "Insurance");

            modelBuilder.HasSequence("IC_Insurance_Claim_Statements_seq", "Insurance");

            modelBuilder.HasSequence("IC_Insurance_Claim_Status_seq", "Insurance");

            modelBuilder.HasSequence("IC_Insurance_Claims_History_seq", "Insurance");

            modelBuilder.HasSequence("IC_INSURANCE_CLAIMS_INCIDENT_seq", "Insurance").HasMax(9999999999999999);

            modelBuilder.HasSequence("IC_Insurance_Claims_seq", "Insurance");

            modelBuilder.HasSequence("IC_Insurance_Claims_temp_seq", "Insurance");

            modelBuilder.HasSequence("IC_Last_Numbers_seq", "Insurance");

            modelBuilder.HasSequence("IC_NOTIFICATION_TO_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Other_Expenditures_seq", "Insurance");

            modelBuilder.HasSequence("IC_Owner_Based_Users_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Deductible_Vessels_History_seq", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Deductible_Vessels_seq", "Insurance").StartsAt(5001);

            modelBuilder.HasSequence("IC_Policy_Deductibles_History_seq", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Deductibles_seq", "Insurance").StartsAt(5001);

            modelBuilder.HasSequence("IC_Policy_Premium_History_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Premium_Import_Logs_seq", "Insurance").HasMax(9999999999999999);

            modelBuilder.HasSequence("IC_Policy_Premium_Installments_seq", "Insurance").HasMax(9999999999999999);

            modelBuilder.HasSequence("IC_Policy_Premium_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Premium_Vessels_HISTORY_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Premium_Vessels_SEQ", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Settings_History_seq", "Insurance");

            modelBuilder.HasSequence("IC_Policy_Settings_seq", "Insurance").StartsAt(5001);

            modelBuilder.HasSequence("IC_Policy_Year_seq", "Insurance").StartsAt(2001);

            modelBuilder.HasSequence("IC_Report_Parameter_seq", "Insurance");

            modelBuilder.HasSequence("IC_Review_Approval_seq", "Insurance");

            modelBuilder.HasSequence("IC_REVIEW_CLAIM_TYPE_SETTINGS_SEQ", "Insurance").HasMax(999999999999999);

            modelBuilder.HasSequence("IC_REVIEW_CLAIM_TYPE_USER_SETTINGS_SEQ", "Insurance").HasMax(999999999999999);

            modelBuilder.HasSequence("IC_REVIEW_REQUEST_APPROVAL_REQUEST_NO_SEQ", "Insurance").HasMax(999999999999999);

            modelBuilder.HasSequence("IC_REVIEW_REQUEST_APPROVAL_SEQ", "Insurance").HasMax(999999999999999);

            modelBuilder.HasSequence("insurance.IC_Deductible_Claim_Subtypes_SEQ", "Insurance").HasMax(99999999999999999);

            modelBuilder.HasSequence("temp_int_v_claim_overview_seq", "Insurance");

            modelBuilder.HasSequence("temp_seq", "Insurance");

            modelBuilder.HasSequence("LI_BSChartOfAccount_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_BSCoAMapping_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_BSEntityMapping_SEQ", "LI");

            modelBuilder.HasSequence("LI_BSINTERCOMPANY_ACCOUNT_MAPPING_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_BSINTERCOMPANY_ACCOUNT_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("li_budget_account_mapping_SEQ", "LI").StartsAt(40);

            modelBuilder.HasSequence("LI_CHART_TEMPLATE_APPLICABLE_ENTITIES_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_CHART_TEMPLATE_DT_ANALYSIS_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_CHART_TEMPLATE_DT_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_CHART_TEMPLATE_HD_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_Company_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_CompanyName_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_CURRWISE_ANL_LAYOUT_SEQ", "LI");

            modelBuilder.HasSequence<int>("LI_ENTRY_TOOL_LOG_SEQ", "LI");

            modelBuilder.HasSequence("LI_FORMAT_ANL_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_INTERCOMPANY_TRANS_DT_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_INTERCOMPANY_TRANS_HD_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_LABUAN_MAPPING_SEQ", "LI");

            modelBuilder.HasSequence("LI_MIS_VALIDATION_MAST_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_REPORT_PARAMETER_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_TRANS_DT_ANL_MULT_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_TRANS_DT_ANL_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_TRANS_DT_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LI_TRANS_HD_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("TransactionFigures_SEQ", "LI").StartsAt(1000);

            modelBuilder.HasSequence("LG_Additional_Amount_Details_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_ADDITIONAL_SERVICES_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_AGENT_FINALIZE_REQUEST_FEE_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_AGENT_FINALIZE_REQUEST_ROUTE_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_AGENT_FINALIZE_REQUEST_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_AGENT_QUOTE_REQUEST_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_AGENT_QUOTES_APPROVAL_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_Airports_IATA_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_BAGGAGE_DETAILS_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_BILL_TO_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_COMMUNICATION_RECIPIENTS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_COMMUNICATIONS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_CONTRACTED_FARE_SETTINGS_SEQ", "LOGISTICS").HasMax(9999999999);

            modelBuilder.HasSequence("LG_DRAFT_FLIGHT_OPTIONS_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_ENTITY_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_FLIGHT_OPTION_TO_APPROVE_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_FLIGHT_OPTIONS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_FLIGHT_PROVIDER_LOOKUP_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_FREQUENT_FLYER_DETAILS_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_GDS_BOOKING_DETAILS_SEQ", "LOGISTICS")
                .HasMin(0)
                .HasMax(9999999999999);

            modelBuilder.HasSequence("LG_GDS_FARE_RULES_DETAILS_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_INVOICE_APPROVAL_HISTORY_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_KG_COST_CENTER_MAPPING_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_LG_AVAILABLE_SERVICES_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_MARKUP_SETTINGS_HISTORY_SEQ", "LOGISTICS")
                .StartsAt(3)
                .HasMax(99999999);

            modelBuilder.HasSequence("LG_MARKUP_SETTINGS_MAPPING_HISTORY_SEQ", "LOGISTICS").HasMax(9999999999);

            modelBuilder.HasSequence("LG_MARKUP_SETTINGS_MAPPING_SEQ", "LOGISTICS").HasMax(9999999999);

            modelBuilder.HasSequence("LG_MARKUP_SETTINGS_SEQ", "LOGISTICS").HasMax(9999999999);

            modelBuilder.HasSequence("LG_MARKUP_TEMPLATES_SEQ", "LOGISTICS").HasMax(9999999999);

            modelBuilder.HasSequence("LG_OTHER_PASSENGER_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_PASSENGERS_DRAFT_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_PASSENGERS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_PAX_APPROVER_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_PAX_DOCUMENTS_DRAFT_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_PAX_DOCUMENTS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_PNR_ADDITIONAL_INFO_TO_PASS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_PROFILE_EMAIL_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_PROFILE_VERIFICATION_STATUS_SEQ", "LOGISTICS").HasMax(9999999999);

            modelBuilder.HasSequence("LG_QUOTE_APPROVAL_REASONS_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_REQUEST_COLOR_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_REQUEST_NO_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_REVISE_TRAVEL_REQUEST_ROUTES_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_SELECTED_FLIGHT_CARBON_EMISSION_DATA_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_SELECTED_FLIGHT_OPTIONS_APPROVAL_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_SELECTED_FLIGHT_OPTIONS_APPROVER_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_SELECTED_FLIGHT_OPTIONS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_SERVICE_FEE_EXCEPTIONLIST_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_SPLIT_BILLING_TRAVEL_REQUEST_DETAILS_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_SPLIT_TICKETING_SETTINGS_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_SPLIT_TICKETING_STOPOVER_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_SUB_ACCOUNT_MAPPING_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_SUGGESTED_FLIGHT_OPTIONS_LEGS_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_ACCOUNTS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_DESK_ADDITIONAL_PCC_DETAILS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_DESK_PCC_DETAILS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_FUSION_SUPPLIER_ROUTE_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_TRAVEL_INVOICE_ADDITINAL_CHARGES_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_INVOICE_AMOUNT_DETAILS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_INVOICE_DETAILS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_COST_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_DESK_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_DRAFT_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_REFERENCE_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_RFQ_DETAILS_SEQ", "LOGISTICS");

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_TRIP_PLAN_MAPPING_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_VESSELS_DRAFT_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_TRAVEL_REQUEST_VESSELS_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("LG_TRAVEL_ROUTE_DRAFT_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_ROUTE_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_TRAVEL_TIME_SEQ", "LOGISTICS").StartsAt(1001);

            modelBuilder.HasSequence("LG_TRAVEL_TYPE_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_USER_PREFERENCES_SEQ", "LOGISTICS").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("LG_USER_PROFILE_AIR_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("UP_LG_COMMUNICATIONS_RECIPIENTS_SEQ", "LOGISTICS").HasMax(9223372036854775);

            modelBuilder.HasSequence("UP_LG_NOTIFY_USERS_SEQ", "LOGISTICS").HasMax(99999999);

            modelBuilder.HasSequence("Latest_Incident-Color_code_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_ACCIDENT_SUBTYPES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_AP_LINK_TO_REPORTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_AP_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_AP_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_DR_DRILL_PERIOD_VESSEL_PLAN_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_DSRP_REPORTS_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_DSRP_REPRESENTATIVE_FINDINGS_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_DSRP_REPRESENTATIVES_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_DSRP_STATUS_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_EVENT_FINDINGS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_EVENTS_ATTACHMENTS_SEQ", "LPSQ").StartsAt(75);

            modelBuilder.HasSequence("LP_EVENTS_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_EVENTS_Status_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_INCIDENT_FINDINGS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_KPI_REVIEW_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_STATUS_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_TARGET_DETAILS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_KPI_TARGET_DETAILS1_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_KPI_TARGET_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_KPI_TRANSACT_DETAILS_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_KPI_TRANSACT_MASTER_SEQ", "LPSQ").StartsAt(6);

            modelBuilder.HasSequence("LP_REPORT_PARAMETER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_DRILL_DETAILS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_EXTERNAL_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_MASTER_SEQ", "LPSQ").StartsAt(250);

            modelBuilder.HasSequence("LP_SBM_MINUTES_DETAILS_SEQ", "LPSQ").StartsAt(2338233800230);

            modelBuilder.HasSequence("LP_SBM_MINUTES_OF_MEETING_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_OFFICE_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_Review_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_SBM_VESSEL_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WF_TRANSACT_CONTROL_ROLES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WF_TRANSACT_CONTROLS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WF_TRANSACT_REPEAT_HISTORY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WF_TRANSACT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WF_TRN_CURRENT_CONTROL_ROLE_USERS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_AREA_AUTHORITY_AUTHORIZATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_ATTENDING_PERSONNEL_ACCEPTANCE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_ATTENDING_PERSONNEL_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_CANCEL_ABORT_OPERATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_CLOSURE_SEQ", "LPSQ");

            modelBuilder.HasSequence<int>("LP_WP_COMBINED_TEMPLATE_SECTIONS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_ENCLOSED_SPEACE_ENTRY_LOG_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_GAS_MEASUREMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_GAS_MEASUREMENTS_WITH_VALIDITY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_GAS_MEASUREMENTS_WITHOUT_VALIDITY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_GENERAL_ACTIVITY_LOG_SEQ", "LPSQ");

            modelBuilder.HasSequence<int>("LP_WP_LOCKOUT_TAGOUT_SECTION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_PERMIT_REQUEST_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_PLAIN_TEXT_SECTION_SEQ", "LPSQ").StartsAt(2);

            modelBuilder.HasSequence("LP_WP_Review_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_SECTION_QUESTIONS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_STATUS_SEQ", "LPSQ").StartsAt(1054);

            modelBuilder.HasSequence("LP_WP_VALIDITY_EXTENTION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_WORK_AUTHORITY_AUTHORIZATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LP_WP_WORK_COMPLETION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPA_ACTION_DETAILS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPA_REFERENCE_LINK_SEQ", "LPSQ")
                .StartsAt(7490)
                .IncrementsBy(2);

            modelBuilder.HasSequence("LPA_REFERENCE_TYPES_TO_CONSIDER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPA_REFERENCES_LINK_SEQ", "LPSQ").StartsAt(7539);

            modelBuilder.HasSequence("LPB_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Feedback_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Report_Sections_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Reports_Section_Elements_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Reports_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Review_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Risk_Investigation_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPB_BBS_Status_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_ACCEPTABILITY_SCALE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_ACCIDENT_ACTION_AREA_IMPROVEMENT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Accident_NewCategory_Remarks_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_ACCIDENT_SAFTEY_NOTIFICATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Action_Details_SEQ", "LPSQ").StartsAt(552000003);

            modelBuilder.HasSequence("LPC_Attachments_Filestream_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_ATTACHMENTS_SEQ", "LPSQ").StartsAt(3014);

            modelBuilder.HasSequence("LPC_BEST_PRACTICE_CIRCULAR_DETAILS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_BEST_PRACTICE_CIRCULARS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_BEST_PRACTICES_CIRCULAR_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_BEST_PRACTICES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Causes_ABSMaRCAT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_CAUSES_DNV_MSCAT_SEQ", "LPSQ").StartsAt(500219356);

            modelBuilder.HasSequence("LPC_Causes_Generic_Details_Seq", "LPSQ");

            modelBuilder.HasSequence("LPC_Causes_Generic_Header_Seq", "LPSQ");

            modelBuilder.HasSequence("LPC_COMMENT_READ_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_COMMENTS_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_COMMENTS_HD_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_COMMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_COMMENTS_USERS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_CONTRACTORS_EXPOSURE_HOURS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Crew_SEQ", "LPSQ").StartsAt(561100028);

            modelBuilder.HasSequence("LPC_Deficiency_Additional_Causes_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_DEFICIENCY_ADDITIONAL_DETAILS_SEQ", "LPSQ").StartsAt(561100029);

            modelBuilder.HasSequence("LPC_DEFICIENCY_OBJECTIVE_EVIDENCE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_DEFICIENCY_USER_COMMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_FACILITATION_PAYMENTS_DETAILS_SEQ", "LPSQ").StartsAt(500007050);

            modelBuilder.HasSequence("LPC_FACILITATION_PAYMENTS_SEQ", "LPSQ").StartsAt(500000734);

            modelBuilder.HasSequence("LPC_FACILITATION_PAYMENTS_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_ACCIDENT_CATEGORIES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_ACCIDENT_REPORTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_ACCIDENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_ACTIVITY_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_ALLISION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_CAUSES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_COLLISION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_CONTAMINATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_CREW_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_DELAY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_FINAL_INVESTIGATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_FIRE_EXPLOSION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_GROUNDING_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_MACHINERY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_NEAR_MISS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_NON_ACCIDENT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_POLLUTION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_PROPERTY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_REVIEW_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_SECURITY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_INCIDENT_STATUS_SEQ", "LPSQ").StartsAt(291);

            modelBuilder.HasSequence("LPC_INCIDENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_JUST_CULTURE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Lessons_Learnt_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Major_Sig_Incident_Status_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Major_Significant_Incidents_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_PASSENGER_INJURY_SEQ", "LPSQ").StartsAt(3);

            modelBuilder.HasSequence("LPC_PERSONAL_RESPONSIBILITY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_POST_INCIDENT_CHECKLIST_HISTORY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_POST_INCIDENT_CHECKLIST_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_Purchase_Order_Reference_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_References_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_REPORTS_ADDITIONAL_DETAILS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_REPORTS_DEFICIENCIES_SEQ", "LPSQ").StartsAt(500127448);

            modelBuilder.HasSequence("LPC_REPORTS_SCREENING_SEQ", "LPSQ").StartsAt(500000026);

            modelBuilder.HasSequence("LPC_REPORTS_SEQ", "LPSQ").StartsAt(500036082);

            modelBuilder.HasSequence("LPC_REPORTS_STATUS_AT_VESSEL_SEQ", "LPSQ").StartsAt(500000027);

            modelBuilder.HasSequence("LPC_REPORTS_STATUS_SEQ", "LPSQ").StartsAt(500043050);

            modelBuilder.HasSequence("LPC_RESULTS_SCALABILITY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_THIRD_PARTY_DAMAGE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_THIRD_PARTY_INJURY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPC_VESSEL_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILL_LESSONS_LEARNED_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILL_OFFICE_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILL_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_EXTERNAL_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_OFFICE_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_PARTICIPANTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_PERSONAL_DETAILS_LIFEBOAT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_PERSONAL_DETAILS_SCBA_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPD_DRILLS_REVIEW_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPF_ATTACHMENTS_SEQ", "LPSQ").StartsAt(3014);

            modelBuilder.HasSequence("LPI_ATTACHMENTS_FILESTREAM_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_BACKUP_UPDATES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_CAUSES_ABSMARCAT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_CAUSES_DNV_MSCAT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_DATA_FILE_UPDATES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_DATA_FILES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_DATA_TRANSFER_ANALYSIS_SEQ", "LPSQ").StartsAt(10160);

            modelBuilder.HasSequence("LPI_INSPECTION_EXECUTIVE_SUMMARY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_INDEX_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_ACTION_DETAILS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_DEFICIENCIES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_SECTIONS_SEQ", "LPSQ").StartsAt(149314);

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_SET_MAP_QUESTION_SET_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_SET_SEQ", "LPSQ").StartsAt(69);

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_REPORT_SUBSECTIONS_SEQ", "LPSQ").StartsAt(127);

            modelBuilder.HasSequence("LPI_INSPECTION_REPORTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_RISKFACTOR_HISTORY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_SECTION_MAIN_COMMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTION_SECTION_QUESTIONS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_INSPECTIONS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_LAPTOP_NAME_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_LAPTOP_REGISTRATION_SEQ", "LPSQ").StartsAt(1000);

            modelBuilder.HasSequence("LPI_REPORT_SECTION_AREA_ANALYSIS_SEQ", "LPSQ").StartsAt(90);

            modelBuilder.HasSequence("LPI_UPGRADE_UPDATES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_UPGRADES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPI_USER_REGISTRATION_SEQ", "LPSQ").StartsAt(1000);

            modelBuilder.HasSequence("LPM_MOC_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_AUTHORITY_USERS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_REQUIRED_INFORMATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_Review_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_Section_Questions_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_Sections_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_SPECIFIC_UNITS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPM_MOC_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_Attachments_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_PR_RESPONSE_SECTION_COMMENT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_PREVIEW_MASTER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_PREVIEW_RESPONSE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_REVIEW_OFFICE_REVIEW_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_REVIEW_STATUS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_SIRE_SI_INSPECTED_PERSONNEL_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_SIRE_SI_OFFICE_RA_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPP_SIRE_SI_RA_AREA_SCORES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QSET_GROUP_QUESTION_DURATION_SEQ", "LPSQ").StartsAt(270);

            modelBuilder.HasSequence("LPQ_QSET_GROUP_QUESTION_ROLES_SEQ", "LPSQ").StartsAt(728);

            modelBuilder.HasSequence("LPQ_QSET_GROUP_QUESTION_SETS_SEQ", "LPSQ").StartsAt(112);

            modelBuilder.HasSequence("LPQ_QSET_GROUP_QUESTIONS_SEQ", "LPSQ").StartsAt(1213);

            modelBuilder.HasSequence("LPQ_QSET_GROUP_REPORT_SUBTYPES_SEQ", "LPSQ").StartsAt(61);

            modelBuilder.HasSequence("LPQ_QUESTION_CHAPTER_COMPANY_UNITS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_CHAPTER_DURATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_CHAPTER_ROLES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_CHAPTER_VESSEL_SUBTYPES_SEQ", "LPSQ").StartsAt(3306);

            modelBuilder.HasSequence("LPQ_QUESTION_CHAPTERS_SEQ", "LPSQ").StartsAt(200);

            modelBuilder.HasSequence("LPQ_QUESTION_DURATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_ROLES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_SET_COMPANY_UNITS_SEQ", "LPSQ").StartsAt(155);

            modelBuilder.HasSequence("LPQ_QUESTION_SET_DURATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_SET_GROUPS_SEQ", "LPSQ").StartsAt(64);

            modelBuilder.HasSequence("LPQ_QUESTION_SET_ROLES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_SET_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTION_SET_VESSEL_SUBTYPES_SEQ", "LPSQ").StartsAt(1468);

            modelBuilder.HasSequence("LPQ_QUESTION_SUBSECTION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTIONS_COMPANY_UNITS_SEQ", "LPSQ").StartsAt(870);

            modelBuilder.HasSequence("LPQ_QUESTIONS_SEQ", "LPSQ").StartsAt(20037);

            modelBuilder.HasSequence("LPQ_QUESTIONS_tmp_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPQ_QUESTIONS_VESSEL_SUBTYPES_SEQ", "LPSQ").StartsAt(45200);

            modelBuilder.HasSequence("LPQ_Questions2_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_ATTACHMENTS_FILESTREAM_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_RA_ACTIVITY_SEQ", "LPSQ").StartsAt(500007712);

            modelBuilder.HasSequence("LPR_RA_ADDITIONAL_CONTROL_MEASURES_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_RA_CONSEQUENCES_SEQ", "LPSQ").StartsAt(500025630);

            modelBuilder.HasSequence("LPR_RA_HAZARD_SEQ", "LPSQ").StartsAt(561101173);

            modelBuilder.HasSequence("LPR_RA_MASTER_SEQ", "LPSQ").StartsAt(190001313);

            modelBuilder.HasSequence("LPR_RA_RECOMMENDATION_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_RA_REFERENCES_SEQ", "LPSQ").StartsAt(500000002);

            modelBuilder.HasSequence("LPR_RA_REVIEW_APPR_SEQ", "LPSQ").StartsAt(500030391);

            modelBuilder.HasSequence("LPR_RA_REVIEW_APPROVAL_SEQ", "LPSQ").StartsAt(500030391);

            modelBuilder.HasSequence("LPR_RA_REVIEW_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_RA_STATUS_SEQ", "LPSQ").StartsAt(561100415);

            modelBuilder.HasSequence("LPR_RA_SUBTASK_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPR_RA_TASK_DETAILS_SEQ", "LPSQ").StartsAt(500000135);

            modelBuilder.HasSequence("LPR_RA_TASK_TEAM_SEQ", "LPSQ").StartsAt(500000304);

            modelBuilder.HasSequence("LPT_ATTACHMENTS_HIS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_ATTACHMENTS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_EXPIRY_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_JOB_ORDER_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_ML_FLAG_DT_SEQ", "LPSQ").StartsAt(1000);

            modelBuilder.HasSequence("LPT_CERTIFICATE_ML_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_ML_VESSEL_TYPE_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_SUBTYPE_SEQ", "LPSQ").StartsAt(1010);

            modelBuilder.HasSequence("LPT_CERTIFICATE_TRANS_HIS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_TRANS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_CERTIFICATE_TYPE_SEQ", "LPSQ").StartsAt(1010);

            modelBuilder.HasSequence("LPT_COMMENT_READ_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_COMMENTS_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_COMMENTS_HD_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_COMMENTS_USERS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_DOCUMENT_TRANS_HIS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_DOCUMENT_TRANS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_FLAGS_DT_SEQ", "LPSQ").StartsAt(1000);

            modelBuilder.HasSequence("LPT_MAIL_NOTIFICATIONS_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_MAIL_NOTIFICATIONS_HD_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_MISCELLANEOUS_TYPE_SEQ", "LPSQ").StartsAt(1000);

            modelBuilder.HasSequence("LPT_REPORT_PARAMETER_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_REQUEST_ACT_DEACT_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_REQUEST_ACT_DEACT_HD_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SEQ_NUM_GEN_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SURVEY_EQUIPMENT_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SURVEY_ML_CLASS_TYPE_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SURVEY_ML_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SURVEY_ML_VESSEL_TYPE_DT_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SURVEY_TRANS_HIS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_SURVEY_TRANS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_TYPE_APPROVAL_HIS_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_TYPE_APPROVAL_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_VESSEL_ANNIVERSARY_TYP_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_VESSEL_APPL_CERTIFICATE_SEQ", "LPSQ");

            modelBuilder.HasSequence("LPT_VESSEL_APPL_SURVEY_SEQ", "LPSQ");

            modelBuilder.HasSequence("RA_TASK_TEAM_SEQ", "LPSQ").StartsAt(500000304);

            modelBuilder.HasSequence("COMMON.[UP_LP_WF_TEMPLATE_SEQ", "MARIAPPS\\biji.paulose");

            modelBuilder.HasSequence("PR_CASH_TRANSACTION_TITLE_SEQ", "MARIAPPS\\dilshad.musthafa");

            modelBuilder.HasSequence("Sequence-20191213-151758", "MARIAPPS\\josnamol.george");

            modelBuilder.HasSequence<int>("ER_SPECIAL_ZONES_SEQ", "MARIAPPS\\riya.pradeep");

            modelBuilder.HasSequence("App_Features_Seq", "Mobile").StartsAt(1100);

            modelBuilder.HasSequence("APP_VERSIONS_HISTORY_SEQ", "Mobile");

            modelBuilder.HasSequence("CM_EMP_TEMPERATURE_LOG_DT_FILESTREAM_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CM_FB_QSTN_RANK_APPLICABLE_TO_SEQ", "Mobile").StartsAt(101003);

            modelBuilder.HasSequence("CO_ATTACHMENTS_FILESTREAM_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_ATTACHMENTS_SEQ", "Mobile");

            modelBuilder.HasSequence("CO_CONTACT_GROUP_NOIFICATION_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_INCIDENT_REPORT_DT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_INCIDENT_REPORT_HD_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_NOTIFICATIONS_FORWARDED_USERS_MOB_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_NOTIFICATIONS_FORWARDED_USERS_MOB_SFV2_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_NOTIFY_USERS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_SEARCH_FILTER_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_USER_NOTIFICATIONS_MOB_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("CO_USER_NOTIFICATIONS_MOB_SFV2_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_CONTACT_DETAILS_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_DIVING_CLEARENCE_DT_SEQ", "Mobile").StartsAt(2000);

            modelBuilder.HasSequence("DM_DIVING_CLEARENCE_HD_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_EVENT_DETAILS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_EXT_VSL_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_EXTERNAL_VESSEL_REGISTER_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_FIELD_REPORT_DETAILS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_FILED_REPORT_ADHOC_SERVICES_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_FILED_REPORT_OTHER_LINKED_SERVICES_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_FILED_REPORT_PO_LINKED_SERVICES_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_FILED_REPORT_SERVICES_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_FR_SERVICE_MAPPING_ITEM_MF_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_JOB_DETAILS_HD_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_JOB_NUMBER_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_JOB_TEAM_USERS_ROLES_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_JOB_TEAM_USERS_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_JOB_WORKS_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_PO_LINKING_DETAILS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_QUOTE_DETAILS_HD_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_QUOTE_NUM_SEQ", "Mobile").StartsAt(190000);

            modelBuilder.HasSequence("DM_QUOTE_T_AND_C_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_QUOTE_WORKS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_SIGN_IN_DETAILS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_TERMS_AND_CONDITIONS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("DM_WORK_VALUES_SEQ", "Mobile");

            modelBuilder.HasSequence("DM_WORKS_SEQ", "Mobile").StartsAt(1058);

            modelBuilder.HasSequence("Email_Notification_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("Emp_Device_Notification_Details_SEQ", "Mobile");

            modelBuilder.HasSequence("EMP_TWO_FACTOR_OTP_DETAILS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("EXCEPTIONCITY_SWIFTCODE_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("LF_Request_Log_Details_SEQ", "Mobile");

            modelBuilder.HasSequence("NOTIFICATION_CONFIG_SETTINGS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("PREJOINING_CHECK_LIST_DOCUMENTS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("PREJOINING_SETTINGS_MAPPING_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("QDMS_Request_Log_Details_SEQ", "Mobile");

            modelBuilder.HasSequence("QDMS_WIKI_DATA_LOCATION_SEQ", "Mobile").StartsAt(31200259);

            modelBuilder.HasSequence("QDMS_WIKI_FILE_SYN_DETAILS_SEQ", "Mobile").StartsAt(31200259);

            modelBuilder.HasSequence("Request_Log_Details_SEQ", "Mobile");

            modelBuilder.HasSequence("SEAFARER_FEEDBACK_QUESTIONS_SEQ", "Mobile").StartsAt(105000);

            modelBuilder.HasSequence("SEAFARER_FEEDBACK_SEQ", "Mobile");

            modelBuilder.HasSequence("SEAFARER_PORTAL_FEEDBACK_DT_SEQ", "Mobile");

            modelBuilder.HasSequence("SEAFARER_PORTAL_FEEDBACK_QSTNS_RANK_WISE_MAPPING_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SEAFARER_PORTAL_FEEDBACK_SEQ", "Mobile");

            modelBuilder.HasSequence("SEAFARER_PORTAL_MS_QUESTION_ANSWER_TYPE_OPTIONS_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_DEPARTMENT_MENU_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_DEPARTMENT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_NEWS_AND_ANNOUNCEMENT_COMMENT_DETAILS_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_NEWS_AND_ANNOUNCEMENT_EMPLOYEE_REACTION_DETAILS_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_NEWS_AND_ANNOUNCEMENT_EMPLOYEES_REACTION_DETAILS_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_QUERIES_AND_FEEDBACK_DT_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_QUERIES_AND_FEEDBACK_HD_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_QUERIES_ATTACHMENT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_QUERIES_ATTACHMENTS_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_QUERIES_DEPARTMENT_DT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_QUERIES_DEPARTMENT_MENU_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_QUERIES_DEPARTMENT_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_QUERIES_DEPARTMENT_USERS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_QUERIES_DT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_QUERIES_HD_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SF_QUERIES_USERS_DT_READ_SEQ", "Mobile");

            modelBuilder.HasSequence("SF_SAVE_TOPIC_FCM_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_COMPANY_CUSTOMIZATION_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_COMPANY_DESIGNATIONS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_COMPANY_USERS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_DESIGNATION_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_MENU_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENT_TILE_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_DEPARTMENTUSERS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_QUERIES_ATTACHMENT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_QUERIES_DEPARTMENT_DT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_QUERIES_DT_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_QUERIES_HD_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SFV2_TILE_MASTER_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SMARTPAL_APP_Details_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SMARTPAL_APP_VERSIONS_HISTORY_SEQ", "Mobile");

            modelBuilder.HasSequence("SMARTPAL_FAV_DETAILS_SEQ", "Mobile").StartsAt(1000);

            modelBuilder.HasSequence("SMARTPAL_ITEM_BUDGET_BALANCE_DETAILS_SEQ", "Mobile");

            modelBuilder.HasSequence("MI_ADMIN_USER_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_ATTACHMENTS_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_CATEGORY_OWNER_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_CATEGORY_REVIEWER_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_CATEGORY_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_CV_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_CHART_DISABLE_LEGEND_STATUS_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_REVIEW_MEMBERS_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_REVIEWER_SUBMISSION_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_STATUS_DT_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_STATUS_HISTORY_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_STATUS_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_Idea_Type_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_USER_TYPE_ROLE_MAPPING_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEA_USER_TYPE_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEAS_REQUEST_INFO_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEAS_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_IDEAS_USER_VOTE_SEQ", "Myidea");

            modelBuilder.HasSequence("MI_OFFICE_SEQ", "Myidea");

            modelBuilder.HasSequence("MDM_AdminStructureDT_SEQ", "OPEX");

            modelBuilder.HasSequence("MDM_AdminStructureDTReferenceMapping_SEQ", "OPEX");

            modelBuilder.HasSequence("MDM_AdminStructureHD_SEQ", "OPEX");

            modelBuilder.HasSequence("PL_ATTACHMENTS_SEQ", "PA").StartsAt(2);

            modelBuilder.HasSequence("PL_COMMENT_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_COMMENT_HD_SEQ", "PA");

            modelBuilder.HasSequence("PL_COMMENT_SEQ", "PA");

            modelBuilder.HasSequence("PL_COMMENT_STATUS_LOG_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_AR_LOG_GROUP_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_AR_LOG_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_AR_MAPPING_LOG_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_AR_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_DEPARTMENT_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_Drawing_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_Drawing_HD_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_HULL_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_DRAWING_USER_DIRECT_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_EMAIL_COMPONENT_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_EMAIL_COMPONENT_HD_SEQ", "PA");

            modelBuilder.HasSequence("PL_EMAIL_LOG_SEQ", "PA");

            modelBuilder.HasSequence("PL_HULL_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_ITERATION_HD_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_PARAMETERS_SEQ", "PA").StartsAt(1000);

            modelBuilder.HasSequence("PL_PERMISSION_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_PERMISSION_HD_SEQ", "PA");

            modelBuilder.HasSequence("PL_PERMISSION_PROCESS_LOG_SEQ", "PA");

            modelBuilder.HasSequence("PL_PROJECT_DEPARTMENT_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_PROJECT_DT_SEQ", "PA");

            modelBuilder.HasSequence("PL_PROPERTIES_DT_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_PROPERTIES_HD_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_PROPERTY_MF_SEQ", "PA");

            modelBuilder.HasSequence("PL_REFERENCE_NO_TRACK_SEQ", "PA").StartsAt(2);

            modelBuilder.HasSequence("PL_ROLE_APPLICABLE_STATUS_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_ROLE_STATUS_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_STATUS_SEQ", "PA").StartsAt(1000);

            modelBuilder.HasSequence("PL_STATUS_SUBMITTED_SEQ", "PA");

            modelBuilder.HasSequence("PL_TILE_CONFIGURATION_CELL_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_TILE_CONFIGURATION_COLUMN_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_TILE_CONFIGURATION_DT_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_TILE_CONFIGURATION_HD_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_TILE_CONFIGURATION_ROW_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_TILE_MF_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_TILE_REF_ROLE_MAPPING_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("PL_USERROLE_DEPARTMENT_MAPPING_SEQ", "PA");

            modelBuilder.HasSequence("PL_WORKFLOW_MAPPING_SEQ", "PA").StartsAt(20);

            modelBuilder.HasSequence("PL_WORKFLOW_PROCESS_LOG_SEQ", "PA");

            modelBuilder.HasSequence("ROLE_USER_UNIQUE_IDENTIFIER_SEQ", "PA");

            modelBuilder.HasSequence("WF_DT_SEQ", "PA");

            modelBuilder.HasSequence("WF_HD_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_HISTORY_HD_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_HISTORY_STEP_DT_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_MAPPIN_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_STEP_ACTION_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_STEP_ASSIGN_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_STEP_ASSIGNMENT_OUTPUT_SEQ", "PA");

            modelBuilder.HasSequence("WF_STEP_ASSIGNMENT_PROPERTIES_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_STEP_DEADLINE_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_STEP_HD_KEY_SEQ", "PA").StartsAt(6);

            modelBuilder.HasSequence("WF_STEP_HD_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_STEP_RESPONSE_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_TASK_LOG_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("WF_TASK_SEQ", "PA").StartsAt(100);

            modelBuilder.HasSequence("ED_EmployeeDetails_SEQ", "PayRoll");

            modelBuilder.HasSequence("HISTORICAL_CHANGE_DTL_SEQ", "PayRoll").StartsAt(4219);

            modelBuilder.HasSequence("PayScaleSeaGoingAllowance_SEQ", "PayRoll");

            modelBuilder.HasSequence("PF_Applicable_Components_SEQ", "PayRoll").StartsAt(105011);

            modelBuilder.HasSequence("PF_Applicable_SEQ", "PayRoll").StartsAt(105011);

            modelBuilder.HasSequence("PF_Contribution_DT_SEQ", "PayRoll").StartsAt(105011);

            modelBuilder.HasSequence("PF_Contribution_Hd_SEQ", "PayRoll").StartsAt(105011);

            modelBuilder.HasSequence("PF_Contribution_Ind_DT_SEQ", "PayRoll").StartsAt(150070);

            modelBuilder.HasSequence("PF_Contribution_Ind_Hd_SEQ", "PayRoll").StartsAt(111398);

            modelBuilder.HasSequence("PF_Financial_Year_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("PF_Interest_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("PF_Percentage_SEQ", "PayRoll").StartsAt(105009);

            modelBuilder.HasSequence("PF_Subscription_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("PF_Withdraw_Terms_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("PR_ACCRUED_WAGES_FLAT_TABLE_SEQ", "PayRoll").StartsAt(1000);

            modelBuilder.HasSequence("PR_Activity_History_SEQ", "PayRoll").StartsAt(674602);

            modelBuilder.HasSequence("PR_Additional_Scale_Appl_Cmpnts_History_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Additional_Scale_Appl_Cmpnts_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("PR_Additional_Scale_History_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Additional_Scale_SEQ", "PayRoll").StartsAt(105014);

            modelBuilder.HasSequence("PR_ADDITIONAL_WAGES_FUSION_DAT_FILE_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_ADDITIONAL_WAGES_HISTORY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Additional_Wages_SEQ", "PayRoll").StartsAt(149047);

            modelBuilder.HasSequence("PR_ADVANCE_PAYMENT_SEQ", "PayRoll").StartsAt(896487);

            modelBuilder.HasSequence("PR_Allotment_Approval_SEQ", "PayRoll").StartsAt(253398);

            modelBuilder.HasSequence("PR_ALLOTMENT_BATCH_SEQ", "PayRoll").StartsAt(1500);

            modelBuilder.HasSequence("PR_ALLOTMENT_PAYMENT_SEQ", "PayRoll").StartsAt(168104);

            modelBuilder.HasSequence<int>("PR_ALLOTMENT_REQUEST_ACCRUED_DETAILS_AUD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_ALLOTMENT_REQUEST_SEQ", "PayRoll").StartsAt(172303);

            modelBuilder.HasSequence("PR_Appl_Rank_Payscale_SEQ", "PayRoll").StartsAt(252570);

            modelBuilder.HasSequence("PR_APPLICATION_PAGE_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_APPLICATION_PAGE_TYPE_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_APPROVED_ACTIVITYS_SEQ", "PayRoll").StartsAt(79882);

            modelBuilder.HasSequence("PR_APPROVED_BONUS_CHILD_SEQ", "PayRoll").StartsAt(1012);

            modelBuilder.HasSequence("PR_APPROVED_BONUS_COMPONENTS_SEQ", "PayRoll").StartsAt(1012);

            modelBuilder.HasSequence("pr_balance_SEQ", "PayRoll").StartsAt(1312927);

            modelBuilder.HasSequence("PR_BLOCK_PAYMENT_AUDIT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_BLOCK_PAYMENT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_BONUS_SETTINGS_DT_SEQ", "PayRoll").StartsAt(1025);

            modelBuilder.HasSequence("PR_BONUS_SETTINGS_HD_SEQ", "PayRoll").StartsAt(1023);

            modelBuilder.HasSequence("PR_BPS_TEMPLATE_MAPPING_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_BPS_TEMPLATE_MAPPING_HD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_BRANCH_SENDERS_ACCOUNT_MAPPING_SEQ", "PayRoll").StartsAt(107170);

            modelBuilder.HasSequence("PR_Btb_Ranks_SEQ", "PayRoll").StartsAt(105012);

            modelBuilder.HasSequence("PR_CASH_ACCOUNT_TITLE_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Cash_Advance_Request_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_CASH_REGISTER_DEFAULT_CURRENCY_SET_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_CASH_REGISTER_TRANSACTION_MODES_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_CASH_REGISTER_TRANSACTIONS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_CASH_TRANSACTION_TITLE_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Closing_Balance_Salary_Based_SEQ", "PayRoll").StartsAt(194700175);

            modelBuilder.HasSequence<int>("PR_COMPONENTS_MAPPING_SAUDI_SALARY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_CONTRACT_PROFILE_HISTORY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Contract_Profile_NB_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Contract_Profile_SEQ", "PayRoll").StartsAt(268852);

            modelBuilder.HasSequence("PR_CPF_CONTRIBUTION_HISTORY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_CPF_SEAFARER_DETAILS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Cumulative_DT_SEQ", "PayRoll").StartsAt(129146);

            modelBuilder.HasSequence("PR_Cumulative_Hd_SEQ", "PayRoll").StartsAt(106491);

            modelBuilder.HasSequence("PR_CUTOFF_DATE_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Draft_Activity_History_SEQ", "PayRoll").StartsAt(3972381);

            modelBuilder.HasSequence("PR_Draft_Balance_SEQ", "PayRoll").StartsAt(2430901);

            modelBuilder.HasSequence("PR_DRAFT_HISTORICAL_APPROVED_ACTIVITYS_SEQ", "PayRoll").StartsAt(93641);

            modelBuilder.HasSequence("pr_Draft_monthly_pay_hd_SEQ", "PayRoll").StartsAt(31463);

            modelBuilder.HasSequence("pr_Draft_Payslip_SEQ", "PayRoll").StartsAt(4857251);

            modelBuilder.HasSequence("pr_Draft_salary_dt_SEQ", "PayRoll").StartsAt(1231144);

            modelBuilder.HasSequence("PR_EMP_ACTIVITY_HISTORY_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_EMP_DETAILS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_EMP_FORCED_PAYROLL_STATUS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_EMP_INSERT", "PayRoll").StartsAt(100);

            modelBuilder.HasSequence("PR_EMP_MONTHLY_INPUT_SETTING_OFF_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_EMP_MONTHLY_INPUT_SETTING_VSL_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_EWALLET_TRANSACTION_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_EWALLET_TRANSACTIONT_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_Exchange_Rate_SAUDI_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Experience_Credit_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("PR_EXTERNAL_ALLOTMENT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_FORCE_HISTORICAL_PAYROLL_PROCESS_SEQ", "PayRoll").StartsAt(1000);

            modelBuilder.HasSequence("PR_FWA_PAYROLL_PROCESS_EXCEPTION_LIST_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_GENERALLEDGERSAL_VOU_SEQ", "PayRoll").StartsAt(11000);

            modelBuilder.HasSequence("PR_GENERALLEDGERTEMP_AGREC_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_GENERALLEDGERTEMP_AGREF_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_GENERALLEDGERTEMP_BatchId_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_GENERALLEDGERTEMP_GLID_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_GENERALLEDGERTEMP_Vou_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_GLOBAL_CUT_OFF_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_HISTORICAL_Activity_History_SEQ", "PayRoll").StartsAt(39821);

            modelBuilder.HasSequence("PR_HISTORICAL_APPROVED_ACTIVITYS_SEQ", "PayRoll").StartsAt(32897);

            modelBuilder.HasSequence("PR_HISTORICAL_APPROVED_COMPONENTS_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_HISTORICAL_BALANCE_SEQ", "PayRoll").StartsAt(1212927);

            modelBuilder.HasSequence("PR_HISTORICAL_CHANGE_APPROVEL_SEQ", "PayRoll").StartsAt(2016441);

            modelBuilder.HasSequence("PR_HISTORICAL_CHANGE_COMPONENT_DTL_SEQ", "PayRoll").StartsAt(671001);

            modelBuilder.HasSequence("PR_HISTORICAL_COMPONENT_ADJUSTMENT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_HISTORICAL_Draft_Activity_History_SEQ", "PayRoll").StartsAt(79821);

            modelBuilder.HasSequence("PR_HISTORICAL_DRAFT_MONTHLY_PAY_HD_SEQ", "PayRoll").StartsAt(265204);

            modelBuilder.HasSequence("PR_HISTORICAL_DRAFT_PAYSLIP_SEQ", "PayRoll").StartsAt(651486);

            modelBuilder.HasSequence("PR_HISTORICAL_DRAFT_PAYSLIP_SUMMARY_SEQ", "PayRoll").StartsAt(97641);

            modelBuilder.HasSequence("PR_HISTORICAL_DRAFT_SALARY_DT_SEQ", "PayRoll").StartsAt(452402);

            modelBuilder.HasSequence("PR_HISTORICAL_LEAVE_SUMMARY_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_HISTORICAL_MONTHLY_PAY_HD_SEQ", "PayRoll").StartsAt(2465204);

            modelBuilder.HasSequence("PR_HISTORICAL_PAYSLIP_SEQ", "PayRoll").StartsAt(486);

            modelBuilder.HasSequence("PR_HISTORICAL_PAYSLIP_SUMMARY_SEQ", "PayRoll").StartsAt(63641);

            modelBuilder.HasSequence("PR_HISTORICAL_SALARY_BASE_LEAVE_DT_SEQ", "PayRoll").StartsAt(787299);

            modelBuilder.HasSequence("PR_HISTORICAL_SALARY_BASE_LEAVE_DT_SUMMARY_SEQ", "PayRoll").StartsAt(5231299);

            modelBuilder.HasSequence("PR_HISTORICAL_SALARY_DT_SEQ", "PayRoll").StartsAt(22402);

            modelBuilder.HasSequence("PR_INCIDENTAL_EXPENSE_SEQ", "PayRoll").StartsAt(272099);

            modelBuilder.HasSequence("PR_Leave_Rule_SEQ", "PayRoll").StartsAt(105023);

            modelBuilder.HasSequence("PR_LOCAL_CUT_OFF_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_MANUAL_OPENING_BALANCE_ENTRY_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_Monthly_Credit_SEQ", "PayRoll").StartsAt(127965);

            modelBuilder.HasSequence("PR_Monthly_Input_SEQ", "PayRoll").StartsAt(434345);

            modelBuilder.HasSequence("PR_Monthly_Input_Var_DT_SEQ", "PayRoll").StartsAt(716647);

            modelBuilder.HasSequence("PR_Monthly_Input_Var_Hd_SEQ", "PayRoll").StartsAt(476009);

            modelBuilder.HasSequence("PR_MONTHLY_INPUTS_AUDIT_TABLE_SEQ", "PayRoll").StartsAt(100);

            modelBuilder.HasSequence("PR_MONTHLY_OT_SEQ", "PayRoll").StartsAt(178702);

            modelBuilder.HasSequence("pr_monthly_pay_hd_SEQ", "PayRoll").StartsAt(650204);

            modelBuilder.HasSequence("PR_MONTHLY_PAY_HD_VSL_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_MONTHLY_RECEIPTS_SEQ", "PayRoll").StartsAt(1000);

            modelBuilder.HasSequence("PR_NOTIFICATION_EXCLUDED_COMPANY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_ORACLE_FUSION_PAYSLIP_SEQ", "PayRoll");

            modelBuilder.HasSequence("pr_overtime_dt_SEQ", "PayRoll").StartsAt(297383);

            modelBuilder.HasSequence("PR_PAID_TO_BANK_DT_SEQ", "PayRoll").StartsAt(2001);

            modelBuilder.HasSequence("PR_PAID_TO_BANK_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_PAY_BY_AGENT_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PAYROLL_PROCESS_ACTIVITY_AUDIT_TABLE_SEQ", "PayRoll").StartsAt(100);

            modelBuilder.HasSequence("PR_PAYROLL_PROCESS_CONTRACT_AUDIT_TABLE_SEQ", "PayRoll").StartsAt(100);

            modelBuilder.HasSequence("PR_PAYROLL_PROCESS_INTERFACE_DATA_DETAIL_AUD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PAYROLL_PROCESS_INTERFACE_DATA_SUMMARY_AUD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PAYROLL_PROCESS_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PAYROLL_PROCESSING_EMPLOYEE_LIST_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_PAYROLL_START_SEAFARER_SETTINGS_SEQ", "PayRoll").StartsAt(2);

            modelBuilder.HasSequence("PR_Payscale_Appl_Cmp_SEQ", "PayRoll").StartsAt(121743);

            modelBuilder.HasSequence("PR_Payscale_DT_SEQ", "PayRoll").StartsAt(476804);

            modelBuilder.HasSequence("PR_Payscale_Revision_SEQ", "PayRoll").StartsAt(111242);

            modelBuilder.HasSequence<int>("PR_PAYSCALE_SENIORITY_BONUS_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Payslip_Approval_SEQ", "PayRoll").StartsAt(493015);

            modelBuilder.HasSequence("PR_Payslip_DT_SEQ", "PayRoll").StartsAt(1234);

            modelBuilder.HasSequence<int>("PR_PAYSLIP_FORMAT_APPLICABLE_COMPANIES_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_PAYSLIP_FORMAT_MAPPING_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PAYSLIP_FORMAT_MASTER_SEQ", "PayRoll").StartsAt(100);

            modelBuilder.HasSequence<int>("PR_PAYSLIP_FORMATS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PAYSLIP_SEND_MAIL_SEQ", "PayRoll");

            modelBuilder.HasSequence("pr_payslip_SEQ", "PayRoll").StartsAt(3368197);

            modelBuilder.HasSequence<int>("PR_POST_ACTIVITY_HISTORY_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_POST_BALANCE_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_POST_MONTHLY_PAY_HD_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_POST_OVERTIME_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_POST_PAYROLL_PROCESS_CREW_SETTINGS_AUDIT_SEQ", "PayRoll").StartsAt(1234);

            modelBuilder.HasSequence<int>("PR_POST_PAYROLL_PROCESS_CREW_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_POST_PAYROLL_PROCESS_VESSEL_SETTINGS_AUDIT_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_POST_PAYROLL_PROCESS_VESSEL_SETTINGS_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_POST_PAYSLIP_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_POST_SALARY_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_PREV_ADJUSTMENT_AMT_SEQ", "PayRoll").StartsAt(34299);

            modelBuilder.HasSequence("PR_PROCESS_LEAVE_LIQUIDATION_ENTRY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_REJOINING_BONUS_AUDIT_SEQ", "PayRoll").StartsAt(6000);

            modelBuilder.HasSequence("PR_REJOINING_BONUS_SEQ", "PayRoll").StartsAt(2345);

            modelBuilder.HasSequence("PR_REMITTANCE_DETAILS_SEQ", "PayRoll").StartsAt(100);

            modelBuilder.HasSequence("PR_Report_Parameter_SEQ", "PayRoll").StartsAt(2416076);

            modelBuilder.HasSequence("PR_SALARY_BASE_LEAVE_DT_SEQ", "PayRoll").StartsAt(34299);

            modelBuilder.HasSequence("pr_salary_dt_SEQ", "PayRoll").StartsAt(2640221);

            modelBuilder.HasSequence("PR_Salary_Rule_SEQ", "PayRoll").StartsAt(311512);

            modelBuilder.HasSequence("PR_Scale_Appl_Cmpnt_SEQ", "PayRoll").StartsAt(135154);

            modelBuilder.HasSequence("PR_SEAGOING_DT_AUDIT_SEQ", "PayRoll").StartsAt(6000);

            modelBuilder.HasSequence("PR_SEAGOING_DT_SEQ", "PayRoll").StartsAt(6000);

            modelBuilder.HasSequence("PR_SEND_TO_OFFICE_EMP_seq", "PayRoll");

            modelBuilder.HasSequence("PR_SHARE_HOLD_PERIOD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_SHARE_SCHEME_LOAN_DEDUCTION_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_SHARE_SCHEME_MF_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_SPORTS_FUND_SEQ", "PayRoll").StartsAt(1001);

            modelBuilder.HasSequence("PR_States_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_Activity_History_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_Balance_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_ACTIVITY_HISTORY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_BALANCE_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_CHANGE_ACTIVITY_DTL_SEQ", "PayRoll").StartsAt(124219);

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_CHANGE_COMPONENT_DTL_SEQ", "PayRoll").StartsAt(124219);

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_LEAVE_SUMMARY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_MONTHLY_PAY_HD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_PAYSLIP_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_PAYSLIP_SUMMARY_SEQ", "PayRoll");

            modelBuilder.HasSequence("pr_TEMP_HISTORICAL_SALARY_BASE_LEAVE_DT_SUMMARY_SEQ", "PayRoll").StartsAt(5231299);

            modelBuilder.HasSequence("PR_TEMP_HISTORICAL_SALARY_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_Monthly_Pay_HD_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_Overtime_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_PAID_COMPONENT_STATUS_SEQ", "PayRoll").StartsAt(4219);

            modelBuilder.HasSequence("PR_TEMP_Payslip_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_PAYSLIP_SUMMARY_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TEMP_SALARY_BASE_LEAVE_DT_SEQ", "PayRoll").StartsAt(52950);

            modelBuilder.HasSequence("PR_TEMP_Salary_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Travel_Not_Applicable_History_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Travel_Not_Applicable_NB_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_TRAVEL_NOT_APPLICABLE_SEQ", "PayRoll").StartsAt(500287);

            modelBuilder.HasSequence<int>("PR_VESSEL_APPL_ALLOWANCE_ACTIVITIES_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_VESSEL_APPL_ALLOWANCE_COMPONENTS_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_VESSEL_APPL_SCALE_NB_DT_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Vessel_Appl_Scale_SEQ", "PayRoll").StartsAt(262043);

            modelBuilder.HasSequence("PR_VESSEL_APPLICABLE_ALLOWNACES_SEQ", "PayRoll");

            modelBuilder.HasSequence<int>("PR_VESSEL_CASH_TRANSACTION_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_VESSEL_SENDERS_BANK_MAPPING_APPLICABLE_COMPANIES_SEQ", "PayRoll").StartsAt(1025);

            modelBuilder.HasSequence("PR_VESSEL_SENDERS_BANK_MAPPING_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_VESSEL_SETTINGS_LOG_TABLE_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_VESSEL_TRANSACTION_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_Vesselwise_Status_SEQ", "PayRoll").StartsAt(121991);

            modelBuilder.HasSequence("PR_Vesselwise_Trans_DT_SEQ", "PayRoll").StartsAt(111744);

            modelBuilder.HasSequence("PR_VESSEWISE_ALLOWANCES_PROCESSED_SEQ", "PayRoll").StartsAt(12000);

            modelBuilder.HasSequence("PR_VESSEWISE_ALLOWNACES_SEQ", "PayRoll");

            modelBuilder.HasSequence("PR_VSL_ALLOTMENT_AUTO_APPROVAL_AUDIT_SEQ", "PayRoll").StartsAt(1000);

            modelBuilder.HasSequence("TEMP_WM_BANK_BRANCHES_SEQ", "PayRoll").StartsAt(103385);

            modelBuilder.HasSequence("WM_Allotment_Mdf_Amount_SEQ", "PayRoll").StartsAt(251155);

            modelBuilder.HasSequence("WM_Allotment_Rqst_DT_SEQ", "PayRoll").StartsAt(143353);

            modelBuilder.HasSequence("WM_Allotment_Rqst_Hd_SEQ", "PayRoll").StartsAt(130441);

            modelBuilder.HasSequence("WM_Bank_Accounts_seq", "PayRoll").HasMax(999999999999999999);

            modelBuilder.HasSequence("WM_Cashadvances_SEQ", "PayRoll").StartsAt(331089);

            modelBuilder.HasSequence("WM_Deductions_Beneficiary_SEQ", "PayRoll").StartsAt(152620);

            modelBuilder.HasSequence("WM_Deductions_SEQ", "PayRoll").StartsAt(146085);

            modelBuilder.HasSequence("WM_Manager_Reg_DT_SEQ", "PayRoll").StartsAt(105011);

            modelBuilder.HasSequence("WM_Managerwise_Pay_Hd_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("WM_Monthly_Allot_Ben_DT_SEQ", "PayRoll").StartsAt(391809);

            modelBuilder.HasSequence("WM_Monthly_Allot_Pay_Hd_SEQ", "PayRoll").StartsAt(440911);

            modelBuilder.HasSequence("WM_Monthly_Payments_SEQ", "PayRoll").StartsAt(1412734);

            modelBuilder.HasSequence("WM_Poea_Letter_SEQ", "PayRoll").StartsAt(121851);

            modelBuilder.HasSequence("WM_POEA_REPORT_REGISTERED_SEQ", "PayRoll").StartsAt(4219);

            modelBuilder.HasSequence("WM_Poea_Scale_Settings_SEQ", "PayRoll").StartsAt(125373);

            modelBuilder.HasSequence("WM_Settings_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("WM_Stop_Allotment_SEQ", "PayRoll").StartsAt(105008);

            modelBuilder.HasSequence("WM_Vessel_Setup_SEQ", "PayRoll").StartsAt(105009);

            modelBuilder.HasSequence("PERF_ACTIVATION_SEQ", "PERFORM")
                .StartsAt(2064)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ADVANCED_VALIDATION_RULE_SEQ", "PERFORM")
                .StartsAt(3)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_CUSTOM_CONFIG_SEQ", "PERFORM")
                .StartsAt(291)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_CUSTOM_FM_CONFIG_SEQ", "PERFORM")
                .StartsAt(33)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_EXTERNAL_MAPPING_EXPORT_SEQ", "PERFORM")
                .StartsAt(64)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_LOG_KPI_SEQ", "PERFORM")
                .StartsAt(26)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_AE_REFERENCE_CURVE_SEQ", "PERFORM")
                .StartsAt(64)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_REPORT_KPI_GEN2_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_REPORT_KPI_HD_GEN2_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_REPORT_KPI_HD_SEQ", "PERFORM")
                .StartsAt(7817)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AE_REPORT_KPI_SEQ", "PERFORM")
                .StartsAt(252405)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_AIS_API_WEATHER_DATA_SEQ", "PERFORM").HasMin(1);

            modelBuilder.HasSequence("PERF_ANALYSIS_CHART_SEQ", "PERFORM")
                .StartsAt(17)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ATTACHMENTS_SEQ", "PERFORM");

            modelBuilder.HasSequence("PERF_BPM_ENGINE_VERSION_GEN2_SEQ", "PERFORM")
                .StartsAt(7)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_BPM_ENGINE_VERSION_SEQ", "PERFORM")
                .StartsAt(35)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_BPM_ENGINE_VERSION_SEQ_GEN2", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_CARGO_GEAR_TYPE_UNIT_CONFIG_SEQ", "PERFORM")
                .StartsAt(3)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_COMPONENT_CATEGORY_SEQ", "PERFORM")
                .StartsAt(11)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_COMPONENT_SEQ", "PERFORM")
                .StartsAt(11)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_CONSTANT_MF_SEQ", "PERFORM")
                .StartsAt(140)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_CP_CRITERIA_DATA_SEQ", "PERFORM")
                .StartsAt(2785)
                .HasMin(1)
                .HasMax(922337203685477580);

            modelBuilder.HasSequence("PERF_CP_DATA_HD_SEQ", "PERFORM")
                .StartsAt(349)
                .HasMin(1)
                .HasMax(922337203685477580);

            modelBuilder.HasSequence("PERF_CP_DESCRIPTION_REF_SEQ", "PERFORM")
                .StartsAt(6)
                .HasMin(1)
                .HasMax(922337203685477580);

            modelBuilder.HasSequence("PERF_CP_PERFORMANCE_LOG_SEQ", "PERFORM")
                .StartsAt(11)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_CP_VARIABLE_DATA_SEQ", "PERFORM")
                .StartsAt(5140)
                .HasMin(1)
                .HasMax(922337203685477580);

            modelBuilder.HasSequence<int>("PERF_CP_VARIABLE_SEQ", "PERFORM")
                .StartsAt(14)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_DB_ERRORS_SEQ", "PERFORM")
                .StartsAt(17)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_DIAGNOSTIC_CHART_CONFIG_SEQ", "PERFORM").StartsAt(43);

            modelBuilder.HasSequence("PERF_DIAGNOSTIC_LOG_GEN2_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_DIAGNOSTIC_LOG_SEQ", "PERFORM")
                .StartsAt(37880155)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_DIAGNOSTIC_SEQ", "PERFORM")
                .StartsAt(63)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_DOA_SEQ", "PERFORM")
                .StartsAt(4239)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_EMAIL_REMAINDER_LOG_SEQ", "PERFORM")
                .StartsAt(2487)
                .HasMin(1);

            modelBuilder.HasSequence<int>("PERF_EMPLOYEE_INFO_SEQ", "PERFORM")
                .StartsAt(83)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_EMPLOYEE_SEQ", "PERFORM")
                .StartsAt(17)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_ENGINE_FAULT_CHART_CONFIG_SEQ", "PERFORM")
                .StartsAt(231775)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ENGINE_FAULT_KPI_HD_SEQ", "PERFORM")
                .StartsAt(3517)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ENGINE_FAULT_KPI_SEQ", "PERFORM")
                .StartsAt(282241)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ENGINE_FAULT_MATRIX_SEQ", "PERFORM")
                .StartsAt(22)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ENGINE_FAULT_SEQ", "PERFORM")
                .StartsAt(21)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ENGINE_FAULT_SYMBOL_DEF_SEQ", "PERFORM")
                .StartsAt(707)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_EQUIPMENT_DETAILS_SEQ_DUMMY", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_EXT_PROVIDER_SEQ", "PERFORM")
                .StartsAt(6)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_EXT_PROVIDER_SYMBOL_SEQ", "PERFORM")
                .StartsAt(190)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_EXT_PROVIDER_TYPE_SEQ", "PERFORM")
                .StartsAt(3)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_FLEET_KPI_CONFIG_TILE_SEQ", "PERFORM").HasMin(1);

            modelBuilder.HasSequence("PERF_FLT_KPI_TILE_CONFIG_SEQ", "PERFORM").HasMin(1);

            modelBuilder.HasSequence("PERF_FLT_KPI_TILE_ROLE_CONFIG_SEQ", "PERFORM").HasMin(1);

            modelBuilder.HasSequence<decimal>("PERF_FQT_DT_SEQ", "PERFORM")
                .StartsAt(19039)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("PERF_FQT_ERROR_LOG_SEQ", "PERFORM")
                .StartsAt(1318)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("PERF_FQT_HD_SEQ", "PERFORM")
                .StartsAt(19039)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_FUEL_LUBE_TEST_RESULTS_DT_SEQ", "PERFORM")
                .StartsAt(70)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_FUEL_LUBE_TEST_RESULTS_HD_SEQ", "PERFORM")
                .StartsAt(41)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_API_WEATHER_DATA_SEQ", "PERFORM").StartsAt(4870);

            modelBuilder.HasSequence("PERF_HP_CUSTOM_CONFIG_SEQ", "PERFORM")
                .StartsAt(899)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_CUSTOM_FM_CONFIG_SEQ", "PERFORM")
                .StartsAt(143)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_EXTERNAL_MAPPING_EXPORT_SEQ", "PERFORM")
                .StartsAt(52)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_LOG_KPI_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_REPORT_HD_GEN2_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_REPORT_HD_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_REPORT_KPI_GEN2_SEQ", "PERFORM")
                .StartsAt(220323)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_REPORT_KPI_HD_SEQ", "PERFORM")
                .StartsAt(8191)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_HP_REPORT_KPI_SEQ", "PERFORM")
                .StartsAt(98281)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_LOG_BOOK_REPORT_FINAL_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_LOG_BOOK_REPORT_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_MANUAL_BPM_PROCESS_SEQ", "PERFORM")
                .StartsAt(41)
                .HasMin(1)
                .HasMax(922337203685477580);

            modelBuilder.HasSequence("PERF_MANUAL_LOG_EQUIP_SYMBOL_SEQ", "PERFORM")
                .StartsAt(1215)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_MANUAL_LOG_SYMBOL_SEQ", "PERFORM")
                .StartsAt(161)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_MANUAL_LOG_TYPE_SEQ", "PERFORM")
                .StartsAt(3)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_ME_CONFIG_CUSTOM_CHILD_SEQ", "PERFORM").StartsAt(80);

            modelBuilder.HasSequence("PERF_ME_CONFIG_CUSTOM_DETAILS_SEQ", "PERFORM").StartsAt(80);

            modelBuilder.HasSequence("PERF_ME_CONFIG_CUSTOM_MASTER_SEQ", "PERFORM").StartsAt(77);

            modelBuilder.HasSequence("PERF_ME_CUSTOM_CONFIG_SEQ", "PERFORM")
                .StartsAt(2434)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ME_CUSTOM_FM_CONFIG_SEQ", "PERFORM")
                .StartsAt(287)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ME_EXTERNAL_MAPPING_EXPORT_SEQ", "PERFORM")
                .StartsAt(178)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_ME_LOG_KPI_SEQ", "PERFORM")
                .StartsAt(58)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_ME_REFERENCE_CURVE_SEQ", "PERFORM")
                .StartsAt(205)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ME_REPORT_KPI_GEN2_SEQ", "PERFORM")
                .StartsAt(282241)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ME_REPORT_KPI_HD_GEN2_SEQ", "PERFORM")
                .StartsAt(3517)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ME_REPORT_KPI_HD_SEQ", "PERFORM")
                .StartsAt(38)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_ME_REPORT_KPI_SEQ", "PERFORM")
                .StartsAt(5121)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_MOD_CREATOR_CATEGORY_SEQ", "PERFORM");

            modelBuilder.HasSequence("PERF_MSPS_API_WEATHER_DATA_SEQ", "PERFORM").StartsAt(1000);

            modelBuilder.HasSequence("PERF_MSPS_EXTERNAL_MAPPING_EXPORT_SEQ", "PERFORM")
                .StartsAt(10)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_NOON_API_WEATHER_DATA_SEQ", "PERFORM").StartsAt(26620);

            modelBuilder.HasSequence("PERF_NOON_CUSTOM_CONFIG_SEQ", "PERFORM")
                .StartsAt(106)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_CUSTOM_FM_CONFIG_SEQ", "PERFORM")
                .StartsAt(16)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_EXTERNAL_MAPPING_EXPORT_SEQ", "PERFORM")
                .StartsAt(210)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_NOON_LOG_KPI_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_LOG_TYPE_CONFIG_SEQ", "PERFORM")
                .StartsAt(40)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_LOG_TYPE_MANDATORY_CONFIG_SEQ", "PERFORM")
                .StartsAt(217)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_LT_CUSTOM_CONFIG_SEQ", "PERFORM")
                .StartsAt(25837)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_LT_CUSTOM_FM_CONFIG_SEQ", "PERFORM")
                .StartsAt(2332)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_ME_LOG_KPI_SEQ", "PERFORM")
                .StartsAt(2)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_NOON_ME_REPORT_KPI_HD_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_ME_REPORT_KPI_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_REPORT_HD_GEN2_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_REPORT_HD_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_REPORT_KPI_GEN2_SEQ", "PERFORM")
                .StartsAt(16529541)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_REPORT_KPI_HD_SEQ", "PERFORM")
                .StartsAt(251996)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_REPORT_KPI_SEQ", "PERFORM")
                .StartsAt(10452037)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_SERVICE_VARIABLE_CONFIG_SEQ", "PERFORM").StartsAt(55);

            modelBuilder.HasSequence("PERF_NOON_SERVICE_VARIABLE_LT_CONFIG_SEQ", "PERFORM")
                .StartsAt(1511)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOON_SVC_LT_TAB_SEQ", "PERFORM")
                .StartsAt(136)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOTIFICATION_CHART_DATA_SEQ", "PERFORM").StartsAt(5020);

            modelBuilder.HasSequence("PERF_NOTIFICATION_COMMENT_SEQ", "PERFORM")
                .StartsAt(99990000000497)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_NOTIFICATION_ENTRY_READ_DETAILS_SEQ", "PERFORM")
                .StartsAt(99990000177555)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_NOTIFICATION_ENTRY_SEQ", "PERFORM")
                .StartsAt(20966)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_NOTIFICATION_ROLE_MAPPING_SEQ", "PERFORM")
                .StartsAt(17)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_NOTIFICATION_RULE_PRIORITY_SEQ", "PERFORM")
                .StartsAt(121)
                .HasMin(1);

            modelBuilder.HasSequence<int>("PERF_NOTIFICATION_RULE_SEQ", "PERFORM")
                .StartsAt(17)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_OUTPUT_CATEGORY_DEF_SEQ", "PERFORM")
                .StartsAt(38)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_CATEGORY_TAGGING_SEQ", "PERFORM")
                .StartsAt(38)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_DIAG_KPI_MAPPING_SEQ", "PERFORM")
                .StartsAt(63)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_DIAG_KPI_SYMBOL_DEF_SEQ", "PERFORM")
                .StartsAt(63)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_DIAG_LOG_TAGGING_SEQ", "PERFORM")
                .StartsAt(109)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_DIAGNOSTIC_DEF_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_LOG_TAGGING_SEQ", "PERFORM")
                .StartsAt(306)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_SYMBOL_DEF_SEQ", "PERFORM")
                .StartsAt(707)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_OUTPUT_VARIABLE_DEF_SEQ", "PERFORM")
                .StartsAt(225)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PARAM_CATEGORY_MF_SEQ", "PERFORM")
                .StartsAt(166)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PARAM_MF_SEQ", "PERFORM")
                .StartsAt(845)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<int>("PERF_PARAMETERS_SEQ", "PERFORM")
                .StartsAt(55)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_PERF_SAMPLE_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PROCESS_CONFIG_SEQ", "PERFORM")
                .StartsAt(8)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PROCESS_CONSTANT_MAPPING_SEQ", "PERFORM")
                .StartsAt(114)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PROCESS_MF_SEQ", "PERFORM")
                .StartsAt(108)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PROCESS_MODEL_FAMILY_ATTACHMENTS_SEQ", "PERFORM")
                .HasMin(-2147483648)
                .HasMax(2147483647);

            modelBuilder.HasSequence("PERF_PROCESS_MODEL_MAIN_SEQ", "PERFORM")
                .StartsAt(682)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PROCESS_MODEL_SEQ", "PERFORM")
                .StartsAt(198982)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PROCESS_PARAM_MAPPING_SEQ", "PERFORM")
                .StartsAt(697)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_PRODUCT_SEQ", "PERFORM")
                .StartsAt(188)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_REF_CURVE_DEF_SEQ", "PERFORM")
                .StartsAt(51)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_REFERENCE_CURVE_KPI_GEN2_SEQ", "PERFORM")
                .StartsAt(1681461)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_REFERENCE_CURVE_KPI_SEQ", "PERFORM")
                .StartsAt(3397581)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_REFERENCE_CURVE_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("Perf_Report_Analysis_DT_SEQ", "PERFORM").StartsAt(48983);

            modelBuilder.HasSequence("Perf_Report_Analysis_HD_SEQ", "PERFORM").StartsAt(2185);

            modelBuilder.HasSequence("PERF_SERVICE_VARIABLE_CATEGORY_SEQ", "PERFORM")
                .StartsAt(24)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_SVD_ADVANCED_VALIDATION_SEQ", "PERFORM")
                .StartsAt(123)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_SVD_CALCULATION_SEQ", "PERFORM")
                .StartsAt(142)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_TELEMETRY_REPORT_KPI_HD_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_TELEMETRY_REPORT_KPI_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_TELEMETRY_SYMBOL_DEF_SEQ", "PERFORM")
                .StartsAt(243)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_TESTPAGE_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_VESSEL_API_WEATHER_DATA_SEQ", "PERFORM")
                .StartsAt(33526)
                .HasMin(1);

            modelBuilder.HasSequence("PERF_VESSEL_PERF_MEASURE_POINT_DT_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_VESSEL_PERF_MEASURE_POINT_HD_SEQ", "PERFORM")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_VESSEL_TYPE_UNIT_CONFIG_SEQ", "PERFORM")
                .StartsAt(35)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_VESSEL_WEATHER_DATA_SEQ", "PERFORM")
                .StartsAt(206134)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("PERF_VOC_DATA_SHARE_SEQ", "PERFORM")
                .StartsAt(4)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<int>("PERF_VPR_KPI_NORMALIZATION_SEQ", "PERFORM").HasMin(1);

            modelBuilder.HasSequence("ACTIVITY_DATA_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("ACTIVITY_EQP_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("ACTIVITY_MTYPE_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("id_seq", "PMS").HasMin(1);

            modelBuilder.HasSequence("id_sequence", "PMS").HasMin(1);

            modelBuilder.HasSequence("PM_ABBREVIATION_REGISTER_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AE_PERF_CONFIG_SEQ", "PMS").StartsAt(65);

            modelBuilder.HasSequence("PM_AR_ACTIONS_MF_SEQ", "PMS").StartsAt(20000);

            modelBuilder.HasSequence("PM_AR_ATTACHMENTS_FILESTREAM_SEQ", "PMS").StartsAt(212025);

            modelBuilder.HasSequence("PM_AR_Attachments_SEQ", "PMS").StartsAt(281953);

            modelBuilder.HasSequence("PM_AR_BUSINESS_FLOW_DT_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_BUSINESS_FLOW_HD_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_CATEGORY_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_CC_EMAIL_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_COMMENTS_ATTACHMENT_SEQ", "PMS").StartsAt(11083);

            modelBuilder.HasSequence<int>("PM_AR_COMMENTS_DT_SEQ", "PMS");

            modelBuilder.HasSequence<int>("PM_AR_COMMENTS_HD_SEQ", "PMS");

            modelBuilder.HasSequence("PM_AR_CREATION_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_FORWARDING_ROLES_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_FUNCTIONAL_ROLE_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_STATUS_HISTORY_SEQ", "PMS").StartsAt(20000);

            modelBuilder.HasSequence("PM_AR_SUB_CATEGORY_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_VESSEL_ALLOCATION_DT_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AR_VESSEL_ALLOCATION_HD_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_AUDIT_SEQ", "PMS").StartsAt(113473);

            modelBuilder.HasSequence("PM_CHANGELOG_DT_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_CHANGELOG_HD_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_CIRCULARS_EQUIP_JOB_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_CIRCULARS_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_CIRCULARS_VSL_MAPPING_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_CLAIM_DOC_SEQ", "PMS").StartsAt(11095);

            modelBuilder.HasSequence("PM_CLAIM_DT_SEQ", "PMS").StartsAt(11095);

            modelBuilder.HasSequence("PM_CLAIM_ITEM_SEQ", "PMS").StartsAt(11095);

            modelBuilder.HasSequence("PM_CLAIM_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_CLIENT_FEATURES_SEQ", "PMS").StartsAt(105001);

            modelBuilder.HasSequence("PM_COLUMN_NAME_CONFIG_SEQ", "PMS");

            modelBuilder.HasSequence("PM_COPY_VESSEL_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_Def_Section_SEQ", "PMS").StartsAt(4001);

            modelBuilder.HasSequence("pm_defect_req_mapping_SEQ", "PMS").HasMax(999999999999999999);

            modelBuilder.HasSequence("PM_DOC_TYPE_SEQ", "PMS").StartsAt(11095);

            modelBuilder.HasSequence("PM_EQ_TYPE_ACC_MAPPING_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_EQUIP_GUARANTEE_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence<int>("PM_EQUIP_JOBPLAN_CONFIG_SEQ", "PMS").HasMax(99999999);

            modelBuilder.HasSequence("PM_EQUIP_NOT_OPERATIONAL_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_EQUIPMENT_CODE_MAPPING_SEQ", "PMS").StartsAt(5900043);

            modelBuilder.HasSequence("PM_EXCLUDE_DL_FIELDS_SEQ", "PMS");

            modelBuilder.HasSequence("PM_EXCLUDED_FIELDS_DL_SETTINGS_SEQ", "PMS");

            modelBuilder.HasSequence("PM_FREQUENCY_CHANGES_LIB_SEQ", "PMS");

            modelBuilder.HasSequence("PM_FREQUENCY_CHANGES_SEQ", "PMS");

            modelBuilder.HasSequence("PM_GUARANTEE_CLAIM_ATTACHMENT_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_GUARANTEE_CLAIM_DT_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_GUARANTEE_CLAIM_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_GUARANTEE_CLAIM_PORT_SCHEDULE_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_GUARANTEE_CREW_RATE_SEQ", "PMS").StartsAt(58806220961);

            modelBuilder.HasSequence("PM_GUARANTEE_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_GUARANTEE_REQUISTION_MAPPING_SEQ", "PMS").StartsAt(10200);

            modelBuilder.HasSequence("PM_GUARANTEE_SPARE_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_INCIDENTS_SEQ", "PMS");

            modelBuilder.HasSequence("PM_INFORMATION_MF_SEQ", "PMS").StartsAt(5900043);

            modelBuilder.HasSequence("PM_Job_Analysis_SEQ", "PMS").StartsAt(105000);

            modelBuilder.HasSequence("PM_JOB_APPROVAL_CYCLE_TEMPLATE_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_Job_Cancel_SEQ", "PMS").StartsAt(123751);

            modelBuilder.HasSequence("PM_JOB_DELETE_USER_SEQ", "PMS");

            modelBuilder.HasSequence("PM_JOB_ITEM_SAFETY_DESCRIPTION_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_JOB_ITEM_SAFETY_INSTRUCTIONS_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_Job_Order_Attachments_Seq", "PMS").HasMax(999999999999999);

            modelBuilder.HasSequence("PM_JOB_ORDER_CBO_TRIGGER_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_Job_Order_Comments_SEQ", "PMS").StartsAt(127117);

            modelBuilder.HasSequence("PM_JOB_ORDER_EMP_SEQ", "PMS");

            modelBuilder.HasSequence("PM_Job_Order_Proc_SEQ", "PMS").StartsAt(3747514);

            modelBuilder.HasSequence("PM_Job_Order_Review_SEQ", "PMS").StartsAt(99990000109602);

            modelBuilder.HasSequence("PM_JOB_ORDER_SEQ", "PMS").StartsAt(5900043);

            modelBuilder.HasSequence("PM_JOB_ORDER_SPARE_STOCK_CONSUMPTION_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_Job_Order_Spares_SEQ", "PMS").StartsAt(200004);

            modelBuilder.HasSequence("PM_JOB_PARAMETERS_SEQ", "PMS").StartsAt(5900043);

            modelBuilder.HasSequence("PM_JOB_PLAN_CBO_TRIGGER_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_Job_Plan_Proc_SEQ", "PMS").StartsAt(105006);

            modelBuilder.HasSequence("PM_Job_Plan_SEQ", "PMS").StartsAt(910766);

            modelBuilder.HasSequence("PM_Job_Plan_Spares_Audit_SEQ", "PMS").HasMax(99999999999999999);

            modelBuilder.HasSequence("PM_Job_Plan_Spares_SEQ", "PMS").StartsAt(200004);

            modelBuilder.HasSequence("PM_Job_Postpone_SEQ", "PMS").StartsAt(279973);

            modelBuilder.HasSequence("PM_JOB_SCHEDULED_TYPE_CHANGE_LOG_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_Job_Unplan_Comments_SEQ", "PMS").StartsAt(105002);

            modelBuilder.HasSequence("PM_Job_Unplan_SEQ", "PMS").StartsAt(200014);

            modelBuilder.HasSequence("PM_JOB_UNPLANNED_TEMP_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_JOBORDER_DURATION_SEQ", "PMS").StartsAt(58806220961);

            modelBuilder.HasSequence("PM_JOBORDER_PARAMETERS_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_JOBPLAN_PARAMETERS_LIB_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_JOBPLAN_PARAMETERS_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_JOBPLAN_RA_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_LEGACY_SYSTEM_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_MA_Analysis_SEQ", "PMS").HasMax(999999999999999999);

            modelBuilder.HasSequence("PM_MANHOURCHARGES_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_ME_PERF_CONFIG_SEQ", "PMS").StartsAt(191);

            modelBuilder.HasSequence("PM_ME_PERFORMANCE_REPORT_DETAILS_SEQ", "PMS").StartsAt(2512000001617);

            modelBuilder.HasSequence("PM_ME_PERFORMANCE_REPORT_SEQ", "PMS").StartsAt(2512000001003);

            modelBuilder.HasSequence("PM_MISCEXP_GC_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_MOUNT_DISMOUNT_DETAILS_SEQ", "PMS").StartsAt(210000);

            modelBuilder.HasSequence("PM_Mount_Dismount_SEQ", "PMS").StartsAt(200000);

            modelBuilder.HasSequence("PM_PM_SAFETY_SUBGROUP_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_POSTPONE_SETTINGS_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_Present_Readings_SEQ", "PMS").StartsAt(382008);

            modelBuilder.HasSequence("PM_Report_Parameter_Seq", "PMS").StartsAt(105009);

            modelBuilder.HasSequence("PM_ROUND_JOB_FORM_MAPPING_SEQ", "PMS").StartsAt(121008);

            modelBuilder.HasSequence("PM_ROUND_JOBS_HD_SEQ", "PMS").StartsAt(450000);

            modelBuilder.HasSequence("PM_Round_Jobs_SEQ", "PMS").StartsAt(105001);

            modelBuilder.HasSequence("PM_Running_Hour_SEQ", "PMS").StartsAt(1009068);

            modelBuilder.HasSequence("PM_SPARE_LIB_TAG_LINK_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_SPARE_TAG_LINK_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_SPM_SAFETY_SUBGROUP_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TAG_MASTER_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_TF_AE_BEARING_METAL_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_BIGEND_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_CONROD_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_GROOVE_WIDTH_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_LINER_CALIBRATION_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_LINER_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_OTHER_DETAILS_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_OVALITY_CHECK_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_OVERHAUL_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PERFORMANCE_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PERFORMANCE_PARAMETER_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PERFORMANCE_PRESSURE_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PERFORMANCE_TEMPARATURE_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PISTON_PIN_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PISTON_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_PISTON_RING_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_AE_RADIAL_THICKNESS_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_BC_PARAMATER_VALUES_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_BC_PARAMATERS_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_BEARING_CLEARANCE_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_BEARING_READING_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_CALIBRE_HD_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_CRANKSHAFT_DEFLECTION_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_CRANKSHAFT_DEFLECTION_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_DECK_MAINTENANCE_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_DECK_MAINTENANCE_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_DECK_REPORT_PARAMETERS_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_DEFLECTION_VALUES_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_EQUIP_GROUP_CHILD_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_EQUIPMENT_GROUP_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_EQUIPMENT_MAPPING_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_HEAD_SLIPPER_READINGS_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_INCINERATOR_LOG_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_INCINERATOR_LOG_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_INSPECTION_CALIBRE_DT_SEQ", "PMS").StartsAt(10020);

            modelBuilder.HasSequence("PM_TF_INSPECTION_CALIBRE_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_JOB_ORDER_FORMS_MAPPING_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_JOB_PLAN_FORMS_MAPPING_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_LINER_MEASUREMENT_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_INDICATOR_DIAGRAM_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_OTHER_DETAILS_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_PERFORMANCE_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_PERFORMANCE_PRESSURE_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_PERFORMANCE_TEMPARATURE_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_PISTON_LINER_OVERHAUL_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_ME_TURBOCHARGER_DATA_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_MEGGER_TEST_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_MEGGER_TEST_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_MEGGER_TEST_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_MONTHLY_RH_REPORT_DT_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_MONTHLY_RH_REPORT_HD_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_MOORING_ROPE_CHECKLIST_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_MOORING_ROPE_CHECKLIST_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_PC_RING_THICKNESS_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_PISTON_RINGS_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_RING_GROOVE_HEIGHT_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_RING_GROOVE_NO_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_SCAVENGE_INSPECTION_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_SCAVENGE_INSPECTION_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_SCAVENGE_INSPECTION_LEGENDS_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_SCAVENGE_INSPECTION_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_SI_ENGINE_PART_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TANK_CONDITION_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TANK_CONDITION_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TANK_INSPECTION_DT_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TANK_INSPECTION_GRADES_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TANK_INSPECTION_HD_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TEC005_AE_EQUIP_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TEC005_AE_PARAMETERS_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TEC005_AE_READING_DT_SEQ", "PMS").StartsAt(3336202);

            modelBuilder.HasSequence("PM_TF_TEC005_PARAM_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TEC005_PU_PARAMETERS_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TEC005_PU_READING_DT_SEQ", "PMS").StartsAt(3336202);

            modelBuilder.HasSequence("PM_TF_TEC005_TC_READING_DT_SEQ", "PMS").StartsAt(3336202);

            modelBuilder.HasSequence("PM_TF_TEC022_DT_SEQ", "PMS").StartsAt(11000);

            modelBuilder.HasSequence("PM_TF_TEC022_HD_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TEC022_MF_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TEC022_VSL_PARAMS_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_TF_TECH_FORMS_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TI_TANK_PARAMETER_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_TI_TANK_TYPE_MF_SEQ", "PMS").StartsAt(5000);

            modelBuilder.HasSequence("PM_TF_VESSEL_FORMS_MAPPING_SEQ", "PMS").StartsAt(150);

            modelBuilder.HasSequence("PM_TRIGGER_CBO_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_UNTRIGGERJOBS_NOTIFY_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_VESSEL_GROUP_DT_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_VESSEL_GROUP_HD_SEQ", "PMS").StartsAt(1000);

            modelBuilder.HasSequence("PM_VESSEL_INSTALLATION_DATE_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_VESSELACTION_GC_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_VESSELACTION_SPARES_GC_MAPPING_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("PM_WARRANTY_DETAILS_SEQ", "PMS").StartsAt(531692);

            modelBuilder.HasSequence("PM_WORK_FLOW_MASTER_SEQ", "PMS").StartsAt(10000);

            modelBuilder.HasSequence("VESSEL_DATA_BUILDING_DETAILS_SEQ", "PMS").StartsAt(50000);

            modelBuilder.HasSequence("VESSEL_DATA_BUILDING_SEQ", "PMS").StartsAt(200);

            modelBuilder.HasSequence("[SP_VENDOR_APPROVAL_ECONNECT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("DeletedRecordsInfo_ID_SEQ", "Purchase");

            modelBuilder.HasSequence("ENGINE_CONFIGURATION_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("I2P_INVOICE_HEADER_SEQ", "Purchase").StartsAt(1001);

            modelBuilder.HasSequence("INVENTORY_CLOSING_HIST_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("INVENTORY_CLOSING_HIST_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("INVENTORY_CLOSING_HIST_RPT_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("MODULE_DT_LINK_SEQ", "Purchase").StartsAt(10000);

            modelBuilder.HasSequence("MODULE_HD_LINK_QT_SEQ", "Purchase").StartsAt(10000);

            modelBuilder.HasSequence("MODULE_HD_LINK_SEQ", "Purchase").StartsAt(10000);

            modelBuilder.HasSequence("REQ_CATEGORY_MERGE_CONF_DT_SEQ", "Purchase").HasMax(999999999999999999);

            modelBuilder.HasSequence("REQ_CATEGORY_MERGE_CONF_HD_SEQ", "Purchase").HasMax(999999999999999999);

            modelBuilder.HasSequence("ROB_SUMMARY_CONFIGURATION_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Account_Change_Log_SEQ", "Purchase").StartsAt(1658531);

            modelBuilder.HasSequence("SP_ADDITIONAL_BANK_FORMATS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_ADMIN_MASTER_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_AGREEMENT_DT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_AGREEMENT_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Analysis_Codes_seq", "Purchase").StartsAt(1700588);

            modelBuilder.HasSequence("Sp_approval_doc_types_seq", "Purchase");

            modelBuilder.HasSequence("SP_APPROVAL_FLAG_LIST_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Approved_Quote_DT_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Approved_Quote_DT_SEQ", "Purchase").StartsAt(200008);

            modelBuilder.HasSequence("SP_Approved_Quote_HD_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Approved_Quote_Hd_SEQ", "Purchase").StartsAt(200008);

            modelBuilder.HasSequence("SP_ATTACHMENTS_FILESTREAM_SEQ", "Purchase").StartsAt(999900202125);

            modelBuilder.HasSequence("SP_Attachments_SEQ", "Purchase").StartsAt(999901724152);

            modelBuilder.HasSequence("SP_BUDGET_BALANCE_FOR_VESSEL_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Budget_Balance_SEQ", "Purchase").StartsAt(105776);

            modelBuilder.HasSequence("SP_Budget_Balance_Vessel_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_COMMENTS_READ_SEQ", "Purchase").StartsAt(1700);

            modelBuilder.HasSequence("SP_COMMENTS_SEQ", "Purchase")
                .StartsAt(9999000016500)
                .HasMin(9999000000001);

            modelBuilder.HasSequence("SP_COMMENTS_USERS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_COMMENTS_VENDORS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_COMPANY_COMPANY_TYPES_ECONNECT_STAGING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_CONFIG_EMAIL_NOTIFICATION_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_COPIED_REQ_PO_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_COPIED_REQUISITIONS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_CP_ITEM_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_CP_REQ_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_CP_USERS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_CP_VESSELS_SEQ", "Purchase").StartsAt(100004);

            modelBuilder.HasSequence("SP_DEVIATION_REASONS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Disb_Comments_SEQ", "Purchase").StartsAt(1250400);

            modelBuilder.HasSequence("SP_DISPATCH_DETAILS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_DISPATCH_ORDER_ITEMS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_DISPATCH_ORDER_SEND_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_DO_ACCOUNT_CODE_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_DO_Goods_Receipt_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_DOC_NUMBER_SETTINGS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_DRYDOCK_ACCOUNT_MAPPING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Enquiry_DT_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Enquiry_DT_SEQ", "Purchase").StartsAt(200016);

            modelBuilder.HasSequence("SP_Enquiry_HD_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Enquiry_Hd_SEQ", "Purchase").StartsAt(105010);

            modelBuilder.HasSequence("SP_Enquiry_Hist_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_ENQUIRY_ITEM_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Enquiry_Ports_SEQ", "Purchase").StartsAt(530348);

            modelBuilder.HasSequence("SP_Enquiry_Remainder_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Enquiry_Service_Det_SEQ", "Purchase").StartsAt(200008);

            modelBuilder.HasSequence("SP_ENQUIRY_TO_VENDOR_ATTACHMENTS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Enquiry_To_Vendor_SEQ", "Purchase").StartsAt(128537);

            modelBuilder.HasSequence("SP_EQUIP_ACCOUNT_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_EQUIP_CODE_ACCOUNT_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_EQUIPMENT_TYPE_SETTINGS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_EXCLUDED_ITEM_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_EXCLUDED_ITEM_SECTION_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_EXCLUDED_REQ_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_GEN_QUERY_SETTINGS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Goods_Evaluation_SEQ", "Purchase").StartsAt(200008);

            modelBuilder.HasSequence("SP_Goods_Receipt_DT_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_Goods_Receipt_Hd_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_I2P_FOLDER_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_IHM_ITEMS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_IHM_VESSELS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_INV_AUTO_APPROVAL_REASON_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_INV_COLUMN_SETTINGS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Invoice_Accrual_SEQ", "Purchase").StartsAt(100000);

            modelBuilder.HasSequence("SP_Invoice_Add_Amount_I2P_TEMP_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Invoice_Add_Amount_SEQ", "Purchase").StartsAt(200015);

            modelBuilder.HasSequence("SP_INVOICE_CORRECTIONS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_INVOICE_DT_I2P_TEMP_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_INVOICE_DT_SEQ", "Purchase").StartsAt(246530);

            modelBuilder.HasSequence("SP_Invoice_HD_Bank_Details_SEQ", "Purchase").StartsAt(616506);

            modelBuilder.HasSequence("SP_INVOICE_HD_I2P_TEMP_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Invoice_Hd_SEQ", "Purchase").StartsAt(730492);

            modelBuilder.HasSequence("SP_Invoice_Hist_SEQ", "Purchase").StartsAt(105009);

            modelBuilder.HasSequence("SP_INVOICE_ITEM_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_INVOICE_PAYMENT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_INVOICE_VENDOR_HISTORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Issue_Stock_SEQ", "Purchase").StartsAt(200008);

            modelBuilder.HasSequence("SP_ITEM_ACCOUNT_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_ITEM_ATTACHMENTS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_ITEM_CATALOGUE_UTILITY_DT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_ITEM_CATALOGUE_UTILITY_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_ITEM_TEMPLATE_VESSELS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Item_UOM_Mapping_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_ITEMS_ATTACHMENTS_FILE_CABINET_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_ITEMS_CATEGORY_SETTINGS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_JOB_ORDER_FREQUENCY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_LOGO_SETTINGS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MAN_VENDORS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_MESSAGES_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_MODULE_HD_LINK_SEQ", "Purchase")
                .StartsAt(16119999000183187)
                .HasMin(9999000000001);

            modelBuilder.HasSequence("SP_MONTH_END_ROB_APPROVAL_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTH_END_ROB_DT_REFERENCE_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTH_END_ROB_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTH_END_ROB_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTH_END_ROB_REVISIONS_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTH_END_ROB_REVISIONS_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTH_END_ROB_SUMMARY_DETAILS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_MONTH_END_ROB_SUMMARY_DT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_MONTH_END_ROB_SUMMARY_HISTORY_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_MONTHENDROB_LEAVE_BACKUP_USER_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_MONTHENDROB_LEAVE_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_PENDING_GRN_REMAINDER_HIST_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Physical_Invent_DT_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Physical_Invent_Hd_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_PO_Accrual_SEQ", "Purchase").StartsAt(100000);

            modelBuilder.HasSequence("SP_Po_Add_Amount_SEQ", "Purchase").StartsAt(105010);

            modelBuilder.HasSequence("SP_PO_CONFIRMATION_DT_SEQ", "Purchase").StartsAt(200008);

            modelBuilder.HasSequence("SP_Po_Confirmation_HD_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_PO_CORRECTIONS_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_PO_Delivery_Hist_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Po_Delivery_SEQ", "Purchase").StartsAt(271242);

            modelBuilder.HasSequence("SP_Po_DT_SEQ", "Purchase").StartsAt(296898);

            modelBuilder.HasSequence("SP_PO_Extension_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_PO_HD_ADD_INFO_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Po_Hd_SEQ", "Purchase").StartsAt(271704);

            modelBuilder.HasSequence("SP_Po_Hist_SEQ", "Purchase").StartsAt(273915);

            modelBuilder.HasSequence("SP_PO_IHM_DT_SEQ", "Purchase").StartsAt(10000);

            modelBuilder.HasSequence("SP_Po_Installment_SEQ", "Purchase").StartsAt(105024);

            modelBuilder.HasSequence("SP_Po_Issued_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_PO_ITEM_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_PO_LAST_NUMBER_GEN_SEQ", "Purchase").StartsAt(1001);

            modelBuilder.HasSequence("SP_PO_LOGISTICS_DT_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_PO_LOGISTICS_DT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_PO_LOGISTICS_HD_HIST_SEQ", "Purchase").StartsAt(99990000018504);

            modelBuilder.HasSequence("SP_PO_LOGISTICS_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_PO_LOGISTICS_QUEUE_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Po_Owner_Approval_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_PO_Reminder_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Po_Service_Det_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_PO_SPLIT_DETAILS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Po_Tracking_DT_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Po_Tracking_Hd_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_PO_VENDOR_AGREEMENTS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_PO_VESSEL_ALLOCATION_VESSEL_UNIQUE_ID_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_PO_VESSEL_ALLOCATION_WAREHOUSE_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_PO_VESSEL_ALLOCATION_WAREHOUSE_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_PURCHASE_USERS_SEQ", "Purchase").StartsAt(1001);

            modelBuilder.HasSequence("SP_Queue_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Quote_Add_Amounts_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Quote_Add_Amounts_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_QUOTE_COMPARISON_SETTINGS_seq", "Purchase").HasMax(99999999999999999);

            modelBuilder.HasSequence("SP_Quote_DT_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Quote_DT_seq", "Purchase").StartsAt(280986);

            modelBuilder.HasSequence("SP_Quote_HD_HIST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Quote_Hd_SEQ", "Purchase").StartsAt(510832);

            modelBuilder.HasSequence("SP_Quote_Hist_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Quote_Service_Estimate_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Quote_Service_Rates_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Reallocation_Hist_INV_Add_Amount_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Reallocation_Hist_INV_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Reallocation_Hist_INV_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_RECURRING_PO_DT_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_RECURRING_PO_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_RECURRING_PO_HIST_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Report_Parameter_SEQ", "Purchase")
                .StartsAt(849201)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("SP_REQ_CATEGORY_MAPPING_SEQ", "Purchase").StartsAt(2250000);

            modelBuilder.HasSequence("SP_REQ_ITEM_CATEGORY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_REQUESTED_ITEMS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Requisition_DT_SEQ", "Purchase").StartsAt(999900815857);

            modelBuilder.HasSequence("SP_Requisition_Hd_SEQ", "Purchase").StartsAt(99990005480865);

            modelBuilder.HasSequence("SP_Requisition_Hist_SEQ", "Purchase").StartsAt(105009);

            modelBuilder.HasSequence("SP_Requisition_Landing_SEQ", "Purchase").StartsAt(999900106324);

            modelBuilder.HasSequence("SP_Requisition_Ports_SEQ", "Purchase").StartsAt(999900109783);

            modelBuilder.HasSequence("SP_Requisition_Service_SEQ", "Purchase").StartsAt(999905189048);

            modelBuilder.HasSequence("SP_Requisition_Splits_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Requisition_Tag_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_RULE_CONFIG_REQ_MAPPING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_RULE_CONFIGURATION_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_RULE_CONFIGURATION_REQUISITION_MAPPING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_SMC_CONTACTS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Stock_SEQ", "Purchase").StartsAt(616225);

            modelBuilder.HasSequence("SP_STOCK_TAKING_PURCHASE_DT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_STOCK_TAKING_PURCHASE_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_TERMS_DT_SEQ", "Purchase").StartsAt(500);

            modelBuilder.HasSequence("SP_TERMS_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_TERMS_REQ_CATEGORY_SEQ", "Purchase").HasMax(999999999999999999);

            modelBuilder.HasSequence("SP_TERMS_VESSEL_DETAILS_SEQ", "Purchase").StartsAt(500);

            modelBuilder.HasSequence("SP_TRANSACTION_AGREEMENT_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_Transaction_DT_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_Transaction_Hd_SEQ", "Purchase").StartsAt(200009);

            modelBuilder.HasSequence("SP_TRANSACTION_STAGES_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_UOM_MISSING_ITEMS_TEMP_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_User_Entity_SEQ", "Purchase").StartsAt(105010);

            modelBuilder.HasSequence("SP_USER_FILTER_SETTINGS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_USER_TAB_SETTINGS_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Utility_Physical_Invent_DT_SEQ", "Purchase").StartsAt(100);

            modelBuilder.HasSequence("SP_Utility_Physical_Invent_Hd_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Utility_Stock_SEQ", "Purchase").StartsAt(500);

            modelBuilder.HasSequence("SP_VALIDATE_EVRY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Vendor_Bank_Details_SEQ", "Purchase").StartsAt(112451);

            modelBuilder.HasSequence("SP_VENDOR_CATEGORIES_ECONNECT_STAGING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_VENDOR_EVALUATION_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_VENDOR_INVOICE_TEMP_ATTACHMENTS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_VENDOR_INVOICE_TEMP_COMMENTS_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_VENDOR_PROFILE_REQUEST_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_VENDOR_TYPE_CONFIG_SEQ", "Purchase").StartsAt(1001);

            modelBuilder.HasSequence("SP_VendorExpenseDetails_History_ID_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_VESSEL_DEFAULT_ENTITY_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_VESSEL_DEPARTMENT_DET_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_VESSEL_ITEM_MAPPING_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_VESSEL_RULE_CONFIG_HD_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_VESSEL_RULE_CONFIG_MAPPING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("SP_WAREHOUSE_PO_VENDOR_PUR_SETT_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_WAREHOUSE_PO_VESSEL_PUR_SETT_HD_SEQ", "Purchase");

            modelBuilder.HasSequence("SP_Warehouse_Receipt_DT_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("SP_Warehouse_Receipt_Hd_SEQ", "Purchase").StartsAt(105008);

            modelBuilder.HasSequence("VESSEL_EQUIPMENT_MAPPING_SEQ", "Purchase").StartsAt(1000);

            modelBuilder.HasSequence("DM_ATTACHMENTS_SEQ", "QDMS");

            modelBuilder.HasSequence("Co_Parameters_SEQ", "Rep").StartsAt(31200336);

            modelBuilder.HasSequence("FM_FILE_DETAILS_SEQ", "Rep");

            modelBuilder.HasSequence("FM_FILE_TYPES_HD_SEQ", "Rep");

            modelBuilder.HasSequence("PR_REP_OUT_PACKET_DT_SEQ", "Rep");

            modelBuilder.HasSequence("PR_REP_OUT_PACKET_HD_SEQ", "Rep");

            modelBuilder.HasSequence("REP_BULK_COUNT_TABLES_SEQ", "Rep");

            modelBuilder.HasSequence("REP_Excluded_Columns_SEQ", "Rep").StartsAt(200001);

            modelBuilder.HasSequence("rep_packet_password_SEQ", "Rep").StartsAt(999900000000000);

            modelBuilder.HasSequence("rep_packet_password_Vessel_SEQ", "Rep").StartsAt(999900000000000);

            modelBuilder.HasSequence("REP_PASSWORD_KEY_OFFICE_SEQ", "Rep");

            modelBuilder.HasSequence("REP_PASSWORD_STATUS_SEQ", "Rep");

            modelBuilder.HasSequence("REP_PRIORITY_TABLE_SETTINGS_SEQ", "Rep");

            modelBuilder.HasSequence("REP_RSA_PASSWORD_VESSEL_SEQ", "Rep");

            modelBuilder.HasSequence("REP_Staging_Queue_Seq", "Rep").StartsAt(100979);

            modelBuilder.HasSequence("REP_TABLE_SETTINGS_SEQ", "Rep").StartsAt(113040);

            modelBuilder.HasSequence("REP_TRACKCHANGE_RECORDS_SEQ", "Rep");

            modelBuilder.HasSequence("REP_TRACKCHANGE_VESSELS_SEQ", "Rep");

            modelBuilder.HasSequence("SC_Alternate_Items_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Avg_Spoilage_Value_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Category_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Categorylog_SEQ", "SeaChef").StartsAt(101000);

            modelBuilder.HasSequence("SC_Consumption_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_CONSUMPTION_HD_HIST_SEQ", "SeaChef");

            modelBuilder.HasSequence("SC_Consumption_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Contracted_Price_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Contracted_Price_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Crew_Consumptions_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_CREW_DRAFT_CONSUMPTIONS_SEQ", "SeaChef");

            modelBuilder.HasSequence("SC_Ellog_SEQ", "SeaChef").StartsAt(113461);

            modelBuilder.HasSequence("SC_EVALUATION_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_EVALUATION_HD_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_FEEDBACK_ANSWERS_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_FEEDBACK_QUESTIONS_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_ITEM_NUTRITION_SEQ", "SeaChef").StartsAt(125150);

            modelBuilder.HasSequence("SC_LOCKING_SETTINGS_SEQ", "SeaChef");

            modelBuilder.HasSequence("SC_Manuals_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Meal_Report_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Meal_Report_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_Crew_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_DT_Item_Cons_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_DT_Items_Cons_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_DT_Items_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Menu_Plan_Requisitions_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Opening_Stock_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_PHYSICAL_BOND_DRAFT_DT_SEQ", "SeaChef");

            modelBuilder.HasSequence("SC_PHYSICAL_INVENT_DRAFT_DT_SEQ", "SeaChef");

            modelBuilder.HasSequence("SC_PHYSICAL_INVENT_DRAFT_HD_SEQ", "SeaChef");

            modelBuilder.HasSequence("SC_PHYSICAL_INVENT_DT_SEQ", "SeaChef").HasMax(9999999999999999);

            modelBuilder.HasSequence("SC_QUEUE_SEQ", "SeaChef").HasMax(999999999999999);

            modelBuilder.HasSequence("SC_Quote_Compare_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Quote_Compare_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Recipe_Nutrition_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Recipes_DT_Clobs_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Recipes_DT_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Recipes_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Report_Parameter_seq", "SeaChef").HasMax(999999999999999999);

            modelBuilder.HasSequence("SC_Stk_Spoilage_Reason_MF_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_TEMP_PRICE_DT_SEQ", "SeaChef").StartsAt(114601);

            modelBuilder.HasSequence("SC_Temp_Price_Hd_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("SC_Utility_Consumption_DT_SEQ", "SeaChef").StartsAt(10000);

            modelBuilder.HasSequence("SC_Utility_Consumption_hd_SEQ", "SeaChef").StartsAt(1000);

            modelBuilder.HasSequence("SC_Utility_Crew_Consumptions_SEQ", "SeaChef").StartsAt(500);

            modelBuilder.HasSequence("SC_Utility_Physical_Invent_DT_SEQ", "SeaChef").StartsAt(500);

            modelBuilder.HasSequence("SC_Victualling_MF_SEQ", "SeaChef").StartsAt(105000);

            modelBuilder.HasSequence("NB_ADMIN_STRUCTURE_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_ADMINSTRUCTURE_SEQ", "SUPERVISION").StartsAt(2);

            modelBuilder.HasSequence("NB_ATACHMENTS_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_DATA_RECORD_HD_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_DATA_RECORD_PROJECT_MAPPING_SEQ", "SUPERVISION").StartsAt(3);

            modelBuilder.HasSequence("NB_DATA_RECORD_TAB_DT_ROW_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_DATA_RECORD_TAB_DT_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_DATA_RECORD_TAB_DT_VALUE_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_DATA_RECORD_TAB_HD_DATA_SEQ", "SUPERVISION").StartsAt(2);

            modelBuilder.HasSequence("NB_DATA_RECORD_TAB_HD_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_DATA_RECORD_TAB_HD_VALUE_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_DATA_RECORD_TILE_HD_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_DATA_RECORD_TILE_MAPPING_SEQ", "SUPERVISION").StartsAt(5);

            modelBuilder.HasSequence("NB_DATA_RECORD_TILE_VIEW_DT_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_FILENAMING_CONVENTION_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_FILTER_HD_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_FILTER_MF_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_FORMAT_MF_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_GENERATE_REPORT_CONFIGURATION_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_GENERATE_REPORT_CONTENT_SETTINGS_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_GENERATE_REPORT_PROJECT_MAPPING_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_GROUP_HEADER_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_INTEGRATION_OBJECTS_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_ITEM_MASTER_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_MASTER_LIST_CONFIGURATION_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_MASTER_LIST_DT_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_MASTER_LIST_HD_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_NAMING_CONVENTION_MASTER_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_PAGEWISE_TILE_CONFIGURATION_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_PROJECT_OVERVIEW_CONFIGURATION_SEQ", "SUPERVISION").StartsAt(1000);

            modelBuilder.HasSequence("NB_PROJECT_PERSONAL_EMP_SEQ", "SUPERVISION").StartsAt(60000);

            modelBuilder.HasSequence("NB_PROJECT_PERSONAL_INITIAL_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_PROJECT_PERSONAL_OFF_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_PROJECT_SKETCH_LABEL_DT_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_REPORT_CUSTOM_TEXT_DT_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_REPORT_FILTER_MAPPING_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_REPORT_IMAGES_SEQ", "SUPERVISION").StartsAt(7);

            modelBuilder.HasSequence("NB_REPORT_MASTER_SEQ", "SUPERVISION");

            modelBuilder.HasSequence("NB_SKETCH_CONFIGURATION_SEQ", "SUPERVISION").StartsAt(300);

            modelBuilder.HasSequence("NB_TILE_CONFIGURATION_CELL_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_TILE_CONFIGURATION_COLUMN_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_TILE_CONFIGURATION_HD_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_TILE_CONFIGURATION_ROW_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("NB_TILE_MF_SEQ", "SUPERVISION").StartsAt(100);

            modelBuilder.HasSequence("Intro_Contents_SEQ", "Training")
                .StartsAt(93500)
                .IncrementsBy(40)
                .HasMin(29616);

            modelBuilder.HasSequence("Intro_Contents_Watched_Stats_SEQ", "Training");

            modelBuilder.HasSequence("TR_FEEDBACK_FORM_DT_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_FEEDBACK_FORM_HD_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Rank_Exam_Mapping_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_REPORT_PARAMETER_SEQ", "Training").StartsAt(116171);

            modelBuilder.HasSequence("TR_Training_Exam_SEQ", "Training")
                .StartsAt(10)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Exam_Users_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Exam_Videos_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_QA_Exam_DT_SEQ", "Training").StartsAt(1000);

            modelBuilder.HasSequence("TR_Training_QA_Results_DT_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_QA_Results_HD_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_QA_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_QA_Status_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Session_HD_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Session_Modules_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Session_Trainees_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Session_Trainers_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Video_Details_SEQ", "Training")
                .StartsAt(156141)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Video_Sub_Details_SEQ", "Training")
                .StartsAt(1000)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Video_Watched_Stats_SEQ", "Training").HasMax(999999999999999999);

            modelBuilder.HasSequence("TR_Training_Videos_SEQ", "Training")
                .StartsAt(113009)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("AUTO_TRIGGER_SEQ", "TRN").HasMin(1);

            modelBuilder.HasSequence("AUTO_TRIGGER_SERIES_NUM_SEQ", "TRN");

            modelBuilder.HasSequence("CADET_TRAINING_FILESHARING_ATTACHMENTS_SEQ", "TRN");

            modelBuilder.HasSequence("TITLE_CATEGORY_MAPPING_SEQ", "TRN").HasMin(1);

            modelBuilder.HasSequence("TITLE_HD_SEQ", "TRN")
                .StartsAt(525)
                .HasMin(1);

            modelBuilder.HasSequence("TOPIC_HD_VERSION_SEQ", "TRN");

            modelBuilder.HasSequence("TOPIC_TYPE_CATEGORY_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TOPICS_CATEGORY_MAPPING_SEQ", "TRN").HasMin(1);

            modelBuilder.HasSequence("TOPICS_CONTENT_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TOPICS_HD_SEQ", "TRN")
                .StartsAt(3678)
                .HasMin(1);

            modelBuilder.HasSequence("TOPICS_TITLE_MAPPING_SEQ", "TRN").HasMin(1);

            modelBuilder.HasSequence("TRAINEE_STATUS_LOOKUP_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINEE_TASK_CODE_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINEE_TASK_DOCUMENTS_FILESTREAM_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ALERT_FORWARDED_USERS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ALLOCATION_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ALLOCATION_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_APPLICATION_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_APPROVAL_CYCLE_HISTORY_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_APPROVAL_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_APPROVAL_PROJECT_RATING_QUESTIONS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_DOCUMENTS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_EXECUTION_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_EXECUTION_HD_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_EXECUTION_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_QUESTION_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_QUESTION_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_QUESTION_TOPIC_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_SET_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_SET_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ASSESSMENT_SET_TOPIC_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_ATTACHMENTS_SEQ", "TRN").StartsAt(2);

            modelBuilder.HasSequence("TRAINING_AUTO_TRIGGER_LOGS_HD_SEQ", "TRN").HasMin(1);

            modelBuilder.HasSequence("TRAINING_AUTO_TRIGGER_SETTINGS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_BLOCK_ADDITIONAL_DATA_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_CADET_TIME_SHEET_SUMMARY_DATA_SEQ", "TRN").HasMin(-9223372036854775807);

            modelBuilder.HasSequence("TRAINING_CATEGORY_DETAILS_SEQ", "TRN").StartsAt(1925);

            modelBuilder.HasSequence("TRAINING_CATEGORY_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_CATEGORY_PAGE_CONFIGURATION_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_COURSE_COMPLETION_HISTORY_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_LAST_ASSIGNED_TASK_RANGE_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PAGE_CONFIGURATION_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PARAMETER_SETTINGS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PRACTICAL_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PRACTICAL_EXECUTION_DT_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PRACTICAL_EXECUTION_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PRACTICAL_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PRACTICAL_TEST_DETAILS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PRACTICAL_USER_TEST_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PROGRAM_STATUS_HISTORY_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PROJECT_RATING_QUESTIONS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PROPERTY_ATTACHMENT_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PROPERTY_TOPIC_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_PROPERTY_VALUES_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_REQUIREMENT_TRIGGER_LOGS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_SCHEDULER_LOGS_HD_SEQ", "TRN").HasMin(1);

            modelBuilder.HasSequence("TRAINING_SLOT_AVAILABLE_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_SUBTASK_COMPLETED_DATE_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_SUBTITLE_LANG_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TASK_COMPLETION_DATE_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TASK_RANGE_LOOKUP_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TITLE_APPROVAL_DETAILS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TOPIC_ATTACHMENT_MAPPING_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TRAINEE_PROFILE_DETAILS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TRAINEE_PROFILE_PROGRAM_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TRAINEE_TASK_REMARKS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_TRAINIEE_REMARKS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_USER_ALERTS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_USER_EXECUTION_HISTORY_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_VIDEO_DETAILS_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_VIDEO_HD_SEQ", "TRN");

            modelBuilder.HasSequence("TRAINING_VIDEO_SUBTITLE_SEQ", "TRN");

            modelBuilder.HasSequence("VO_ACTIVITY_MASTER_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Alert_Acknowledgement_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_ALERT_AREA_DT_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_ALERT_AREA_HD_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_ALERT_USERS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_ARRIVAL_DEPARTURE_VERIFICATION_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_ATTACHMENT_FILESTREAM_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ATTACHMENTS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_BUNKER_ADDITIONAL_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("Vo_Bunker_Fuel_Analysis_Header_SEQ", "Voyage").StartsAt(2000);

            modelBuilder.HasSequence("Vo_Bunker_Fuel_Analysis_Logistics_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("Vo_Bunker_Fuel_Analysis_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_BUNKER_GOODS_RECEIPTS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_BUNKER_LOG_DT_AUDIT_V4_SEQ", "Voyage").StartsAt(12168);

            modelBuilder.HasSequence("VO_BUNKER_LOG_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_BUNKER_LOG_EVENTS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_BUNKER_LOG_HD_AUDIT_V4_SEQ", "Voyage").StartsAt(12168);

            modelBuilder.HasSequence("VO_BUNKER_LOG_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_BUNKER_SOUNDING_DT_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_BUNKER_SOUNDING_HD_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_BUNKER_SOUNDING_SUMMARY_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_BUNKER_STOCK_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_CARGO_BOG_CALCULATION_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_CARGO_BREAK_BULK_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_CARGO_LOG_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_CARGO_OPERATION_DT_AUDIT_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_CARGO_OPERATION_DT_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_CARGO_OPERATION_HD_AUDIT_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_CARGO_OPERATION_HD_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_CARGO_OPERATIONS_GSV_SEQ", "Voyage")
                .StartsAt(100)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_CARGO_PLAN_COMMODITY_SEQ", "Voyage")
                .StartsAt(8)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_CARGO_PLAN_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_CARGO_QUANTITY_SPLITUP_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_CARGO_TANK_LEVEL_PRODUCT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_CARGO_TANK_PRODUCT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_CARGO_TIME_SHEET_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_CARGOSPACE_MAPPING_CLIENT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Contract_Alert_Roles_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Contract_Alerts_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_COUNTER_MASTER_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_CP_VOYAGE_DETAILS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_CP_WARNINGS_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_CUSTOM_TEMPLATE_RPT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_DASHBOARD_SETTINGS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEBUNKER_STOCK_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_DEV_DOW_MASTER_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_ANALYSIS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_BASIC_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_BUNKER_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_DIS_CONS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_A_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_B_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_C_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_DEPR_B_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_PNTA_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_PNTB_DEPR_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_PNTB_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DEVIATION_POS_PNTC_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_ANALYSIS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_BASIC_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_BUNKER_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_DIS_CONS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_ENDED_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_ENDED_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_STARTED_ROB_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DOWNTIME_STARTED_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_DR_REPORT_MAIL_CONFIG_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_ENGINE_PERFORM_STD_DT_CLIENT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ENGINE_PERFORM_STD_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ENGINE_PERFORM_STD_HD_CLIENT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ENGINE_PERFORM_STD_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ENV_ACTIVITY_LOG_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_EQUIP_MEASURE_POINT_MAPPING_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Equipment_Attribute_SEQ", "Voyage")
                .StartsAt(100000)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<int>("VO_ESI_COLUMN_MAPPER_SEQ", "Voyage");

            modelBuilder.HasSequence<int>("VO_ESI_COLUMN_PROVIDER_MAPPING_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_EVENT_FILTER_SETTINGS_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_EVENT_ITEM_BREAKUP_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_EVENT_LOG_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_EVENT_LOG_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_EVENTS_VESSEL_TYPE_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_FTI_DT_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_FTI_ROB_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_FUEL_CONSUMPTION_LOG_MP_AUDIT_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_Fuel_Consumption_Log_mp_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_FUEL_TYPE_MF _SEQ", "Voyage");

            modelBuilder.HasSequence<decimal>("VO_FW_CONSUMPTION_LOG_SEQ", "Voyage")
                .StartsAt(7)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_GARBAGE_LOG_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_GARBAGE_TARGET_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Gases_Log_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Gases_Log_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Gases_Sub_Type_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Goods_Receipt_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Goods_Receipt_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_HULL_PROP_DT_EVENTS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_HULL_PROP_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_HULL_PROP_EVENT_MASTER_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_HULL_PROP_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ISSUE_STOCK_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ITEM_CONSUMPTION_BREAKUP_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_ITEM_CONSUMPTION_EXT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Item_Consumption_Log_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Item_Grades_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_KPI_DETAILS_SEQ", "Voyage")
                .StartsAt(100)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_LEG_DT_SEQ", "Voyage").StartsAt(11100);

            modelBuilder.HasSequence("VO_LNG_CARGO_BASIC_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LNG_CARGO_CALCULATION_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LNG_CARGO_COMPOSITION_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LNG_CARGO_PROPERTIES_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LOG_ADDITIONAL_MP_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LOG_BOOK_APPROVAL_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_LOG_BOOK_CONSUMPTION_DETAILS_VMRC_SEQ", "Voyage")
                .StartsAt(17003)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_LOG_BOOK_EXT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_LOG_BOOK_MACHINERY_DETAILS_VMRC_SEQ", "Voyage")
                .StartsAt(111)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("Vo_Log_Book_Positon_MP_SEQ", "Voyage")
                .StartsAt(111)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_LOG_BOOK_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LOG_COUNTERS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LOG_Notification_Attachments_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LOG_Notifications_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_LOG_VALIDATION_NOTIFICATIONS_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_LOG_VALIDATIONS_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_LOG_VERIFICATION_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_LOG_WARNINGS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_LOGBOOK_PERFORMANCE_SEQ", "Voyage");

            modelBuilder.HasSequence<decimal>("VO_MAIL_RECIPIENT_CONFIG_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_MAIL_TRACK_WAYPOINT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_MARPOL_LOG_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_MASTER_TEMPLATE_RPT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_MODCHECKS_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_NAVIGATOR_DATA_SEQ", "Voyage").StartsAt(105002);

            modelBuilder.HasSequence("Vo_Oil_Fields_Master_SEQ", "Voyage").StartsAt(991293321);

            modelBuilder.HasSequence<decimal>("VO_OPERATING_RANGE_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_OPERATIONAL_ALERT_ROLES_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_OTHER_ITEM_CONSUMPTION_HD_SEQ", "Voyage");

            modelBuilder.HasSequence<decimal>("VO_OtherItem_Consumption_Log_mp_SEQ", "Voyage")
                .StartsAt(9716)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PASSAGE_PLAN_HD_SEQ", "Voyage").StartsAt(11100);

            modelBuilder.HasSequence("VO_Passage_Plan_Log_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PASSAGE_WEATHER_LOG_MP_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PERF_CONFIG_DETAIL_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_CONFIG_DRAFT_SEQ", "Voyage")
                .StartsAt(40)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_CONFIG_SFOC_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_EQUIP_CONFIGURATION_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_EQUIPMENT_MP_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_PERF_EQUIPMENT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_MEASURE_POINT_CATEGORY_SEQ", "Voyage")
                .StartsAt(912)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_MEASURE_POINT_GROUP_SEQ", "Voyage")
                .StartsAt(119)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERF_MEASURE_POINT_SEQ", "Voyage")
                .StartsAt(599)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PERFORMANCE_LOG_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Physical_Inventory_Log_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_PHYSICAL_INVENTORY_TRACK_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PILOTAGE_LOG_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PLANNING_DETAILS_SEQ", "Voyage").StartsAt(11100);

            modelBuilder.HasSequence("VO_PLANNING_SEQ", "Voyage").StartsAt(11100);

            modelBuilder.HasSequence<decimal>("VO_PORT_ALERTS_ATTACHMENT_LINK_SEQ", "Voyage")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_PORT_ALERTS_SEQ", "Voyage")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_PORT_CALL_LOG_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PORT_CALL_LOG_EVENTS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PORT_CALL_LOG_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PORT_CALL_RESTRICTIONS_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_PORT_SERVICES_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PORT_SERVICES_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PORT_SERVICES_LINK_DT_SEQ", "Voyage").StartsAt(50);

            modelBuilder.HasSequence("VO_PORT_SERVICES_LOG_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_PORT_SERVICES_LOG_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VO_PORTCALL_WAYPOINT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_POWER_TABLE_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_REPORT_TYPE_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SDR_ADD_MATERIALS_DT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SDR_CREW_HOURS_DT_SEQ", "Voyage")
                .StartsAt(8)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SDR_DAMAGE_ITEM_DT_SEQ", "Voyage")
                .StartsAt(3007)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SDR_EXT_COMPANY_DT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SDR_STEVEDORE_DAMGE_HD_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_SHIFTING_EVENT_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_STEVEDORE_DAMGE_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Stock_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_STOCK_SPLITUP_SEQ", "Voyage").StartsAt(100);

            modelBuilder.HasSequence("VO_STOCK_TRANSFER_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_TANK_LEVEL_MAPPING_SEQ", "Voyage").StartsAt(1000);

            modelBuilder.HasSequence("VO_TANK_LEVEL_MEASUREMENT_AFTER_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_TANK_LEVEL_MEASUREMENT_BEFORE_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_TANK_LEVEL_TEMPERATURE_AFTER_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_TANK_LEVEL_TEMPERATURE_BEFORE_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_TANK_LEVEL_TEMPERATURE_MAPPING_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_TANK_MAPPING_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_Temp_Reporting_Frequency_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_Transaction_DT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Transaction_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_TRANSACTION_SPLITUP_AUDIT_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_TRANSACTION_SPLITUP_SEQ", "Voyage").StartsAt(233500005232);

            modelBuilder.HasSequence("VO_TUGS_LOG_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_USER_TEMPLATE_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VALIDATION_VESSEL_TYPE_SEQ", "Voyage");

            modelBuilder.HasSequence<decimal>("VO_VALIDATIONS_V4_CLIENTS_SEQ", "Voyage")
                .StartsAt(1000)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_VALIDATIONS_VESSELS_CLIENT_SEQ", "Voyage")
                .StartsAt(10)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence<decimal>("VO_VERIFICATION_FILESTREAM_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VERSION_TRACKER_SEQ", "Voyage");

            modelBuilder.HasSequence<decimal>("VO_VESSEL_ATTRIBUTES_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Vessel_Benchmark_HD_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Vessel_Benchmark_REF_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Vessel_Benchmark_SET_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Vessel_Employment_SEQ", "Voyage").StartsAt(11100);

            modelBuilder.HasSequence<decimal>("VO_VESSEL_EMPLOYMENT_TRIAL_DATA_SEQ", "Voyage")
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_Vessel_Equip_MP_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_VESSEL_PERF_MEASURE_POINT_DT_SEQ", "Voyage")
                .StartsAt(2412241200039280)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VESSEL_PERF_MEASURE_POINT_HD_SEQ", "Voyage")
                .StartsAt(2412241200001697)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VESSEL_POSITION_SEQ", "Voyage")
                .StartsAt(500)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VESSEL_VERSION_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VesselConfiguration_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_VO_SAMPLE_SEQ", "Voyage");

            modelBuilder.HasSequence("VO_VOYAGE_DETAILS_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Voyage_Events_Log_Mapping_1SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_Voyage_Events_Log_Mapping_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_VOYAGE_GASES_TYPE_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence("VO_VOYAGE_STATUS_SEQ", "Voyage").HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_VOYAGE_SUB_ACTIVITY_SEQ", "Voyage")
                .StartsAt(100)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VO_WAY_POINT_SEQ", "Voyage").StartsAt(1100);

            modelBuilder.HasSequence<decimal>("VOY_PERF_VAR_MAPPING_SEQ", "Voyage")
                .StartsAt(100)
                .HasMin(1)
                .HasMax(999999999999999999);

            modelBuilder.HasSequence("VR_WEEKLY_REPORT_ATTACHMENT_SEQ", "VR");

            modelBuilder.HasSequence("VR_WEEKLY_REPORT_COMMENT_DT_SEQ", "VR");

            modelBuilder.HasSequence("VR_WEEKLY_REPORT_COMMENT_HISTORY_SEQ", "VR");

            modelBuilder.HasSequence("VR_WEEKLY_REPORT_HD_SEQ", "VR");

            modelBuilder.HasSequence("VR_WEEKLY_REPORT_STATUS_LOG_SEQ", "VR");

            modelBuilder.HasSequence("COLLECTIONS_ATTACHMENTS_SEQ", "WIKI").StartsAt(111);

            modelBuilder.HasSequence("JV_COLLECTIONS_ATTACHMENTS_SEQ", "WIKIJV");

            modelBuilder.HasSequence("JV_COLLECTIONS_FILESTREAM_SEQ", "WIKIJV");

            modelBuilder.HasSequence("JV_COLLECTIONS_FILESTREAM1_SEQ", "WIKIJVS").StartsAt(1000);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
