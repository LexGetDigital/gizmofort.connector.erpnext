/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/11/2022 7:52:10 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.Budget
{
    public partial class ERP_Accounts_Budget : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_Budget() : this(new ERPObject(_DockType.Accounts_Budget)) { }
        public ERP_Accounts_Budget(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_Budget>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_Budget>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_Budget>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_Budget? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_Budget>(json: json);
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

        [Column("budget_against")]
        public string? BudgetAgainst
        {
            get { return data.budget_against; }
            set { data.budget_against = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("fiscal_year")]
        public string? FiscalYear
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        [Column("monthly_distribution")]
        public string? MonthlyDistribution
        {
            get { return data.monthly_distribution; }
            set { data.monthly_distribution = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("applicable_on_material_request")]
        public int ApplicableOnMaterialRequest
        {
            get { return data.applicable_on_material_request; }
            set { data.applicable_on_material_request = value; }
        }

        [Column("action_if_annual_budget_exceeded_on_mr")]
        public string? ActionIfAnnualBudgetExceededOnMr
        {
            get { return data.action_if_annual_budget_exceeded_on_mr; }
            set { data.action_if_annual_budget_exceeded_on_mr = value; }
        }

        [Column("action_if_accumulated_monthly_budget_exceeded_on_mr")]
        public string? ActionIfAccumulatedMonthlyBudgetExceededOnMr
        {
            get { return data.action_if_accumulated_monthly_budget_exceeded_on_mr; }
            set { data.action_if_accumulated_monthly_budget_exceeded_on_mr = value; }
        }

        [Column("applicable_on_purchase_order")]
        public int ApplicableOnPurchaseOrder
        {
            get { return data.applicable_on_purchase_order; }
            set { data.applicable_on_purchase_order = value; }
        }

        [Column("action_if_annual_budget_exceeded_on_po")]
        public string? ActionIfAnnualBudgetExceededOnPo
        {
            get { return data.action_if_annual_budget_exceeded_on_po; }
            set { data.action_if_annual_budget_exceeded_on_po = value; }
        }

        [Column("action_if_accumulated_monthly_budget_exceeded_on_po")]
        public string? ActionIfAccumulatedMonthlyBudgetExceededOnPo
        {
            get { return data.action_if_accumulated_monthly_budget_exceeded_on_po; }
            set { data.action_if_accumulated_monthly_budget_exceeded_on_po = value; }
        }

        [Column("applicable_on_booking_actual_expenses")]
        public int ApplicableOnBookingActualExpenses
        {
            get { return data.applicable_on_booking_actual_expenses; }
            set { data.applicable_on_booking_actual_expenses = value; }
        }

        [Column("action_if_annual_budget_exceeded")]
        public string? ActionIfAnnualBudgetExceeded
        {
            get { return data.action_if_annual_budget_exceeded; }
            set { data.action_if_annual_budget_exceeded = value; }
        }

        [Column("action_if_accumulated_monthly_budget_exceeded")]
        public string? ActionIfAccumulatedMonthlyBudgetExceeded
        {
            get { return data.action_if_accumulated_monthly_budget_exceeded; }
            set { data.action_if_accumulated_monthly_budget_exceeded = value; }
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

