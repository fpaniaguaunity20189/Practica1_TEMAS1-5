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

    [Header("REFERENCIAS")]
    [SerializeField] protected GameObject personaje;

    [Header("FX")]
    [SerializeField] protected ParticleSystem psExplosion;

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

    public void Atacar() {

    }


    public int DetectarDistanciaAlPersonaje() {

        return 0;
    }

    /*
    private void OnMouseDown() {
        Debug.Log("PULSADO CON EL RATON");
        RecibirDanyo(10);
    }
    */

}
