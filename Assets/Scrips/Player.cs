using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadJugador = 0.03f;

    void Start()
    {
        
    }

    
    void Update()
    {
        MovimientoJugador();
        
    float horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(0, horizontalInput * Time.deltaTime * 100.0f, 0);


    }

    void MovimientoJugador()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 movJugador = new Vector3(hor,0,ver);
        transform.Translate(movJugador * velocidadJugador);
    }
}