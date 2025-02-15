using TMPro;
using UnityEngine;

public class LevelDistance : MonoBehaviour
{
    public TextMeshProUGUI runDistance;
    public TextMeshProUGUI runDistanceMain;
    public GameObject player;
    public float disRun;
    public bool isTimeRunnig = true;

    void Update()
    {
        if (isTimeRunnig == true)
        {
            timer();
        }

    }
    public void timer()
    {
        disRun += Time.deltaTime;
        int minutes = Mathf.FloorToInt(disRun / 60);
        int seconds = Mathf.FloorToInt(disRun % 60);
        runDistance.text = string.Format("{00:00}:{1:00}", minutes, seconds);
        runDistanceMain.text = string.Format("{00:00}:{1:00}", minutes, seconds);
    }

}