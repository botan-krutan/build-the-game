using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{   
    public GameState gameState;
    public UnityEvent<GameState> OnStateChanged = new UnityEvent<GameState>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateState(GameState newState)
    {
        gameState = newState;
/*        switch (newState)
        {
            case GameState.ShowGoal:
                break;
            case GameState.BuildLevel:
                break;
            case GameState.Launch:
                break;
            case GameState.Win:
                break;
            case GameState.Loose:
                break;
            default:
                break;
        }*/
        OnStateChanged.Invoke(newState);
    }
    public enum GameState
    {
        ShowGoal,
        BuildLevel,
        Launch,
        Win, 
        Loose
    }
}
