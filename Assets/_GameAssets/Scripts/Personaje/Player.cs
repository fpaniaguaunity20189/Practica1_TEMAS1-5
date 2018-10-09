using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private const int NUM_ARMAS = 4;
    [SerializeField] int armaActiva = 0;
    [SerializeField] private bool estaVivo;
    [SerializeField] private int vidaActual;
    [SerializeField] private int vidaMaxima;
    [SerializeField] GameObject[] armas = new GameObject[NUM_ARMAS];
    [SerializeField] TextMesh tm;
    private void Start() {
        /*SOLUCION CUTRE
         armas[0].SetActive(true);
         armas[1].SetActive(false);
         armas[2].SetActive(false);
         armas[3].SetActive(false);
        */
        //BUCLE FOR
        /*
        for(int i = 0; i < NUM_ARMAS; i++) {
            armas[i].SetActive(false);
        }
        */
        //BUCLE FOR EACH
        ActivarArma(armaActiva);
    }
    private void Update() {
        tm.text = ""+vidaActual;

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            ActivarArma(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            ActivarArma(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            ActivarArma(2);
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            ActivarArma(3);
        }
    }

    private void ActivarArma(int armaActiva) {
        DesactivarArmas();
        armas[armaActiva].SetActive(true);
    }

    private void DesactivarArmas() {
        foreach (var arma in armas) {
            arma.SetActive(false);
        }
    }


    public void IncrementarVida(int incrementoVida) {
        vidaActual = vidaActual + incrementoVida;
        if (vidaActual > vidaMaxima) {
            vidaActual = vidaMaxima;
        }
    }

    public void CambiarArma() {

    }

    public void Atacar() {

    }
    
    public void RecibirDanyo(int danyo) {
        vidaActual = vidaActual - danyo;
        if (vidaActual <= 0) {
            vidaActual = 0;
            Morir();
        }
    }

    public void Morir() {

    }

}
