using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    [SerializeField] private GameObject _gate;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(_gate);
            Destroy(gameObject);
        }
    }
}
