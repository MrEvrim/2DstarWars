using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiCikisNoktasi : MonoBehaviour
{
    public GameObject dusmanMermisi;
    public float atesHizi;
    public float atesMax = 10;
    public float atesMin = 5;
    // Start is called before the first frame update
    void Start()
    {
        atesHizi = Random.Range(atesMin, atesMax);
        
    }

    // Update is called once per frame
    void Update()
    {
        atesHizi -= Time.deltaTime;
        if (atesHizi <= 0)
        {
            Instantiate(dusmanMermisi, transform.position, Quaternion.identity);

            atesHizi = Random.Range(atesMin, atesMax);
        }
    }
      
}
