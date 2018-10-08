using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    [Header("ESTADO")]
    [SerializeField] bool estaVivo = true;
    [SerializeField] int vida = 10;

    [Header("ATAQUE")]
    [SerializeField] int distanciaDeteccion = 5;
    [SerializeField] protected int danyo = 2;//Daño que infringe

    [Header("REFERENCIAS")]
    [SerializeField] protected GameObject personaje;

    //int distanciaExplosion;
    private void Start() {
        
    }

    public int DetectarDistanciaAlPersonaje() {

        return 0;
    }
    public void Morir() {
        Debug.Log("MURIENDO");
        /*
         1. Indicar que está muerto.
         2. Sistema de particulas
         3. Gritos horribles de dolor / Despedirse de los seres querido
         4. Destruir el enemigo
         5. ¿Aumentar salud? ¿Increntar puntuacion? ...
         */
        estaVivo = false;
    }

    public void Atacar() {

    }

    public void RecibirDanyo(int danyo) {
        Debug.Log("RECIBIENDO DAÑO");
        vida = vida - danyo;
        if (vida <= 0) {
            vida = 0;
            Morir();
        }
    }

    /*
    private void OnMouseDown() {
        Debug.Log("PULSADO CON EL RATON");
        RecibirDanyo(10);
    }
    */

}
