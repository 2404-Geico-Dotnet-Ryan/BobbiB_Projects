class Lots  
{
    public int LotNumber { get; set; }  // freeform but need to verify it is unique; required
    public string Address { get; set; } // break into street, city, state, zip?; required
    public string Neighborhood { get; set; }  // required
    public double LotSizeAcres { get; set; } // required if lot size is not in feet
    public double LotSizeFeet { get; set; } // required if lot size is not in acres
    public string Description { get; set; } // should be a list of options; not required


    public Lots(int lotNumber, string address, string neighborhood, double lotSizeAcres, double lotSizeFeet, string description)
    {
        LotNumber = lotNumber;
        Address = address;
        Neighborhood = neighborhood;
        LotSizeAcres = lotSizeAcres;
        LotSizeFeet = lotSizeFeet;
        Description = description;
    }

    public override string ToString()
    {
        return $"Lot Number: {LotNumber}\nAddress: {Address}\nNeighborhood: {Neighborhood}\nLot Size (acres): {LotSizeAcres}\nLot Size (feet): {LotSizeFeet}\nDescription: {Description}";
    }
}    

/*
- Lot Number - Unique Key
- Location Information
    - Address   
    - Neighborhood  
- Lot Size 
    - acres     
    - feet
- Description of property
    - options like "wooded", "cleared", "corner", "hillside"
- Acquired Price 
- Acquired Date (YYYY/MM/DD)
- Listed Price
- Listed Date (YYYY/MM/DD)
- Sold Price
- Sold Date (YYYY/MM/DD)
- Status: Available, Hold, Pending Sale, Sold
- Status Date (YYYY/MM/DD)
*/