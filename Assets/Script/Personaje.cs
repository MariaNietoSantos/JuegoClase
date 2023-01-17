using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;
    [SerializeField] float salto;
    [SerializeField] AudioClip[] sonidos;
    [SerializeField] private AudioSource sonido;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector2.up * salto);
            animator.SetBool("Saltar", true);
            sonido.clip = sonidos[1]; sonido.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Saltar", false);
        if (collision.transform.tag == "Perder")
        {
            sonido.clip = sonidos[0]; sonido.Play();
            GameManager.Instancia.Perder();
        }
    }
}
