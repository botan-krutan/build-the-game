using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    [SerializeField] GameObject _ballPrefab;
    [SerializeField] Vector2 _spawnLocation;
    [SerializeField] GameObject _goButton;
    public void OnGoButtonPress()
    {
        GameObject ball = Instantiate(_ballPrefab, _spawnLocation, Quaternion.Euler(0,0,0));
        Camera.main.GetComponent<FollowBall>()._ballTransform = ball.transform;
        GameObject[] draggables = GameObject.FindGameObjectsWithTag("Draggable");
        foreach(var draggable in draggables)
        {
            draggable.tag = "Undraggable";
        }
        _goButton.SetActive(false);
    }
}
