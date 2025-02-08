using UnityEngine;
using UnityEngine.UI;

public class FontControl : MonoBehaviour
{
    public Font newFont; // Arrastra la fuente aquí desde el inspector
    public Text textToChange;

    void Start()
    {
        if (newFont != null && textToChange != null)
        {
            textToChange.font = newFont;
            textToChange.fontSize = 24; // Cambiar tamaño
            textToChange.color = Color.red; // Cambiar color
        }
    }
}
