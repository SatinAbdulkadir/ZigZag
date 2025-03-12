using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform topunKonumu;
    Vector3 fark;

    // Start is called before the first frame update
    void Start()
    {
        fark = transform.position - topunKonumu.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (TopHareketi.düstü_mü == false)
        { 
            transform.position = topunKonumu.position + fark;
        }
    }
}
