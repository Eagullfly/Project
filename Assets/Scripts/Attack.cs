using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    List<string> combo = new List<string>(new string[] { "firstPunch", "secondPunch", "thirdPunch" });
    public Animator animator;
    public int combonum;
    public float reset;
    public float resetTime;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && combonum < 3)
        {
            animator.SetTrigger(combo[combonum]);
            combonum++;
            reset = 0f;
        }

        if(combonum > 0)
        {
            reset += Time.deltaTime;
            if(reset > resetTime)
            {
                animator.SetTrigger("Reset");
                combonum = 0;
            }
        }

        if(combonum == 3)
        {
            resetTime = 3f;
            combonum = 0;
        }
        else
        {
            resetTime = 1f;
        }
    }
}
