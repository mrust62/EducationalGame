using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation7 : MonoBehaviour
{

    Animator anim7;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim7 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim7.Play("Spin3", 0, randomOffset);
    }

}