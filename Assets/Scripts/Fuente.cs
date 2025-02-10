using UnityEngine;
using UnityEngine.UI; // Para el texto UI estándar
using TMPro;         // Para TextMeshPro

public class FontController : MonoBehaviour
{
    // Array para textos estándar
    public Text[] uiTextsToChange;

    // Array para textos TextMeshPro
    public TMP_Text[] tmpTextsToChange;

    // Nueva fuente para aplicar
    public Font newFont;

    // Método para cambiar la fuente
    public void ChangeFont()
    {
        // Cambiar la fuente de textos estándar
        foreach (Text uiText in uiTextsToChange)
        {
            if (uiText != null)
            {
                uiText.font = newFont;
            }
        }

        // Cambiar la fuente de textos TextMeshPro
        foreach (TMP_Text tmpText in tmpTextsToChange)
        {
            if (tmpText != null)
            {
                tmpText.font = TMP_FontAsset.CreateFontAsset(newFont); // Convierte la fuente para TextMeshPro
            }
        }

        Debug.Log("Fuente cambiada en todos los textos.");
    }
    
}

