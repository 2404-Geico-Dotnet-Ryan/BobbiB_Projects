class Sale
{
    public int LotNumber { get; set; }  //links to LotNumber in Lots.cs; required
    public int SaleId { get; set; }  //add ID generator; required
    public double AcquiredPrice { get; set; } // required
    public DateTime AcquiredDate { get; set; } // required
    public double ListedPrice { get; set; } // optional
    public DateTime ListedDate { get; set; } // required if ListedPrice is provided
    public double SoldPrice { get; set; } // optional
    public DateTime SoldDate { get; set; } // required if SoldPrice is provided
    public string Status { get; set; } // list of options; required
    public DateTime StatusDate { get; set; } // creation time stamp added with each update; required

    public Sale(int lotNumber, double acquiredPrice, DateTime acquiredDate, double listedPrice, DateTime listedDate, double soldPrice, DateTime soldDate, string status, DateTime statusDate)
    {
        LotNumber = lotNumber;  
        AcquiredPrice = acquiredPrice;
        AcquiredDate = acquiredDate;
        ListedPrice = listedPrice;
        ListedDate = listedDate;
        SoldPrice = soldPrice;
        SoldDate = soldDate;
        Status = status;
        StatusDate = statusDate;
    }

    public override string ToString()
    {
        return $"Lot Number: {LotNumber}\nAcquired Price: {AcquiredPrice}\nAcquired Date: {AcquiredDate}\nListed Price: {ListedPrice}\nListed Date: {ListedDate}\nSold Price: {SoldPrice}\nSold Date: {SoldDate}\nStatus: {Status}\nStatus Date: {StatusDate}";
    }
}