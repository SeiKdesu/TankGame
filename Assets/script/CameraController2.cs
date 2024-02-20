

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    private GameObject mainCamera;              //メインカメラ格納用//https://xr-hub.com/archives/6272
    private GameObject playerObject;            //回転の中心となるプレイヤー格納用
    private GameObject aim;
    public float rotateSpeed = 2.0f;            //回転の速さ

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラとユニティちゃんをそれぞれ取得
        mainCamera = GameObject.Find("MainCamera");
        playerObject = GameObject.Find("tank");
        aim = GameObject.Find("ue");
    }

    // Update is called once per frame
    void Update()
    {
        //rotateCameraの呼び出し
        rotateCamera();
    }
    //カメラを回転させる関数
    private void rotateCamera()
    {
        //Vector3でX,Y方向の回転の度合いを定義
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, 0, 0);

        //transform.RotateAround()をしようしてメインカメラを回転させる
        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
        //transform.RotateAround()をしようしてメインカメラを回転させる
        aim.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        aim.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
    }
}
