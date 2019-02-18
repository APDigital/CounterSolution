namespace Engine
{
    public class Orange : ICountable
    {
        public string Size { get; set; }
        public int Count()
        {
            return 2;
        }
    }
}
