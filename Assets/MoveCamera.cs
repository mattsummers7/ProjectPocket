using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 targetPosition;

    public enum PlayerIndex
    {
        Player1,
        Player2,
        Player3,
    }

    PlayerIndex playerIndex; 

    void Start()
    {
        
    }


    void Update()
    {
        GetPosition(playerIndex);
        print(targetPosition);
    }

    public void GetPosition(PlayerIndex playerIndex)
    {
        switch (playerIndex)
        {
            case PlayerIndex.Player1:
                targetPosition = transform.position;
                break;
            case PlayerIndex.Player2:
                targetPosition = transform.position;
                break;
            case PlayerIndex.Player3:
                targetPosition = transform.position;
                break;
        }
    }

    
}
