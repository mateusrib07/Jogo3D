using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float velocidade = 5.0f;
    [SerializeField] private float forcaPulo = 5.0f;
    private Vector3 anguloRotacao = new Vector3(0,90,0);
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Andar
    public void Andar()
    {
        float moveV = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0, 0, -1 * moveV * velocidade * Time.deltaTime)
        Vector3 direcao = moveV * transform.forward;
        rb.MovePosition(rb.position + direcao * velocidade * Time.deltaTime);
    }

    //Pular
    public void Pular()
    {
        rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
    }

    //Virar
    public void Virar()
    {
        float moveH = Input.GetAxis("Horizontal");
        Quaternion rotacao = Quaternion.Euler(-1 * anguloRotacao * moveH * Time.deltaTime);
        rb.MoveRotation(rotacao * rb.rotation);
    }

}
