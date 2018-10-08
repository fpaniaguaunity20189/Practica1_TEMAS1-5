using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTonto : EnemigoMovil {
	// Use this for initialization
	void Start () {
        InvokeRepeating("RotarAleatoriamente", 1, 2);
	}
	
	// Update is called once per frame
	void Update () {
        Avanzar();
    }

    private void OnCollisionEnter(Collision collision) {
        RotarAleatoriamente();
        if (collision.gameObject.name == "Player") {
            collision.gameObject.GetComponent<Player>().RecibirDanyo(danyo);
            //Destroy(this.gameObject);
        }
    }
}
