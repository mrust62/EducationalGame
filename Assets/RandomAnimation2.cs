using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation2 : MonoBehaviour
{

    Animator anim2;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim2 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim2.Play("Rotate2", 0, randomOffset);
    }

}
