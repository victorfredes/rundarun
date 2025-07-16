using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate es mejor para la física. Mantenemos el movimiento constante aquí.
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
    }

    // ¡NUEVA FUNCIÓN! El componente Player Input la llamará automáticamente.
    // El nombre debe ser "On" seguido del nombre de la Acción: "OnJump".
    public void OnJump()
    {
        // Solo saltamos si estamos en el suelo
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    // El resto del código de colisiones se mantiene igual.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("¡Has chocado! Reiniciando...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}




#region old
/*
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para recargar la escena

public class PlayerController : MonoBehaviour
{
    // Variables que podemos ajustar desde el Inspector de Unity
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;

    private Rigidbody2D rb;
    private bool isGrounded;

    // Start se llama una vez, al principio del juego
    void Start()
    {
        // Obtenemos el componente Rigidbody2D para poder usarlo en el código
        rb = GetComponent<Rigidbody2D>();
    }

    // Update se llama en cada fotograma
    void Update()
    {
        // Movimiento constante hacia la derecha
        // Usamos rb.velocity para no interferir con otras fuerzas como el salto
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);

        // Comprobamos si se presiona la barra espaciadora Y si el jugador está en el suelo
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Aplicamos una fuerza vertical instantánea para el salto
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    // Este método se llama cuando nuestro jugador colisiona con algo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si chocamos con un objeto con la etiqueta "Obstacle"
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("¡Has chocado! Reiniciando...");
            // Recargamos la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    // Estos métodos detectan cuándo el collider del jugador entra o sale de otro collider
    // Los usamos para saber si estamos tocando el suelo
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
*/

#endregion