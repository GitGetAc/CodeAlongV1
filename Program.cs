namespace CodeAlong3
{
    internal class Program
    {
        static void Main()
        {
            House house = new();
            Floor currentFloor = new();

            Console.Write("Enter how many floors do you want to have: ");
            int FloorNumber = Convert.ToUInt16(Console.ReadLine());

            while (house.Floors.Count < FloorNumber)
            {
                Console.Write("Enter room type 'kitchen' 'bathroom' 'livingroom': ");
                string roomType = Console.ReadLine()!;

                currentFloor.AddRoom(new Room(roomType));

                if (currentFloor.Rooms.Count == 5)
                {
                    house.AddFloor(currentFloor);
                    currentFloor = new();
                }
            }
            house.PrintOutHouse();
        }
    }
}
