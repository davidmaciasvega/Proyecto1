using UnityEngine;

public class DragDrop2D : MonoBehaviour
{
    private Camera cam;
    private Transform focus;
    private bool isDrag = false;
    private Vector3 offset; // Offset entre el mouse y el centro del objeto

    void Start()
    {
        cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("¡No se encontró la cámara principal!");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clic detectado en el mouse.");
            
            // Posición del mouse en el mundo (2D)
            Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0;

            // Usar OverlapPoint para detección precisa
            Collider2D hitCollider = Physics2D.OverlapPoint(mouseWorldPos);
            
            if (hitCollider != null)
            {
                focus = hitCollider.transform;
                Debug.Log("Objeto detectado: " + hitCollider.name);
                isDrag = true;

                // Calcular offset para evitar "saltos" al arrastrar
                offset = focus.position - mouseWorldPos;
            }
            else
            {
                Debug.LogWarning("No se detectó ningún collider.");
            }
        }
        else if (Input.GetMouseButtonUp(0) && isDrag)
        {
            isDrag = false;
            Debug.Log("Mouse soltado.");
        }
        else if (isDrag)
        {
            // Actualizar posición manteniendo el offset
            Vector3 mouseWorldPos = cam.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0; // Mantener Z=0 para 2D
            focus.position = mouseWorldPos + offset;
        }
    }
}