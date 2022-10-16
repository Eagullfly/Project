using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionDeselect : MonoBehaviour
{
    public Camera cam1;
    public GameObject player;
    private GameObject gpc;
    public CinemachineFreeLook freeLook;
    GameObject[] minions;

    // Start is called before the first frame update
    void Start()
    {
        minions = GameObject.FindGameObjectsWithTag("Minion");
        gpc = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            foreach (GameObject minion in minions)
            {
                minion.GetComponent<MinionSelect>().enabled = true;
            }
            freeLook.enabled = false;
            cam1.GetComponent<VillainCameraController>().enabled = true;
            player.GetComponent<MinionMovement>().enabled = false;
            player.GetComponent<Attack>().enabled = false;
            gpc.GetComponent<GroundPlacementController>().enabled = true;
            Camera.main.transform.rotation = Quaternion.Euler(60, 0, 0);
            Debug.Log("You are mastermind");
            
            //cam1.enabled = true;
            //cam2.enabled = false;
            //cam1.GetComponent<CinemachineBrain>().enabled = true;
            //charControl.enabled = false;
            //gpc.enabled = true;
        }
    }
}
