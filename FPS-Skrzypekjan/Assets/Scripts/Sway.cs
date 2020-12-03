using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{

    #region Variables

    public float intensity;
    public float smooth;

    private Quaternion originRotation;

    #endregion


    #region MonoBehaviour Callbacks

    private void Start()
    {
        originRotation = transform.rotation;
    }
    private void Update()
    {
        UpdateSway();
    }

    #endregion


    #region Private Methods

    private void UpdateSway()
    {
        //Controls
        float t_x_mouse = Input.GetAxis("Mouse X");
        float t_y_mouse = Input.GetAxis("Mouse Y");

        //Target rotation
        Quaternion t_x_adj = Quaternion.AngleAxis(-intensity * t_x_mouse, Vector3.up);
        Quaternion t_y_adj = Quaternion.AngleAxis(intensity * t_y_mouse, Vector3.right);
        Quaternion targetRotation = originRotation * t_y_adj * t_x_adj;

        //Rotate towards target rotation
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * smooth);

    }

    #endregion
}
