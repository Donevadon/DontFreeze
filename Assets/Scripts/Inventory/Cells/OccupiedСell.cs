namespace Game.Inventory.Cells
{
    public class OccupiedСell : Cell
    {
        public override bool isFree => false;

        public OccupiedСell(IItemInventory item)
            : base(item)
        {
            
        }
    }
}