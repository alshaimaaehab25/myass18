using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory inventory1, Inventory inventory2)
        {
            Inventory combinedInventory = new Inventory();

            foreach (var item in inventory1.items)
            {
                combinedInventory.AddItem(item);
            }

            foreach (var item in inventory2.items)
            {
                combinedInventory.AddItem(item);
            }

            return combinedInventory;
        }
    }
}
