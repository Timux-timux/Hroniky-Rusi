using JetBrains.Annotations;
using UnityEngine;

public class CameraWalk : MonoBehaviour
{
   public Animator animator;

    // public Transform OldPosition;
     Vector3 OldPosition;

     void Start()
    {
         OldPosition = transform.position;
    }
   
    void Update()
    {       

        if (OldPosition != transform.position) { 
            animator.SetBool("walk", true);}else animator.SetBool("walk", false);

        
        OldPosition = transform.position;


            
        
    }
}
