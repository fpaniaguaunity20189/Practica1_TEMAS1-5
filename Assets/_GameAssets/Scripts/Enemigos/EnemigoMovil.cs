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

    protected override void Update()
    {
        /*
         * El modificador 'override' indica que el método sobreescribe a un método
         * equivalente que se encuentra en la clase padre y está declarado como
         * 'virtual'.
         * 
         * En el método que sobreescribe podemos sustituir la funcionalidad del método
         * del padre o completarla, llamando al mismo método del objeto base.
         */

        /*
        Debug.Log("UPDATE DE ENEMIGO MOVIL");
        base.Update();
        */
        Avanzar();
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
        print(collision.gameObject.tag);
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<Player>().RecibirDanyo(danyo);
            Morir();
        }
    }
}
