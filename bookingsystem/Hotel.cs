namespace bookingsystem;

public class Hotel {

    // Add in the constructor here 
    public Hotel() {

        NumRooms = 200;
        PriceSeason = "Winter";
        IsOpen = true;
    }

    // Add in the overloaded constructor here 
    public Hotel(int numRooms, string priceSeason, bool isOpen) {

        this.NumRooms = numRooms;
        this.PriceSeason = priceSeason;
        this.IsOpen = isOpen;

    }
    int NumRooms { get; set; }
    string PriceSeason { get; set; }
    bool IsOpen { get; set; }
    
    
    public void CloseHotel() {

        Console.WriteLine("closing Hotel"); 
        IsOpen = false;
    }

    public void OpenHotel() {

        IsOpen = true;
        Console.WriteLine("Opening hotel"); 
        
    
    
    }


    public void ChangePriceSeason(){

        Console.WriteLine("Changing Season"); 
        
        PriceSeason = "Summer"; 
    }
    
    // Add in a method to instantiate all the rooms in the Hotel here 
    Room [] rooms = new Room [200];
    Random random = new Random();
    
    
    public Room [] CreateRooms(){
    
    
    for (int i = 0; i < rooms.Length; i++)
{
   rooms [i] = new Room ();
( (Room) rooms [i]).RoomNum = random.Next (100, 500); // Random number between 100 and 500
( (Room) rooms [i]).RoomType = random.Next (1, 4) == 1 ? "Single" : "Double"; // Random type
( (Room) rooms [i]).RoomPrice = random.Next (50, 150);  // Random price between 50 and 150
}

        return rooms; 
    }
}