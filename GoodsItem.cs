namespace VendingMachine
{
    public class GoodsItem
    {
        public string ItemName { get; private set; }
        public int ItemPrice { get; set; }
        public int ItemInventory { get; private set; }

        public GoodsItem(string itemName, int itemPrice, int itemInventory)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
            ItemInventory = itemInventory;
        }
    }
}