using UnityEngine;

public class PlayerControl : MonoBehaviour
{   

    public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        Vector3 startPosition = transform.position;
        startPosition.x += speed * input * Time.deltaTime;
        transform.position = startPosition;
    }
}
