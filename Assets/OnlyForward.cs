using UnityEngine;

public class OnlyForward : MonoBehaviour
{
    public float speed = 5f;
    public float moveDuration = 3f;


    private void Start()
    {
        
        Destroy(gameObject, 40f);
    }
    void Update()
    {
        
            transform.position += Vector3.forward * SpeedChanger.newSpeed * Time.deltaTime;
           
        
    }
}
