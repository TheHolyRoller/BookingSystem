namespace bookingsystem;

public class Customer {

    // Add in the fields here 
    public int CustomerID { get; set; }
    public bool CheckedIN { get; set; }
    public bool Paid { get; set; }


    // Add in the constructor here 
    public Customer() {

        CustomerID = 0;
        CheckedIN = false;
        Paid = false;
    }
    
    public Customer(int customerID, bool checkedIN, bool paid) {

        this.CustomerID = customerID;
        this.CheckedIN = checkedIN;
        this.Paid = paid;
        
    }
    
    public void CheckIN(){

        CheckedIN = true;
        Console.WriteLine("You have checked IN!"); 
    }
    
    public void CheckOUT(){

        CheckedIN = false;
        Console.WriteLine("You have checked out"); 
    
    }



// Add in a has paid method here 
public void PayInvoice(){
        
        Paid = true;
        Console.WriteLine("The room has been paid for"); 
}

}

