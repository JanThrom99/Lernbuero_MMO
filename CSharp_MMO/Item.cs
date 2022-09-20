namespace CSharp_MMO
{
    public class Item
    {
        public string KindOfItem;
        public string Name;
        public int Cost;
        public int Amount;

        public Item(string kindOfItem, string name, int cost, int amount)
        {
            this.KindOfItem = kindOfItem;
            this.Name = name;
            this.Cost = cost;
            this.Amount = amount;
        }

        public void ReduceAmount()
        {
            this.Amount-=1;
        }
        public void IncreaseAmount()
        {
            this.Amount -= 1;
        }
    }
}