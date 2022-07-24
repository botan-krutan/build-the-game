using UnityEngine;

public class GoButton : MonoBehaviour
{
    public void OnButtonPress()
    {   
        FindObjectOfType<GameManager>().UpdateState(GameManager.GameState.Launch);
        foreach(var draggable in GameObject.FindGameObjectsWithTag("Draggable"))
        {
            draggable.tag = "Undraggable";
        }
    }
}
