using UnityEngine;

public class PracticeMovingDrone : MonoBehaviour
{     
 Rigidbody drone;
 [SerializeField] GameObject panel;
   
    void Start()
    {
        drone=GetComponent<Rigidbody>();
               drone.rotation=Quaternion.Euler(
            new Vector3(0,-90f,0)
            
        );
      
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        Destroy(panel,5);
        MovementUpDown();
        MovementForward();
        Rotation();
        sides();

       
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
        if(Input.GetKey(KeyCode.I))
        {
            upForce=128f;
        }
        else if(Input.GetKey(KeyCode.K))
        {
            upForce=-200f;
        }
          else if(!Input.GetKey(KeyCode.K)&&!Input.GetKey(KeyCode.I))
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
}
