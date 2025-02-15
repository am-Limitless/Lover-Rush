using System.Collections;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject num3;
    public GameObject num2;
    public GameObject num1;
    public GameObject go;
    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequnce());
    }

    IEnumerator CountSequnce()
    {
        yield return new WaitForSeconds(1f);
        num3.SetActive(true);
        yield return new WaitForSeconds(1f);
        num2.SetActive(true);
        yield return new WaitForSeconds(1f);
        num1.SetActive(true);
        yield return new WaitForSeconds(1f);
        go.SetActive(true);
        PlayerMove.canMove = true;
    }

}
