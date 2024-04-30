using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation6 : MonoBehaviour
{

    Animator anim6;
    float randomOffset;

    // Start is called before the first frame update
    void Start()
    {
        anim6 = GetComponent<Animator>();
        randomOffset = Random.Range(0f, 1f);

        anim6.Play("Spin2", 0, randomOffset);
    }

}