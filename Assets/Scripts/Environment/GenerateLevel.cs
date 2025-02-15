using System.Collections;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    [Header("Level Settings")]
    [SerializeField] private GameObject[] section;         // Array of level sections to instantiate.
    [SerializeField] private bool creatingSection = false; // Section creation check.
    [SerializeField] private int secNum;                   // Delay between spawns.
    private int zPos = 50;                // Tracks the Z position for the next section.

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;

            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(1);
        creatingSection = false;
    }
}
