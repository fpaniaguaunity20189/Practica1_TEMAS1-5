using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private const int NUM_ARMAS = 4;
    [SerializeField] int armaActiva = 0;
    [SerializeField] private bool estaVivo;
    [SerializeField] private int vidaActual;
    [SerializeField] private int vidaMaxima;
    [SerializeField] Arma[] armas = new Arma[NUM_ARMAS];
    [SerializeField] TextMesh tm;
    [SerializeField] HUDScript hs;
    private void Start() {
        ActivarArma(armaActiva);
    }
    private void Update() {
        tm.text = ""+vidaActual;
        if (Input.GetMouseButtonDown(0)) {
            Disparar();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            armaActiva = 0;
            ActivarArma(armaActiva);
            hs.ActivarArma(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            armaActiva = 1;
            ActivarArma(armaActiva);
            hs.ActivarArma(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            armaActiva = 2;
            ActivarArma(armaActiva);
            hs.ActivarArma(2);
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            armaActiva = 3;
            ActivarArma(armaActiva);
        }
    }

    public void Disparar() {
        armas[armaActiva].ApretarGatillo();
    }

    private void ActivarArma(int armaActiva) {
        DesactivarArmas();
        armas[armaActiva].gameObject.SetActive(true);
    }

    private void DesactivarArmas() {
        foreach (var arma in armas) {
            arma.gameObject.SetActive(false);
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
