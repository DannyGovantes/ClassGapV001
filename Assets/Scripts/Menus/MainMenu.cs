using UnityEngine;
using System.Collections;

public class MainMenu :Menu<MainMenu> {
    public Vector3 CameraPos;

    public Vector3 desiredPos;


    private void LateUpdate() {
        if(Input.GetKeyDown(KeyCode.Space)){
            Vector3 pos = CameraPos;
            Vector3 desired = Vector3.Lerp(pos,desiredPos, 0.12f);
            desiredPos = desired;
            Camera.main.transform.position = desiredPos;
        }
    }

    
}