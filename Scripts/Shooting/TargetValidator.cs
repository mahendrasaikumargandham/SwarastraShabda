using UnityEngine;

public class TargetValidator : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Debug.Log("Arrow Detected");
            gameManager.IncrementScore();
            Destroy(gameObject, 4f);
        }
    }
}
