namespace Game.Inventory.Cells
{
    public class FreeCell : Cell
    {
        public override bool isFree => true;

        public FreeCell()
            : base(new DefaultItems.NullItem()) 
        {

        }
    }
}