using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    Animator animator;
    public TextMeshProUGUI Text;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Debug.Log("OnTrigger");
       
        animator.Play("TextAnim",0,0);

    }
}
