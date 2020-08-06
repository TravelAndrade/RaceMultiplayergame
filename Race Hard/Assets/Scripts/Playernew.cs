using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Playernew : Photon.MonoBehaviour
{
    public float speed = 50f;
    private float lastSynchronizationTime = 0f;
    private float syncDelay = 0f;
    private float syncTime = 0f;
    private Vector3 syncStartPosition = Vector3.zero;
    private Vector3 syncEndPosition = Vector3.zero;
    private Vector3 syncStartRotation = Vector3.zero;
    private Vector3 syncEndRotation = Vector3.zero;
    public GameObject camera;
    public GameObject bullet;
    GameObject scoreboard;
    int playerCount;
 
    /*
    //public healthbar playerhealth;
    public healthbar _health;

    //public bool syncLocalRotation = true;
    public int score = 0;
    public int score1 = 0;
    public BulletScript spread;
    public GameObject pistol;
    public GameObject shotgun;
    public GameObject rifle;
    public GameObject sniper;
    public GameObject crossbow;

    CharacterController characterController;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 moveRotation = Vector3.zero;


    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;

    public float minimumX = -360F;
    public float maximumX = 360F;

    public float minimumY = -60F;
    public float maximumY = 60F;
    float check;

    float rotationY = 0F;
*/

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo Info)
    {
       // check = FindObjectOfType<healthbar>().health.healthAmount;
        if (stream.isWriting)
        {
            stream.SendNext(GetComponent<Rigidbody>().position);
            stream.SendNext(GetComponent<Rigidbody>().velocity);
            //stream.SendNext(check);
        }
        else
        {
            Vector3 syncPosition = (Vector3)stream.ReceiveNext();
            //Vector3 syncRotation = (Vector3)stream.ReceiveNext();
            Vector3 syncVelocity = (Vector3)stream.ReceiveNext();
            syncTime = 0f;
            syncDelay = Time.time - lastSynchronizationTime;
            lastSynchronizationTime = Time.time;
            syncEndPosition = syncPosition + syncVelocity * syncDelay;
            syncStartPosition = GetComponent<Rigidbody>().position;
            //this.check = (float)stream.ReceiveNext();
        }
    }
    
    public void Awake()
    {
       // gameObject.GetComponent<Rigidbody>();
        lastSynchronizationTime = Time.time;
      //  pistol.SetActive(false);
      //  shotgun.SetActive(false);
      //  rifle.SetActive(false);
      //  sniper.SetActive(false);
     //   crossbow.SetActive(false);
      //  spread.pistol_spread = false;
      //  spread.shotgun_spread = false;
      //  spread.Assault_rifle_spread = false;
      //  spread.sniper_spread = false;
     //   spread.crossbow_spread = false;

      //  characterController = GetComponent<CharacterController>();

    }
   /* public void Start()
    {
        scoreboard = GameObject.Find("Canvas").transform.Find("Scoreboard").gameObject;
    }
    */
    public void Update()
    {
        //if (syncLocalRotation) myTransform.localRotation = Quaternion.Slerp(lhs.rot, rhs.rot, t);


        if (this.photonView.isMine)
        {
            InputMovement();
            //bullet.SetActive(true);
            // gameObject.GetComponent<BulletFireScript>().enabled = true;
            InputColorChange();
        }
        else
        {
            SynchedMovement();
            //spread.SynchedBullet();
           // camera.SetActive(false);
           // gameObject.GetComponent<BulletFireScript>().enabled = false;
        }
        //if (Input.GetKeyDown(KeyCode.Tab))
        //{
        //    scoreboard.SetActive(true);
        //    UpdateScoreboard();
        //}
        //if (Input.GetKeyUp(KeyCode.Tab))
        //{
        //    scoreboard.SetActive(false);
        //}
        
           // PhotonNetwork.player.NickName = "Player # " + Random.Range(1.00f, 9.00f);
        
        //if (Input.GetKeyDown(KeyCode.Tab))
        //{
        //    scoreboard.SetActive(true);
        //    UpdateScoreboard();
        //}
    }

    void InputMovement()
    {
        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position - Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position - Vector3.right * speed * Time.deltaTime);
    }


    public void SynchedMovement()
    {
        syncTime += Time.deltaTime;
        GetComponent<Rigidbody>().position = Vector3.Lerp(syncStartPosition,
            syncEndPosition, syncTime / syncDelay);
    }

    private void InputColorChange()
    {
        if (Input.GetKeyDown(KeyCode.R))
            ChangeColorTo(new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
    }

    [PunRPC]
    void ChangeColorTo(Vector3 color)
    {
        GetComponent<Renderer>().material.color = new Color(color.x, color.y, color.z, 1f);

        if (photonView.isMine)
            photonView.RPC("ChangeColorTo", PhotonTargets.OthersBuffered, color);
    }

}
