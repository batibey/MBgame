using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{

    public GameObject kucukCember;
    GameObject OyunYoneticisi;

    // Start is called before the first frame update
    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            kucukCemberOlustur();
        }
    }

    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);

        OyunYoneticisi.GetComponent<OyunYoneticisi>().KucukCemberlerdeTextGosterme();
    }
}
