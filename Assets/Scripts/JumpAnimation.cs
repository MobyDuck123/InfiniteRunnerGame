using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetTrigger("Jump");
        }
    }
}
