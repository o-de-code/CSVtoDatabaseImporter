namespace CSVtoDatabaseImporter.Models
{
    class SampleCabData
    {
        public int Id { get; set; }
        public DateTime tpep_pickup_datetime { get; set; }
        public DateTime tpep_dropoff_datetime { get; set; }
        public int passenger_count { get; set; }
        public double trip_distance { get; set; }
        public string store_and_fwd_flag { get; set; } = string.Empty;
        public int PULocationID { get; set; }
        public int DOLocationID { get; set; }
        public int fare_amount { get; set; }
        public double tip_amount { get; set; }
    }
    
}
