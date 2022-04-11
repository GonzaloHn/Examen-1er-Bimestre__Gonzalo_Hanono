using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public string nombre;
    public int año;
    public char orientación;

    // Start is called before the first frame update
    void Start()
    {
        if (nombre == "")
        {
            Debug.Log("Error. Ingrese un nombre real.");
        }
        else if (año < 1 || año > 5)
        {
            Debug.Log("Error. El año ingresado no es válido.");
        }
        else if(año == 1 || año == 2)
        {
            Debug.Log("Error. Aún estás en el ciclo básico.");
        }
        else if(orientación == 'T' || orientación == 'D' || orientación == 'G' || orientación == 'M' || orientación == 'H')
        {
            Debug.Log("Muchas gracias " + nombre + "!");
        }
        else
        {
            Debug.Log("“Solo puede ingresar T, D, G, M o H.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
