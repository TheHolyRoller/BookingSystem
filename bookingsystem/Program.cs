
using bookingsystem;

Console.WriteLine("Dear Esteemed Guest Would you like to Check-in?");

string input = Console.ReadLine();

// Create the id Tracker variable here 
int customerID = 0; 

if (input == "yes")
{

    // Instantiate the Hotel Class here 

    Hotel newHotel = new Hotel(200, "Winter", true);


    // Now instantiate the room classes. 
    Room[] rooms = newHotel.CreateRooms();
    
    Console.WriteLine("this is the rooms array" + rooms);

    Room guestRoom;

    // Instantiate the Customer class here 
    Customer customer = new Customer(customerID++, false, false); 
    
    Console.WriteLine("What type of Room would you Like?");
    string roomInputType = Console.ReadLine();
    
    
     Room findRoom(string roomInputType){
        
        if (roomInputType == "double")
    {

        Console.WriteLine("Excellent Choice");
        
        for (int i = 0; i < rooms.Length; i++)
        {

            if (rooms[i].RoomType == "double")
            {
                    return rooms[i];
            }
            
        }

            return null; 

    }
     else if (roomInputType == "single")
    {

        Console.WriteLine("Excellent Choice");
        // Now search for a single room 

        for (int i = 0; i < rooms.Length; i++)
        {

            if (rooms[i].RoomType == "single")
            {
                    return rooms[i];

            }

        }

            return null; 
    }
    
     else
    {
        // Default case: throw an exception or return a default value
        return null;
        throw new ArgumentException("Invalid room type");
        // Or
    }
    
    }


    guestRoom = findRoom(roomInputType);

    Console.WriteLine("this is the guest room" + guestRoom); 
    
    
    if(guestRoom != null){


        // Call the methods on guest room
        guestRoom.ReserveRoom();
        guestRoom.DisplayRoomDetails();


        // Now ask the user how many nights they want to stay for 
        Console.WriteLine("How many nights would you like to stay for?");
        string numberOfNights = Console.ReadLine(); 
        
        // Convert the string to a number here 
        // string s = "2";
int convertedNights = System.Convert.ToInt32(numberOfNights); // i will be 2
        Console.WriteLine("THIS IS THE NUMBER OF NIGHTS INPUT" + numberOfNights); 
        

        // Calculate the cost here 
      double totalCost = guestRoom.CalculateCost(convertedNights);

        Console.WriteLine("this is the total cost" + totalCost); 
        

        customer.PayInvoice();
        customer.CheckIN(); 

    }
    else{

        Console.WriteLine("Sorry this didn't work out");
    
    }
    
}
