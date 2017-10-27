using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arcam : MonoBehaviour {

    //gyro
    private Gyroscope gyro;
    private GameObject CameraContainer;
    private Quaternion rotation;

    //cam
    private WebCamTexture cam;
    public RawImage backround;
    public AspectRatioFitter fit;

    private bool arReady = false;

    private void Start()
    {

        if (!SystemInfo.supportsGyroscope)
        {
            Debug.Log("SYs not supported");
            return;
        }

        //back camera
        for (int i = 0; i < WebCamTexture.devices.Length; i++)
        {
            if (!WebCamTexture.devices[i].isFrontFacing)
            {
                cam = new WebCamTexture(WebCamTexture.devices[i].name, Screen.width, Screen.height);
                break;
            }
        }
        // if we dont find cam
        if (cam == null)
        {
            Debug.Log("no camera");
            return;
        }
        //both services are supported

        CameraContainer = new GameObject("Camera Container");
        CameraContainer.transform.position = transform.position;
        transform.SetParent(CameraContainer.transform);

        gyro = Input.gyro;
        gyro.enabled = true;
        CameraContainer.transform.rotation = Quaternion.Euler(90f, 0, 0);
        rotation = new Quaternion(0, 0, 1, 0);
        cam.Play();
        backround.texture = cam;

        arReady = true;


    }

    private void Update()
    {
        if(arReady)
        {
            // update camera
            float ratio = (float)cam.width / (float)cam.height;
            fit.aspectRatio = ratio;

            float scaleY = cam.videoVerticallyMirrored ? -0.1f : 1.0f;
            backround.rectTransform.localScale = new Vector3 (1f, scaleY, 1f);

            int orient = -cam.videoRotationAngle;
            backround.rectTransform.localEulerAngles = new Vector3(0,0,orient);
       
            //update gyro
            transform.localRotation = gyro.attitude * rotation;

        }
    }




}
