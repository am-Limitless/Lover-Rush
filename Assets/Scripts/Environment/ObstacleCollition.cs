using UnityEngine;

public class ObstacleCollition : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public AudioSource IooChathe;
    public GameObject mainCam;
    public GameManager gameManager;
    public GameObject levelManager;

     
    
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        IooChathe.GetComponent<AudioSource>().Play();
        mainCam.GetComponent<Animator>().enabled = true;
        gameManager.GameOver();
        levelManager.GetComponent<LevelDistance>().isTimeRunnig = false;

    }

}
