﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
    [SerializeField] GameObject prefabBala;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("DISPARA");
            GameObject nuevaBala = Instantiate(prefabBala, transform.position, transform.rotation);
            nuevaBala.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);
        }
		
	}
}
