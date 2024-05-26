using UnityEngine;

public class ArrowShoot : MonoBehaviour
{
    [Header("Shooting Settings")]
    [SerializeField] private float range;
    [SerializeField] private GameObject arrowPrefab;

    [Header("References")]
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject currentArrow;

    private void Shoot()
    {
        currentArrow.SetActive(false);

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, range))
        {
            Instantiate(arrowPrefab, hit.point, Quaternion.identity);
        }
    }
}
