

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    private GameObject mainCamera;              //���C���J�����i�[�p//https://xr-hub.com/archives/6272
    private GameObject playerObject;            //��]�̒��S�ƂȂ�v���C���[�i�[�p
    private GameObject aim;
    public float rotateSpeed = 2.0f;            //��]�̑���

    // Start is called before the first frame update
    void Start()
    {
        //���C���J�����ƃ��j�e�B���������ꂼ��擾
        mainCamera = GameObject.Find("MainCamera");
        playerObject = GameObject.Find("tank");
        aim = GameObject.Find("ue");
    }

    // Update is called once per frame
    void Update()
    {
        //rotateCamera�̌Ăяo��
        rotateCamera();
    }
    //�J��������]������֐�
    private void rotateCamera()
    {
        //Vector3��X,Y�����̉�]�̓x�������`
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, 0, 0);

        //transform.RotateAround()�����悤���ă��C���J��������]������
        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
        //transform.RotateAround()�����悤���ă��C���J��������]������
        aim.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        aim.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
    }
}
