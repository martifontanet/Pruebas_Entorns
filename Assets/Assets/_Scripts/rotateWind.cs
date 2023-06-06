using UnityEngine;

public class rotateWind : MonoBehaviour
{
    public HingeJoint hinge;
    public int motorForce;
    public int windForce;
    public float targetSpeed;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }
    void Update()
    {
        targetSpeed = Mathf.Sin(Time.time) * windForce * 500;

        int Speed = (int)targetSpeed;

        JointMotor motor = hinge.motor;
        motor.force = motorForce;
        motor.targetVelocity = Speed * Time.deltaTime;
        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;

    }
}
