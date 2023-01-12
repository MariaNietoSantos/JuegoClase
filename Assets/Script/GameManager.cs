using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int puntuacionActual;
    [SerializeField] int puntuacionMaxima;
    [SerializeField] float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Perder()
    {

    }
    public void ReiniciarJuego()
    {

    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual += puntuacionActual;
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", puntuacionMaxima);
        }
    }
} 
