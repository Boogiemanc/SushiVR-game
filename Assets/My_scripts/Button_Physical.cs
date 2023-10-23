using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button_Physical : MonoBehaviour
{
    public Transform buttonTop;
    public Transform ButtonLowerlimit;
    public Transform ButtonUppperLimit;
    public float threshold;
    public float force = 10;
    private float upperlowerDiff;
    public bool isPressed;
    private bool prePressedState;
    public UnityEvent onPressed;
    public UnityEvent onReleased;


    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(GetComponent<Collider>(), buttonTop.GetComponent<Collider>());
        if (transform.eulerAngles != Vector3.zero)
        {
            Vector3 savedAngle = transform.eulerAngles;
            transform.eulerAngles = Vector3.zero;
            upperlowerDiff = ButtonUppperLimit.position.y - ButtonLowerlimit.position.y;
            transform.eulerAngles = savedAngle;

        }
        else
            upperlowerDiff = ButtonUppperLimit.position.y - ButtonLowerlimit.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        buttonTop.transform.localPosition = new Vector3(0, buttonTop.transform.localPosition.y, 0);
        buttonTop.transform.localEulerAngles = new Vector3(0, 0, 0);
        if (buttonTop.localPosition.y >= 0)
            buttonTop.transform.position = new Vector3(ButtonUppperLimit.position.x, ButtonUppperLimit.position.y, ButtonUppperLimit.position.z);
        else
            buttonTop.GetComponent<Rigidbody>().AddForce(buttonTop.transform.up * force * Time.fixedDeltaTime);
        if (buttonTop.localPosition.y <= ButtonLowerlimit.localPosition.y)
            buttonTop.transform.position = new Vector3(ButtonLowerlimit.position.x, ButtonLowerlimit.position.y, ButtonLowerlimit.position.z);

        if (Vector3.Distance(buttonTop.position, ButtonLowerlimit.position) < upperlowerDiff * threshold)
            isPressed = true;
        else
            isPressed = false;

        if (isPressed && prePressedState != isPressed)
            Pressed();
        if (!isPressed && prePressedState != isPressed)
            Released();
    }

    void Pressed() {
        prePressedState = isPressed;
        onPressed.Invoke();
        Debug.Log("pressed");
    
    }
    void Released() {
        prePressedState = isPressed;
        onReleased.Invoke();
        Debug.Log("release");
    }













    
}
