using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoTerrestre : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] float velocidad = 4;
    [SerializeField] Vector2 posicionI;
    [SerializeField] Vector2 posicionF;
    [SerializeField] Vector2 posicionIkk;
    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
}
