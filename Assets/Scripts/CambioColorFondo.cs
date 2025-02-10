using UnityEngine;
using UnityEngine.UI; // Asegúrate de tener esto para trabajar con UI

public class ChangeBackgroundColor : MonoBehaviour
{
    // Referencia a la imagen de fondo
    public Image backgroundImage;

    // Nuevo color de fondo para aplicar
    public Color newBackgroundColor;

    // Método para cambiar el color de fondo
    public void ChangeColor()
    {
        if (backgroundImage != null)
        {
            backgroundImage.color = newBackgroundColor;
            Debug.Log("Color de fondo de la imagen cambiado.");
        }
        else
        {
            Debug.LogError("No se ha asignado una imagen de fondo.");
        }
    }
}
