    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    [SerializeField] float _tapRadius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 0;
            Debug.Log(touchPosition.ToString());
            RaycastHit2D results = Physics2D.CircleCast(touchPosition, _tapRadius, Vector2.zero);
            if(results.collider)
            {
                GameObject resultsObject = results.collider.gameObject;
                if (resultsObject.CompareTag("Draggable"))
                {
                    resultsObject.transform.position = touchPosition;
                }
            }

        }
    }
}
