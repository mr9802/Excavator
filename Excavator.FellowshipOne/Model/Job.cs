//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Excavator.F1.Model
{
    using System;
    using System.Collections.Generic;

    public partial class Job
    {
        public Nullable<int> Job_ID { get; set; }

        public Nullable<int> Ministry_ID { get; set; }

        public Nullable<int> Activity_ID { get; set; }

        public string Job_Title { get; set; }

        public string Job_Description { get; set; }

        public Nullable<bool> DYD_Enabled { get; set; }

        public string Position_Contact { get; set; }

        public string Gender { get; set; }

        public string Marital_Status { get; set; }

        public Nullable<int> Reports_To_Individual { get; set; }

        public string Ministry_Purpose { get; set; }

        public string Requirements { get; set; }

        public string Training_Requirements { get; set; }

        public string Time_Commitment_Required { get; set; }

        public Nullable<byte> Christian_Maturity_Required { get; set; }

        public string Comments { get; set; }

        public Nullable<int> Minimum_Age { get; set; }

        public Nullable<System.DateTime> Created_Date { get; set; }

        public Nullable<System.DateTime> Last_Updated_Date { get; set; }

        public Nullable<int> Contact_Individual_ID { get; set; }

        public Nullable<int> Reports_To_Individual_ID { get; set; }

        public Nullable<int> Maximum_Age { get; set; }

        public Nullable<bool> Is_Active { get; set; }
    }
}
