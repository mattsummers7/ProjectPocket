using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public GameObject location1;
    public GameObject location2;

    private Vector3 position;
    void Start()
    {
        Debug.Log(location2.transform.GetChild(0).transform.position);
        Debug.Log(location2.transform.GetChild(0).transform.localPosition);
        Debug.Log(location1.transform.GetChild(0).transform.position);
        Debug.Log(location1.transform.GetChild(0).transform.localPosition);
        transform.position = new Vector3((-location2.transform.GetChild(0).transform.position.x + location1.transform.GetChild(0).transform.position.x) / 2, location1.transform.GetChild(0).transform.position.y, (location1.transform.GetChild(0).transform.position.z - 1));


    }

    void Update()
    {
        
    }
}
