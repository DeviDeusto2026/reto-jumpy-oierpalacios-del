using UnityEngine;

public class OneWayPlatformController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private int platformLayer;
    private int playerLayer;

    void Start()
    { 
        platformLayer = LayerMask.NameToLayer("Platform");
        playerLayer = LayerMask.NameToLayer("Player");
    }

    void Update()
    {
        // Si el personaje esta subiendo, ignora la colisi�n con las plataformas
        bool isGoingUp = rb.linearVelocity.y > 0.1f;

        Physics.IgnoreLayerCollision(playerLayer, platformLayer, isGoingUp);
    }
}
