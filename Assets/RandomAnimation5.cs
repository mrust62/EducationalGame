using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation5 : MonoBehaviour
{

    Animator anim5;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim5 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim5.Play("Spin1", 0, randomOffset);
    }

}