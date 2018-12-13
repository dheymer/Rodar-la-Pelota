using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    int intContador;
    public Text txtScore, txtMessageWin;
    Rigidbody rb;
    public float velocidad;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        intContador = 0;
        ScoreUpdate();
        txtMessageWin.gameObject.SetActive(false);
    }

    private void ScoreUpdate()
    {
        txtScore.text = "Puntuación: " + intContador;
    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Colisión");
        Destroy(other.gameObject);
        intContador = intContador + 1;
        ScoreUpdate();
        if (intContador >= 12) {
            txtMessageWin.gameObject.SetActive(true);
        }
    }
}
