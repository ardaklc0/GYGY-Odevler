double basePrice = 1235.65;

Customer ARDA_KILIC = new Customer { Name = "Arda", Surname = "Kılıç", ChoosenRoom = new King() };
Customer ASLAN_KILIC = new Customer { Name = "Aslan", Surname = "Kılıç", ChoosenRoom = new Deluxe() };

RoomManager roomManager_ASLAN_KILIC = new RoomManager() { Customer = ASLAN_KILIC };
RoomManager roomManager_ARDA_KILIC = new RoomManager() { Customer = ARDA_KILIC };

double occupiedPrice_ARDA_KILIC = roomManager_ARDA_KILIC.GetCheckOutBill(basePrice, 13);
double occupiedPrice_ASLAN_KILIC = roomManager_ASLAN_KILIC.GetCheckOutBill(basePrice, 13);
Console.WriteLine(occupiedPrice_ARDA_KILIC);
Console.WriteLine(occupiedPrice_ASLAN_KILIC);





public interface IHotelRoom
{
    public double Bill(double basePrice);
}

public class Standart : IHotelRoom
{
    public double Bill(double basePrice)
    {
        return basePrice;
    }
}

public class Deluxe : IHotelRoom
{
    public double Bill(double basePrice)
    {
        return basePrice * 1.1;
    }
}

public class Suite : IHotelRoom
{
    public double Bill(double basePrice)
    {
        return basePrice * 1.5;
    }
}

public class King : IHotelRoom
{
    public double Bill(double basePrice)
    {
        return basePrice * 2.5;
    }
}

public class Customer
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public IHotelRoom ChoosenRoom { get; set; }
}


public class RoomManager
{
    public Customer Customer { get; set; }

    public double GetCheckOutBill(double basePrice, int occupiedDays)
    {
        return Customer.ChoosenRoom.Bill(basePrice) * occupiedDays;
    }
}