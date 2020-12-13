namespace Game.Inventory
{
    public abstract class Cell
    {
        private IItemInventory item{get;set;}

        public abstract bool isFree{get;}

        public Cell(IItemInventory item)
        {
            this.item = item;
        }
    }
}