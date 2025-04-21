using UnityEngine;

public class FindPlayerPosition : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 midPosition;
    private Vector3 endPosition;
    private float desiredDuration = 3f;
    private float elapsedTime;
    public bool isMoving = false;

    public GameObject LerpCamera;

    [SerializeField]
    private GameObject intialPosition;

    public AnimationCurve curve;

    void Start()
    {
        startPosition = intialPosition.transform.position;
        endPosition = intialPosition.transform.position;

        LerpCamera.transform.position = startPosition;

        
    }

    void MoveCamera()
    {
        

        Vector3 currentPosition = LerpCamera.transform.position;
        if (currentPosition == endPosition)
        {
            isMoving = false;
            elapsedTime = 0f;
        }
        else
        {
            if (isMoving)
            {
                elapsedTime += Time.deltaTime;
                float percentageComplete = elapsedTime / desiredDuration;

            

                Vector3 lerpOne = Vector3.Lerp(startPosition, midPosition, curve.Evaluate(percentageComplete));
                Vector3 lerpTwo = Vector3.Lerp(midPosition, endPosition, curve.Evaluate(percentageComplete));

                LerpCamera.transform.position = Vector3.Lerp(lerpOne, lerpTwo, curve.Evaluate(percentageComplete));
            }
        }
        
        

        
    }


    public void setPoints(Vector3 endPoint)
    {
        startPosition = LerpCamera.transform.position;
        elapsedTime = 0f;
        endPosition = endPoint;
        midPosition = new Vector3(((startPosition.x + endPosition.x) / 2), .85f, ( - 4));
    }

    public Vector3 activePlayer;

    void Update()
    {
        MoveCamera();

        if(Input.GetKey(KeyCode.Q))
        {
            activePlayer = new Vector3 (this.transform.GetChild(0).transform.position.x, this.transform.GetChild(0).transform.position.y, this.transform.GetChild(0).transform.position.z-2);
            setPoints(activePlayer);
            isMoving = true;
            
        }

        if(Input.GetKey(KeyCode.W))
        {
            activePlayer = new Vector3 (this.transform.GetChild(1).transform.position.x, this.transform.GetChild(1).transform.position.y, this.transform.GetChild(1).transform.position.z-2);
            setPoints(activePlayer);
            isMoving = true;
            
        }

        if(Input.GetKey(KeyCode.E))
        {
            activePlayer = new Vector3 (this.transform.GetChild(2).transform.position.x, this.transform.GetChild(2).transform.position.y, this.transform.GetChild(2).transform.position.z-2);
            setPoints(activePlayer);
            isMoving = true;
           
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(startPosition);
            Debug.Log(midPosition);
            Debug.Log(endPosition);
        }
    }
}
