using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    public GameObject levelControl;


    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        levelControl.GetComponent<CollectControl>().incrementscore();
        this.gameObject.SetActive(false);
    }
}
