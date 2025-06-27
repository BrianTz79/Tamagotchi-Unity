using UnityEngine;
using UnityEngine.UI; // Necesitamos esta línea para trabajar con la UI

public class MascotaStats : MonoBehaviour
{
    // Stats de la mascota
    public float hambre = 50f;
    public float felicidad = 50f;

    // Configuración de las stats
    public float maxStat = 100f;
    public float decaimientoHambrePorSegundo = 0.5f;
    public float decaimientoFelicidadPorSegundo = 0.2f; // <-- NUEVO: La felicidad baja más lento

    // Referencias a los elementos de la UI
    public Slider barraHambre;
    public Slider barraFelicidad; // <-- NUEVO

    // La función Update se ejecuta una vez por cada fotograma
    void Update()
    {
        // Lógica de decaimiento del hambre
        if (hambre > 0)
        {
            hambre -= decaimientoHambrePorSegundo * Time.deltaTime;
        }

        // Lógica de decaimiento de la felicidad // <-- NUEVO
        if (felicidad > 0)
        {
            felicidad -= decaimientoFelicidadPorSegundo * Time.deltaTime;
        }

        // Actualizamos las barras de UI en cada frame
        barraHambre.value = hambre / maxStat;
        barraFelicidad.value = felicidad / maxStat; // <-- NUEVO
    }

    // Esta función será llamada por el botón "Alimentar"
    public void Alimentar()
    {
        hambre += 15f;
        if (hambre > maxStat)
        {
            hambre = maxStat;
        }
        Debug.Log("Alimentado! Hambre actual: " + hambre);
    }

    // Esta función será llamada por el botón "Jugar" // <-- NUEVO
    public void Jugar()
    {
        felicidad += 20f; // Jugar sube más la felicidad
        if (felicidad > maxStat)
        {
            felicidad = maxStat;
        }
        Debug.Log("Jugando! Felicidad actual: " + felicidad);
    }
}