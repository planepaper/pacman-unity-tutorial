using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Ghost : MonoBehaviour
{
    public Movement movement { get; private set; }
    public GhostBehaviour initialBehaviour;
    public Transform target;
    private readonly int points = 200;
    public int Points
    {
        get => points;
    }


    private void Awake()
    {
        movement = GetComponent<Movement>();
    }

    private void Start()
    {
        ResetState();
    }

    public void ResetState()
    {
        gameObject.SetActive(true);
        movement.ResetState();

        if (initialBehaviour != null)
        {
            initialBehaviour.Enable();
        }
    }

    public void SetPosition(Vector3 position)
    {
        // Keep the z-position the same since it determines draw depth
        position.z = transform.position.z;
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {

        }
    }

}
