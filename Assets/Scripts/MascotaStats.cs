using UnityEngine;
using UnityEngine.UI; // Necesitamos esta línea para trabajar con la UI

public class MascotaStats : MonoBehaviour
{
    // Stats de la mascota
    public float hambre = 50f;
    public float felicidad = 50f;

    public float maxStat = 100f;
    public float decaimientoHambrePorSegundo = 0.5f;

    // Referencias a los elementos de la UI
    public Slider barraHambre;

    // La función Update se ejecuta una vez por cada fotograma
    void Update()
    {
        if (hambre > 0)
        {
            hambre -= decaimientoHambrePorSegundo * Time.deltaTime;
        }

        // Actualizamos la barra de UI en cada frame
        barraHambre.value = hambre / maxStat;
    }

    // Esta función será llamada por el botón
    public void Alimentar()
    {
        hambre += 15f;
        // Nos aseguramos de que no pase del máximo
        if (hambre > maxStat)
        {
            hambre = maxStat;
        }
        Debug.Log("Alimentado! Hambre actual: " + hambre);
    }
}