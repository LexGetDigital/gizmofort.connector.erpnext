/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.ScheduledJobType
{
    public partial class ERP_Core_ScheduledJobType : ERPNextObjectBase
    {
        public ERP_Core_ScheduledJobType() : this(new ERPObject(_DockType.Core_ScheduledJobType)) { }
        public ERP_Core_ScheduledJobType(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_ScheduledJobType>(propertyName);
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

        [Column("stopped")]
        public int Stopped
        {
            get { return data.stopped; }
            set { data.stopped = value; }
        }

        [Column("method")]
        public string? Method
        {
            get { return data.method; }
            set { data.method = value; }
        }

        [Column("server_script")]
        public string? ServerScript
        {
            get { return data.server_script; }
            set { data.server_script = value; }
        }

        [Column("frequency")]
        public string? Frequency
        {
            get { return data.frequency; }
            set { data.frequency = value; }
        }

        [Column("cron_format")]
        public string? CronFormat
        {
            get { return data.cron_format; }
            set { data.cron_format = value; }
        }

        [Column("create_log")]
        public int CreateLog
        {
            get { return data.create_log; }
            set { data.create_log = value; }
        }

        [Column("last_execution")]
        public DateTime? LastExecution
        {
            get { return data.last_execution; }
            set { data.last_execution = value; }
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

