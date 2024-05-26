using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;

    [Header("Arrow")]
    [SerializeField] private GameObject arrow;

    private void Start()
    {
        animator = GetComponent<Animator>();
        arrow.SetActive(false);
    }

    private void Update()
    {
        HandleMovement();
        HandleActions();
    }

    private void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        animator.SetFloat("Strafe", x);
        animator.SetFloat("Forward", y);
        animator.SetBool("Run", Input.GetKey(KeyCode.LeftShift));
    }

    private void HandleActions()
    {
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Aim", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("Shoot", true);
        }
        else
        {
            animator.SetBool("Aim", false);
            animator.SetBool("Shoot", false);
        }
    }

    private void HandleArrowActive()
    {
        arrow.SetActive(true);
    }
}
