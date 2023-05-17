using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggering : MonoBehaviour
{

    public Animator anim;

    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    private Vector3 _startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        _startingPosition = transform.parent.localPosition;
        anim = gameObject.GetComponent<Animator>();
        
               
        
    }

    

    void Update()
    {
       
    }

    public void OnPointerEnter()
    {
        anim.enabled = true;
        anim.SetTrigger("Burden");
    }

    public void OnPointerExit()
    {
        anim.enabled = false;
        anim.ResetTrigger("Burden");
    }
    /*public void OnPointerExit()
    {
        TriggerAnimation(false);
    }*/


    /// <summary>
    /// Sets this instance's material according to gazedAt status.
    /// </summary>
    ///
    /// <param name="gazedAt">
    /// Value `true` if this object is being gazed at, `false` otherwise.
    /// </param>
    /// 
    /*private void TriggerAnimation(bool gazedAt)
    {
      
          anim.SetTrigger("Burden");
                      
    }*/

    private void TriggerAnimation()
    {
        anim.SetTrigger("Burden");
        
    }
  
}

