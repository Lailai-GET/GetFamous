namespace GetFamous
{
    public class Star
    {
        public string StarName { get; private set; }
        public List<Sheeple> Sheeples { get; private set; }
        public int Funds { get; private set; }

        public Star(string starName, List<Sheeple> sheeples, int funds)
        {
            StarName = starName;
            Sheeples = sheeples;
            this.Funds = funds;
        }
    }
}
