using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] public float tiempo;
    public static GameManager Instancia;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
       puntuacionMaxima = PlayerPrefs.GetInt("PuntuacionMaxima");
    }
    public void Perder()
    {

    }
    public void ReiniciarJuego()
    {

    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual += 1;
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", puntuacionMaxima);
        }
    }
} 
