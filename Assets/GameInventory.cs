using UnityEngine;

namespace Assignment18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory potionsInventory = new Inventory();
            potionsInventory.AddItem("Healing Potion");
            potionsInventory.AddItem("Strength Potion");

            Inventory elixirsInventory = new Inventory();
            elixirsInventory.AddItem("Elixir");
            elixirsInventory.AddItem("Dark Elixir");

            Inventory combinedInventory = potionsInventory + elixirsInventory;
            combinedInventory.ShowItems();
        }
    }
}
