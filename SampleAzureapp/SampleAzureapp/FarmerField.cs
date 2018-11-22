using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAzureapp
{
    public class FarmerField
    {
        public int FarmerFieldID { get; set; }
        public int FarmerID { get; set; }
        public string FieldName { get; set; }
        public Nullable<bool> WaypointsAvl { get; set; }
        public Nullable<decimal> NearestRoadwayLat { get; set; }
        public Nullable<decimal> NearestRoadwayLong { get; set; }
        public Nullable<decimal> TruckRate { get; set; }
        public string FieldStatus { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string AS400_ID { get; set; }
        public string FieldLat { get; set; }
        public string FieldLong { get; set; }
        public Nullable<bool> IsDelayed { get; set; }
        public string ColorCode { get; set; }
        public Nullable<System.TimeSpan> TripIntervalTime { get; set; }
    }
}
