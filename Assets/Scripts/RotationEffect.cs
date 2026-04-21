using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    public float speed = 2f;
    public float angle = 10f;

    // Update is called once per frame
    void Update()
    {
       float tilt = Mathf.Sin(Time.time * speed) * angle;
       gameObject.transform.localRotation = Quaternion.Euler(0, 0, tilt);
    }
}
