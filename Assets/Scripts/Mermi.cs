using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public float HareketHizi = 4.5f;

    public GameObject patlamaPrefab;


    private PuanManag puanManag;
    // Start is called before the first frame update
    void Start()
    {
        puanManag = GameObject.Find("ScoreManag").GetComponent<PuanManag>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * HareketHizi * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dusman")
        {
            Instantiate(patlamaPrefab,transform.position,Quaternion.identity);
            Destroy(collision.gameObject);
            puanManag.UpdatePuan(50);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Kenar")
            Destroy(gameObject);

    

    }
}
