namespace Engine
{
    public class Apple : ICountable
    {
        public string Colour { get; set; }
        public int Count()
        {
            return 1;
        }
    }
}
