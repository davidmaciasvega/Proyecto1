using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        }
    
       void OnCollisionEnter2D(Collision2D collision)
{
    animator.SetBool("isColliding", true);
}
    
        void OnCollisionExit(Collision collision)
{
    animator.SetBool("isColliding", false);
    Debug.Log("Colisión terminada con: " + collision.gameObject.name); // Verifica en la consola
}
    }