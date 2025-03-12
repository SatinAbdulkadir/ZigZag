using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TopHareketi : MonoBehaviour
{
    public ZeminSpawner zeminSpawnerScripti;
    public static bool düstü_mü;

    Vector3 yön;
    public float hýz;

    public float eklenecekHýz;

    void Start()
    {
        yön = Vector3.forward;
        düstü_mü = false;
    }

   
    void Update()
    {
        if (transform.position.y<=0.5f)
        {
            düstü_mü = true;
        }
        if (düstü_mü==true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {

            if (yön.x==0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;
            }
            hýz = hýz + eklenecekHýz * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hýz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag=="zemin")
        {
            Skor.skor++;
            zeminSpawnerScripti.zemin_oluþtur();

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
