using UnityEngine;
using UnityEngine.UI; // Para el texto UI estándar
using TMPro;         // Para TextMeshPro

public class ChangeFontColor : MonoBehaviour
{
    // Array para textos estándar
    public Text[] uiTextsToChange;

    // Array para textos TextMeshPro
    public TMP_Text[] tmpTextsToChange;

    // Nuevo color para aplicar
    public Color newColor;

    // Método para cambiar el color
    public void ChangeColor()
    {
        // Verificar el valor alfa del nuevo color
        if (newColor.a == 0)
        {
            newColor.a = 1; // Establecer el alfa a 1 si es 0 para asegurar que el color no es transparente
        }

        // Cambiar el color de textos estándar
        foreach (Text uiText in uiTextsToChange)
        {
            if (uiText != null)
            {
                uiText.color = newColor;
            }
        }

        // Cambiar el color de textos TextMeshPro
        foreach (TMP_Text tmpText in tmpTextsToChange)
        {
            if (tmpText != null)
            {
                tmpText.color = newColor;
            }
        }

        Debug.Log("Color de la fuente cambiado en todos los textos.");
    }
}
