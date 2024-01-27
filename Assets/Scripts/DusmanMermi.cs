using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanMermi : MonoBehaviour
{
    public float hiz = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * hiz * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kenar")
        {
            Destroy(gameObject);
        }
    }
}
