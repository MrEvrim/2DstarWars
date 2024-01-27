using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class PlayerCanlari : MonoBehaviour
{
    public int canlar = 3;
    public Image[] canUI;
    public GameObject patlamaPrefab;
    public GameObject olumPaneli;
    // Start is called before the first frame update
    void Start()
    {
        olumPaneli.active = false;
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag=="Dusman")
        {
            //çarpan yok olsunn
            Destroy(collision.collider.gameObject);
            Instantiate(patlamaPrefab,transform.position,Quaternion.identity); 
            canlar -=1;
            for(int i = 0; i < canUI.Length; i++) 
            {
                if (i < canlar)
                {
                    canUI[i].enabled = true;       
                }
                else
                {
                    canUI[i].enabled = false;
                }
            }
            if (canlar <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DusmanMermi")
        {
            //çarpan yok olsunn
            Destroy(collision.gameObject);
            Instantiate(patlamaPrefab, transform.position, Quaternion.identity);
            canlar -= 1;
            for (int i = 0; i < canUI.Length; i++)
            {
                if (i < canlar)
                {
                    canUI[i].enabled = true;
                }
                else
                {
                    canUI[i].enabled = false;
                }
            }
            if (canlar <= 0)
            {
                Destroy(gameObject);
                olumPaneli.active = true;

            }
        }
    }

}

