//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatfield.EnviroData.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfileResult
    {
        public ProfileResult()
        {
            this.ProfileResultValues = new HashSet<ProfileResultValue>();
        }
    
        public long ResultID { get; set; }
        public Nullable<double> XLocation { get; set; }
        public Nullable<int> XLocationUnitsID { get; set; }
        public Nullable<double> YLocation { get; set; }
        public Nullable<int> YLocationUnitsID { get; set; }
        public Nullable<int> SpatialReferenceID { get; set; }
        public Nullable<double> IntendedZSpacing { get; set; }
        public Nullable<int> IntendedZSpacingUnitsID { get; set; }
        public Nullable<double> IntendedTimeSpacing { get; set; }
        public Nullable<int> IntendedTimeSpacingUnitsID { get; set; }
        public string AggregationStatisticCV { get; set; }
    
        public virtual Unit Unit { get; set; }
        public virtual Result Result { get; set; }
        public virtual SpatialReference SpatialReference { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual Unit Unit2 { get; set; }
        public virtual Unit Unit3 { get; set; }
        public virtual ICollection<ProfileResultValue> ProfileResultValues { get; set; }
    }
}
