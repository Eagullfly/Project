using Cinemachine;
using UnityEngine;

public class MinionSelect : MonoBehaviour
{
    public Camera cam1;
    public GameObject player;
    private GameObject gpc;
    public CinemachineFreeLook freeLook;
    GameObject[] minions;
    //public Camera cam2;
    //public CharacterController charControl;
    //CharacterMovement move;
    //Attack attack;
    //public GameObject GroundPlacementController;

    //[SerializeField]
    //private GameObject minion;

    // Start is called before the first frame update
    void Start()
    {
        freeLook.enabled = false;
        cam1.GetComponent<VillainCameraController>().enabled = true;
        gpc = GameObject.FindGameObjectWithTag("Player");
        minions = GameObject.FindGameObjectsWithTag("Minion");
        //cam1.enabled = true;
        //cam2.enabled = false;
        //Camera.main.transform.rotation = Quaternion.Euler(60, 0, 0);
        //cam1.GetComponent<CinemachineBrain>().enabled = true;
        //charControl = minion.GetComponent<CharacterController>();
        //charControl.enabled = false;
        //move = GetComponent<CharacterMovement>();
        //player.GetComponent<CharacterMovement>().enabled = false;
        //attack = GetComponent<Attack>();
        //player.GetComponent<Attack>().enabled = false;
        //gpc = GameObject.Find("GroundPlacementController").GetComponent<GroundPlacementController>();
        //gpc.enabled = true;
    }

    void OnMouseDown()
    {

        if (!enabled)
        {
            return;
        }
        else
        {
            freeLook.enabled = true;
            cam1.GetComponent<VillainCameraController>().enabled = false;
            player.GetComponent<MinionMovement>().enabled = true;
            player.GetComponent<Attack>().enabled = true;
            gpc.GetComponent<GroundPlacementController>().enabled = false;
            Debug.Log("You are a minion");
            foreach(GameObject minion in minions)
            {
                //minion.GetComponent<MinionDeselect>().enabled = true;
                minion.GetComponent<MinionSelect>().enabled = false;
            }
            
        }
        //cam1.enabled = false;
        //cam2.enabled = true;
        //cam1.GetComponent<CinemachineBrain>().enabled = false;
        //charControl.enabled = true;
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Escape))
        {
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

        /*if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast (ray, out hit))
            {
                if(hit.transform.tag == "minion")
                {
                    cam1.enabled = !cam1.enabled;
                    cam2.enabled = !cam2.enabled;
                    Debug.Log("You are a minion");
                }
            }
        }*/
    }
}
