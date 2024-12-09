using UnityEngine;

namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");
            Debug.Log("Stored item: " + gameContainer.GetItem());
            string description = GameUtils.DescribeItem(gameContainer.GetItem());
            Debug.Log(description);
        }
    }
}

