using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Inventory
{
    public abstract class Storage
    {
        private Cell[] cells;

        public Storage(int countCell)
        {
            cells = new Cell[countCell];
            for(int i = 0; i < cells.Length; i++)
            {
                cells[i] = CreateCell();
            }
        }

        protected abstract Cell CreateCell();
        protected abstract Cell CreateOccupiedCell(IItemInventory item);

        public bool AddItem(IItemInventory item)
        {
            for(int i = 0; i < cells.Length;i++)
            {
                if(cells[i].isFree)
                {
                    cells[i] = CreateOccupiedCell(item);
                    return true;
                }
            }
            return false;
        }
    }
}