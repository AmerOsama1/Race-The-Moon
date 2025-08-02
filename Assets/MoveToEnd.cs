using UnityEngine;

public class MoveToEnd : MonoBehaviour
{
    public Transform END;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 20f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, END.position, time*Time.deltaTime);
    }
}
