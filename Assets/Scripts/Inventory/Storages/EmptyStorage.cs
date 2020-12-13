using UnityEngine;

namespace Game.Inventory.Storages
{
    public class EmptyStorage : Storage
    {
        public EmptyStorage(int countCell) : base(countCell)
        {
        }

        protected override Cell CreateCell()
        {
            return new Cells.FreeCell();
        }

        protected override Cell CreateOccupiedCell(IItemInventory item)
        {
            return new Cells.OccupiedСell(item);
        }
    }
}