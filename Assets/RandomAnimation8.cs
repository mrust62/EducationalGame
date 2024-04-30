using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation8 : MonoBehaviour
{

    Animator anim8;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim8 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim8.Play("Spin4", 0, randomOffset);
    }

}