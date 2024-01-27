using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiAtes : MonoBehaviour
{
    public GameObject MermiPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(MermiPrefab, transform.position, Quaternion.identity);
        }
    }
}
