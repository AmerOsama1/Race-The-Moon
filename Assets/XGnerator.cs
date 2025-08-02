using UnityEngine;

public class XGnerator : MonoBehaviour
{
    public Transform[] Pos;
    public GameObject OBJ;

    // Start is called once before the first execution of Update after the MonoBehaviour is create
    void Start()
    {
        InvokeRepeating("St", 5f, 5f);
    }
    void St()
    {
        for (int i = 0; i < Pos.Length; i++)
        {
            Instantiate(OBJ, Pos[i].position, OBJ.transform.rotation);
        }
    }
}
