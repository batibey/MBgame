using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberKod : MonoBehaviour
{

    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject oyunYoneticisi;
    // Start is called before the first frame update
    void Start()
    {

        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
            
        }

        if(col.tag == "kucukcembertag")
        {
            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
        }
    }
}
