// Add in the imports here 



using System.Numerics;

namespace bookingsystem;


public class Room {


    // Add in the fields here 
    public int RoomNum { get; set; }
    public string? RoomType { get; set; }
    public double RoomPrice { get; set; }
    public bool Available { get; set; }
    public string RoomStatus { get; set; }
    // Add in the getter and setter methods here 

    // Add in the constructor here 
    public Room() {

        RoomNum = 0;
        RoomType = "single";
        RoomPrice = 0;
        Available = false;
        RoomStatus = "Ready";
    }

    // Add in the overloaded constructor here 
    public Room(int roomNum, string roomType, double roomPrice, bool avail, string roomStatus) {

        RoomNum = roomNum;
        RoomType = roomType;
        RoomPrice = roomPrice;
        Available = avail;
        RoomStatus = roomStatus;
    }


    // Add in the methods here 

    // Add in the calculate cost method here 
    public double CalculateCost(int nights) {


        double totalCost = nights * RoomPrice;

        return totalCost;

    }




    // Add in the check-in function here 
    public void ReserveRoom(string customerName, DateTime checkIN, DateTime checkout) {
        Available = false;
        RoomStatus = "Reserved";
        Console.WriteLine("the Room has just been Reserved");
    }


    // Add in a cancel room reservation here 
    public void CancelReservation() {

        Available = true;
        RoomStatus = "Ready";
        Console.WriteLine("Room Reservation has been canceled");

    }

    public void DisplayRoomDetails(){

        Console.WriteLine(RoomNum);
        Console.WriteLine(RoomPrice);
        Console.WriteLine(Available);

    }

// Add in the overloaded methods here 


}