using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float MarginX = 0.5f;
    public float MarginY = 0.5f;
    public float SmoothX = 4f;
    public float SmoothY = 4f;
    public Vector2 MaxXandY;
    public Vector2 MinXandY;

    private  Transform player;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player").transform;        
    }
    bool CheckXMargin() {
        return Mathf.Abs(transform.position.x - player.position.x) > MarginX;
    }
    bool CheckYMargin() {
        return Mathf.Abs(transform.position.y - player.position.y) > MarginY;
    }
    void FixedUpdate() {
        TrackPlayer();
    }
    void TrackPlayer() {
        float targetX = transform.position.x;
        float targetY = transform.position.y;
        if(CheckXMargin())
        targetX = Mathf.Lerp(transform.position.x, player.position.x, SmoothX * Time.deltaTime);
        if(CheckYMargin())
        targetY = Mathf.Lerp(transform.position.y, player.position.y, SmoothY * Time.deltaTime);
        
        targetX = Mathf.Clamp(targetX, MinXandY.x, MaxXandY.x);
        targetY = Mathf.Clamp(targetY, MinXandY.y, MaxXandY.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}
