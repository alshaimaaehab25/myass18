using System;
using UnityEngine;



    // GameContainer<T> class that stores a single item of any type
    public class GameContainer<T>
    {
        private T item; // Variable to hold the item

        // Method to save an item in the GameContainer
        public void SetItem(T item)
        {
            this.item = item;
        }

        // Method to return the saved item
        public T GetItem()
        {
            return item;
        }
    }

    // GameUtils class with a static method to describe the item
    public static class GameUtils
    {
        // Static method to describe an item
        public static string DescribeItem<T>(T something)
        {
            return $"This item is {something.ToString()}";
        }
    }

    // MonoBehaviour class for testing the generics functionality in Unity
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            // Create a GameContainer for a string and store a "Healing Potion"
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");

            // Log the saved item
            Debug.Log("Stored item: " + gameContainer.GetItem());

            // Describe the item using the DescribeItem method
            string description = GameUtils.DescribeItem(gameContainer.GetItem());
            Debug.Log(description);
        }
    }

