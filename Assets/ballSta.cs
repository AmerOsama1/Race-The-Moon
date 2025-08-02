using UnityEngine;

public class ballSta : MonoBehaviour
{
    public Transform[] Pos;
    public GameObject[] OBJ;

    // Start is called once before the first execution of Update after the MonoBehaviour is create
    void Start()
    {
        InvokeRepeating("St", 1.5f, 1.5f);
    }
    void St()
    {
        for (int i = 0; i < Pos.Length; i++)
        {
            Instantiate(OBJ[Random.Range(0, OBJ.Length)], Pos[i].position, Quaternion.identity);
        }
    }
}
