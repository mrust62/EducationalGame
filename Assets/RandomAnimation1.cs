using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation1 : MonoBehaviour
{

    Animator anim1;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim1 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim1.Play("Rotate1", 0, randomOffset);
    }

}