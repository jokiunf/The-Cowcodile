using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb2D;
    private Vector2 MovementInput;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovementInput.y = Input.GetAxisRaw("Vertical");
        MovementInput.x = Input.GetAxisRaw("Horizontal");

        MovementInput = MovementInput.normalized;
    }
    private void FixedUpdate()
    {

        rb2D.linearVelocity = MovementInput * velocidad;
    }
}
