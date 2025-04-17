using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 targetPosition;

    bool isMoving;
    void Start()
    {
        
        targetPosition = transform.GetChild(0).transform.position;        
    }


    void Update()
    {
    
        
            if(Input.GetKeyDown(KeyCode.Space))
            {
                FindFirstObjectByType<LerpMovement>().isMoving = true;
                FindFirstObjectByType<LerpMovement>().setPoints(targetPosition);
            }
        
        
        
        
    }

    
}
