using UnityEngine;
using DG.Tweening;
public class FollowBall : MonoBehaviour
{
    public Transform _ballTransform;
    Vector2 _goal;
    float _zPos;

    private void Start()
    {
        _zPos = transform.position.z;
        _goal = GameObject.FindGameObjectWithTag("Goal").transform.position;

        transform.DOMove(new Vector3(_goal.x, _goal.y, _zPos), 2).OnComplete(() => 
        {
            transform.DOMove(new Vector3(_ballTransform.position.x, _ballTransform.position.y, _zPos), 1).OnComplete(() =>
            {
                transform.DOMove(new Vector3(0, 0, _zPos), 1).OnComplete(() =>
                {
                    FindObjectOfType<GameManager>().UpdateState(GameManager.GameState.BuildLevel);
                });
                
            });
        });
    }
    //
    private void Update()
    {   if (FindObjectOfType<GameManager>().gameState == GameManager.GameState.Launch)
        {
            if (_ballTransform) transform.position = new Vector3(_ballTransform.position.x, _ballTransform.position.y, _zPos);
            else transform.position = new Vector3(0, 0, _zPos);
        }

    }
}
