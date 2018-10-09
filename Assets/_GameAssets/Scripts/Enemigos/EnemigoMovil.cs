using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovil : Enemigo {
    [Header("Enemigo Movil")]
    [SerializeField] protected int speed = 1;
    [SerializeField] protected int inicioRotacion = 1;
    [SerializeField] protected int tiempoEntreRotacion = 2;

    private void Start()
    {
        InvokeRepeating("RotarAleatoriamente", inicioRotacion, tiempoEntreRotacion);
    }

    protected void Avanzar() {
        if (estaVivo)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    protected void RotarAleatoriamente() {
        float rotacion = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0, rotacion, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        RotarAleatoriamente();
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<Player>().RecibirDanyo(danyo);
            estaVivo = false;
            ParticleSystem ps = Instantiate(psExplosion, transform.position, Quaternion.identity);
            ps.Play();
            Destruir();
        }
    }
}
