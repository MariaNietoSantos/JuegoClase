using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual;
    [SerializeField] public int puntuacionMaxima;
    [SerializeField] public float tiempo;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject boton;
    [SerializeField] GameObject jugador;
    [SerializeField] GameObject enemigo;
    [SerializeField] bool cronometro;
    [SerializeField] ObstaculoTerrestre obstaculo;
    [SerializeField] AudioClip[] sonidos;
    [SerializeField] private AudioSource sonido;
    public static GameManager Instancia;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        boton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (cronometro)
        {
            tiempo += Time.deltaTime;
        }
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
        sonido.clip = sonidos[0]; sonido.Play();
        jugador.SetActive(false);
        enemigo.SetActive(false);
        gameOver.SetActive(true);
        boton.SetActive(true);
        cronometro = false;
    }
    public void ReiniciarJuego()
    {
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        gameOver.SetActive(false);
        boton.SetActive(false);
        tiempo = 0;
        cronometro = true;
        obstaculo.ReiniciarEnemigo();
    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual += 1;
        if (puntuacionActual > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("PuntuacionMaxima", puntuacionMaxima);
        }
    }


} 
