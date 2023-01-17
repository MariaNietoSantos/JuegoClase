using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoTerrestre : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] float velocidad;
    [SerializeField] Vector2 posicionI;
    [SerializeField] Vector2 posicionF;
    [SerializeField] Vector2 posicionIkk;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 4;
        mainCamera = Camera.main;
        posicionI = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        posicionF = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));

        posicionIkk = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > posicionI.x)
        {
            transform.Translate(Vector3.left * Time.deltaTime * velocidad);
        }
        else
        {
            transform.position = posicionIkk;
            velocidad = velocidad + 0.5f;
        }

        if (velocidad == 22)
        {
            velocidad = velocidad - 0.5f;
        }
    }
    public void ReiniciarEnemigo()
    {
        transform.position = posicionIkk;
        velocidad = 1;
    }
}
