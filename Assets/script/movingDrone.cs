using UnityEngine;
using UnityEngine.Networking;

public class movingDrone : NetworkBehaviour
{     
    Rigidbody drone;
    // public GameObject bulletP;
    // public Transform bulletS;
    void Start()
    {
        if (!isLocalPlayer)
        {
            GameObject.Find("TIME").GetComponent<Countdown>().isGameStarted = true;
            return;
        }

        drone = GetComponent<Rigidbody>();
        drone.rotation=Quaternion.Euler(
            new Vector3(0,-90f,0));

        GameObject o = GameObject.Find("Camera");
        if (o != null)
        {
            o.GetComponent<cameraBehaviour>().followThis = drone.transform;
        }

        transform.position = new Vector3(556.0f, 56.5f, -1015.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (!isLocalPlayer)
            return;

        MovementUpDown();
        MovementForward();
        Rotation();
        sides();

    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        fire();
    //    }
        drone.AddRelativeForce(Vector3.up * upForce);
        Vector3 vector;
        vector.x=drone.position.x;
        vector.y=Mathf.Clamp(drone.position.y, 5.225f, 128f);
        vector.z=drone.position.z;
                drone.position = vector;
                drone=GetComponent<Rigidbody>();
                       drone.rotation=Quaternion.Euler(
                    new Vector3(0,-90f,0)
            
        );
    }
    public float upForce;
    void MovementUpDown()
    {
        if (Input.GetKey(KeyCode.I))
        {
            upForce=300f;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            upForce=-200f;
        }
          else if (!Input.GetKey(KeyCode.K) && !Input.GetKey(KeyCode.I))
        {
            upForce=98.1f;
        }
    }
    private float movementForwardSpeed=300.0f;
    private float titlAmountForward;
        private float titelVelocityForward=0;

    void MovementForward()
    {
      if(Input.GetAxis("Vertical") != 0)
      {           

          drone.AddRelativeForce(Vector3.forward * Input.GetAxis("Vertical") * movementForwardSpeed);
           titlAmountForward=Mathf.SmoothDamp(titlAmountForward, 20 * Input.GetAxis("Vertical"), ref titelVelocityForward ,0.1f);
      }
    }
    private float wantedYrotation;
    private float currYrotation;
        private float rotationAmountbykeys=2.5f;
            private float rotationYvelocity;
            void Rotation()
            {
                if(Input.GetKey(KeyCode.J))
                {
                    wantedYrotation-=rotationAmountbykeys;
                }
                if(Input.GetKey(KeyCode.H))
                {
                    wantedYrotation+=rotationAmountbykeys;
                }
                currYrotation=Mathf.SmoothDamp(currYrotation,wantedYrotation, ref rotationYvelocity , 0.25f);
            }
    private float sideAmount=300f;
    private float titelamountSides;
    private float titelamountVel;
    void sides()
    {
          drone.AddRelativeForce(Vector3.right * Input.GetAxis("Horizontal") * sideAmount);
    }

    public override void OnStartLocalPlayer()
    {
        //GameObject ob = GameObject.Find("Mesh1");
        //ob.GetComponent<SkinnedMeshRenderer>().material.color = Color.blue;
      //  GetComponent<SkinnedMeshRenderer>().material.color = Color.blue;
    }
    // void fire()
    // {
    //     GameObject bullet=(GameObject)Instantiate(bulletP,bulletS.position,bulletS.rotation);
    //     bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward*12.0f;
    //     Destroy(bullet,2);
    // }
}
