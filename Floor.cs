namespace CodeAlong3
{
    internal class Floor
    {
        public List<Room> Rooms { get; set; }

        public Floor()
        {
            Rooms = [];
        }

        public void AddRoom(Room room)
        {
            if ((room.Type == "kitchen" || room.Type == "bathroom" || room.Type == "livingroom"))
            {
                if (room.Type == "livingroom") Rooms.Add(room);
                else if (!Rooms.Any(r => r.Type == room.Type)) Rooms.Add(room);
                else Console.WriteLine("Cannot add room. Please enter a different room type.");
            }
            else
            {
                Console.WriteLine("Cannot add room. Please enter a different room type.");
            }
        }
    }
}
