using TMPro;
using UnityEngine;
public class CollectControl : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI coinCount;
    public TextMeshProUGUI coinCountMain;

    public void incrementscore()
    {
        score++;
        coinCount.text = score.ToString();
        coinCountMain.text = score.ToString();

    }
}
