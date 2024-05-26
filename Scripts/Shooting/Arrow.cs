using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Vector3 m_target;
    public float Speed;

    void Update() {
        float step = Speed * Time.deltaTime;
        if(m_target != null) {
            transform.position = Vector3.MoveTowards(transform.position, m_target, step);
        }
    }

    public void setTarget(Vector3 target) {
        m_target = target;
    }
}
