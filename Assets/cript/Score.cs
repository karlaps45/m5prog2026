using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score;
    public TextMeshProUGUI scoretexty;


    private void Update()
    {
        scoretexty.text = score.ToString();

        Enemy.enemydeath += getenemypoints;
    }

    private void getenemypoints()
    {
        score += 100;
    }

}
