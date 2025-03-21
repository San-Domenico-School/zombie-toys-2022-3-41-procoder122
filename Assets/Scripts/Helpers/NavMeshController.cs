using UnityEngine;

public class NavMeshController : MonoBehaviour
{
    // Private serialized field for the target (Transform)
    [SerializeField] private Transform target;

    // Private field for speed
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        // You can initialize the speed here, or set it in the Unity Inspector
        speed = 5f; // Example value, adjust as needed
    }

    // Update is called once per frame
    void Update()
    {
        // Example logic using target and speed to move the object
        if (target != null)
        {
            // Move towards the target (simplified movement)
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
