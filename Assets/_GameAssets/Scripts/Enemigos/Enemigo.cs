using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    [Header("ESTADO")]
    [SerializeField] protected bool estaVivo = true;
    [SerializeField] int vida = 10;

    [Header("ATAQUE")]
    [SerializeField] int distanciaDeteccion = 5;
    [SerializeField] protected int danyo = 2;//Daño que infringe

    [Header("FX")]
    [SerializeField] protected ParticleSystem psExplosion;

    protected GameObject player;

    private void Awake() {
        player = GameObject.Find("Player");
    }

    protected virtual void Update()
    {
        /*
         * Al declarar un método virtual (en cuyo caso ya no puede ser privado,
         * estamos indicando que dicho método puede ser sobreescrito en las clases
         * hijas, por lo que podremos 'pisar' su funcionalidad o completarla mediante
         * llamadas al mismo método de la clase padre (referencia a base)
         */

        /*
        print("UPDATE DEL ENEMIGO");
        */
    }

    public void RecibirDanyo(int danyo) {
        Debug.Log("RECIBIENDO DAÑO");
        vida = vida - danyo;
        if (vida <= 0) {
            vida = 0;
            Morir();
        }
    }

    public void Morir() {
        Debug.Log("MURIENDO");
        estaVivo = false;
        ParticleSystem ps = Instantiate(psExplosion, transform.position, Quaternion.identity);
        ps.Play();
        Destroy(this.gameObject);
    }

    protected Vector3 GetDistancia() {
        return player.transform.position - transform.position;
    }

}
