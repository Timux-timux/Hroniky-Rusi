using UnityEngine;

public class мрхайбольшенемашет : MonoBehaviour
{
    public Animator Animator;

    private void OnTriggerEnter(Collider other)
    {
        Animator.SetBool("dilog", true);
    }
}
