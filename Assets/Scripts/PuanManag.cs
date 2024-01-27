using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PuanManag : MonoBehaviour
{
    public int puan;
    public TMP_Text txtPuan;

    public GameObject kazandinPaneli;
    // Start is called before the first frame update
    void Start()
    {
        txtPuan.text = $"Score : {puan}";
        kazandinPaneli.active = false;
    }
    public void UpdatePuan(int puanlar)
    {
        puan += puanlar;
        txtPuan.text = $"Score : {puan}";
        if (puan == 1700)
        {
            kazandinPaneli.active = true;
        }
    }
    private void Update()
    {
       
    }
}
