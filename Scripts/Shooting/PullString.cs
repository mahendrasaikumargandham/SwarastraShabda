using UnityEngine;

public class PullString : MonoBehaviour
{
    [Header("Bow String Settings")]
    [SerializeField] private GameObject bowString;
    [SerializeField] private Transform stringIdlePos;
    [SerializeField] private Transform stringPullPos;

    public void StringPull()
    {
        MoveString(stringPullPos);
    }

    public void StringNotPull()
    {
        MoveString(stringIdlePos);
    }

    private void MoveString(Transform targetPosition)
    {
        bowString.transform.position = targetPosition.position;
        bowString.transform.SetParent(targetPosition);
    }
}
