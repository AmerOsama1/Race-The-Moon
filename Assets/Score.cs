using UnityEngine;
using TMPro;
using System.ComponentModel.Design.Serialization;
public class Score : MonoBehaviour
{
    public  float score;
    public static int IncScore;
   public TextMeshProUGUI Sc;
    public TextMeshProUGUI After_Sc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IncScore = 5;
    }

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime * IncScore *20;
        Sc.text = score.ToString("0");
        After_Sc.text = score.ToString("Your Score is "+" 0 ");
    }
}
