using UnityEngine;

public class VegeTablesCarrot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement playerMovement))
            Destroy(gameObject);
    }
}