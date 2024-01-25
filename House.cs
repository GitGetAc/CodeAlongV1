namespace CodeAlong3
{
    internal class House
    {
        public List<Floor> Floors { get; set; }

        public House()
        {
            Floors = [];
        }

        public void AddFloor(Floor floor)
        { 
           Floors.Add(floor);
        }

        public void PrintOutHouse() 
        {
            for (int i = 0; i < Floors.Count; i++)
            {
                Console.WriteLine($"Floor {i + 1}:");

                foreach (Room r in Floors[i].Rooms)
                {
                    Console.WriteLine(r.Type);
                }
            }
        }
    }
}
