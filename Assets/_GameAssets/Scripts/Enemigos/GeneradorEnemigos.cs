using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour {
    int numEnemigos = 0;
    [SerializeField] int numEnemigosMaximo = 5;
    [SerializeField] GameObject prefabEnemigo;

	void Start () {
        InvokeRepeating("GenerarEnemigo", 2, 2);
	}
    void GenerarEnemigo()
    {
        //GameObject newEnemigo = Instantiate(prefabEnemigo, transform);
        GameObject newEnemigo = Instantiate(prefabEnemigo, transform.position, Quaternion.identity);
        numEnemigos++;
        if (numEnemigos == numEnemigosMaximo)
        {
            CancelInvoke();
        }
    }
}
