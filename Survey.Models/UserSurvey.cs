//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Survey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSurvey
    {
        public int UserId { get; set; }
        public int SurveyCourseId { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> DateOfEvent { get; set; }
    
        public virtual SurveyCours SurveyCours { get; set; }
        public virtual User User { get; set; }
    }
}