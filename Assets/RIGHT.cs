using UnityEngine;

public class RIGHT : MonoBehaviour
{
    public float speed = 10f;


    private void Start()
    {

        Destroy(gameObject, 40f);
    }
    void Update()
    {

        transform.position += Vector3.right * SpeedChanger.newSpeed * Time.deltaTime;


    }
}
