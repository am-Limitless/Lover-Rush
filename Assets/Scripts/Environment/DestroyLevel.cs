using System.Collections;
using UnityEngine;


public class DestroyLevel : MonoBehaviour
{
    public string parentName;

    // Update is called once per frame
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(50);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
