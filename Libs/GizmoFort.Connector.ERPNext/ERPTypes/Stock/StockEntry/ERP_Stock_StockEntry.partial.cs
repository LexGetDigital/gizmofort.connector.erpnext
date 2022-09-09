/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.StockEntry
{
    public partial class ERP_Stock_StockEntry : ERPNextObjectBase
    {
        public ERP_Stock_StockEntry() : this(new ERPObject(_DockType.Stock_StockEntry)) { }
        public ERP_Stock_StockEntry(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_StockEntry>(propertyName);
        }

        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTime? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTime? Modified
        {
            get { return data.modified; }
            set { data.modified = value; }
        }

        [Column("modified_by")]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = value; }
        }

        [Column("owner")]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = value; }
        }

        [Column("docstatus")]
        public int Docstatus
        {
            get { return data.docstatus; }
            set { data.docstatus = value; }
        }

        [Column("idx")]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("stock_entry_type")]
        public string? StockEntryType
        {
            get { return data.stock_entry_type; }
            set { data.stock_entry_type = value; }
        }

        [Column("outgoing_stock_entry")]
        public string? OutgoingStockEntry
        {
            get { return data.outgoing_stock_entry; }
            set { data.outgoing_stock_entry = value; }
        }

        [Column("purpose")]
        public string? Purpose
        {
            get { return data.purpose; }
            set { data.purpose = value; }
        }

        [Column("add_to_transit")]
        public int AddToTransit
        {
            get { return data.add_to_transit; }
            set { data.add_to_transit = value; }
        }

        [Column("work_order")]
        public string? WorkOrder
        {
            get { return data.work_order; }
            set { data.work_order = value; }
        }

        [Column("purchase_order")]
        public string? PurchaseOrder
        {
            get { return data.purchase_order; }
            set { data.purchase_order = value; }
        }

        [Column("subcontracting_order")]
        public string? SubcontractingOrder
        {
            get { return data.subcontracting_order; }
            set { data.subcontracting_order = value; }
        }

        [Column("delivery_note_no")]
        public string? DeliveryNoteNo
        {
            get { return data.delivery_note_no; }
            set { data.delivery_note_no = value; }
        }

        [Column("sales_invoice_no")]
        public string? SalesInvoiceNo
        {
            get { return data.sales_invoice_no; }
            set { data.sales_invoice_no = value; }
        }

        [Column("pick_list")]
        public string? PickList
        {
            get { return data.pick_list; }
            set { data.pick_list = value; }
        }

        [Column("purchase_receipt_no")]
        public string? PurchaseReceiptNo
        {
            get { return data.purchase_receipt_no; }
            set { data.purchase_receipt_no = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("posting_time")]
        public TimeSpan? PostingTime
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        [Column("set_posting_time")]
        public int SetPostingTime
        {
            get { return data.set_posting_time; }
            set { data.set_posting_time = value; }
        }

        [Column("inspection_required")]
        public int InspectionRequired
        {
            get { return data.inspection_required; }
            set { data.inspection_required = value; }
        }

        [Column("from_bom")]
        public int FromBom
        {
            get { return data.from_bom; }
            set { data.from_bom = value; }
        }

        [Column("apply_putaway_rule")]
        public int ApplyPutawayRule
        {
            get { return data.apply_putaway_rule; }
            set { data.apply_putaway_rule = value; }
        }

        [Column("bom_no")]
        public string? BomNo
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        [Column("fg_completed_qty")]
        public decimal FgCompletedQty
        {
            get { return data.fg_completed_qty; }
            set { data.fg_completed_qty = value; }
        }

        [Column("use_multi_level_bom")]
        public int UseMultiLevelBom
        {
            get { return data.use_multi_level_bom; }
            set { data.use_multi_level_bom = value; }
        }

        [Column("from_warehouse")]
        public string? FromWarehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = value; }
        }

        [Column("source_warehouse_address")]
        public string? SourceWarehouseAddress
        {
            get { return data.source_warehouse_address; }
            set { data.source_warehouse_address = value; }
        }

        [Column("source_address_display")]
        public string? SourceAddressDisplay
        {
            get { return data.source_address_display; }
            set { data.source_address_display = value; }
        }

        [Column("to_warehouse")]
        public string? ToWarehouse
        {
            get { return data.to_warehouse; }
            set { data.to_warehouse = value; }
        }

        [Column("target_warehouse_address")]
        public string? TargetWarehouseAddress
        {
            get { return data.target_warehouse_address; }
            set { data.target_warehouse_address = value; }
        }

        [Column("target_address_display")]
        public string? TargetAddressDisplay
        {
            get { return data.target_address_display; }
            set { data.target_address_display = value; }
        }

        [Column("scan_barcode")]
        public string? ScanBarcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }

        [Column("total_outgoing_value")]
        public decimal TotalOutgoingValue
        {
            get { return data.total_outgoing_value; }
            set { data.total_outgoing_value = value; }
        }

        [Column("total_incoming_value")]
        public decimal TotalIncomingValue
        {
            get { return data.total_incoming_value; }
            set { data.total_incoming_value = value; }
        }

        [Column("value_difference")]
        public decimal ValueDifference
        {
            get { return data.value_difference; }
            set { data.value_difference = value; }
        }

        [Column("total_additional_costs")]
        public decimal TotalAdditionalCosts
        {
            get { return data.total_additional_costs; }
            set { data.total_additional_costs = value; }
        }

        [Column("supplier")]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        [Column("supplier_name")]
        public string? SupplierName
        {
            get { return data.supplier_name; }
            set { data.supplier_name = value; }
        }

        [Column("supplier_address")]
        public string? SupplierAddress
        {
            get { return data.supplier_address; }
            set { data.supplier_address = value; }
        }

        [Column("address_display")]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("select_print_heading")]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        [Column("letter_head")]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        [Column("is_opening")]
        public string? IsOpening
        {
            get { return data.is_opening; }
            set { data.is_opening = value; }
        }

        [Column("remarks")]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [Column("per_transferred")]
        public decimal PerTransferred
        {
            get { return data.per_transferred; }
            set { data.per_transferred = value; }
        }

        [Column("total_amount")]
        public decimal TotalAmount
        {
            get { return data.total_amount; }
            set { data.total_amount = value; }
        }

        [Column("job_card")]
        public string? JobCard
        {
            get { return data.job_card; }
            set { data.job_card = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("credit_note")]
        public string? CreditNote
        {
            get { return data.credit_note; }
            set { data.credit_note = value; }
        }

        [Column("is_return")]
        public int IsReturn
        {
            get { return data.is_return; }
            set { data.is_return = value; }
        }

        [Column("_user_tags")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [Column("_comments")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [Column("_assign")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [Column("_liked_by")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

