using UnityEngine;



public class Colisiones : MonoBehaviour

{

    void Start()

    {

        Debug.Log("Script Colisiones iniciado en: " + gameObject.name);

    }



    void OnCollisionEnter2D(Collision2D col)

    {

        Debug.Log("OnCollisionEnter2D llamado con: " + col.gameObject.name);



        if (col.gameObject.CompareTag("Bloque"))

        {

            Debug.Log("Colisión con Bloque");

        }

        if (col.gameObject.CompareTag("Piso"))

        {

            Debug.Log("Colisión con Piso");

        }

    }

}