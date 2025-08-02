using UnityEngine;

public class View : MonoBehaviour
{
    public CameraFollow cm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void thirdPirson()
    {
        cm.offset = new Vector3(0, 3, -9);
    }
    public void FirstPirson()
    {
        cm.offset = new Vector3(0, 1, 1.5f);

    }

}
