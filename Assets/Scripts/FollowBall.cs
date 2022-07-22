using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform _ballTransform;

    
    private void Update()
    {
        if (_ballTransform) transform.position = new Vector3(_ballTransform.position.x, _ballTransform.position.y, transform.position.z);
        else transform.position = new Vector3(0, 0, transform.position.z);
    }
}
