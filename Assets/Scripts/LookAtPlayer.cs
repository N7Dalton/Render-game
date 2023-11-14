using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private Transform Player;
    private GameObject PlayerGO;
    void Start()
    {
        PlayerGO = GameObject.FindGameObjectWithTag("Player");
        Player = PlayerGO.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player, Vector3.forward);
    }
}
