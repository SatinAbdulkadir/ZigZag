using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TopHareketi : MonoBehaviour
{
    public ZeminSpawner zeminSpawnerScripti;
    public static bool d�st�_m�;

    Vector3 y�n;
    public float h�z;

    public float eklenecekH�z;

    void Start()
    {
        y�n = Vector3.forward;
        d�st�_m� = false;
    }

   
    void Update()
    {
        if (transform.position.y<=0.5f)
        {
            d�st�_m� = true;
        }
        if (d�st�_m�==true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {

            if (y�n.x==0)
            {
                y�n = Vector3.left;
            }
            else
            {
                y�n = Vector3.forward;
            }
            h�z = h�z + eklenecekH�z * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = y�n * Time.deltaTime * h�z;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag=="zemin")
        {
            Skor.skor++;
            zeminSpawnerScripti.zemin_olu�tur();

            StartCoroutine(ZeminiSil(collision.gameObject));
        }

        collision.gameObject.AddComponent<Rigidbody>();
    }

    IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }
}
