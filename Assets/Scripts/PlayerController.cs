using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //propiedades
    //modificador ocultar del inspector
    //[HideInInspector]

    //modificador de rango para la variable en el editor
    //[Range(0,20)]

    //puede ser private y añadir el modificador SerializedField
    //[Range(0, 20),SerializeField]
    //[Range(0, 20)][SerializeField]
    //[Range(0, 20)]
    //[SerializeField]

    [Range(0, 20), SerializeField,
    Tooltip("Velocidad lineal máxima del coche")]
    private float speed=10.0f;

    [Range(0, 90), SerializeField,
    Tooltip("Velocidad de giro máxima del coche")]
    public float turnSpeed=45.0f;

    private float horizonalInput;
    private float verticalInput;
    
    /*
    //manual de orden de ejecución de métodos de la api
    //https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void Awake()
	{
        Debug.Log("Objeto despertando " + gameObject.name);
    }

	// Start is called before the first frame update
	void Start()
    {
        //Mensajes consola
        Debug.Log("Método start de player controller "+gameObject.name);
    }
    */

    // Update is called once per frame
    void Update()
    {
        //Mover vehiculo adelante    
        //this.transform.Translate(0, 0, 1);
        
        horizonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Vector3.forward*Time.deltaTime* verticalInput);
        transform.Rotate(turnSpeed * Vector3.up * Time.deltaTime* horizonalInput);
    }
}
