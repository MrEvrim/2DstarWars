using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanHareket : MonoBehaviour
{
    public float hareketHizi=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * hareketHizi * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kenar")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -0.3f,transform.position.z );
            hareketHizi *= -1;
        }
    }
}
