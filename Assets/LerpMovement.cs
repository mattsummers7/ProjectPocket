using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 midPosition;
    private Vector3 endPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;
    public bool isMoving = false;

    public GameObject lerpPoint;

    [SerializeField]
    private GameObject intialPosition;

    public AnimationCurve curve;

    void Start()
    {
        startPosition = intialPosition.transform.position;
        endPosition = intialPosition.transform.position;

        transform.position = startPosition;

        midPosition = new Vector3(lerpPoint.transform.position.x, lerpPoint.transform.position.y, lerpPoint.transform.position.z);
    }

    void Update()
    {
        if (isMoving)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / desiredDuration;

            Vector3 lerpOne = Vector3.Lerp(startPosition, midPosition, curve.Evaluate(percentageComplete));
            Vector3 lerpTwo = Vector3.Lerp(midPosition, endPosition, curve.Evaluate(percentageComplete));

            transform.position = Vector3.Lerp(lerpOne, lerpTwo, curve.Evaluate(percentageComplete));
        }
        

        
    }


    public void setPoints(Vector3 endPoint)
    {
        startPosition = transform.position;
        elapsedTime = 0f;
        endPosition = endPoint;
    }

}
