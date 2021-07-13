using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//GamePad Mappings:  http://wiki.etc.cmu.edu/unity3d/index.php/Joystick/Controller
// [XBox 360 Controller] & [Logitech GamePad F310] have same input manager mappings

public class JoystickReader : MonoBehaviour
{
    #region --- helpers ---
    [System.Serializable]
    public class TextJoystick
    {
        public Text txtLT;
        public Text txtLB;
        public Text txtRT;
        public Text txtRB;
        public Text txtBack;
        public Text txtStart;
        public Text txtLeftAnalogX;
        public Text txtLeftAnalogY;
        public Text txtRightAnalogX;
        public Text txtRightAnalogY;
        public Text txtA;
        public Text txtB;
        public Text txtX;
        public Text txtY;
        public Text txtDPadX;
        public Text txtDPadY;
        public Text txtLeftAnalogPress;
        public Text txtRightAnalogPress;
    }
    #endregion

    public Text txtJoysticks;
    public TextJoystick joy1 = new TextJoystick();

    private void Start()
    {
        string names = "";
        int cnt = 0;
        string[] joysticknames = Input.GetJoystickNames();
        foreach (string name in joysticknames)
        {
            cnt += 1;
            if (cnt > 1)
                names += ", ";
            names += cnt.ToString() + ". " + name;
            Debug.Log(names);
        }
        txtJoysticks.text = "Joysticks : " + names;
    }
    private void Update()
    {
        ReadingJoystick1();
    }
    private void ReadingJoystick1()
    {
        //LT is the positive values of the 3rd axis (Left Trigger)
        float LT = Input.GetAxis("LT1");
        LT = (LT > 0) ? LT : 0;

        //RT is the negative values of the 3rd axis (RightTrigger)
        float RT = Input.GetAxis("RT1");
        RT = (RT < 0) ? RT : 0;

        //18 inputs from joystick
        joy1.txtLT.text = "LT : " + LT.ToString();
        joy1.txtLB.text = "LB : " + Input.GetButton("LB1").ToString();
        joy1.txtRT.text = "RT : " + RT.ToString();
        joy1.txtRB.text = "RB : " + Input.GetButton("RB1").ToString();
        joy1.txtBack.text = "Back : " + Input.GetButton("Back1").ToString();
        joy1.txtStart.text = "Start : " + Input.GetButton("Start1").ToString();
        joy1.txtLeftAnalogX.text = "LeftAnalogX : " + Input.GetAxis("LeftAnalogX1").ToString();
        joy1.txtLeftAnalogY.text = "LeftAnalogY : " + Input.GetAxis("LeftAnalogY1").ToString();
        joy1.txtRightAnalogX.text = "RightAnalogX : " + Input.GetAxis("RightAnalogX1").ToString();
        joy1.txtRightAnalogY.text = "RightAnalogY : " + Input.GetAxis("RightAnalogY1").ToString();
        joy1.txtA.text = "A : " + Input.GetButton("A1").ToString();
        joy1.txtB.text = "B : " + Input.GetButton("B1").ToString();
        joy1.txtX.text = "X : " + Input.GetButton("X1").ToString();
        joy1.txtY.text = "Y : " + Input.GetButton("Y1").ToString();
        joy1.txtDPadX.text = "DPadX : " + Input.GetAxis("DPadX1").ToString();
        joy1.txtDPadY.text = "DPadY : " + Input.GetAxis("DPadY1").ToString();
        joy1.txtLeftAnalogPress.text = "LeftAnalogPress : " + Input.GetAxis("LeftAnalogPress1");
        joy1.txtRightAnalogPress.text = "RightAnalogPress : " + Input.GetAxis("RightAnalogPress1");
    }
}