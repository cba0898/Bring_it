using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform PlayerTransform;
    Vector3 Offset;
    public GameObject GameObject;
    private void Awake()
    {
        PlayerTransform = GameObject.transform;
        Offset = transform.position - PlayerTransform.position;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate() //Updat���� ���ϰ� ���� �ٴ°Ŷ� lateupdate
    {
        transform.position = PlayerTransform.position + Offset;
    }
}
