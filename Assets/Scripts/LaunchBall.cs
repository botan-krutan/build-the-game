using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<GameManager>().OnStateChanged.AddListener(Unfreeze);
    }
    void Unfreeze(GameManager.GameState state)
    {   
        if(state == GameManager.GameState.Launch)
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
        }
        
    }
}
