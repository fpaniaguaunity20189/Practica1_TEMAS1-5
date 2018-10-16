using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstatico : Enemigo {
    [SerializeField] float distanciaAtaque = 5;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] Transform posGeneracion;
    [SerializeField] int potenciaDisparo;
    [SerializeField] float tiempoEntreDisparos = 2;
    float tiempoAtaque;

    private void Start() {
        tiempoAtaque = tiempoEntreDisparos;
    }

    private void IntentoAtaque() {
        tiempoAtaque += Time.deltaTime;//tiempoAtaque = tiempoAtaque + Time.deltaTime;
        if (tiempoAtaque >= tiempoEntreDisparos) {
            tiempoAtaque = 0;
            //Generar disparo y lanzar
            Disparar();
        }
    }

    private void Disparar() {
        GameObject proyectil = Instantiate(
            prefabProyectil, 
            posGeneracion.position, 
            posGeneracion.rotation);
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(
            Vector3.forward * potenciaDisparo);
    }

	protected override void Update () {
        //Mira al player
        Vector3 target = new Vector3(
                player.transform.position.x,
                transform.position.y,
                player.transform.position.z
            );
        transform.LookAt(target);
        //Obtiene el vector de distancia
        Vector3 distancia = GetDistancia();
        //Evalua si la distancia es menor que la distancia de ataque y ataca
        if (distancia.sqrMagnitude < (distanciaAtaque * distanciaAtaque)) {
            IntentoAtaque();
        }
    }


}
