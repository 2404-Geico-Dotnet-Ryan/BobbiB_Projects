class Customer
{
    public int CustomerId { get; set; }  //add ID generator
    public string FirstName { get; set; }  // Can first and last name be combined into one field?
    public string LastName { get; set; }
    public string AddressStreet { get; set; }  // Can address be combined into one field?
    public string AddressCity { get; set; }   //add validation for city i.e. must contain letters
    public string AddressState { get; set; }    //add validation for state i.e. must contain 2 letters
    public string AddressZip { get; set; }  //add validation for zip code i.e. must contain 5 digits
    public string PhoneNumber { get; set; } //add validation for phone number i.e. must contain 10 digits
    public string Email { get; set; }  //add validation for email i.e. must contain @ and .
    public int[] RelatedLotNumber { get; set; } // should this be a list?
    public string Status { get; set; }  //should this be an enum?
    public DateTime StatusDate { get; set; }  //add creation time stamp process for this field


    public Customer(int customerId, string lastName, string firstName,string street, string city, string state, string zip, string phoneNumber, string email, int[] relatedLotNumber, string status, DateTime statusDate)
    {
        CustomerId = customerId;
        LastName = lastName;
        FirstName = firstName;
        AddressStreet = street;
        AddressCity = city;
        AddressState = state;
        AddressZip = zip;
        PhoneNumber = phoneNumber;
        Email = email;
        RelatedLotNumber = relatedLotNumber;
        Status = status;
        StatusDate = statusDate;
    }

    public override string ToString()
    {
        return $"Customer ID: {CustomerId}\nName: {FirstName} {LastName}\nAddress: {AddressStreet}, {AddressCity}, {AddressState} {AddressZip}\nPhone Number: {PhoneNumber}\nEmail: {Email}\nRelated Lot Number: {RelatedLotNumber}\nStatus: {Status}\nStatus Date: {StatusDate}";
    }
}

/*
- Customer ID - Unique Key
- Name - First, Last
- Address
- Phone Number  
- Email
- Related Lot Number 
    - allow for multiples
- Related Customer ID
    - allow for multiples
- Status: Interest, No Interest, Holding Lot(s), Purchased Lot(s)
- Statue Date (YYYY/MM/DD)
*/