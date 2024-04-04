using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation4 : MonoBehaviour
{

    Animator anim4;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim4 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim4.Play("Rotate4", 0, randomOffset);
    }

}