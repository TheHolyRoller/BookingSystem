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


    // Add in the overloaded constructor here 
    public Customer(int customerID, bool checkedIN, bool paid) {

        this.CustomerID = customerID;
        this.CheckedIN = checkedIN;
        this.Paid = paid;

    }


    // Add in the methods here 

    // Add in a check in method here 

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


        // Set the Invoice to paid here 

        Paid = true;
        Console.WriteLine("The room has been paid for"); 
        
        
}



}

