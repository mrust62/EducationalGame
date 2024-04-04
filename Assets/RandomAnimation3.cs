using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation3 : MonoBehaviour
{

    Animator anim3;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim3 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim3.Play("Rotate3", 0, randomOffset);
    }

}