using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class characterAnimitor : MonoBehaviour
{
    const float locomationAnimationSmoothTime = 0.1f;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speedPercent", 4, locomationAnimationSmoothTime, Time.deltaTime);
    }
}
