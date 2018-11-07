using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{

    Animator anim;

    int one = Animator.StringToHash("jump");
    //Make sure Trigger parameter in animator controller is wrote the same way that you string it//

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger(one);
        }
    }
}
