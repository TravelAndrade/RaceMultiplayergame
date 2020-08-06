using UnityEngine;
using System.Collections;

public class BulletFireScript : Photon.MonoBehaviour
{

    public Transform bulletprefab;
    Vector3 gun;
    public GameObject Gun_pos;
    public float BulletForce = 500.0f;
    public bool rifle = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gun = new Vector3(Gun_pos.transform.position.x, Gun_pos.transform.position.y, Gun_pos.transform.position.z);
            Fire(Gun_pos.transform.position, transform.rotation);
            StartCoroutine(Rapid());
        }
    }

    [PunRPC]
    private void Fire(Vector3 pos, Quaternion dir)
    {
        Instantiate(bulletprefab, pos, dir);

        if (this.photonView.isMine)
        {
            this.photonView.RPC("Fire", PhotonTargets.OthersBuffered, pos, dir);
        }
    }

    IEnumerator Rapid()
    {
        rifle = true;
        yield return new WaitForSeconds(0.05f);
        rifle = false;
    }
}
