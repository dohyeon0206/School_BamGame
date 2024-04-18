using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamGenerator : MonoBehaviour
{
    public GameObject bamPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bam = Instantiate(bamPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 dir = ray.direction;
            bam.GetComponent<BamController>().Shoot(dir.normalized * 2000);
        }
    }
}
