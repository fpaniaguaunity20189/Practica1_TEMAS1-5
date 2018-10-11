using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour {
    bool activa;
    [SerializeField] GameObject puntoGeneracion;
    [SerializeField] GameObject prefabBala;
    [SerializeField] int potenciaDisparo = 100;
    public void ApretarGatillo() {
        print("Apretando gatillo:" + gameObject.name);
        GameObject nuevaBala = Instantiate(
            prefabBala, 
            puntoGeneracion.transform.position, 
            puntoGeneracion.transform.rotation);
        nuevaBala.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * potenciaDisparo);
    }

}
